let n = 72;
console.log(`Prime factors of ${n} are:`);

for (let i = 2; i * i <= n; i++) {
    while (n % i === 0) {
        console.log(i);
        n = n / i;
    }
}

if (n > 1) {
    console.log(n);
}
