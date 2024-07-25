# Tarefa 1
# Elyse irá invocar a primeira carta do baralho sem usar array[index] ou .shift(). É como mágica.
def get_first_card(deck):
    one, *rest = deck
    print(one)
    return one

get_first_card([1, 2, 3, 5, 8])

# Tarefa 2
# Elyse realiza um truque de mão e invoca a segunda carta do baralho sem usar array[index].
def get_second_card(deck):
    one, two, *rest = deck
    print(two)
    return two

get_second_card([3, 2, 10, 6, 7])

# Tarefa 3
# Elyse fará as duas primeiras cartas do baralho trocarem de lugar. Ela não precisa chamar uma única função.
def swap_top_two_cards(deck):
    one, two, *rest = deck
    invert = [two, one, *rest]
    print(invert)
    return invert

swap_top_two_cards([10, 7, 3, 8, 5])

# Tarefa 4
# Elyse separará o baralho em dois montes. O primeiro monte conterá apenas a carta do topo do baralho original, enquanto o segundo monte conterá todas as outras cartas.
def discard_top_card(deck):
    one, *rest = deck
    two_piles = [one, rest]
    print(two_piles)
    return two_piles

discard_top_card([2, 5, 4, 9, 3])

# Tarefa 5
# Elyse irá inserir um conjunto de cartas de figuras (ou seja, valete, dama e rei) em seu baralho de forma que elas se tornem a segunda, terceira e quarta cartas, respectivamente.
def insert_face_cards(deck):
    one, *rest = deck
    new_deck = [one, "jack", "queen", "king", *rest]
    print(new_deck)
    return new_deck

insert_face_cards([5, 4, 7, 10])