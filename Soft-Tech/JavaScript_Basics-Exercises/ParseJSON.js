function solve(arr){
    let data =  arr.map(JSON.parse);

    for (let i = 0; i < data.length; i++){
        console.log(`Name: ${data[i].name}`);
        console.log(`Age: ${data[i].age}`);
        console.log(`Date: ${data[i].date}`);
    }
}

solve([`{"name":"Gosho","age":10,"date":"19/06/2005"}`,
`{"name":"Tosho","age":11,"date":"04/04/2005"}`,]);