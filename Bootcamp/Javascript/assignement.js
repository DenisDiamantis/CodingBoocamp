const correct = ["B", "B", "B", "B"];
//all inputs with sumbit being the last
const form = document.querySelectorAll("input");
let result = 0;
let index = 0;
const resultDisplay = document.querySelector('.result');


// check the answers
form[form.length - 1].addEventListener("click", (f) => {
    f.preventDefault();
    result = 0;
    index = 0;
    
    form.forEach((e) => {
        if (e.checked) {
            if (e.value == correct[index]) {
                index++;
                result += 25;

            }
        }
    })
    //show result
    console.log("The result is " + result);
    scrollTo(0, 0);
    resultDisplay.classList.remove('d-none');
    let show = 0;
    let timer = setInterval(() => {
        if (show != result) {
            document.querySelector("span").innerText = `${++show}%`
        }else{
            clearInterval(timer);
        }
    }, 10);
});



