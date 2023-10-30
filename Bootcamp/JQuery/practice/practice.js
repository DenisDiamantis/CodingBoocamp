//predicate

const Person = {
    name: "John",
    age: 30,
    height: 1.80
};
const isAbove25 = ((p) => p.age > 25);

console.log(isAbove25());