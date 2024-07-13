<?php

function totalBirdCount($birdsPerDay) {
    $totalBirds = 0;
    foreach ($birdsPerDay as $birds) {
        $totalBirds += $birds;
    }
    return $totalBirds;
}
// echo totalBirdCount([2, 5, 0, 7, 4, 1, 3, 0, 2, 5, 0, 1, 3, 1]) . "\n";

/**
 * Calculates the total number of birds seen in a specific week.
 *
 * @param array $birdsPerDay
 * @param int $week
 * @return int birds counted in the given week
 */
function birdsInWeek($birdsPerDay, $week) {
    $matriz = [];
    $semana = [];

    foreach ($birdsPerDay as $birds) {
        $semana[] = $birds;
        if (count($semana) == 7) {
            $matriz[] = $semana;
            $semana = [];
        }
    }

    $semanaEscolhida = $matriz[$week - 1];
    $somaSemanaEscolhida = array_sum($semanaEscolhida);

    return $somaSemanaEscolhida;
}

echo birdsInWeek([2, 5, 0, 7, 4, 1, 3, 0, 2, 5, 0, 1, 3, 1], 2) . "\n";

/**
 * Fixes the counting mistake by increasing the bird count
 * by one for every second day.
 *
 * @param array $birdsPerDay
 * @return array corrected bird count data
 */
function fixBirdCountLog($birdsPerDay) {
    for ($index = 0; $index < count($birdsPerDay); $index++) {
        if ($index % 2 === 0) {
            $birdsPerDay[$index] += 1;
        }
    }

    return $birdsPerDay;
}

print_r(fixBirdCountLog([2, 5, 0, 7, 4, 1]));

?>
