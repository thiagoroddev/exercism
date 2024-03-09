"""Instruções
Neste exercício, você implementará a lógica da missão para um novo jogo de RPG que um amigo está desenvolvendo. A personagem principal do jogo é Annalyn, uma garota corajosa com um cachorro de estimação feroz e leal. Infelizmente, ocorre um desastre, pois sua melhor amiga foi sequestrada enquanto procurava frutas na floresta. Annalyn tentará encontrar e libertar sua melhor amiga, opcionalmente levando seu cachorro com ela nesta missão.

Depois de algum tempo seguindo a trilha de sua melhor amiga, ela encontra o acampamento onde sua melhor amiga está presa. Acontece que existem dois sequestradores: um cavaleiro poderoso e um arqueiro astuto.

Tendo encontrado os sequestradores, Annalyn considera quais das seguintes ações ela pode realizar:

1- Ataque rápido: um ataque rápido pode ser feito se o cavaleiro estiver dormindo, pois leva tempo para ele colocar a armadura, então ficará vulnerável.

2- Espião: o grupo pode ser espionado se pelo menos um deles estiver acordado. Caso contrário, espionar é uma perda de tempo.

3- Sinalizar prisioneiro: o prisioneiro pode ser sinalizado usando sons de pássaros se o prisioneiro estiver acordado e o arqueiro estiver dormindo, pois os arqueiros são treinados em sinalização de pássaros para que possam interceptar a mensagem.

4- Prisioneiro livre: Annalyn pode tentar entrar furtivamente no acampamento para libertar o prisioneiro. Isso é algo arriscado de se fazer e só pode ter sucesso de duas maneiras:
Se Annalyn tiver seu cachorro de estimação, ela poderá resgatar o prisioneiro se o arqueiro estiver dormindo. O cavaleiro está com medo do cachorro e o arqueiro não terá tempo de se preparar antes que Annalyn e o prisioneiro possam escapar.
Se Annalyn não tem seu cachorro, ela e o prisioneiro devem ser muito sorrateiros! Annalyn pode libertar o prisioneiro se o prisioneiro estiver acordado e o cavaleiro e o arqueiro estiverem dormindo, mas se o prisioneiro estiver dormindo, eles não poderão ser resgatados: o prisioneiro ficaria surpreso com a aparição repentina de Annalyn e acordaria o cavaleiro e o arqueiro.
=========================================================
Você tem quatro tarefas: implementar a lógica para determinar se as ações acima estão disponíveis com base no estado dos três personagens encontrados na floresta e se o cachorro de estimação de Annalyn está presente ou não.

1. Verifique se a ação ‘Ataque Rápido’ é possível
Implemente uma função chamada canExecuteFastAttack que assume um valor booleano que indica se o cavaleiro está acordado. Esta função retorna verdadeiro se a ação 'Ataque Rápido' estiver disponível com base no estado do personagem. Caso contrário, retorna falso:

const cavaleiroIsAwake = verdadeiro;
canExecuteFastAttack(knightIsAwake);
// => falso

2. Verifique se a ação ‘Espionar’ é possível
Implemente uma função chamada canSpy que assume três valores booleanos, indicando se o cavaleiro, o arqueiro e o prisioneiro, respectivamente, estão acordados. A função retorna verdadeiro se a ação 'Espião' estiver disponível com base no estado dos personagens. Caso contrário, retorna falso:

const cavaleiroIsAwake = falso;
const archerIsAwake = verdadeiro;
const prisioneiroIsAwake = falso;
canSpy(cavaleiroIsAwake, arqueiroIsAwake, prisioneiroIsAwake);
// => verdadeiro

3. Verifique se a ação 'Sinalizar Prisioneiro' é possível
Implemente uma função chamada canSignalPrisoner que assume dois valores booleanos, indicando se o arqueiro e o prisioneiro, respectivamente, estão acordados. A função retorna verdadeiro se a ação 'Signal Prisoner' estiver disponível com base no estado dos personagens. Caso contrário, retorna falso:

const archerIsAwake = falso;
const prisioneiroIsAwake = verdadeiro;
canSignalPrisoner(arqueiroIsAwake, prisioneiroIsAwake);
// => verdadeiro
4. Verifique se a ação ‘Prisioneiro Livre’ é possível
Implemente uma função chamada canFreePrisoner que aceita quatro valores booleanos. Os três primeiros parâmetros indicam se o cavaleiro, o arqueiro e o prisioneiro, respectivamente, estão acordados. O último parâmetro indica se o cachorro de estimação de Annalyn está presente. A função retorna verdadeiro se a ação 'Prisioneiro Livre' estiver disponível com base no estado dos personagens e na presença do cachorro de estimação de Annalyn. Caso contrário, retorna falso:

const cavaleiroIsAwake = falso;
const archerIsAwake = verdadeiro;
const prisioneiroIsAwake = falso;
const petDogIsPresent = falso;
canFreePrisoner(cavaleiroIsAwake, arqueiroIsAwake, prisioneiroIsAwake, petDogIsPresent);
// => falso*/ 

//================================================================================

// @ts-verificar
//
// ☝🏽 A linha acima habilita a verificação de tipo para este arquivo. Vários IDEs interpretam
// a diretiva @ts-check. Isso lhe dará um preenchimento automático útil na web
// e IDEs suportados ao implementar este exercício. Você não precisa
// entender tipos, JSDoc ou TypeScript para completar este JavaScript
// exercício, e pode ignorar completamente este bloco de comentários e diretiva.

// 👋🏽 Olá de novo!
//
// Um rápido lembrete sobre esboços de exercícios:
//
// 💡 Você pode limpar completamente qualquer stub antes de começar. Muitas vezes
// recomendamos usar o stub, pois eles já estão configurados corretamente para
//trabalhe com os testes, que você pode encontrar em ./annalyns-infiltration.spec.js.
//
// 💡 Você não precisa escrever blocos de comentários JSDoc; não é esperado
// em JavaScript idiomático, mas algumas empresas e guias de estilo os aplicam.
//
// Agora ajude Annalyn a libertar sua melhor amiga!

const knightIsAwake = true;
const archerIsAwake = false;
const prisonerIsAwake = false;
const petDogIsPresent = false;

/*
  * O ataque rápido está disponível quando o cavaleiro está dormindo
  *
  * @param {boolean} knightIsAwake
  *
  * @return {boolean} Se você pode ou não executar um ataque rápido.
  */
"""

