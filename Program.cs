using System;

namespace lesson_2 // Д/З Урок2. Стрелков Максим
{
    class Program

    {
        static void Main()

        {
            Console.Clear();

            MainMenu();
        }

        static void Task1() //Задача №1.Написать метод, возвращающий минимальное из трёх чисел.
        #region
        {
            Console.Clear();
            Console.WriteLine("Задача №1.Написать метод, возвращающий минимальное из трёх чисел.");
            Console.WriteLine("                                                                ");

            Console.WriteLine("Введите три целых числа");
            Console.Write("Введите первое число: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int number2 = int.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            int number3 = int.Parse(Console.ReadLine());

            int min;
            min = number1;

            if (number2 < min) min = number2;
            if (number3 < min) min = number3;

            Console.WriteLine($"Наименьшее число: {min}");

            Console.WriteLine("Нажмите ENTER для выхода в основное меню.");
            Console.ReadKey();
            MainMenu();


        }
        #endregion

        static void Task2() //Задача №2.Написать метод подсчета количества цифр числа.
        #region
        {
            Console.Clear();
            long num;
            Console.WriteLine("Задача №2.Написать метод подсчета количества цифр числа.");
            Console.Write("Введите число: ");
            num = long.Parse(Console.ReadLine());

            int count = 0;
            while (num != 0)
            {
                count++;
                num = num / 10;
            }
            Console.WriteLine(count);
            Console.WriteLine("Нажмите ENTER для выхода в основное меню.");
            Console.ReadKey();
            MainMenu();



        }
        #endregion

        static void Task3() //Задача №3.С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
        #region
        {
            Console.Clear();
            Console.WriteLine("Задача №3.С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.");

            int number;
            int summa = 0;

            do
            {
                Console.Write("Введите любое число: ");
                number = int.Parse(Console.ReadLine());
                Console.WriteLine();


                if (number > 0 && number % 2 == 1)
                    summa += number;

            } while (number != 0);
            Console.WriteLine("Сумма всех нечётных чисел: " + summa);
            Console.WriteLine("Нажмите ENTER для выхода в основное меню.");
            Console.ReadKey();
            MainMenu();
        }
        #endregion


        static void Task4() //Задача №4.Реализовать метод проверки логина и пароля,ввод пароля ограничить тремя попытками.
        #region
        {
            Console.Clear();
            string login;
            string goodlogin = "root";
            int logflag;
            Console.WriteLine("Задача №4.Реализовать метод проверки логина и пароля." +
                "                                                                     ");
            Console.WriteLine("Логин: ");
            login = Console.ReadLine();
            logflag = login.CompareTo(goodlogin);

            if (logflag == 0)
            {
                CheckPWD();
            }
            Console.WriteLine("Неправильный логин!!! Нажмите Enter");
            Console.ReadKey();

            MainMenu();
        }
        static void CheckPWD()
        {
            string trupwd = "GeekBrains";
            string pwd;
            int pwdflag;
            int pwdcount = 0;

            do
            {
                Console.WriteLine("Пароль: ");
                pwd = Console.ReadLine();
                pwdflag = pwd.CompareTo(trupwd);
                pwdcount++;

                if (pwdflag == 0)
                {
                    Console.WriteLine("ПАРОЛЬ ВЕРНЫЙ , Нажмите Enter");
                    Console.ReadLine();
                    MainMenu();
                }

                if (pwdflag != 0 && pwdcount > 3)

                    Console.ReadKey();
                Console.WriteLine("НЕПРАВИЛЬНЫЙ ПАРОЛЬ");

            }
            while (pwdflag != 0 && pwdcount < 3);

            Console.WriteLine("ВЫ ПРЕВЫСИЛИ ЧИСЛО ПОПЫТОК ВВОДА ПАРОЛЯ , Нажмите Enter");

            Console.ReadKey();
            MainMenu();


        }
        #endregion

        static void Task5() //Задача №5.Написать программу, которая запрашивает массу и рост человека, вычисляет его ИМТ и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.");
        #region
        {
            Console.Clear();
            Console.WriteLine("Задача №5.Написать программу, которая запрашивает массу и рост человека, вычисляет его ИМТ и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.");


            Console.Write("Введите свой вес в кг ");
            string inputstr1 = Console.ReadLine();
            double m = double.Parse(inputstr1);
            Console.Write("Введите свой рост в метрах ");
            string inputstr2 = Console.ReadLine();
            double h = double.Parse(inputstr2);

            double v = m / (h * h);

            if (v <= 18)
            {
                    
                Console.WriteLine($"Ваш ИМТ={v}, предельно низкий вес.");
                Console.WriteLine("Нажмите Enter для выхода в меню");
                Console.ReadKey();
                MainMenu();
            }

            if (v <= 25 && v > 18)
            {
                Console.WriteLine($"Ваш ИМТ={v},нормальный вес");
                Console.WriteLine("Нажмите Enter для выхода в меню");
                Console.ReadKey();
                MainMenu();
            }

            if (v > 25)
            {
                Console.WriteLine($"Ваш ИМТ={v},избыточный вес");
                Console.WriteLine("Нажмите Enter для выхода в меню");
                Console.ReadKey();
                MainMenu();
            }
        }
        #endregion


        static void MainMenu() //Главное меню.
        #region
        {

            Console.Clear();
            bool flag = true;

            while (flag)

            {
                Console.WriteLine("Задача №1,Нажмите  [1]");
                Console.WriteLine("Задача №2,Нажмите  [2]");
                Console.WriteLine("Задача №3,Нажмите  [3]");
                Console.WriteLine("Задача №4,Нажмите  [4]");
                Console.WriteLine("Задача №5,Нажмите  [5]");
                Console.WriteLine("Для выхода нажмите [0]" +
                "                  ");

                Console.WriteLine();
                Console.Write("Выбор: ");

                int num = int.Parse(Console.ReadLine());

                switch (num)
                {

                    case 0:
                        Console.WriteLine("Выход");
                        flag = false;
                        break;

                    case 1:
                        Console.WriteLine("Выполнение Задачи №1");
                        Task1();
                        break;

                    case 2:
                        Console.WriteLine("Выполнение Задачи №2");

                        Task2();
                        break;

                    case 3:
                        Console.WriteLine("Выполнение Задачи №3");
                        Task3();
                        break;

                    case 4:
                        Console.WriteLine("Выполнение Задачи №4");
                        Task4();
                        break;

                    case 5:
                        Console.WriteLine("Выполнение Задачи №5");
                        Task5();
                        break;
                }

                if (num > 5 && true)
                
                {
                    Console.WriteLine("Вы ввели неправильный номер, нажмите Enter и повторите попытку.");
                    Console.ReadKey();
                    MainMenu();
                
                }

                if (false) 
                { }
                    
                break; //чем другим можно прервать выполнение и выйти?
                
            }
            
            

              
        }
    }
}
#endregion



































