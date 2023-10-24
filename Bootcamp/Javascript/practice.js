// console.log("Welcome to Javascript");
// console.log("Welcome to PeopleCert");
// console.log(20 + "/" + 10 + "/" + 2023);

// let firstName = "Scott";
// let age = 20;
// let a = true;
// console.log(firstName);
// console.log(age);
// console.log(a);

// const noOfHoursPerDay = 50;
// let rentPerHour = 2;
// console.log(noOfHoursPerDay * rentPerHour);
// let rentPerDay = noOfHoursPerDay * rentPerHour;
// console.log(rentPerDay);

// Operators
// let a = 10, b = 3;
// let c = a + b;
// console.log(c);
// let d = a - b;
// console.log(d);
// let e = a * b;
// console.log(e);
// let f = a / b;
// console.log(f);
// let g = a % b;
// console.log(g);
// let h = a ** b;
// console.log(h);

// Assignment operators
// let a = 10;
// a = a + 8;
// a += 1;
// console.log(a);
// a = a / 3;
// a -= 3;
// console.log(a);

// Increment Decrement Operators
// let a = 10;
// console.log(a);
// let b = ++a;
// console.log(a, b);
// let a = 10;
// console.log(a);
// let b = a++;
// console.log(a, b);

// Relational Operators
// let a = 10, b = "10";
// let c = a == b;
// let d = a === b;
// console.log(c);
// console.log(d);
// let e = a != b;
// let f = a < b;
// let g = a > b;
// let h = a <= b;
// let i = a <= b;

// Logical Operators
// let a = 10, b = 100, c = 50;

// let d = a === b && b < c;//AND  
// let e = a === b || b < c;//OR

// let f = !(a === b); //NOT

// Concatenatoin
// let username = "Scott", age = 20;
// let message1 = "Hey" + username + ", your age is " + age;
// console.log(message1);
// Interpolation
// let message2 =
//     `Hey ${username},
// your age 
// is ${age}`;
// console.log(message2);

// DecisionMaking
// let student1 = 85;
// if (student1 >= 90) {
//     console.log("Pass with A")
// } else if (student1 >= 80) {
//     console.log("Pass with B")
// } else if (student1 >= 70) {
//     console.log("Pass with c")
// } else {
//     console.log("Better luck next time");
// }
// console.log("Thank you for taking the exam");
// ---------------------------------------------
//     let color = "red";
// switch (color) {
//     case "red":
//         console.log("color is red");
//         break;
//     case "green":
//         console.log("color is green");
//         break;
//     default:
//         console.log("no matching color");
//         break;
// }

// Loops
// 1..5
// let i = 1;
// while (i <= 5) {
//     console.log(i);
//     i += 1;
// }
// do {
//     console.log(i);
//     i += 1;
// } while (i <= 5);
// for (let i = 1; i <= 5; i++) {
//     console.log(i);
// }

// for (let i = 1; i <= 10; i++) {
//     console.log(i);
//     if (i === 6) {
//         //break;
//         continue;
//     }
// }

// hoisting
// console.log("Statement 1 ", x);
// console.log("hello");
// var x = 1;
// console.log("Statement 1 ", x);

// let a = 5;
// {
//     let i = 1;
//     console.log(a);
// }
// console.log(i);

// Functions

// function showCity() {
//     console.log("PeopleCert");
//     console.log("Coding");
//     console.log("Bootcamp");
// }
// let showCity = function () {
//     console.log("PeopleCert");
//     console.log("Coding");
//     console.log("Bootcamp");
// }

// let showCity = () => {
//     console.log("PeopleCert");
//     console.log("Coding");
//     console.log("Bootcamp");
// }

// showCity();

// let getSimpleInterest = function (principal, rateofInterest, noOfYears) {

//     let result = (principal * rateofInterest * noOfYears) / 100;
//     console.log(result);
//     return result;
// }

// let k = getSimpleInterest(1000, 6.7, 3) + 10;
// console.log(k);
// let j = getSimpleInterest(2000, 20, 10) + 8;
// console.log(j);

// let showCity = function () {
//     console.log("Athens");
//     showCountry();
// }
// let showCountry = function () {
//     console.log("Greece");
// }
// showCity();

