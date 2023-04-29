using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System. IO;

namespace FunctionalTesting
{
    internal class Program
    {
        public struct Tests
        {
            public string NomerTesta;
            public string TemaTesta;
            public string NazvanieTesta;
           
        }
        public static void ZapolnenieTesta()
        {
            string res;
            string[] mass = new string[Ziseoffile1()];
            Tests[] test = new Tests[Ziseoffile1()];

            using (StreamReader DJ = new StreamReader("Tests.txt"))
            {
                for (int i = 0; i < DJ.Peek(); i++)
                {
                    res = DJ.ReadLine();
                    mass = res.Split(' ');
                    test[i].NomerTesta = mass[0];
                    test[i].TemaTesta = mass[1];
                    test[i].NazvanieTesta = mass[2];
                    
                    Console.WriteLine(" Номер теста: " + test[i].NomerTesta + " Тема теста: " + test[i].TemaTesta + " Название теста: " + test[i].NazvanieTesta );
                }
            }
        }




        public static void avtorizachia()
        {
            
            string Familia = Console.ReadLine();
            string Name = Console.ReadLine();
            string otetestvo = Console.ReadLine();
            string res;
            string[] mass = new string[Ziseoffile()];
            Student[] student = new Student[Ziseoffile()];

            using (StreamReader DJ = new StreamReader("File.txt"))
            {
                for (int i = 0; i < DJ.Peek(); i++)
                {
                    res = DJ.ReadLine();
                    mass = res.Split(' ');
                    student[i].Familia = mass[0];
                    student[i].Name = mass[1];
                    student[i].Otchestvo = mass[2];
                    student[i].balnabral = Convert.ToInt32(mass[3]);
                    student[i].balmax = Convert.ToInt32(mass[4]);
                    student[i].ochenka = Convert.ToInt32(mass[5]);
                }
            }
            int count = 0;
            for (int i = 0; i < Ziseoffile(); i++)
            {
                if (Familia == student[i].Familia)
                {
                    if (Name == student[i].Name)
                    {
                        if (otetestvo == student[i].Otchestvo)
                        {
                            Console.WriteLine("\t");
                            Console.WriteLine("                                                  Ваш результат :");
                            Console.WriteLine(" " + student[i].Familia + " " + student[i].Name + " " + student[i].Otchestvo + " Набранное колличество баллов: " + student[i].balnabral + " Максимально баллов за тест: " + student[i].balmax + " Оценка: " + student[i].ochenka);
                            count = 1;
                        }
                    }
                }

            }
            if (count == 0)
            {
                Console.WriteLine("\t");
                Console.WriteLine("Студент с такими данными не найден, введите другие данные");
                Console.WriteLine("\t");
                avtorizachia();
            }

        }

       public struct Student
       {
            public string Familia;
            public string Name;
            public string Otchestvo;
            public int balnabral;
            public int balmax;
            public int ochenka;
       }
        public static void ZapolnenieStacta()
        {
            string res;
            string[] mass = new string[Ziseoffile()];
            Student[] student = new Student[Ziseoffile()];

            using (StreamReader DJ = new StreamReader("File.txt"))
            {
                for (int i = 0; i < DJ.Peek(); i++)
                {
                    res = DJ.ReadLine();
                    mass = res.Split(' ');
                    student[i].Familia = mass[0];
                    student[i].Name = mass[1];
                    student[i].Otchestvo = mass[2];
                    student[i].balnabral = Convert.ToInt32(mass[3]);
                    student[i].balmax = Convert.ToInt32(mass[4]);
                    student[i].ochenka = Convert.ToInt32(mass[5]);

                    Console.WriteLine(" " + student[i].Familia + " " + student[i].Name + " " + student[i].Otchestvo + " " + student[i].balnabral + " " + student[i].balmax + " " + student[i].ochenka);
                }
            }
        }

