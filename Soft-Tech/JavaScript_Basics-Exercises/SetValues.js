function solve(arr){
    let data = Array(Number(arr[0]) + 1).join('0').split('').map(parseFloat);

    for (let i = 1; i < arr.length; i++){
        let current = arr[i].split(" - ");
        let index = Number(current[0]);
        let element = Number(current[1]);

        data[index] = element;
    }

    for (let i of data){
        console.log(i);
    }
}

solve(["5", "0 - 1", "3 - 2", "4 - 3"]);