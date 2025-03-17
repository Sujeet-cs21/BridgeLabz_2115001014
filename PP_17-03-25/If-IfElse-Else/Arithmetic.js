let a = parseInt(process.argv[2]);
let b = parseInt(process.argv[3]);
let c = parseInt(process.argv[4]);

let op1 = a + b * c;
let op2 = a % b + c;
let op3 = c + a / b;
let op4 = a * b + c;

let max = op1;
let min = op1;

// Find max
if (op2 > max) max = op2;
else if (op3 > max) max = op3;
else if (op4 > max) max = op4;

// Find min
if (op2 < min) min = op2;
else if (op3 < min) min = op3;
else if (op4 < min) min = op4;

console.log("Results of Arithmetic Operations:");
console.log("a + b * c =", op1);
console.log("a % b + c =", op2);
console.log("c + a / b =", op3);
console.log("a * b + c =", op4);

console.log("Maximum value:", max);
console.log("Minimum value:", min);
