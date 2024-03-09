"""
Introduction
Comparison
In JavaScript, numbers can be compared using the following relational and equality operators.

Comparison	Operator
Greater than	a > b
Greater than or equals	a >= b
Less than	a < b
Less than or equals	a <= b
(Strict) Equals	a === b
Not (strict) equals	a !== b
The comparison result is always a boolean value: true or false.

1 < 3;
// => true

2 !== 2;
// => false

1 === 1.0;
// => true
// All numbers are floating-points, so this is different syntax for
// the exact same value.
In JavaScript, the comparison operators above can also be used to compare strings. In that case, a dictionary (lexicographical) order is applied. You can find a list of the exact order of all the characters here.

'Apple' > 'Pear';
// => false

'a' < 'above';
// => true

'a' === 'A';
// => false
Conditionals
A common way to conditionally execute logic in JavaScript is the if-statement. It consists of the if keyword, a condition wrapped in round brackets and a code block wrapped in curly brackets. The code block will only be executed if the condition evaluates to true.

if (condition) {
  // code that is executed if "condition" is true
}
It can be used stand-alone or combined with the else keyword.

if (condition) {
  // code that is executed if "condition" is true
} else {
  // code that is executed otherwise
}
To nest another condition into the else statement, you can use else if.

if (condition1) {
  // code that is executed if "condition1" is true
} else if (condition2) {
  // code that is executed if "condition2" is true
  // but "condition1" was false
} else {
  // code that is executed otherwise
}
Instructions
In this exercise, you will write some code to help you prepare to buy a vehicle.

You have three tasks, one to determine if you will need to get a license, one to help you choose between two vehicles and one to estimate the acceptable price for a used vehicle.

Some kinds of vehicles require a drivers license to operate them. Assume only the kinds 'car' and 'truck' require a license, everything else can be operated without a license.

Implement the needsLicense(kind) function that takes the kind of vehicle and returns a boolean indicating whether you need a license for that kind of vehicle.

needsLicense('car');
// => true

needsLicense('bike');
// => false

Stuck? Reveal Hints
Opens in a modal
You evaluate your options of available vehicles. You manage to narrow it down to two options but you need help making the final decision. For that implement the function chooseVehicle(option1, option2) that takes two vehicles as arguments and returns a decision that includes the option that comes first in dictionary order.

chooseVehicle('Wuling Hongguang', 'Toyota Corolla');
// =>  'Toyota Corolla is clearly the better choice.'

chooseVehicle('Volkswagen Beetle', 'Volkswagen Golf');
// =>  'Volkswagen Beetle is clearly the better choice.'

Stuck? Reveal Hints
Opens in a modal
Now that you made your decision you want to make sure you get a fair price at the dealership. Since you are interested in buying a used vehicle, the price depends on how old the vehicle is. For a rough estimate, assume if the vehicle is less than 3 years old, it costs 80% of the original price it had when it was brand new. If it is more than 10 years old, it costs 50%. If the vehicle is at least 3 years old but not older than 10 years, it costs 70% of the original price.

Implement the calculateResellPrice(originalPrice, age) function that applies this logic using if, else if and else (there are other ways if you want to practice). It takes the original price and the age of the vehicle as arguments and returns the estimated price in the dealership.

calculateResellPrice(1000, 1);
// => 800

calculateResellPrice(1000, 5);
// => 700

calculateResellPrice(1000, 15);
// => 500

"""

#// @ts-check
#//
#// The line above enables type checking for this file. Various IDEs interpret
#// the @ts-check directive. It will give you helpful autocompletion when
#// implementing this exercise.

"""/**
 * Determines whether or not you need a license to operate a certain kind of vehicle.
 *
 * @param {string} kind
 * @returns {boolean} whether a license is required
 */"""

def needs_license(kind):
    return kind == 'car' or kind == 'truck'

print(needs_license('car'))
  
"""
  * Helps choosing between two options by recommending the one that
  * comes first in dictionary order.
  *
  * @param {string} option1
  * @param {string} option2
  * @returns {string} a sentence of advice which option to choose
""" 
  
def choose_vehicle(option1, option2):
  if option1 > option2:
      return option2 + ' is clearly the better choice.'
  else:
      return option1 + ' is clearly the better choice.'

print(choose_vehicle('A', 'b'))

"""/**
  * Calculates an estimate for the price of a used vehicle in the dealership
  * based on the original price and the age of the vehicle.
  *
  * @param {number} originalPrice
  * @param {number} age
  * @returns {number} expected resell price in the dealership
  """

def calculate_resell_price(original_price, age):
  if age > 10:
      return 0.5 * original_price
  elif age < 3:
      return 0.8 * original_price
  else:
      return 0.7 * original_price

print(calculate_resell_price(1000, 15))