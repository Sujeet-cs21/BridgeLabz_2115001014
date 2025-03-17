const prompt = require("prompt-sync")();

// Function to check if a number is prime
function isPrime(num) {
    if (num < 2) return false;
    for (let i = 2; i * i <= num; i++) {
        if (num % i === 0) return false;
    }
    return true;
}

// Function to get palindrome of a number
function getPalindrome(num) {
    return parseInt(num.toString().split("").reverse().join(""));
}

// Main logic
let number = parseInt(prompt("Enter a number: "));

if (isPrime(number)) {
    console.log(`${number} is a prime number.`);
    let palindrome = getPalindrome(number);
    console.log(`Palindrome of ${number} is ${palindrome}.`);
    
    if (isPrime(palindrome)) {
        console.log(`Palindrome ${palindrome} is also a prime number.`);
    } else {
        console.log(`Palindrome ${palindrome} is not a prime number.`);
    }
} else {
    console.log(`${number} is not a prime number.`);
}