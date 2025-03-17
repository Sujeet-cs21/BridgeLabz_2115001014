let n = 5;
let harmonic = 0.0;

for (let i = 1; i <= n; i++) {
    harmonic += 1 / i;
}

console.log(`The ${n}th Harmonic Number is: ${harmonic.toFixed(4)}`);