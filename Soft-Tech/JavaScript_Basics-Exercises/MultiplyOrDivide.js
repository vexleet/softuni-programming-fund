function multiplyOrDivide([num1, num2]){
    num1 = Number(num1);
    num2 = Number(num2);

    if(num2 >= num1){
        console.log(num1 * num2);
    }
    else{
        console.log(num1 / num2);
    }
}

multiplyOrDivide(["13", "13"])