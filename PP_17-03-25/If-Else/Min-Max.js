// Generate 5 random three-digit numbers
let num1 = Math.floor(Math.random() * 900) + 100;
let num2 = Math.floor(Math.random() * 900) + 100;
let num3 = Math.floor(Math.random() * 900) + 100;
let num4 = Math.floor(Math.random() * 900) + 100;
let num5 = Math.floor(Math.random() * 900) + 100;

console.log("Generated Numbers:", num1, num2, num3, num4, num5);

// Initialize min and max
let min = num1;
let max = num1;

// Check for minimum
if (num2 < min) min = num2;
else if (num3 < min) min = num3;
else if (num4 < min) min = num4;
else if (num5 < min) min = num5;

// Check for maximum
if (num2 > max) max = num2;
else if (num3 > max) max = num3;
else if (num4 > max) max = num4;
else if (num5 > max) max = num5;

console.log("Minimum Value:", min);
console.log("Maximum Value:", max);