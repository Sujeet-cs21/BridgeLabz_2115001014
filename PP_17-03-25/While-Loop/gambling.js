let money = 100;
let wins = 0;
let bets = 0;
const goal = 200;

while (money > 0 && money < goal) {
    let bet = Math.floor(Math.random() * 2); // 0 for loss, 1 for win
    bets++;

    if (bet === 1) {
        money++;
        wins++;
    } else {
        money--;
    }
    
    console.log(`Current Money: ${money}, Bets Placed: ${bets}, Wins: ${wins}`);
}

console.log(`Game Over! ${money === 200 ? "You reached the goal!" : "You went broke!"}`);
console.log(`Total Bets Made: ${bets}, Total Wins: ${wins}`);
