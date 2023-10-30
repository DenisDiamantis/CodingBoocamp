//predicate function that returns true/false

const Person = {
    name: "John",
    age: 30,
    height: 1.80
};

const isAbove25 = ((Person) => Person.age > 25);

console.log(isAbove25(Person));

//arrays
let prices = [50, 80, 300];
prices[0] = 450;
for (let i = 0; i < 3; i++) {
    console.log(prices[i]);
}

let students = [
    { studentName: "John", age: 17 },
    { studentName: "Scott", age: 15 },
    { studentName: "Smith", age: 16 },
    { studentName: "Jones", age: 16 }
];


for (let index = 0; index < students.length; index++) {
    console.log(`Student Name ${students[index].studentName}`);
}

let upStudents = students.map((p) => {
    p.studentName = p.studentName.toUpperCase();
    return p;
});

//destructuring

const x = [1, 2, 3, 4, 5];
const [y, z, k, l] = x;
console.log(y);
console.log(z);
console.log(k);
console.log(l);

const obj = { a: 1, b: 2 };
const { a, b } = obj;
console.log(a + 1);
console.log(b + 1);
console.log(obj.a);
console.log(obj.b);


//import
import { persons } from "./persons.js";
console.log(persons);

//arrow Function
function greetOne() {
    console.log('hello');
}

const greetTwo = () => 'hello';

//filter/map

let personsList = [
    { name: "John", color: "black" },
    { name: "Scott", color: "orange" },
    { name: "Smith", color: "black" },
    { name: "Jones", color: "red" }
];

const newPersons = personsList.filter((p) => {
    return p.color == "black";
});

console.log(newPersons);

const names = personsList.map((p) => {
    return p.name;
})
console.log(names);

//spread (...)

const blog = { title: "new blog", author: "george" }
const idBlog = { ...blog, id: 1 };

//fetch
const toDo = fetch("https://jsonplaceholder.typicode.com/todos/1")
    .then((res) => {

        res.json().then((data) => console.log(data))

    });

console.log("hello");

const getToDo = async() => {
    const res = await fetch("https://jsonplaceholder.typicode.com/todos/1");
    const data = await res.json()
    console.log(data);
}
getToDo();