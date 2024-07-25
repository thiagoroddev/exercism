<?php
// Task 1
function getFirstCard($deck)
{
    $one = array_shift($deck);
    echo $one;
    return $one;
}

// Task 2
function getSecondCard($deck)
{
    array_shift($deck); // Remove o primeiro elemento
    $two = array_shift($deck);
    echo $two;
    return $two;
}

// Task 3
function swapTopTwoCards($deck)
{
    $one = array_shift($deck);
    $two = array_shift($deck);
    $invert = array_merge([$two, $one], $deck);
    echo implode(', ', $invert);
    return $invert;
}

// Task 4
function discardTopCard($deck)
{
    $one = array_shift($deck);
    $twoPiles = [$one, $deck];
    echo implode(', ', $twoPiles);
    return $twoPiles;
}

// Task 5
function insertFaceCards($deck)
{
    $one = array_shift($deck);
    $newDeck = array_merge([$one, 'jack', 'queen', 'king'], $deck);
    echo implode(', ', $newDeck);
    return $newDeck;
}
