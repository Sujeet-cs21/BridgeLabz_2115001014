const prompt = require("prompt-sync")();

function convertTemperature(choice, temp) {
    switch (choice) {
        case '1': // Celsius to Fahrenheit
            if (temp < 0 || temp > 100) {
                console.log("Temperature out of range (0°C - 100°C).");
                return;
            }
            console.log(`${temp}°C = ${(temp * 9/5) + 32}°F`);
            break;

        case '2': // Fahrenheit to Celsius
            if (temp < 32 || temp > 212) {
                console.log("Temperature out of range (32°F - 212°F).");
                return;
            }
            console.log(`${temp}°F = ${((temp - 32) * 5/9).toFixed(2)}°C`);
            break;

        default:
            console.log("Invalid choice.");
    }
}

// User Input
console.log("1: Convert Celsius to Fahrenheit\n2: Convert Fahrenheit to Celsius");
let choice = prompt("Enter your choice (1/2): ");
let temp = parseFloat(prompt("Enter temperature: "));

convertTemperature(choice, temp);
