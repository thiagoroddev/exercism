def two_sum(array1, array2):
    soma_um = ""
    soma_dois = ""

    for element in array1:
        soma_um += str(element)

    for element in array2:
        soma_dois += str(element)

    soma_total = int(soma_um) + int(soma_dois)
    print(soma_total)
    return soma_total

two_sum([1, 2, 3], [0, 7])

# Task 2

def lucky_number(value):
    valor_original_string = str(value)
    valor_invertido = valor_original_string[::-1]

    print(valor_invertido)
    print(valor_original_string)

    if valor_original_string == valor_invertido:
        print("True")
        return True
    else:
        print("False")
        return False

lucky_number(524425)

# Task 3

def error_message(input):
    if input is None or input == "" or str(input).strip() == "":
        print("Required field")
        return "Required field"

    try:
        parsed_number = float(input)
        if parsed_number == 0:
            print("Must be a number besides 0")
            return "Must be a number besides 0"
    except ValueError:
        print("Must be a number")
        return "Must be a number"

    print("Empty")
    return ""

error_message(None)
