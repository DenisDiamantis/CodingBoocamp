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

//Operators
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

//Increment Decrement Operators
// let a = 10;
// console.log(a);
// let b = ++a;
// console.log(a, b);
// let a = 10;
// console.log(a);
// let b = a++;
// console.log(a, b);

//Relational Operators
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

//Logical Operators
// let a = 10, b = 100, c = 50;

// let d = a === b && b < c;//AND  
// let e = a === b || b < c;//OR

// let f = !(a === b); //NOT

//Concatenatoin
// let username = "Scott", age = 20;
// let message1 = "Hey" + username + ", your age is " + age;
// console.log(message1);
//Interpolation
// let message2 = 
// `Hey ${username},
// your age 
// is ${age}`;
// console.log(message2);

//DecisionMaking
// let student1 = 85;
// if (student1 >= 90) {
//     console.log("Pass with A")
// } else if (student1 >= 80) {
//     console.log("Pass with B")
// } else if (student1 >= 70) {
//     console.log("Pass with c")
// }else{
//     console.log("Better luck next time");
// }
// console.log("Thank you for taking the exam");
//---------------------------------------------
// let color = "red";
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

//Loops
//1..5
//let i = 1;
// while (i <= 5) {
//     console.log(i);
//     i += 1;
// }
// do{
//     console.log(i);
//     i += 1;
// }while (i <= 5);
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

//hoisting
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

//Functions

//  function showCity () {
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

// let k=getSimpleInterest(1000,6.7,3)+10;
// console.log(k);
// let j=getSimpleInterest(2000,20,10) +8;
// console.log(j);

// let showCity=function(){
//     console.log("Athens");
//     showCountry();
// }
// let showCountry=function(){
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
//Default arguments
// let getNetPrice = function (price, TaxRate=18) {
//     let netPrice = price + (price * TaxRate / 100);
//     return netPrice;
// }

// let netPriceOfProduct1 = getNetPrice(1000, 10);
// console.log(netPriceOfProduct1);


// let netPriceOfProduct2 = getNetPrice(4000);
// console.log(netPriceOfProduct2);

//pure Function
// let getSquare=function(n){
//     let sq=n*n;
//     return sq;
// }
// console.log(getSquare(5));
// console.log(getSquare(5));

// callback function
// let Callback1 = function (name, age) {
//     console.log(`Callback 1: Name is ${name},age is ${age}`);
// };

// let Callback2 = function (name, age) {
//     console.log(`Callback 2:Age is ${age}, Name is ${name}`);
// };

// let DoWork = function (name, age, myFunctionRef){
//     name="Mr "+name;
//     age++;
//     myFunctionRef(name,age);
// }
// DoWork("Scott",20,Callback1)
// DoWork("Mark",40,Callback2)

// Higher order functions
// let doSomeWork=function(){
//     return function(){
//         return "Hello"
//     };
// };
// let result=doSomeWork();

// console.log(result());

