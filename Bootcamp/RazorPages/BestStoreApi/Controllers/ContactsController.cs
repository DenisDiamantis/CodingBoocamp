using BestStoreApi.Models;
using BestStoreApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BestStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly ApplicationDbContext context;


        private readonly EmailSender emailSender;

        public ContactsController(ApplicationDbContext context, EmailSender emailSender)
        {
            this.context = context;
            this.emailSender = emailSender;
        }

        [HttpGet("subjects")]
        public IActionResult GetSubjects()
        {
            var listSubjects = context.Subjects.ToList();
            return Ok(listSubjects);
        }

        [HttpGet]
        public IActionResult GetContacts(int? page)
        {
            if (page == null || page <1)
            {
                page = 1;
            }

            int pageSize = 5;
            int totalPages = 0;

            decimal count = context.Contacts.Count();
            totalPages = (int) Math.Ceiling(count / pageSize);

            var contacts = context.Contacts
                .Include(c=>c.Subject)
                .OrderByDescending(c => c.Id)
                .Skip((int)(page-1)*pageSize)
                .Take(pageSize)
                .ToList();

            var response = new
            {
                Contacts = contacts,
                TotalPages = totalPages,
                PageSize = pageSize,
                Page = page
            };

            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult GetContact(int id)
        {
            var contact = context.Contacts.Include(c => c.Subject).FirstOrDefault(c => c.Id == id);

            if(contact==null)
            {
                return NotFound();
            }

            return Ok(contact);
        }

        [HttpPost]
        public IActionResult CreateContact(ContactDto contactDto)
        {
            var subject = context.Subjects.Find(contactDto.SubjectId);
            if(subject ==null)
            {
                ModelState.AddModelError("Subject", "Please select a valid subject");
                return BadRequest(ModelState);
            }
            Contact contact = new Contact()
            {
                FirstName = contactDto.FirstName, 
                LastName = contactDto.LastName,
                Email = contactDto.Email,
                Phone = contactDto.Phone ?? "",
                Subject = subject,
                Message = contactDto.Message,
                CreatedAt = DateTime.Now
            };

            context.Contacts.Add(contact);
            context.SaveChanges();
            //send confirmation email
            string emailSubject = "Contact Confirmation";
            string username = contactDto.FirstName + " " + contactDto.LastName;
            string emailMessage = "Dear " + username + "\n" +
                "We received you message. Thank you for contacting us. \n" +
                "Our team will contact you very soon.\n" +
                "Best Regards\n\n" +
                "Your Message:\n" + contactDto.Message;

          
            emailSender.SendEmail(emailSubject, contact.Email, username, emailMessage).Wait();

            return Ok(contact);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateContact(int id , ContactDto contactDto)
        {
            var subject = context.Subjects.Find(contactDto.SubjectId);
            if (subject==null)
            {
                ModelState.AddModelError("Subject", "Please select a valid subject");
                return BadRequest(ModelState);
            }
            var contact = context.Contacts.Find(id);
            if(contact == null)
            {
                return NotFound();
            }
            contact.FirstName = contactDto.FirstName;
            contact.LastName = contactDto.LastName;
            contact.Email = contactDto.Email;
            contact.Phone = contactDto.Phone ?? "";
            contact.Subject = subject;
            contact.Message = contactDto.Message;

            context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            //Method1
            /*
            var contact = context.Contacts.Find(id);
            if (contact == null)
            {
                return NotFound();
            }

            context.Contacts.Remove(contact);
            context.SaveChanges();
            return Ok();
            */

            //Method 2
            try
            {
                var contact = new Contact() { Id = id, Subject=new Subject() };
                context.Contacts.Remove(contact);
                context.SaveChanges();
            }
            catch(Exception)
            {
                return NotFound();
            }

            return Ok();
        }

    }
}
