let heads = 0, tails = 0;

while (heads < 11 && tails < 11) {
    let flip = Math.floor(Math.random() * 2); // 0 for Heads, 1 for Tails

    if (flip === 0) {
        heads++;
    } else {
        tails++;
    }
    
    console.log(`Heads: ${heads}, Tails: ${tails}`);
}

console.log(`Game Over! ${heads === 11 ? "Heads" : "Tails"} wins!`);