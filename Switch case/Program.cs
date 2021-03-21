using System;

namespace Switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            string dia;

            switch(x)// SE O VALOR QUE EU DIGITAR FOR IGUAL A 1, VAI SER SEGUNDA, SE FOR IGUAL A 2 TERCA
            {
                case 1:
                    dia = "Segunda";
                    break;
                case 2:
                    dia = "Terça";
                    break;
                case 3:
                    dia = "Quarta";
                    break;
                case 4:
                    dia = "Quinta";
                    break;
                case 5:
                    dia = "Sexta";
                    break;
                case 6:
                    dia = "Sabado";
                    break;
                case 7:
                    dia = "Domingo";
                    break;

                default:
                    dia = "Valor invalido";//SE NAO FOR NENHUM DOS CASOS ACIMA, ENTAO VAI EXECUTAR VALOR INVALIDO
                    break;

            }

            Console.WriteLine("Dia: " + dia);
            Console.ReadKey();

        }
    }
}
