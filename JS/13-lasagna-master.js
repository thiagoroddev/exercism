/* 
Introduction
A function is a block of organized, reusable code that is used to perform some action. There are multiple ways to define functions in JavaScript. Here we will look at function declarations and function expressions. Other possibilities like arrow functions will be covered in other concepts.

Function Declaration
The standard way of defining a function in JavaScript is a function declaration, also called function definition or function statement.

It consists of the function keyword, the name of the function, and a comma-separated list of parameters in round brackets. This is followed by the function body (collection of statements that defines what a function does) wrapped in curly brackets.

function someName(param1, param2, param3) {
  // ...
}
In JavaScript, a function is invoked (called) by stating the function name followed by parentheses that contain the arguments.

someName(arg1, arg2, arg3);
Parameters
When working with parameters inside the function body, be aware of possible side effects.

Values of primitive data types are immutable. The original value is never affected by what happens to the argument in the function body.
For all other values (objects, arrays, functions), a reassignment will not affect the original value. However, if you modify such an argument (e.g. add a key to an object), that also modifies the original value that was passed in.
By default, all parameters defined in the function declaration are optional in JavaScript. If you provide fewer arguments than there are parameters, the missing arguments will be undefined inside the function, see Null and Undefined. In many cases, it makes sense to assign a more appropriate default value than undefined. This can be done by specifying default parameters directly in the function definition.

function someName(param1 = defaultValue1, param2 = defaultValue2) {
  // ...
}
Return Statement
A return statement ends the function execution and specifies a value to be returned to the function caller. A function can have multiple return statements.

function checkNumber(num) {
  if (num === 0) {
    return 'You passed 0, please provide another number.';
  }

  return 'Thanks for passing such a nice number.';
}
The result of a function that returns no value or does not have a return statement is undefined. There are no implicit returns in JavaScript.

function nakedReturn(a) {
  a * 2;
  return;
}

nakedReturn(1);
// => undefined

function noReturn(a) {
  a * 2;
}

noReturn(1);
// => undefined
In JavaScript, you can only return exactly one value. If you want to pass more information, you need to combine it into one entity first, usually into an object, or an array.

function divide(a, b) {
  return {
    quotient: Math.floor(a / b),
    remainder: a % b,
  };
}
Function Expression
A function declaration is a standalone statement. But sometimes it is helpful to define a function as part of another expression, e.g., in an assignment, as a function parameter (callback) or as value in an object. This can be done with a function expression. It has the same syntax as a function declaration, only that the function name can be omitted to create an anonymous function.

const someFunction = function (param) {
  // ...
};

someOtherFunction(function (param) {
  // ...
});

const obj = {
  someFunction: function (param) {
    // ...
  },
};
Instructions
In this exercise, you are going to write some more code related to preparing and cooking your brilliant lasagna from your favorite cookbook.

You have five tasks. The first one is related to the cooking itself, the other four are about the perfect preparation.

*/

//Task 1
/*
When you have lasagna in the oven, you want to know whether you can already take it out or not. To make sure the lasagna does not burn in the oven, you usually set a timer. But sometimes you forget about that.

Write a function cookingStatus that accepts the remaining time on the timer in minutes as a parameter. The function has three possible results.

If the timer shows 0, it should return 'Lasagna is done.'.
If the timer shows any other number, the result should be 'Not done, please wait.'.
If the function is called without a timer value, the result should be 'You forgot to set the timer.'.
The timer will never show a value below 0.

cookingStatus(12);
// => 'Not done, please wait.'

cookingStatus();
// => 'You forgot to set the timer.'
*/

function cookingStatus(status) {
  if (status == isNaN || status == null) {
    console.log("You forgot to set the timer.");
    return "You forgot to set the timer.";
  } else if (status === 0) {
    console.log("Lasagna is done.");
    return "Lasagna is done.";
  } else {
    console.log("Not done, please wait.");
    return "Not done, please wait.";
  }
}
cookingStatus("");

// ######################## GPT
/*
function cookingStatus(timer) {
  if (timer === undefined) {
    return 'You forgot to set the timer.';
  } else if (timer === 0) {
    return 'Lasagna is done.';
  } else {
    return 'Not done, please wait.';
  }
} 
##################################
  */

//Task 2
/*
For the next lasagna that you will prepare, you want to make sure you have enough time reserved so you can enjoy the cooking. You already made a plan with all the layers your lasagna will have. Now you want to estimate how long the preparation will take based on that.

Implement a function preparationTime that accepts an array of layers and the average preparation time per layer in minutes. The function should return the estimate for the total preparation time based on the number of layers. If the function is called without providing the average preparation time, 2 minutes should be assumed instead. 

const layers = ['sauce', 'noodles', 'sauce', 'meat', 'mozzarella', 'noodles'];
preparationTime(layers, 3);
// => 18

preparationTime(layers);
// => 12
*/

function preparationTime(layer, average = 2) {
  let contador = 0;
  for (let i = 0; i < layer.length; i++) {
    contador++;
  }
  console.log(contador * average);
  return contador * average;
}

