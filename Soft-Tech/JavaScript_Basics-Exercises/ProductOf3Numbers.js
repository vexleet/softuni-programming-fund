function solve(arr){
    arr = arr.map(Number);
    if(arr.some(x => x == 0)){
        console.log("Positive");
        return;
    }

    let negativeNumbers = arr.filter(x => x < 0);

    if(negativeNumbers.length % 2 == 1){
        console.log("Negative");
    }
    else{
        console.log("Positive");
    }
}

solve(["-3", "-2", "0"])