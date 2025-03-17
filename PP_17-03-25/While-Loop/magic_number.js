const prompt = require("prompt-sync")();

let low = 1;
let high = 100;
let found = false;

console.log("Think of a number between 1 and 100.");

while (low < high) {
    let mid = Math.floor((low + high) / 2);
    let response = prompt(`Is number less than ${mid}? (yes/no): `);

    if (response.toLowerCase() === "yes") {
        high = mid - 1;
    } else {
        low = mid + 1;
    }

    if (low === high) {
        found = true;
        console.log(`Magic Number is: ${low}`);
        break;
    }
}
