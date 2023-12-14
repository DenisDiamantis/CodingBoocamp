using Microsoft.AspNetCore.Mvc;
using MyBestStoreAPI.Models;
using MyBestStoreAPI.Services;

namespace MyBestStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractsController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public ContractsController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult GetContracts()
        {
            var contacts = context.Contacts.ToList();
            return Ok(contacts);
        }
        [HttpGet("{id}")]
        public IActionResult GetContract(int id)
        {
            var contact = context.Contacts.Find(id);
            if (contact == null)
            {
                return NotFound();
            }
            return Ok(contact);
        }

        [HttpPost]
        public IActionResult PostContracts(ContactDto contactDto)
        {
            Contact contact = new Contact()
            {
                FirstName = contactDto.FirstName,
                LastName = contactDto.LastName,
                Email = contactDto.Email,
                Phone = contactDto.Phone,
                Subject = contactDto.Subject,
                Message = contactDto.Message,
                CreatedAt = DateTime.Now
            };

            context.Contacts.Add(contact);
            context.SaveChanges();
            return Ok(contact);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteContract(int id)
        {
            try
            {
                //var contact = context.Contacts.Find(id);
                var contact = new Contact() { Id = id };
                context.Contacts.Remove(contact);
                context.SaveChanges();
                return Ok(contact);

            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateContact(int id, ContactDto contactDto)
        {
            var contact = context.Contacts.Find(id);
            if (contact == null)
            {
                return NotFound();
            }
            contact.FirstName = contactDto.FirstName;
            contact.LastName = contactDto.LastName;
            contact.Email = contactDto.Email;
            contact.Phone = contactDto.Phone;
            contact.Subject = contactDto.Subject;
            contact.Message = contactDto.Message;

            context.SaveChanges();
            return Ok(contact);
        }
    }
}