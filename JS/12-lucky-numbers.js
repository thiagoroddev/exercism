/*
Introduction
In JavaScript, values may be of different types. Changing the type of a variable can be done by explicit type conversion. Besides that, JavaScript also performs type coercion (implicit type conversion) when the context requires it.

Type Conversion
JavaScript does not have a construct to cast into a (different) type like many other languages but some built-in helpers can be used instead. Most notably, Boolean, Number and String can be used as functions to convert a value to the respective type.

Converting to a Boolean (Truthy/Falsy Values)
With Boolean(value) you can convert any value to a boolean. There is a fixed set of values, so called falsy values, that convert to false. Most importantly, false, 0, empty string, null, undefined and NaN are falsy.

For all other values, Boolean returns true. These values are called truthy.

Boolean(-1);
// => true

Boolean(0);
// => false

Boolean(' ');
// => true

Boolean('');
// => false
Note that because of the described rules, '0', 'false', [] and {} are truthy in JavaScript.

Converting to a Number
Number(value) can be used to convert a value to a number. Whitespaces at the beginning and the end of a string are ignored and an empty string is converted to 0. If you try to convert a non-primitive value or a string that does not represent a number, the result is NaN (Not-A-Number).

Number('  -12.34  ');
// => -12.34

Number('1,2');
// => NaN

Number('');
// => 0

Number({ num: 123 });
// => NaN
Converting to a String
With String(value) you can convert a value to a string. The result is what you would expect it to be for primitive values.

String(12.34);
// => '12.34'

String(false);
// => 'false'

String(null);
// => 'null'

String(undefined);
// => 'undefined'
For arrays, the String function will apply the string conversion for each element and join the results with a comma. You can also apply the join method yourself, e.g. to customize the separator. Note that in these cases null and undefined will be converted to an empty string.

String([42, null, true, 'abc']);
// => '42,,true,abc'
For objects, by default String returns an unhelpful text.

String({ key: 'value' });
// => '[object Object]'
Type Coercion
In certain contexts, JavaScript will automatically convert a value to another data type before it evaluates some statement. This implicit conversion is called type coercion.

Boolean Context
When a non-boolean value is used in a boolean context, JavaScript will apply the same rules as the Boolean function to implicitly convert the value.

Coercion to boolean commonly occurs for

the condition of an if statement
the first operand of the ternary operator ?
the operand of the logical NOT operator !
the operands of the logical AND && and OR || operators (the result of the expression is one of the operands, not necessarily a boolean)
const num = 0;
if (num) {
  // this block is NOT executed because 0 is falsy
}
String Context
If the addition operator + is used for primitive values and one operand is a string, the other one will be coerced into a string as well. The conversion logic is the same as when using the String function. Afterwards, the two strings are concatenated.

let name;
'hello ' + name;
// => 'hello undefined'
Numeric Context
Many operators coerce the operands into numbers (if necessary) according to the logic of the Number function explained above.

Arithmetic operators: + (if no string is involved), -, *, /, %, **
Unary plus and unary negation operators: +, -
Relational operators (for non-string operands): >, >=, <, <=
Bitwise operators: |, &, ^, ~
Refer to the MDN list of operators for more details about any of those operators.

To avoid mistakes, it is good practice to always call Number explicitly before applying those operators.

Instructions
Your friend Kojo is a big fan of numbers. He has a small website called 'fun-with-numbers'. Kojo is not that good at programming so he asked you for help.

You will build two helper functions for new number games on Kojos' website and a third one to validate some input the user can enter.

One of the games on Kojos' website looks like a slot machine that shows two groups of wheels with digits on them. Each group of digits represents a number. For the game mechanics, Kojo needs to know the sum of those two numbers.

Write a function twoSum that accepts two arrays as parameters. Each array consists of one or more numbers between 0 and 9. The function should interpret each array as a number and return the sum of those two numbers.

twoSum([1, 2, 3], [0, 7]);
//=> 130

// [1, 2, 3] represents 123 and [0, 7] represents 7.
// 123 + 7 = 130

Stuck? Reveal Hints
Opens in a modal
Another game on the website is a little quiz called "Lucky Numbers". A user can enter a number and then sees whether the number belongs to some secret sequence or pattern. The sequence or pattern of the "lucky numbers" changes each month and each user only has a limited number of tries to guess it.

This months' lucky numbers should be numbers that are palindromes. Palindromic numbers remain the same when the digits are reversed.

Implement the new luckyNumber function that accepts a number as a parameter. The function should return true if the number is a palindrome and false otherwise. The input number will always be a positive integer.

luckyNumber(1441);
//=>  true

luckyNumber(123);
//=> false

Stuck? Reveal Hints
Opens in a modal
In various places on the website, there are input fields where the users can enter numbers and click a button to trigger some action. Kojo wants to improve the user experience of his site. He wants to show an error message in case the user clicks the button but the field contains an invalid input value.

Here is some more information on how the value of an input field is provided.

If the user types something into a field, the associated value is always a string even if the user only typed in numbers.
If the user types something but deletes it again, the variable will be an empty string.
Before the user even started typing, the variable can be undefined or null.
Write a function errorMessage that accepts the user input as a parameter. If the user did not provide any input, errorMessage should return 'Required field'. If the input does not represent a non-zero number (according to the JavaScript conversion rules), 'Must be a number besides 0' should be returned. In all other cases, you can assume the input is valid, the return value should be an empty string.

errorMessage('123');
// => ''

errorMessage('');
// => 'Required field'

errorMessage('abc');
// => 'Must be a number besides 0'
*/

//Task 1
function twoSum(array1, array2) {
  let somaUm = "";
  let somaDois = "";

  array1.forEach((element) => {
    somaUm += element;
  });

  array2.forEach((element) => {
    somaDois += element;
  });

  let somaTotal = Number(somaUm) + Number(somaDois);
  console.log(somaTotal);
  return somaTotal;
}

twoSum([1, 2, 3], [0, 7]);

//Task 2

function luckyNumber(value) {
  let valorOriginalString = value.toString();
  let valorInvertido = "";

  for (let i = valorOriginalString.length - 1; i > -1; i--) {
    valorInvertido += valorOriginalString[i];
  }
  console.log(valorInvertido);
  console.log(valorOriginalString);
  if (valorOriginalString === valorInvertido) {
    console.log("True");
    return true;
  } else {
    console.log("False");
    return false;
  }
}

luckyNumber(524425);

// Task 3
function errorMessage(input) {
  if (input === null || input === undefined || input.toString().trim() === "") {
    console.log("Require field");
    return "Required field";
  }

  // Tenta converter a entrada para número
  let parsedNumber = Number(input);

  // Verifica se a entrada não é um número válido ou é zero
  if (isNaN(parsedNumber) || parsedNumber === 0) {
    console.log("Must be a number besides");
    return "Must be a number besides 0";
  }

  // Se passar todas as verificações, retorna uma string vazia
  console.log("vazio");
  return "";
}

errorMessage();
