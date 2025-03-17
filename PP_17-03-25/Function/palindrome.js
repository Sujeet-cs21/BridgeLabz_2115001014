function isPalindrome(num) {
    let original = num.toString();
    let reversed = original.split("").reverse().join("");
    return original === reversed;
}

const prompt = require("prompt-sync")();
let num1 = parseInt(prompt("Enter first number: "));
let num2 = parseInt(prompt("Enter second number: "));

console.log(`${num1} is ${isPalindrome(num1) ? "" : "not "}a palindrome.`);
console.log(`${num2} is ${isPalindrome(num2) ? "" : "not "}a palindrome.`);