        static int Ziseoffile()// количество строк в файле
        {
            int count = 0;

            using (var sw = new StreamReader("File.txt"))
            {

                for (int i = 0; sw.Peek() != -1; i++)
                {
                    sw.ReadLine();
                    count++;
                }
            }
            return count;
        }
        static int Ziseoffile1()// количество строк в файле
        {
            int count = 0;

            using (var sw = new StreamReader("Tests.txt"))
            {

                for (int i = 0; sw.Peek() != -1; i++)
                {
                    sw.ReadLine();
                    count++;
                }
            }
            return count;
        }





        static void Main(string[] args)
        {
           

            // Выбор пользователя
            Console.WriteLine("                                      Добро пожаловать в программу <<Тестирование>>");
            Console.WriteLine("\t");
            Console.WriteLine(" Выберите цифрой (от 1 до 2) каким пользователем вы являетесь, если же хотите завершить работу -- нажмите <3>:");
            Console.WriteLine("\t");
            Console.WriteLine(" 1 - Пользователь <<Студент>>");
            Console.WriteLine(" 2 - Пользователь <<Экзаменатор>>");
            Console.WriteLine("\t");
            Console.WriteLine(" 3 - Завершить работу");
            Console.WriteLine("\t");


            
            int rejim = Convert.ToInt32(Console.ReadLine());

            if (rejim < 1 || rejim > 3)
            {
                Console.WriteLine("      ОШИБКА : Введены неверные данные. Пожалуйста, введите значения от <1> до <3>");
                Console.WriteLine("\t");
                Main(args);
                
            }

            // Выбор пользователя Студент

            if (rejim  == 1)
            {
                Console.WriteLine("                                          Вы вошли как: Пользователь <<Студент>>");
                Console.WriteLine("\t");
                Console.WriteLine(" Выберите действие, если же хотите завершить работу -- нажмите <3>:");
                Console.WriteLine("\t");
                Console.WriteLine(" 1 - Посмотреть результаты тестирования");
                Console.WriteLine("\t");
                Console.WriteLine(" 3 - Завершить работу");
                Console.WriteLine("\t");

                int vibor = Convert.ToInt32(Console.ReadLine());

                if (vibor == 1)
                {
                    Console.WriteLine("   Введите вашу фамилию, имя и отчество (через Enter)");
                   
                    avtorizachia();

                }
                else if (vibor == 3 )
                {
                    Console.WriteLine("                                                     До свидания!");
                    Console.ReadKey();
                }
                
                Console.ReadKey();

            }

            // Выбор пользователя Экзаменатор

            if (rejim == 2)
            {
                Console.WriteLine("                                          Вы вошли как: Пользователь <<Экзаменатор>>");
                Console.WriteLine("\t");
                Console.WriteLine(" Выберите цифрой (от 1 до 2) действие, если же хотите завершить работу -- нажмите <3>:");
                Console.WriteLine("\t");
                Console.WriteLine(" 1 - Посмотреть список тестов");
                Console.WriteLine(" 2 - Посмотреть результаты тестирования");
                Console.WriteLine("\t");
                Console.WriteLine(" 3 - Завершить работу");
                Console.WriteLine("\t");
                
                int viborexza = Convert.ToInt32(Console.ReadLine());
               
                if (viborexza == 1)
                {
                    Console.WriteLine("                                                            Тесты:");
                    ZapolnenieTesta();

                }
                if (viborexza == 2)
                {
                    Console.WriteLine("                                               Результаты тестирования студентов:");
                    ZapolnenieStacta();

                }
                else if (viborexza == 3)
                {
                    Console.WriteLine("                                                     До свидания!");
                    Console.ReadKey();
                }

                Console.ReadKey();


            }

            // Выбор пользователя выйти из проги

            else if (rejim == 3)
            {
                Console.WriteLine("                                                     До свидания!");
                Console.ReadKey();
            } 

            Console.ReadKey();

        }
    }
}
