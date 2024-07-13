<?php

// Task 1
function frontDoorResponse($line) {
    $firstLetter = strtoupper($line[0]);
    return $firstLetter;
}
// echo frontDoorResponse('Stands so high') . "\n";

// Task 2
function frontDoorPassword($word) {
    $firstLetter = strtoupper($word[0]);
    $remainingLetters = strtolower(substr($word, 1));
    return $firstLetter . $remainingLetters;
}
// echo frontDoorPassword('SHIRE') . "\n";

// Task 3
function backDoorResponse($line) {
    $trimmedLine = trim($line);
    return $trimmedLine[strlen($trimmedLine) - 1];
}
// echo backDoorResponse('Stands so high') . "\n";

// Task 4
function backDoorPassword($word) {
    $firstLetter = strtoupper($word[0]);
    $remainingWord = substr($word, 1);
    return $firstLetter . $remainingWord . ', please';
}

echo backDoorPassword('horse') . "\n";

?>
