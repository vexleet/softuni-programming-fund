function solve(str){
    let obj = {};

    for (let i = 0; i < str.length; i++){
        let command = str[i].split(" -> ");
        let key = command[0];
        let value = "";
        if(Number(command[1])){
            value = Number(command[1])
        }
        else{
            value = command[1];
        }
        obj[key] = value;
    }

    let data = JSON.stringify(obj);

    console.log(data);
}

solve(["name -> Angel", "surname -> Pesho", "age -> 20", "town -> blg", "grade -> 6.00"])