preparationTime(
  ["sauce", "noodles", "sauce", "meat", "mozzarella", "noodles"],
  3
);

/* #####################################################
GPT

function preparationTime(layers, avgTimePerLayer = 2) {
  return layers.length * avgTimePerLayer;
}function preparationTime(layers, avgTimePerLayer = 2) {
  return layers.length * avgTimePerLayer;
}
######################################################

*/

//Task 3
/*
Besides reserving the time, you also want to make sure you have enough sauce and noodles to cook the lasagna of your dreams. For each noodle layer in your lasagna, you will need 50 grams of noodles. For each sauce layer in your lasagna, you will need 0.2 liters of sauce.

Define the function quantities that takes an array of layers as a parameter. The function will then determine the quantity of noodles and sauce needed to make your meal. The result should be returned as an object with keys noodles and sauce.

quantities(['sauce', 'noodles', 'sauce', 'meat', 'mozzarella', 'noodles']);
// => { noodles: 100, sauce: 0.4 }
*/
function quantities(layers) {
  let contadorNoodles = 0;
  let contadorSauce = 0;
  for (let i = 0; i < layers.length; i++) {
    if (layers[i] == "noodles") {
      contadorNoodles++;
    }
    if (layers[i] == "sauce") {
      contadorSauce++;
    }
  }

  console.log({ noodles: contadorNoodles * 50, sauce: contadorSauce * 0.2 });
  return { noodles: contadorNoodles * 50, sauce: contadorSauce * 0.2 };
}

quantities(["sauce", "noodles", "sauce", "meat", "mozzarella", "noodles"]);

/* GPT ###################################################################

function quantities(layers) {
  let noodles = 0;
  let sauce = 0;

  layers.forEach(layer => {
    if (layer === 'noodles') {
      noodles += 50;
    } else if (layer === 'sauce') {
      sauce += 0.2;
    }
  });

  return { noodles, sauce };
} ###########################################################################
 */

//Task 4
/*
A while ago you visited a friend and ate lasagna there. It was amazing and had something special to it. The friend sent you the list of ingredients and told you the last item on the list is the "secret ingredient" that made the meal so special. Now you want to add that secret ingredient to your recipe as well.

Write a function addSecretIngredient that accepts two arrays of ingredients as parameters. The first parameter is the list your friend sent you and the second is the ingredient list for your own recipe. The function should add the last item from your friend's list to the end of your list. The array that represents your recipe should be modified directly and the function should not return anything. However, the first argument should not be modified.

const friendsList = ['noodles', 'sauce', 'mozzarella', 'kampot pepper'];
const myList = ['noodles', 'meat', 'sauce', 'mozzarella'];

addSecretIngredient(friendsList, myList);
// => undefined

console.log(myList);
// => ['noodles', 'meat', 'sauce', 'mozzarella', 'kampot pepper']
*/
const friendsList = ["noodles", "sauce", "mozzarella", "kampot pepper"];
const myList = ["noodles", "meat", "sauce", "mozzarella"];
function addSecretIngredient(friendList, myList) {
  //console.log(myList);
  let lastIngredient = friendList[friendList.length - 1];
  //console.log(lastIngredient);
  myList.push(lastIngredient);

  console.log(myList);
}

addSecretIngredient(friendsList, myList);

//Task 5
/*
The amounts listed in your cookbook only yield enough lasagna for two portions. Since you want to cook for more people next time, you want to calculate the amounts for different numbers of portions.

Implement a function scaleRecipe that takes two parameters.

A recipe object that holds the amounts needed for 2 portions. The format of the object can be seen in the example below.
The number of portions you want to cook.
The function should return a recipe object with the amounts needed for the desired number of portions. You want to keep the original recipe though. This means, in this task the recipe argument should not be modified.

const recipe = {
  noodles: 200,
  sauce: 0.5,
  mozzarella: 1,
  meat: 100,
};

scaleRecipe(recipe, 4);
// =>
// {
//   noodles: 400,
//   sauce: 1,
//   mozzarella: 2,
//   meat: 200,
// };

console.log(recipe);
// =>
// {
//   noodles: 200,
//   sauce: 0.5,
//   mozzarella: 1,
//   meat: 100,
// };
*/
const recipe = {
  noodles: 200,
  sauce: 0.5,
  mozzarella: 1,
  meat: 100,
};

function scaleRecipe(recipe, portions) {
  let recipeForOne = {};
  for (let i in recipe) {
    recipeForOne[i] = recipe[i] / 2;
  }
  console.log(recipeForOne);

  let recipeCurrent = {};
  for (let ingredient in recipeForOne) {
    recipeCurrent[ingredient] = recipeForOne[ingredient] * portions;
  }

  console.log(recipeCurrent);
}
scaleRecipe(recipe, 4);

/*
GPT ######################################################################

function scaleRecipe(recipe, portions) {
  const scaledRecipe = {};
  const factor = portions / 2;

  for (const ingredient in recipe) {
    if (recipe.hasOwnProperty(ingredient)) {
      scaledRecipe[ingredient] = recipe[ingredient] * factor;
    }
  }

  return scaledRecipe;
}
  #######################################################################
*/