// Arguments
// let getCartBill = function () {
//     let sum = 0;
//     for (let i = 0; i < arguments.length; i++) {
//         sum += arguments[i];
//     }
//     return sum;
// }

// console.log(getCartBill(13));
// console.log(getCartBill(13, 89, 67, 4));
// console.log(getCartBill(13, 89, 67, 4, 23, 76));
// Default arguments
// let getNetPrice = function (price, TaxRate = 18) {
//     let netPrice = price + (price * TaxRate / 100);
//     return netPrice;
// }

// let netPriceOfProduct1 = getNetPrice(1000, 10);
// console.log(netPriceOfProduct1);


// let netPriceOfProduct2 = getNetPrice(4000);
// console.log(netPriceOfProduct2);

// pure Function
// let getSquare = function (n) {
//     let sq = n * n;
//     return sq;
// }
// console.log(getSquare(5));
// console.log(getSquare(5));

// callback function
//     let Callback1 = function (name, age) {
//         console.log(`Callback 1: Name is ${name},age is ${age}`);
//     };

// let Callback2 = function (name, age) {
//     console.log(`Callback 2:Age is ${age}, Name is ${name}`);
// };

// let DoWork = function (name, age, myFunctionRef) {
//     name = "Mr " + name;
//     age++;
//     myFunctionRef(name, age);
// }
// DoWork("Scott", 20, Callback1);
// DoWork("Mark", 40, Callback2);

// Higher order functions
// let doSomeWork = function () {
//     return function () {
//         return "Hello"
//     };
// };
// let result = doSomeWork();
// console.log(result());

// setTimeout
// function SayHello() {
//     console.log("Hello");
// };

// function SayGoodbye() {
//     console.log("Goodbye");
// };

// SayHello();
// setTimeout(SayGoodbye, 5000);

// Objects
// let person = {
//     personName: "Scott",
//     personLast: "Doe",
//     birthDay() {
//         return `Happy Birthday to ${this.personName}`;
//     }
// };

// console.log(person.birthDay());
// console.log(person.personName);
// console.log(person.personLast);

// employee scenario
// let employee = {
//     firstName: "John",
//     lastName: "Smith",
//     designation: "Clerk",
//     salary: 3000,
//     workExperienceYears: 6,

//     getFullName() {
//         return `${this.firstName} ${this.lastName}`;
//     },
//     promotion() {
//         let isEligibleForPromotion;

//         if (this.designation == "Clerk") {
//             if (this.workExperienceYears >= 3) {
//                 isEligibleForPromotion = true;
//                 this.designation = "Asst. Manager";
//                 this.salary += this.salary * (10 / 100);

//             } else {
//                 isEligibleForPromotion = false;
//             }

//         } else if (this.designation == "Asst. Manager") {
//             if (this.workExperienceYears > 5) {
//                 isEligibleForPromotion = true;
//                 this.designation = "Manager";
//                 this.salary += this.salary * (20 / 100);
//             }
//             isEligibleForPromotion = false;
//         } else {
//             console.log("Not have enough years of experience yet");
//             isEligibleForPromotion = false;
//         }
//         return isEligibleForPromotion;
//     }


// };
// console.log(employee.getFullName());
// console.log(employee.designation);
// console.log(employee.salary);
// if (employee.promotion()) {
//     console.log("Congratulations!");
// } else {
//     console.log("The employee is not eligible for promotion this year")
// };
// console.log(employee.getFullName());
// console.log("You became a " + employee.designation);
// console.log("Your current salary is " + employee.salary);
// if (employee.promotion()) {
//     console.log("Congratulations!");
// } else {
//     console.log("The employee is not eligible for promotion this year")
// };
// console.log(employee.getFullName());
// console.log("You became a " + employee.designation);
// console.log("Your current salary is " + employee.salary);

//after creation add
// let student = {};
// student.marks = 70;
// console.log(student);
// student.getResult = function () {
//     if (this.marks >= 50) {
//         return "Pass";
//     } else {
//         return "Fail";
//     }
// };
// console.log(student.getResult());


//call funtion on object
// let person={
//     age:20
// };

// let birthDay=function(years){
//     this.age +=years;
// }
// console.log(person.age);
// birthDay.call(person,3);
// console.log(person.age);


//arrow function
// let add=(a,b)=>{
//     return a+b;
// }
// console.log(add(10,3));


