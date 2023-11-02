// Part 1
const userName = "Moroni";
console.log(`Username: ${userName}`);

// Part 2
const currentDateAndTime = new Date();
console.log(`It is now ${currentDateAndTime.toLocaleString()}`);

// Part 3
let theTotal = total(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
console.log(`The total is ${theTotal}`);

// 'total' function declaration
function total(...theNumbers) {
	let sum = 0;
	for (let aNumber of theNumbers) {
		sum += aNumber * 1; // Why do we use * 1? It implicitly converts a string to a number.
	}
	return sum
}

// Answer to the question "Why do we use * 1 in the total function?"

// The * 1 operator is used to implicitly convert a string to a number. This is necessary because the for...in loop iterates over the properties of the theNumbers object, which are all strings. By using the * 1 operator, we ensure that the values of the aNumber variable are always numbers before they are added to the sum variable.

// Here is an example of how the * 1 operator works:

const aString = "10";
const aNumber = aString * 1;

console.log(aNumber); // This will log the number 10 to the console

