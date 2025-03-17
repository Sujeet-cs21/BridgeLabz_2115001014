let conversionType = parseInt(process.argv[2]);
let value = parseFloat(process.argv[3]);

switch (conversionType) {
    case 1: // Feet to Inches
        console.log(`${value} feet = ${value * 12} inches`);
        break;
    case 2: // Feet to Meters
        console.log(`${value} feet = ${(value * 0.3048).toFixed(2)} meters`);
        break;
    case 3: // Inches to Feet
        console.log(`${value} inches = ${(value / 12).toFixed(2)} feet`);
        break;
    case 4: // Meters to Feet
        console.log(`${value} meters = ${(value / 0.3048).toFixed(2)} feet`);
        break;
    default:
        console.log("Invalid input! Use: \n1 for Feet to Inch\n2 for Feet to Meter\n3 for Inch to Feet\n4 for Meter to Feet");
}
