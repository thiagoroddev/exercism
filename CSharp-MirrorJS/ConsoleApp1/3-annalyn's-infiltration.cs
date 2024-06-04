/*Instruções
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


using System;

public class Program3
{
    public static bool CanExecuteFastAttack(bool knightIsAwake)
    {
        // Ação 'Ataque Rápido' é possível se o cavaleiro estiver dormindo
        return !knightIsAwake;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        // Ação 'Espionar' é possível se pelo menos um dos personagens estiver acordado
        return knightIsAwake || archerIsAwake || prisonerIsAwake;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        // Ação 'Sinalizar Prisioneiro' é possível se o arqueiro e o prisioneiro estiverem acordados
        return !archerIsAwake && prisonerIsAwake;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        // Ação 'Prisioneiro Livre' é possível em duas condições:
        // 1. Se Annalyn tiver seu cachorro de estimação e o arqueiro estiver dormindo
        // 2. Se Annalyn não tiver seu cachorro de estimação, o prisioneiro estiver acordado e ambos o cavaleiro e o arqueiro estiverem dormindo
        return (petDogIsPresent && !archerIsAwake) || (!petDogIsPresent && !knightIsAwake && !archerIsAwake && prisonerIsAwake);
    }

    public static void Main(string[] args)
    {
        // Testando as funções
        bool knightIsAwake = false;
        bool archerIsAwake = true;
        bool prisonerIsAwake = false;
        bool petDogIsPresent = false;

        Console.WriteLine("Ataque Rápido: " + CanExecuteFastAttack(knightIsAwake));
        Console.WriteLine("Espionar: " + CanSpy(knightIsAwake, archerIsAwake, prisonerIsAwake));
        Console.WriteLine("Sinalizar Prisioneiro: " + CanSignalPrisoner(archerIsAwake, prisonerIsAwake));
        Console.WriteLine("Prisioneiro Livre: " + CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent));
    }
}
