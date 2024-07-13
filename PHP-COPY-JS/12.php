<?php

// Task 1
function twoSum($array1, $array2) {
    $somaUm = "";
    $somaDois = "";

    foreach ($array1 as $element) {
        $somaUm .= $element;
    }

    foreach ($array2 as $element) {
        $somaDois .= $element;
    }

    $somaTotal = intval($somaUm) + intval($somaDois);
    echo $somaTotal . "\n";
    return $somaTotal;
}

twoSum([1, 2, 3], [0, 7]);

// Task 2
function luckyNumber($value) {
    $valorOriginalString = strval($value);
    $valorInvertido = strrev($valorOriginalString);

    echo $valorInvertido . "\n";
    echo $valorOriginalString . "\n";

    if ($valorOriginalString === $valorInvertido) {
        echo "True\n";
        return true;
    } else {
        echo "False\n";
        return false;
    }
}

luckyNumber(524425);

// Task 3
function errorMessage($input) {
    if ($input === null || $input === "" || trim(strval($input)) === "") {
        echo "Required field\n";
        return "Required field";
    }

    // Tenta converter a entrada para número
    $parsedNumber = floatval($input);

    // Verifica se a entrada não é um número válido ou é zero
    if (is_nan($parsedNumber) || $parsedNumber === 0) {
        echo "Must be a number besides 0\n";
        return "Must be a number besides 0";
    }

    // Se passar todas as verificações, retorna uma string vazia
    echo "Empty\n";
    return "";
}

errorMessage(null);
?>
