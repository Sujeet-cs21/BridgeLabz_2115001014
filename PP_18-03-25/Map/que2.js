function generateBirthMonths(count) {
    let birthMonths = new Map();

    for (let i = 0; i < count; i++) {
        let month = Math.floor(Math.random() * 12) + 1;
        if (!birthMonths.has(month)) {
            birthMonths.set(month, []);
        }
        birthMonths.get(month).push(i + 1);
    }

    return birthMonths;
}

console.log("Individuals by Birth Month:", generateBirthMonths(50));