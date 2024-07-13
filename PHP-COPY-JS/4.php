<?php

function dayRate($ratePerHour) {
    return $ratePerHour * 8;
}

echo "Rate per day worked: " . dayRate(29.654321) . "\n";

// 2
function daysInBudget($budget, $ratePerHour) {
    return floor($budget / ($ratePerHour * 8));
}

echo "Days working: " . daysInBudget(20000, 89) . "\n";

// 3
function priceWithMonthlyDiscount($ratePerHour, $numDays, $discount) {
    $monthRate = $ratePerHour * 8 * 22;
    $monthlyDiscount = $discount * $monthRate;
    $daysRemaining = $numDays % 22;
    
    $monthsWork = floor($numDays / 22);
    $discountedMonthlyRate = $monthRate - $monthlyDiscount;
    $costDaysRamaining = $daysRemaining * $ratePerHour * 8;

    echo "\n Cost per month: " . $monthRate .
         "\n Discount per month: " . $monthlyDiscount .
         "\n Cost per month with discount: " . $discountedMonthlyRate .
         "\n Months worked: " . $monthsWork .
         "\n Days remaining: " . $daysRemaining .
         "\n Cost the days ramaining: " . $costDaysRamaining;

    return ceil($discountedMonthlyRate * $monthsWork + $costDaysRamaining);
}

echo "\nTotal cost with discount: " . priceWithMonthlyDiscount(29.654321, 220, 0.112) . "\n";

?>
