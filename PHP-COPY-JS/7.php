<?php

function needsLicense($kind) {
    if ($kind === 'car' || $kind === 'truck') {
        return true;
    } else {
        return false;
    }
}
echo var_export(needsLicense('car'), true) . "\n";

/**
 * Helps choosing between two options by recommending the one that
 * comes first in dictionary order.
 *
 * @param string $option1
 * @param string $option2
 * @return string a sentence of advice which option to choose
 */
function chooseVehicle($option1, $option2) {
    if ($option1 > $option2) {
        return $option2 . ' is clearly the better choice.';
    } else {
        return $option1 . ' is clearly the better choice.';
    }
}
echo chooseVehicle('A', 'b') . "\n";

/**
 * Calculates an estimate for the price of a used vehicle in the dealership
 * based on the original price and the age of the vehicle.
 *
 * @param float $originalPrice
 * @param int $age
 * @return float expected resell price in the dealership
 */
function calculateResellPrice($originalPrice, $age) {
    if ($age > 10) {
        return 0.5 * $originalPrice;
    } else if ($age < 3) {
        return 0.8 * $originalPrice;
    } else {
        return 0.7 * $originalPrice;
    }
}

echo calculateResellPrice(1000, 15) . "\n";

?>
