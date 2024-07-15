<?php

// Task 1
echo cookingStatus("");

// Task 2
preparationTime(["sauce", "noodles", "sauce", "meat", "mozzarella", "noodles"], 3);

// Task 3
quantities(["sauce", "noodles", "sauce", "meat", "mozzarella", "noodles"]);

// Task 4
$friendsList = ["noodles", "sauce", "mozzarella", "kampot pepper"];
$myList = ["noodles", "meat", "sauce", "mozzarella"];
addSecretIngredient($friendsList, $myList);

// Task 5
$recipe = [
    "noodles" => 200,
    "sauce" => 0.5,
    "mozzarella" => 1,
    "meat" => 100
];
scaleRecipe($recipe, 4);

// Task 1
function cookingStatus($status) {
    if ($status === null || $status === "") {
        echo "You forgot to set the timer." . PHP_EOL;
        return "You forgot to set the timer.";
    } elseif ($status === 0) {
        echo "Lasagna is done." . PHP_EOL;
        return "Lasagna is done.";
    } else {
        echo "Not done, please wait." . PHP_EOL;
        return "Not done, please wait.";
    }
}

// Task 2
function preparationTime($layer, $average = 2) {
    $contador = count($layer);
    echo $contador * $average . PHP_EOL;
    return $contador * $average;
}

// Task 3
function quantities($layers) {
    $contadorNoodles = 0;
    $contadorSauce = 0;
    foreach ($layers as $layer) {
        if ($layer == "noodles") {
            $contadorNoodles++;
        }
        if ($layer == "sauce") {
            $contadorSauce++;
        }
    }

    $result = [
        "noodles" => $contadorNoodles * 50,
        "sauce" => $contadorSauce * 0.2
    ];
    echo json_encode($result) . PHP_EOL;
    return $result;
}

// Task 4
function addSecretIngredient(&$friendList, &$myList) {
    $lastIngredient = end($friendList);
    array_push($myList, $lastIngredient);
    echo implode(", ", $myList) . PHP_EOL;
}

// Task 5
function scaleRecipe($recipe, $portions) {
    $recipeForOne = [];
    foreach ($recipe as $ingredient => $amount) {
        $recipeForOne[$ingredient] = $amount / 2;
    }
    echo json_encode($recipeForOne) . PHP_EOL;

    $recipeCurrent = [];
    foreach ($recipeForOne as $ingredient => $amount) {
        $recipeCurrent[$ingredient] = $amount * $portions;
    }
    echo json_encode($recipeCurrent) . PHP_EOL;
}
?>
