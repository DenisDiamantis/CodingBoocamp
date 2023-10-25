// getElement
// console.log(document.getElementById("p1"));
// console.log(document.getElementsByName("abc"));
// console.log(document.getElementsByName("abc")[0]);
// console.log(document.getElementsByName("abc")[1]);
// console.log(document.getElementsByName("abc")[2]);
// console.log(document.getElementsByTagName("p"));
// console.log(document.getElementsByClassName("abc"));

// query selector
// console.log(document.querySelectorAll(".class1"));
// console.log(document.querySelector(".class1"))

// getting inside tag
// console.log(document.getElementById("p1").tagName);
// console.log(document.getElementById("p1").id);
// console.log(document.getElementById("p1").innerHTML);
// console.log(document.getElementById("p1").innerText);

// edit text
// document.getElementById("p2").innerText = "april";
// let mycolors = ["lightgreen", "lightblue", "pink"];
// document.getElementById("p1").style.backgroundColor = mycolors[0];
// document.getElementById("p2").style.backgroundColor = mycolors[1];
// document.getElementById("p3").style.backgroundColor = mycolors[2];
// document.getElementById("p4").style.fontSize = "30px";

// parent - children
// console.log(document.getElementById("p1").parentElement.parentElement);
// console.log(document.getElementById("div1").children);

// Image
// let x = document.getElementById("myimage").getAttribute("src");
// console.log(x);
// document.getElementById("myimage").removeAttribute("src");
// document.getElementById("myimage").setAttribute("src", "img1.jpg");

//addElement
// let newpara = document.createElement("p");
// newpara.innerText = "para 8";
// newpara.style.backgroundColor = "lightgreen";
// document.getElementById("div1").appendChild(newpara);

//eventListener
// document.getElementById("div1").addEventListener("click", sample1);
// document.getElementById("div1").addEventListener("dblclick", sample2);

// function sample1() {
//     console.log("You clicked me");
//     document.getElementById("div1").innerHTML = "clicked 1 at " + new Date().toLocaleDateString();
// };
// function sample2() {
//     console.log("You clicked me");
//     document.getElementById("div1").style.backgroundColor="red";
// };

//checkbox
// document.getElementById("chk1").addEventListener("change",sample);

// function sample(){
//     let a =document.getElementById("chk1").checked;
//     if(a==true){
//         document.getElementById("txt1").value="5000";
//     }else{
//         document.getElementById("txt1").value="1000";
//     }
// }

//dropdownList
// document.getElementById("drp1").addEventListener("change", sample);
// function sample() {
//     let a = document.getElementById("drp1").value;
//     if (a == 1) {
//         document.getElementById("txt1").value = "5000";
//     } else if(a == 2){
//         document.getElementById("txt1").value = "10000";
//     }else if (a == 3){
//         document.getElementById("txt1").value = "20000";
//     }else{
//         document.getElementById("txt1").value = "";
//     }
// };

//radiobutton
document.getElementById("rd1").addEventListener("change", sample1);
document.getElementById("rd2").addEventListener("change", sample2);
document.getElementById("rd3").addEventListener("change", sample3);
function sample1(){
    let a =document.getElementById("rd1").checked;
     document.getElementById("txt1").value="5000";
}

function sample2(){
    let a =document.getElementById("rd2").checked;
        document.getElementById("txt1").value="10000";
}
function sample3(){
    let a =document.getElementById("rd3").checked;
        document.getElementById("txt1").value="20000";
}



