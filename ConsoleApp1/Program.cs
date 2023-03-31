using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1)É  possível  atribuir  uma  variável  do  tipo  int  para  uma  variável  do  tipo  float,  assim  como,  é possível realizar a atribuição inversa. A respeito dessa afirmativa, diga se ela é verdadeira ou falsa.
         //É falsa pois float tem casas decimais e o int não, então não tem como mudar float para o int.
         //ex:
         //int nI = 10;
         //float nF = nI;
         //Console.WriteLine(nF); resultado 10

            //float nF2 = 20.5f;
            //int nI2 = (int)nF2;
            //Console.WriteLine(nI2); resultado 20

            //2)Explique  a  diferença  entre  o  Console.ReadLine()  e  o  Console.Read().  Qual  é  o  tipo  de  dado que eles retornam? Esse tipo é o mesmo sempre?
            //O Console.ReadLine() ele pega o dados de uma linha já o Console.Read() é só uma letra. Não as vezes o Console.Read() ou Console.ReadLine() pode pegar outros tipos de dados como número.

            //3)Quando é necessário realizar a leitura de um valor a partir do Console para uma variável de tipo int, float ou double, que tipo de cuidado precisamos tomar?
            //É necessario tomar cuidado ao realizar a leitura de um valor quando a variavel é invalida para o tipo variavel

            //4)Dado o programa abaixo, ao executá-lo qual seria seu propósito/objetivo?Se você entrar com o número 8, qual será a saída? E se entrar com 27? E se entrar com 28?
            //Descobrir se o valor é par e menor que 10. Se você entrar com o número 8 será "mensagem 2". Se entrar com 27 será "mensagem 2". Se entrar com 28 será "mensagem 1".

            //5)A Equação do Movimento Retilíneo Uniforme é uma importante fórmula da física que pode ser calculada informando se algumas variáveis. Pesquise sobre a fórmula e crie um programa capaz de calcular a posição final de um objeto qualquer.
            //Console.Write("Digite a posição inicial (S0): ");
            //double s0 = double.Parse(Console.ReadLine());

            //Console.Write("Digite a velocidade (v): ");
            //double v = double.Parse(Console.ReadLine());

            //Console.Write("Digite o tempo (t): ");
            //double t = double.Parse(Console.ReadLine());

            //double s = s0 + v * t;

            //Console.WriteLine("A posição final do objeto é: " + s);

            //6)Crie  um  programa  que  seja  capaz  de  analisar  se  um  dado  número  inteiro  gerado  pelo computador é:
            //Random R = new Random();
            //int numero = R.Next(1, 1000);

            //if (numero % 3 == 0 && numero % 5 == 0 && numero % 10 == 0)
            //{
            //    Console.WriteLine("O número é divisível por 3, 5 e 10.", numero);
            //}
            //else if (numero % 3 == 0 && numero % 5 == 0)
            //{
            //    Console.WriteLine("O número é divisível por 3 e 5.", numero);
            //}
            //else if (numero % 3 == 0)
            //{
            //    Console.WriteLine("O número é somente divisível por 3.", numero);
            //}
            //else if (numero % 5 == 0)
            //{
            //    Console.WriteLine("O número é somente divisível por 5.", numero);
            //}
            //else
            //{
            //    Console.WriteLine("O número não é divisível por 3, 5 e 10, nem por 3 e 5, nem somente por 3, nem somente por 5.", numero);
            //}

            //7)Crie um programa que seja capaz de calcular o tempo gasto por um aluno da escola IFlândia, 
            //para realizaro trajeto entre sua casa e seu local de estudo.
            //Considere que cada parte do trajeto terá um gasto de tempo médio e as frações de distância devem
            //ser consideradas proporcionalmente. O aluno informará apenas qual é o km onde a sua casa está localizada.
            //A escola fica sempre no km 100.Qual será o tempo necessário para o aluno chegar ao seu destino?
            

            //Console.Write("Informe o km onde a sua casa está localizada: ");
            //int kmCasa = int.Parse(Console.ReadLine());

            //double distanciaEscola = 100 - kmCasa;
            //double tempoCaminhando = distanciaEscola * 0.1;
            //double tempoCorrendo = distanciaEscola * 0.05;
            //double tempoTotal = tempoCaminhando + tempoCorrendo;

            //Console.WriteLine("Distância da escola: ", distanciaEscola, "km");
            //Console.WriteLine("Tempo caminhando: ", tempoCaminhando, "horas");
            //Console.WriteLine("Tempo correndo: ", tempoCorrendo, "horas");
            //Console.WriteLine("Tempo total: ", tempoTotal, "horas");

            //8)A empresaGatos Fofos SA.vende diversas marcas de rações para gatos.
            //Crie um programa que seja  capaz  de  auxiliar  o  departamento  financeiro
            //da  empresa  no  cálculo  do  lucro  líquido  e imposto  devido  para  a  venda
            //de  cada  marca.  O  usuário  do  sistema deverá  entrar  com  a quantidade de unidades
            //de um determinado produto e a marca. A saída será o valor total da compra e
            //o lucro líquido((preço –custo) –imposto).Utilize a estrutura switch. 


            //Console.Write("Digite a quantidade de unidades: ");
            //int quantidade = int.Parse(Console.ReadLine());

            //Console.Write("Digite a marca (ROYAL, WISKAS, GOLDEN, NUTRIEN, SPECIALCAT, MARBA ou GATUS): ");
            //string marca = Console.ReadLine().ToUpper();

            //double preco, custo, imposto, valorTotal, lucroLiquido;

            //switch (marca)
            //{
            //case "ROYAL":
            //    preco = 129.50;
            //    custo = 77.5;
            //    imposto = 33;
            //    break;
            //case "WISKAS":
            //    preco = 182.78;
            //    custo = 89.72;
            //    imposto = 7.5;
            //    break;
            //case "GOLDEN":
            //    preco = 159.46;
            //    custo = 71.72;
            //    imposto = 2.5;
            //    break;
            //case "NUTRIEN":
            //    preco = 144.80;
            //    custo = 88.9;
            //    imposto = 25;
            //    break;
            //case "SPECIALCAT":
            //    preco = 205.40;
            //    custo = 83.24;
            //    imposto = 22;
            //    break;
            //case "MARBA":
            //    preco = 125.10;
            //    custo = 90.4;
            //    imposto = 17.9;
            //    break;
            //case "GATUS":
            //    preco = 133.99;
            //    custo = 94.6;
            //    imposto = 20;
            //    break;
            //default:
            //    Console.WriteLine("Marca inválida!");
            //    return;
            //}

            //valorTotal = quantidade * preco;
            //lucroLiquido = (preco - (preco * custo / 100)) - ((preco - (preco * custo / 100)) * imposto / 100);

            //Console.WriteLine("Valor total da compra: R$", valorTotal);
            //Console.WriteLine("Lucro líquido: R$", lucroLiquido);
            
            
    }
}
