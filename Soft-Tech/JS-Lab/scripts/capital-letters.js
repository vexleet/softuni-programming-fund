function capitalLetters(str){
    let letters = str.join(" ").match(/\b[A-Z]+\b/g);

    console.log(letters.join(', '));
}