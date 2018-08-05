function solve(arr){
    let data = {};
    let item = arr[arr.length - 1];

    for (let i = 0; i < arr.length - 1; i++){
        let current = arr[i].split(" ");
        let key = current[0];
        let value = current[1];

        if(!(key in data)){
            data[key] = value;
        }
        else{
            data[key] = value;
        }
    }

    if(item in data){
        console.log(data[item]);
    }
    else{
        console.log("None");
    }

}

solve(["key value", "key evalue", "test testu", "2"])