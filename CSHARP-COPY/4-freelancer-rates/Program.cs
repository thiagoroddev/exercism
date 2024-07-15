/*Instructions
In this exercise you will be writing code to help a freelancer communicate with their clients about the prices of certain projects. You will write a few utility functions to quickly calculate the costs for the clients.

1. Calculate the day rate given an hourly rate
A client contacts the freelancer to enquire about their rates. The freelancer explains that they work 8 hours a day. However, the freelancer knows only their hourly rates for the project. Help them estimate a day rate given an hourly rate.

dayRate(89);
// => 712
The day rate does not need to be rounded or changed to a "fixed" precision.

2. Calculate the number of workdays given a fixed budget
Another day, a project manager offers the freelancer to work on a project with a fixed budget. Given the fixed budget and the freelancer's hourly rate, help them calculate the number of days they would work until the budget is exhausted. The result must be rounded down to the nearest whole number.

daysInBudget(20000, 89);
// => 28
3. Calculate the discounted rate for large projects
Often, the freelancer's clients hire them for projects spanning over multiple months. In these cases, the freelancer decides to offer a discount for every full month, and the remaining days are billed at day rate. Every month has 22 billable days. Help them estimate their cost for such projects, given an hourly rate, the number of days the project spans, and a monthly discount rate. The discount is always passed as a number, where 42% becomes 0.42. The result must be rounded up to the nearest whole number.

priceWithMonthlyDiscount(89, 230, 0.42);
// => 97972 */


/*Instruções
Neste exercício você escreverá código para ajudar um freelancer a se comunicar com seus clientes sobre os preços de determinados projetos. Você escreverá algumas funções utilitárias para calcular rapidamente os custos para os clientes.

1. Calcule a taxa diária dada uma taxa horária
Um cliente entra em contato com o freelancer para perguntar sobre suas taxas. O freelancer explica que trabalham 8 horas por dia. Porém, o freelancer conhece apenas o valor da hora do projeto. Ajude-os a estimar uma taxa diária dada uma taxa horária.

taxadiária(89);
// => 712
A taxa diária não precisa ser arredondada ou alterada para uma precisão “fixa”.

2. Calcule o número de dias úteis com um orçamento fixo
Outro dia, um gerente de projeto oferece ao freelancer para trabalhar em um projeto com orçamento fixo. Dado o orçamento fixo e a taxa horária do freelancer, ajude-os a calcular o número de dias que trabalhariam até que o orçamento se esgotasse. O resultado deve ser arredondado para o número inteiro mais próximo.

diasInBudget(20000, 89);
// => 28
3. Calcule a taxa de desconto para grandes projetos
Freqüentemente, os clientes do freelancer os contratam para projetos que duram vários meses. Nestes casos, o freelancer decide oferecer um desconto para cada mês completo, e os dias restantes são cobrados à diária. Cada mês tem 22 dias faturáveis. Ajude-os a estimar o custo desses projetos, considerando uma taxa horária, o número de dias que o projeto dura e uma taxa de desconto mensal. O desconto é sempre passado como um número, onde 42% vira 0,42. O resultado deve ser arredondado para o número inteiro mais próximo.

preçoComDescontoMensal(89, 230, 0,42);
// => 97972*/

using System;

public class Program
{
    // 1. Calcula a taxa diária dada uma taxa horária
    public static int DayRate(int ratePerHour)
    {
        return ratePerHour * 8;
    }

    // 2. Calcula o número de dias úteis com um orçamento fixo
    public static int DaysInBudget(int budget, int ratePerHour)
    {
        return budget / (ratePerHour * 8);
    }

    // 3. Calcula a taxa de desconto para grandes projetos
    public static int PriceWithMonthlyDiscount(int ratePerHour, int numDays, double discount)
    {
        int monthRate = ratePerHour * 8 * 22;
        int monthlyDiscount = (int)(discount * monthRate);
        int daysRemaining = numDays % 22;
        int monthsWork = numDays / 22;
        int discountedMonthlyRate = monthRate - monthlyDiscount;
        int costDaysRemaining = daysRemaining * ratePerHour * 8;
        return (discountedMonthlyRate * monthsWork) + costDaysRemaining;
    }

    public static void Main(string[] args)
    {
        // Testando as funções
        int ratePerHour = 29;
        int budget = 20000;
        int numDays = 230;
        double discount = 0.42;

        Console.WriteLine("Rate per day worked: " + DayRate(ratePerHour));
        Console.WriteLine("Days working: " + DaysInBudget(budget, ratePerHour));
        Console.WriteLine("Total cost with discount: " + PriceWithMonthlyDiscount(ratePerHour, numDays, discount));
    }
}