//Classes
// class employee {
//     empId;
//     empName;
//     salary;

//     getEmpName() {
//         return this.empName;
//     }
//     increaseSalary(amount) {
//         this.salary += amount;
//     }
// }

// let employee1 = new employee();
// employee1.empId = 101;
// employee1.empName = "Scott";
// employee1.salary = 3000;
// employee1.increaseSalary(800);
// console.log(employee1);
// let employee2 = new employee();
// employee2.empId = 102;
// employee2.empName = "John";
// employee2.salary = 2000;
// employee2.increaseSalary(300);
// console.log(employee2);

//Constructors
// class person {
//     personName;
//     age;
//     email
//     constructor(pName, ag, em) {
//         this.personName = pName;
//         this.age = ag;
//         this.email = em;
//     }

// }

// let person1 = new person();//no arguement constructor
// let person2 = new person("Scott",20,"scott@gmail.com");
// let person3 = new person("John",24,"john@gmail.com");


//Private variable
// class Customer {
//     customerId;
//     customerName;
//     #creditCardNumber;


//     constructor(customerId, customerName, creditCardNumber) {
//         this.customerId = customerId;
//         this.customerName = customerName;
//         this.#creditCardNumber = creditCardNumber;
//     }

//     getCreditCardNumber(){
//         return this.#creditCardNumber;
//     }
// }

// let customer1= new Customer(101,"Smith",12345);
// console.log(customer1.customerId);
// console.log(customer1.creditCardNumber);
// console.log(customer1.getCreditCardNumber());

//Static variable
// class Student {
//     studentName;
//     marks;
//     static studentCount =0;

//     constructor(studentName, marks) {
//         this.studentName = studentName;
//         this.marks = marks;
//         Student.studentCount++;
//     }
// }

// let student1 = new Student("John", 90);
// let student2 = new Student("Scott", 80);
// console.log(Student.studentCount);

//Arrays
// let prices = [50, 80, 300];
// console.log(prices[0]);
// prices[0] = 150;
// console.log(prices[0]);
// console.log(prices.length);
// prices.push(70);
// prices[0] = 150;
// console.log(prices.length);
// console.log(prices[prices.length - 1]);
// for (let index = 0; index < prices.length; index++) {
//     console.log(prices[index]);

// }
// let students = [
//     { studentName: "Jones", age: 17 },
//     { studentName: "Scott", age: 15 },
//     { studentName: "Smith", age: 20 },
//     { studentName: "Mike", age: 22 }
// ]
// console.log(students.length);
// for (let index = 0; index < prices.length; index++) {
//     console.log(`Student Name: ${students[index].studentName}, age: ${students[index].age}`);

// }

//aarray-push/pop
// let prices = [700, 40, 80, 25];
// prices.push(500);
// for (let index = 0; index < prices.length; index++) {
//     console.log(prices[index]);

// }
// console.log(prices.pop());
// for (let index = 0; index < prices.length; index++) {
//     console.log(prices[index]);

// }
// console.log();

// let products=[
//     {productName: "TV",price:5000},
//     {productName: "Monitor",price:1200},
//     {productName: "iPad",price:2000},
//     {productName: "iPhone",price:1800}
// ];

// products.push({productName:"Keyboard",price:45});
// console.log(products);

//Array callback functions
// const products = [
//     {
//         id: 1, productName: "Samsung TV",
//         price: 5000, brand: "Samsung"
//     },
//     {
//         id: 2, productName: "Apple iPod",
//         price: 770, brand: "Apple"
//     },
//     {
//         id: 3, productName: "LG Monitor",
//         price: 1200, brand: "LG"
//     },
//     {
//         id: 4, productName: "Apple iPad",
//         price: 2000, brand: "Apple"
//     },
//     {
//         id: 5, productName: "Apple iPhone",
//         price: 1900, brand: "Apple"
//     }
// ];

// let iProducts = products.filter((p) => { return p.brand === "Apple" });
// console.log(iProducts);

// let update = products.map((p) => {
//     p.price += 100;
//     p.productName = p.productName.toUpperCase();
//     return p;
// });
// console.log(update);

//Conversions
// let a = 10;
// let b = a.toString();
// let c = "10";
// let d = Number(c);
// let e = parseInt(c);

// let a = new Date();
// console.log(a);
