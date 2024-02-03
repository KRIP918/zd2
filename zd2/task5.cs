using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd2;

internal class task5
{
    public static void solution()
    {
        int a = Convert.ToInt32(Console.ReadLine());

        switch (a)
        {
            case 1:
                Console.WriteLine("Сложение");
                break;
            case 2:
                Console.WriteLine("Вычитание");
                break;
            case 3:
                Console.WriteLine("Умножение");
                break;
            default:
                Console.WriteLine("Операция не определена");
                break;
        }
    }
}