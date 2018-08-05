function solve(arr){
    let data = new Array();
    for (let i = 0; i < arr.length; i++){
        data.push({});
    }

    for (let i = 0; i < data.length; i++){
        let current = arr[i].split(" -> ");

        let name = current[0];
        let age = Number(current[1]);
        let grade = current[2];

        data[i].Name = name;
        data[i].Age = age;
        data[i].Grade = grade;
    }

    for (let i of data){
        console.log(`Name: ${i.Name}`);
        console.log(`Age: ${i.Age}`);
        console.log(`Grade: ${i.Grade}`);
    }
}

solve(["Pesho -> 13 -> 6.00", "Ivan -> 12 -> 5.57", "Toni -> 13 -> 4.90"]);