<?php

function timeToMixJuice($name) {
    switch ($name) {
        case 'Pure Strawberry Joy':
            return 0.5;

        case 'Energizer':
        case 'Green Garden':
            return 1.5;

        case 'Tropical Island':
            return 3;
        
        case 'All or Nothing':
            return 5;

        default:
            return 2.5;
    }
}

// Exemplo de uso:
// echo timeToMixJuice('Berries & Lime') . "\n";

?>

<?php

function limesToCut($wedgesNeeded, $limes) {
    $accumulator = 0;
    $wedgesLimes = 0;
    
    while ($wedgesLimes < $wedgesNeeded && $accumulator < count($limes)) {
        switch ($limes[$accumulator]) {
            case 'small':
                $wedgesLimes += 6;
                break;

            case 'medium':
                $wedgesLimes += 8;
                break;

            case 'large':
                $wedgesLimes += 10;
                break;
        }
        $accumulator++;
    }
    return $accumulator;
}

// Exemplo de uso:
// echo limesToCut(25, ['small', 'small', 'large', 'medium', 'small']) . "\n";

?>


<?php

function remainingOrders($timeLeft, $orders) {
    $time = 0;
    $juicesMissings = $orders;
    $index = 0;

    while ($index < count($juicesMissings) && $time < $timeLeft) {
        $suco = $juicesMissings[$index];

        switch ($suco) {
            case 'Pure Strawberry Joy':
                $time += 0.5;
                break;

            case 'Energizer':
            case 'Green Garden':
                $time += 1.5;
                break;

            case 'Tropical Island':
                $time += 3;
                break;

            case 'All or Nothing':
                $time += 5;
                break;

            default:
                $time += 2.5;
                break;
        }

        $index++;
    }

    return array_slice($juicesMissings, $index);
}

// Exemplo de uso:
// $orders = ['Pure Strawberry Joy', 'Energizer', 'Tropical Island', 'Green Garden'];
// $remaining = remainingOrders(5, $orders);
// print_r($remaining);

?>
