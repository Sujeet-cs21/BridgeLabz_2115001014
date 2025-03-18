function findRepeatedDigits(range) {
    let repeatedDigits = [];
    for (let i = 0; i <= range; i++) {
        let numStr = i.toString();
        if (numStr.length === 2 && numStr[0] === numStr[1]) {
            repeatedDigits.push(i);
        }
    }
    return repeatedDigits;
}

console.log("Repeated Digits:", findRepeatedDigits(100));