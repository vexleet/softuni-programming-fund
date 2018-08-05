function solve(arr){
    for (let i = 0; i<arr.length;i++){
        if(arr[i] === "Stop"){
            return;
        }
        console.log(arr[i]);
    }
}

solve(["Line1", "line2", "line3", "Stop", "Oesho"])