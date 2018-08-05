function sumNumbers(){
    let firstNum = document.querySelector('#num1').value;
    let secondNum = document.querySelector('#num2').value;

    let result = document.querySelector('#result');
    result.innerHTML = Number(firstNum) + Number(secondNum);
}