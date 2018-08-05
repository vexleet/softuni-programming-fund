function solve(arr){
    let data = new Array();

    for (let i = 0; i < arr.length; i++){
        let current = arr[i].split(' ');
        let command = current[0];
        let numberOrIndex = Number(current[1]);

        if(command == "add"){
            data.push(numberOrIndex);
        }
        else if(command == "remove"){
            if(numberOrIndex >= 0 && numberOrIndex < data.length){
                data.splice(numberOrIndex, 1);
            }
        }
    }

    for (let i of data){
        console.log(i);
    }
}

solve(["add 3", "add 5", "remove 1", "add 2"]);