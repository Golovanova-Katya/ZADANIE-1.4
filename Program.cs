using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Задание_1._4
{
    class Program
    {
        static void rezultat(string str)
        {
        }
        static void Main(string[] args)
        {
            Console.Write("Введи число буквами русского алфавита: ");
            string[] massiv = Console.ReadLine().Split(' ');
            int chislo = massiv.Count();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < chislo; i++)
            {
                switch (massiv[i])
                {
                    case "один": sb.Append("1"); break;
                    case "два": sb.Append("2"); break;
                    case "три": sb.Append("3"); break;
                    case "четыре": sb.Append("4"); break;
                    case "пять": sb.Append("5"); break;
                    case "шесть": sb.Append("6"); break;
                    case "семь": sb.Append("7"); break;
                    case "восемь": sb.Append("8"); break;
                    case "девять": sb.Append("9"); break;
                    case "ноль": sb.Append("0"); break;
                    case "десять": sb.Append("10"); break;
                    case "одиннадцать": sb.Append("11"); break;
                    case "двенадцать": sb.Append("12"); break;
                    case "тринадцать": sb.Append("13"); break;
                    case "четырнадцать": sb.Append("14"); break;
                    case "пятьнадцать": sb.Append("15"); break;
                    case "шестьнадцать": sb.Append("16"); break;
                    case "семьнадцать": sb.Append("17"); break;
                    case "восемнадцать": sb.Append("18"); break;
                    case "девятьнадцать": sb.Append("19"); break;

                    case "двадцать":
                        sb.Append("2");
                        if (i + 1 >= chislo) sb.Append("0");
                        break;
                    case "тридцать":
                        sb.Append("3");
                        if (i + 1 >= chislo) sb.Append("0");
                        break;
                    case "сорок":
                        sb.Append("4");
                        if (i + 1 >= chislo) sb.Append("0");
                        break;
                    case "пятьдесят":
                        sb.Append("5");
                        if (i + 1 >= chislo) sb.Append("0");
                        break;
                    case "шестьдесят":
                        sb.Append("6");
                        if (i + 1 >= chislo) sb.Append("0");
                        break;
                    case "семьдесят":
                        sb.Append("7");
                        if (i + 1 >= chislo) sb.Append("0");
                        break;
                    case "восемьдесят":
                        sb.Append("8");
                        if (i + 1 >= chislo) sb.Append("0");
                        break;
                    case "девяносто":
                        sb.Append("9");
                        if (i + 1 >= chislo) sb.Append("0");
                        break;
                    case "сто":
                        sb.Append("1");
                        if (i + 1 >= chislo) sb.Append("00");
                        else if (i + 2 >= chislo) rezultat(massiv[i + 1]);
                        break;
                    case "двести":
                        sb.Append("2");
                        if (i + 1 >= chislo) sb.Append("00");
                        else if (i + 2 >= chislo) rezultat(massiv[i + 1]);
                        break;
                    case "триста":
                        sb.Append("3");
                        if (i + 1 >= chislo) sb.Append("00");
                        else if (i + 2 >= chislo) rezultat(massiv[i + 1]);
                        break;
                    case "четыреста":
                        sb.Append("4");
                        if (i + 1 >= chislo) sb.Append("00");
                        else if (i + 2 >= chislo) rezultat(massiv[i + 1]);
                        break;
                    case "пятьсот":
                        sb.Append("5");
                        if (i + 1 >= chislo) sb.Append("00");
                        else if (i + 2 >= chislo) rezultat(massiv[i + 1]);
                        break;
                    case "шестьсот":
                        sb.Append("6");
                        if (i + 1 >= chislo) sb.Append("00");
                        else if (i + 2 >= chislo) rezultat(massiv[i + 1]);
                        break;
                    case "семьсот":
                        sb.Append("7");
                        if (i + 1 >= chislo) sb.Append("00");
                        else if (i + 2 >= chislo) rezultat(massiv[i + 1]);
                        break;
                    case "восемьсот":
                        sb.Append("8");
                        if (i + 1 >= chislo) sb.Append("00");
                        else if (i + 2 >= chislo) rezultat(massiv[i + 1]);
                        break;
                    case "девятьсот":
                        sb.Append("9");
                        if (i + 1 >= chislo) sb.Append("00");
                        else if (i + 2 >= chislo) rezultat(massiv[i + 1]);
                        break;

                }
            }
            Console.WriteLine(sb);

            Console.ReadKey();
        }
    }
}

