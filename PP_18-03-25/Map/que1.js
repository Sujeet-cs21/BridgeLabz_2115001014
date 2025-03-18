function rollDie() {
    return Math.floor(Math.random() * 6) + 1;
}

function trackDieRolls() {
    let rollMap = new Map();
    let maxCount = 10, maxRolled = null, minRolled = null;

    while (![...rollMap.values()].includes(maxCount)) {
        let roll = rollDie();
        rollMap.set(roll, (rollMap.get(roll) || 0) + 1);
    }

    maxRolled = [...rollMap.entries()].reduce((a, b) => (a[1] > b[1] ? a : b))[0];
    minRolled = [...rollMap.entries()].reduce((a, b) => (a[1] < b[1] ? a : b))[0];

    console.log("Die Rolls:", rollMap);
    console.log("Max Rolled:", maxRolled, "Min Rolled:", minRolled);
}

trackDieRolls();