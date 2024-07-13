<?php

function createVisitor($name, $age, $ticketId) {
    return [
        'name' => $name,
        'age' => $age,
        'ticketId' => $ticketId
    ];
}

// Exemplo de uso:
// print_r(createVisitor('Verena Nardi', 45, 'H32AZ123'));

?>

<?php

function revokeTicket($visitor) {
    $visitor['ticketId'] = null;
    return $visitor;
}

// Exemplo de uso:
// $visitor = [
//     'name' => 'Verena Nardi',
//     'age' => 45,
//     'ticketId' => 'H32AZ123',
// ];
// print_r(revokeTicket($visitor));

?>

<?php

function ticketStatus($tickets, $ticketId) {
    foreach ($tickets as $key => $value) {
        if ($key === $ticketId) {
            if ($value === null) {
                return 'not sold';
            } else {
                return "sold to $value";
            }
        }
    }
    return 'unknown ticket id';
}

// Exemplo de uso:
// $tickets = [
//     '0H2AZ123' => null,
//     '23LA9T41' => 'Verena Nardi',
// ];
// echo ticketStatus($tickets, '0H2AZ123') . "\n";
// echo ticketStatus($tickets, '23LA9T41') . "\n";

?>

<?php

function simpleTicketStatus($tickets, $ticketId) {
    if (isset($tickets[$ticketId]) && $tickets[$ticketId] !== null) {
        return $tickets[$ticketId];
    }
    return 'invalid ticket';
}

// Exemplo de uso:
// $tickets = [
//     '0H2AZ123' => null,
//     '23LA9T41' => 'Verena Nardi',
// ];
// echo simpleTicketStatus($tickets, '0H2AZ123') . "\n";

?>

<?php

function gtcVersion($visitor) {
    return isset($visitor['gtc']['version']) ? $visitor['gtc']['version'] : null;
}

// Exemplo de uso:
// $visitorNew = [
//     'name' => 'Verena Nardi',
//     'age' => 45,
//     'ticketId' => 'H32AZ123',
//     'gtc' => [
//         'signed' => true,
//         'version' => '2.1',
//     ]
// ];
// echo gtcVersion($visitorNew) . "\n";

?>



