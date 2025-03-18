function getRandomNumbers(count, min, max) {
    return Array.from({ length: count }, () => Math.floor(Math.random() * (max - min + 1)) + min);
}

function findSecondLargestAndSmallest(arr) {
    let largest = -Infinity, secondLargest = -Infinity;
    let smallest = Infinity, secondSmallest = Infinity;

    arr.forEach(num => {
        if (num > largest) {
            secondLargest = largest;
            largest = num;
        } else if (num > secondLargest && num !== largest) {
            secondLargest = num;
        }

        if (num < smallest) {
            secondSmallest = smallest;
            smallest = num;
        } else if (num < secondSmallest && num !== smallest) {
            secondSmallest = num;
        }
    });

    return { secondLargest, secondSmallest };
}

let numbers = getRandomNumbers(10, 100, 999);
console.log("Numbers:", numbers);
console.log(findSecondLargestAndSmallest(numbers));

numbers.sort((a, b) => a - b);
console.log("Sorted Numbers:", numbers);
console.log("2nd Smallest:", numbers[1], "2nd Largest:", numbers[numbers.length - 2]);