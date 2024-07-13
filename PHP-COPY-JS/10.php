<?php

function createScoreBoard() {
    return ['The Best Ever' => 1000000];
}

// Exemplo de uso:
// print_r(createScoreBoard());

?>

<?php

function addPlayer($scoreBoard, $player, $score) {
    $scoreBoard[$player] = $score;
    return $scoreBoard;
}

// Exemplo de uso:
// $scoreBoard = ['Dave Thomas' => 2];
// print_r(addPlayer($scoreBoard, 'José Valim', 4));

?>

<?php

function removePlayer($scoreBoard, $player) {
    unset($scoreBoard[$player]);
    return $scoreBoard;
}

// Exemplo de uso:
// $scoreBoard = ['Dave Thomas' => 0];
// print_r(removePlayer($scoreBoard, 'Dave Thomas'));

?>

<?php

function updateScore($scoreBoard, $player, $points) {
    if (isset($scoreBoard[$player])) {
        $scoreBoard[$player] += $points;
    } else {
        $scoreBoard[$player] = $points;
    }
    return $scoreBoard;
}

// Exemplo de uso:
// $scoreBoard = ['Freyja Ćirić' => 12771008];
// print_r(updateScore($scoreBoard, 'Freyja Ćirić', 73));

?>

<?php

function applyMondayBonus($scoreBoard) {
    foreach ($scoreBoard as $player => $score) {
        $scoreBoard[$player] += 100;
    }
    return $scoreBoard;
}

// Exemplo de uso:
// $scoreBoard = [
//     'Dave Thomas' => 44,
//     'Freyja Ćirić' => 539,
//     'José Valim' => 265,
// ];
// print_r(applyMondayBonus($scoreBoard));

?>

<?php

function normalizeScore($params) {
    $score = $params['score'];
    $normalizeFunction = $params['normalizeFunction'];

    $normalizedScore = $normalizeFunction($score);

    return $normalizedScore;
}

// Exemplo de uso:
// $params = ['score' => 400, 'normalizeFunction' => 'normalize'];
// print_r(normalizeScore($params));

// Função de normalização exemplo
function normalize($score) {
    return 2 * $score + 10;
}

?>




