/*
Introduction
Array destructuring
JavaScript's array destructuring syntax is a concise way to extract values from an array and assign them to distinct variables.

In this example, each value in the numberOfMoons array is assigned to its corresponding planet:

const numberOfMoons = [0, 2, 14];
const [venus, mars, neptune] = numberOfMoons;

neptune;
// => 14
Rest and spread
JavaScript has a built-in ... operator that makes it easier to work with indefinite numbers of elements. Depending on the context, it's called either a rest operator or spread operator.

Rest elements
When ... appears on the left-hand side of an assignment, those three dots are known as the rest operator. The three dots together with a variable name is called a rest element. It collects zero or more values, and stores them into a single array.

const [a, b, ...everythingElse] = [0, 1, 1, 2, 3, 5, 8];

everythingElse;
// => [1, 2, 3, 5, 8]
Note that in JavaScript, unlike some other languages, a rest element cannot have a trailing comma. It must be the last element in a destructuring assignment.

Spread elements
When ... appears on the right-hand side of an assignment, it's known as the spread operator. It expands an array into a list of elements. Unlike the rest element, it can appear anywhere in an array literal expression, and there can be more than one.

const oneToFive = [1, 2, 3, 4, 5];
const oneToTen = [...oneToFive, 6, 7, 8, 9, 10];

oneToTen;
// => [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
Instructions
Elyse, magician-to-be, continues her training. She has a deck of cards she wants to manipulate.

To make things easier, she usually only starts with cards numbered 1 to 10, although some of the tricks may involve additional cards.
*/

//Task 1 --------------------------------------------------------------------------------
/*
Elyse will summon the first card in the deck without using the array[index] or .shift(). It's just like magic.*/
function getFirstCard(deck) {
  const [one, ...rest] = deck;

  console.log(one);
  return one;
}

getFirstCard([1, 2, 3, 5, 8]);

//Task 2
/*
Elyse performs sleight of hand and summons the second card in the deck without using the array[index].*/

function getSecondCard(deck) {
  const [one, two, ...rest] = deck;

  console.log(two);
  return two;
}

getSecondCard([3, 2, 10, 6, 7]);

// Task 3
/*
Elyse will make the top two cards of the deck switch places. She doesn't need to call a single function.
*/

function swapTopTwoCards(deck) {
  const [one, two, ...rest] = deck;
  const invert = [two, one, ...rest];

  console.log(invert);
  return invert;
}

swapTopTwoCards([10, 7, 3, 8, 5]);

// Task 4
/* 
Elyse will separate the deck into two piles. The first pile will contain only the top card of the original deck, while the second pile will contain all the other cards.
*/
function discardTopCard(deck) {
  const [one, ...rest] = deck;
  const twoPiles = [one, rest];

  console.log(twoPiles);
  return twoPiles;
}

discardTopCard([2, 5, 4, 9, 3]);

// Task 5
/* 
Elyse will insert a set of face cards (i.e. jack, queen, and king) into her deck such that they become the second, third, and fourth cards, respectively.
*/
function insertFaceCards(deck) {
  const [one, ...rest] = deck;
  const newDeck = [one, "jack", "queen", "king", ...rest];

  console.log(newDeck);
  return newDeck;
}

insertFaceCards([5, 4, 7, 10]);