function canExecuteFastAttack(knightIsAwake) {
  if (knightIsAwake === true) {
    return false
    console.log('False')
  } else {
    return true
    console.log('True')
  }
}
console.log(canExecuteFastAttack())

"""
  * Um espião útil captura informações, o que não será possível fazer se todos estiverem dormindo.
  *
  * @param {boolean} knightIsAwake
  * @param {boolean} arqueiroIsAwake
  * @param {boolean} prisioneiroIsAwake
  *
  * @returns {boolean} Se você pode ou não espionar alguém.
"""

def can_spy(knight_is_awake, archer_is_awake, prisoner_is_awake):
    if knight_is_awake or archer_is_awake or prisoner_is_awake:
        print('True')
        return True
    else:
        print('False')
        return False

print(can_spy())

"""
  * Você será pego pelo arqueiro se sinalizar enquanto ele estiver acordado.
  *
  * @param {boolean} arqueiroIsAwake
  * @param {boolean} prisioneiroIsAwake
  *
  * @returns {boolean} Se você pode ou não enviar um sinal ao prisioneiro.
"""

def can_signal_prisoner(archer_is_awake, prisoner_is_awake):
    if not archer_is_awake and prisoner_is_awake:
        print('True')
        return True
    else:
        print('False')
        return False

print(can_signal_prisoner())


"""
  * A etapa final do plano: libertar a melhor amiga de Annalyn.
  *
  * @param {boolean} knightIsAwake
  * @param {boolean} arqueiroIsAwake
  * @param {boolean} prisioneiroIsAwake
  * @param {boolean} petDogIsPresent
  *
  * @returns {boolean} Se você pode ou não libertar o amigo de Annalyn.
"""

def can_free_prisoner(knight_is_awake, archer_is_awake, prisoner_is_awake, pet_dog_is_present):
    if pet_dog_is_present:
        if not archer_is_awake and not knight_is_awake:
            print('True')
            return True
        elif not archer_is_awake and knight_is_awake:
            return True
        else:
            print('False')
            return False
    else:
        if prisoner_is_awake:
            if not archer_is_awake and not knight_is_awake:
                print('True')
                return True
            else:
                print('False')
                return False
        else:
            print('False')
            return False

print(can_free_prisoner())


# Melhoria ChatGPT: ---------------------------------------------------------

def can_execute_fast_attack(knight_is_awake):
    return not knight_is_awake

print(can_execute_fast_attack())

def can_spy(knight_is_awake, archer_is_awake, prisoner_is_awake):
    return knight_is_awake or archer_is_awake or prisoner_is_awake

print(can_spy())

def can_signal_prisoner(archer_is_awake, prisoner_is_awake):
    return not archer_is_awake and prisoner_is_awake

print(can_signal_prisoner())

def can_free_prisoner(knight_is_awake, archer_is_awake, prisoner_is_awake, pet_dog_is_present):
    if pet_dog_is_present:
        return not archer_is_awake and (not knight_is_awake or knight_is_awake)
    else:
        return prisoner_is_awake and not archer_is_awake and not knight_is_awake

print(can_free_prisoner())

