let persons = [
    { name: "Scott", age: 20, mobile: "123456789" },
    { name: "Smith", age: 22, mobile: "987654321" },
    { name: "Allen", age: 24, mobile: "134679245" }
];

for (let index = 0; index < persons.length; index++) {
    let element = persons[index];
    console.log(element);
    let str = "<tr> <td>" + element.name +
        "</td> <td>" + element.age + "</td> <td>" +
        element.mobile + "</td> </tr>";
    $("#table1").append(str);

}