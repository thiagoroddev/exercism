
#Task 1
def cooking_status(status):
    if status is None or status == "":
        print("You forgot to set the timer.")
        return "You forgot to set the timer."
    elif status == 0:
        print("Lasagna is done.")
        return "Lasagna is done."
    else:
        print("Not done, please wait.")
        return "Not done, please wait."

cooking_status("")

#Task 2
def preparation_time(layers, average=2):
    contador = len(layers)
    print(contador * average)
    return contador * average

preparation_time(["sauce", "noodles", "sauce", "meat", "mozzarella", "noodles"], 3)

#Task 3
def quantities(layers):
    contador_noodles = 0
    contador_sauce = 0
    for layer in layers:
        if layer == "noodles":
            contador_noodles += 1
        elif layer == "sauce":
            contador_sauce += 1

    print({"noodles": contador_noodles * 50, "sauce": contador_sauce * 0.2})
    return {"noodles": contador_noodles * 50, "sauce": contador_sauce * 0.2}

quantities(["sauce", "noodles", "sauce", "meat", "mozzarella", "noodles"])

#Task 4

friends_list = ["noodles", "sauce", "mozzarella", "kampot pepper"]
my_list = ["noodles", "meat", "sauce", "mozzarella"]

def add_secret_ingredient(friends_list, my_list):
    last_ingredient = friends_list[-1]
    my_list.append(last_ingredient)
    print(my_list)

add_secret_ingredient(friends_list, my_list)


#Task 5
recipe = {
    "noodles": 200,
    "sauce": 0.5,
    "mozzarella": 1,
    "meat": 100,
}

def scale_recipe(recipe, portions):
    recipe_for_one = {ingredient: amount / 2 for ingredient, amount in recipe.items()}
    print(recipe_for_one)

    recipe_current = {ingredient: amount * portions for ingredient, amount in recipe_for_one.items()}
    print(recipe_current)

scale_recipe(recipe, 4)
