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
            //Exercício 1
            //int metros, cm, mm;
            //Console.WriteLine("Digite o número de metros:");
            //Console.Readkey();
            //metros = int.Parse(Console.ReadLine());
            //cm = metros * 100;
            //mm = metros * 1000;
            //Console.WriteLine("A quantidade em cm é: " + cm);
            //Console.WriteLine("A quantidade em mm é: " + mm); 
            //Console.ReadKey();

            //Exercício 2
            //int fahren1, ResInt;
            //float fahren2, ResFloat;
            //Console.WriteLine("Digite o fahrenheit int:");
            //fahren1 = int.Parse(Console.ReadLine()); 
            //Console.WriteLine("Digite o fahrenheit float:");
            //fahren2 = float.Parse(Console.ReadLine());

            //ResInt = (fahren1 - 32) * (5 / 9);
            //ResFloat = (fahren2 - 32.0f) * (5.0f / 9);
            //Console.WriteLine("resultado float" +ResFloat);
            //Console.WriteLine("resultado int" + ResFloat);

            //Exercício 3
            int altura, peso, imc;
            Console.WriteLine("Digite a sua altura em metros: ");
            altura = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o seu peso em quilogramas: ");
            peso = int.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            Console.WriteLine("Seu índice de massa corporal é: " + imc);
        }
    }
}
