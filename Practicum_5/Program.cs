using System;

namespace Practicum_5
{
    delegate void Classes();
    delegate int Functions(int a, int b);
    class First
    {
        private string str = "";
        public string Str { get { return str; } set { str = value; } }
        public void fun1()
        {
            Console.WriteLine("Работает функция fun1");
            str += "1";
        }
        public void fun2()
        {
            Console.WriteLine("Работает функция fun2");
            str += "2";
        }
        public void fun3()
        {
            Console.WriteLine("Работает функция fun3");
            str += "3";
        }
        public void fun5()
        {
            Console.WriteLine("Работает функция fun5");
            str += "5";
        }
        public void Report()
        {
            Console.WriteLine("Работает функция Report. Итоговое значение str = " + str);
        }
    }
    class Second
    {
        public static int Add(int a, int b) => a + b;
        public static int Subtraction(int a, int b) => a - b;
    }
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Создаются два класса - First и Second.\nВ классе First \n\t1.создано закрытое поле str и 5 функций.\nВ классе Second\n\t1.рассмотрены способы добавления методов в делегат\n");
            First first = new First();
            Classes del_one = first.Report;
            Classes del_second = first.Report;
            
            first.Str = "#######################";
            del_one = first.fun1;
            del_one += first.Report;
            del_one += first.fun2;
            del_one += first.Report;
            del_one += first.fun5;
            del_one += first.Report;
            del_one();

            first.Str = "***********************";
            del_second = first.fun1;
            del_second += first.Report;
            del_second = first.fun2;
            del_second += first.Report;
            del_second += first.fun3;
            del_second += first.Report;
            del_second += first.fun5;
            del_second += first.Report;
            del_second();

            Console.WriteLine("\nАнализируем работу метода Add c числами 9 и 9.\n");
            Functions result;
            result = Second.Add;
            Console.WriteLine("Результат: " + result(9, 9));
            Console.WriteLine("\nАнализируем работу метода Subtraction с числами 49 и 9.\n");
            result = Second.Subtraction;
            Console.WriteLine("Результат: " + result(49, 9));
        }
    }
}

