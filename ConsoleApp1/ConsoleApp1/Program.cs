using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal credit;
            int proc;
            decimal permonth;
            decimal summ;
            decimal a;
            decimal b;
            b = 0.01m;

            Console.WriteLine("Введите сумму кредита");
            credit = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Введите проценты кредита");
            proc = int.Parse(Console.ReadLine());

            a=proc*b;
            summ = credit+(credit*a);
            permonth = summ / 12;

            Console.WriteLine("1 месяц " + permonth);
            Console.WriteLine("2 месяц " + permonth);
            Console.WriteLine("3 месяц " + permonth);
            Console.WriteLine("4 месяц " + permonth);
            Console.WriteLine("5 месяц " + permonth);
            Console.WriteLine("6 месяц " + permonth);
            Console.WriteLine("7 месяц " + permonth);
            Console.WriteLine("8 месяц " + permonth);
            Console.WriteLine("9 месяц " + permonth);
            Console.WriteLine("10 месяц " + permonth);
            Console.WriteLine("11 месяц " + permonth);
            Console.WriteLine("12 месяц " + permonth);
            Console.WriteLine("Итого = "+summ);
        }
    }
}
