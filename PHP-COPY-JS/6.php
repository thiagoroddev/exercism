<?php

function getItem($cards, $position) {
    return $cards[$position];
}
echo getItem([1, 2, 4, 1], 2) . "\n";

/**
 * Exchange card with replacementCard at the 0-based position
 *
 * @param array $cards
 * @param int $position
 * @param int $replacementCard
 *
 * @return array the cards with the change applied
 */
function setItem($cards, $position, $replacementCard) {
    $cards[$position] = $replacementCard;
    return $cards;
    /* Solução do Bard:
    
    // Create a copy of the cards array to avoid modifying the original
    $updatedCards = $cards;

    // Perform the sleight of hand: replace the card at the specified position
    $updatedCards[$position] = $replacementCard;

    // Return the adjusted stack
    return $updatedCards;
    */
}
print_r(setItem([1, 2, 4, 1], 2, 6));
echo "\n";

/**
 * Insert newCard at the end of the cards array
 *
 * @param array $cards
 * @param int $newCard
 *
 * @return array the cards with the newCard applied
 */
function insertItemAtTop($cards, $newCard) {
    $cards[] = $newCard;
    return $cards;
}
print_r(insertItemAtTop([5, 9, 7, 1], 8));
echo "\n";

/**
 * Remove the card at the 0-based position
 *
 * @param array $cards
 * @param int $position
 *
 * @return array the cards without the removed card
 */
function removeItem($cards, $position) {
    array_splice($cards, $position, 1);
    return $cards;
}
print_r(removeItem([3, 2, 6, 4, 8], 2));
echo "\n";

/**
 * Remove card from the end of the cards array
 *
 * @param array $cards
 *
 * @return array the cards without the removed card
 */
function removeItemFromTop($cards) {
    array_pop($cards);
    return $cards;
}
print_r(removeItemFromTop([3, 2, 6, 4, 8]));
echo "\n";

/**
 * Insert newCard at beginning of the cards array
 *
 * @param array $cards
 * @param int $newCard
 *
 * @return array the cards including the new card
 */
function insertItemAtBottom($cards, $newCard) {
    array_unshift($cards, $newCard);
    return $cards;
}
print_r(insertItemAtBottom([5, 9, 7, 1], 8));
echo "\n";

/**
 * Remove card from the beginning of the cards
 *
 * @param array $cards
 *
 * @return array the cards without the removed card
 */
function removeItemAtBottom($cards) {
    array_shift($cards);
    return $cards;
}
print_r(removeItemAtBottom([8, 5, 9, 7, 1]));
echo "\n";

/**
 * Compare the number of cards with the given stackSize
 *
 * @param array $cards
 * @param int $stackSize
 *
 * @return bool true if there are exactly stackSize number of cards, false otherwise
 */
function checkSizeOfStack($cards, $stackSize) {
    return count($cards) == $stackSize;
}
var_export(checkSizeOfStack([3, 2, 6, 4, 8], 4));
echo "\n";

?>
