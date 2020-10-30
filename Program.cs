using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR11
{
    class Program
    {
        static void Main(string[] args)
        {
           //Ввести пять различных ненулевых целых чисел. Найти два наибольших числа.


        //m1:
        //    Console.Write("Введите первое число \n");
        //    int A = Convert.ToInt32(Console.ReadLine());
        //    if (A == 0)
        //        {
        //            Console.Write("Вы ввели не правильное число \n");
        //            goto m1;
        //        }
        //m2:
        //    Console.Write("Введите второе число \n");
        //    int B = Convert.ToInt32(Console.ReadLine());
        //    if (B == 0)
        //    {
        //        Console.Write("Вы ввели не правильное число \n");
        //        goto m2;
        //    }
        //m3:
        //    Console.Write("Введите третье число \n");
        //    int C = Convert.ToInt32(Console.ReadLine());
        //    if (C == 0)
        //    {
        //        Console.Write("Вы ввели не правильное число \n");
        //        goto m3;
        //    }
        //m4:
        //    Console.Write("Введите четвёртое число \n");
        //    int D = Convert.ToInt32(Console.ReadLine());
        //    if (D == 0)
        //    {
        //        Console.Write("Вы ввели не правильное число \n");
        //        goto m4;
        //    }
        //m5:
        //    Console.Write("Введите пятое число \n");
        //    int E = Convert.ToInt32(Console.ReadLine());
        //    if (E == 0)
        //    {
        //        Console.Write("Вы ввели не правильное число \n");
        //        goto m5;
        //    }

            


        //m10:
        //    int Fn1 = 0;
        //    int Sn2 = 0;

        //    if (A > Fn1)
        //    {
        //        Fn1 = A;
        //    }
        //    if (B > Fn1)
        //    {
        //        Fn1 = B;
        //    }
        //    if (C > Fn1)
        //    {
        //        Fn1 = C;
        //    }
        //    if (D > Fn1)
        //    {
        //        Fn1 = D;
        //    }
        //    if (E > Fn1)
        //    {
        //        Fn1 = E;
        //    }

        //    if (Fn1 > A && Fn1 != A)
        //    {
        //        Sn2 = A;
        //    }
        //    if (Fn1 > B && Fn1 != B)
        //    {
        //        Sn2 = B;
        //    }
        //    if (Fn1 > C && Fn1 != C)
        //    {
        //        Sn2 = C;
        //    }
        //    if (Fn1 > D && Fn1 != D)
        //    {
        //        Sn2 = D;
        //    }
        //    if (Fn1 > E && Fn1 != E)
        //    {
        //        Sn2 = E;
        //    }






        //    Console.WriteLine("Первое большое число = {0}",Fn1);
        //    Console.WriteLine("Второе большое число = {0}",Sn2);
        //    Console.Write("Введите число чтобы выйти \n");



            //Проверить истинность высказывания: "Цифры данного 
            //целого положительного трехзначного числа, введенного
            //с клавиатуры, образуют убывающую последовательность".

       m120:
            Console.Write("Введите целое положительное трехзначное число \n");
            double A = Convert.ToDouble(Console.ReadLine());
            int Aa = Convert.ToInt32(A);
            if (Aa == A) { goto m121; }
            else { Console.Write("Вы ввели не правильное число \n"); goto m120; }


       m121:
            int A1 = Aa / 100;
            int A2 = (Aa / 10) % 10;
            int A3 = Aa % 10;
            if (A1 > A2 && A2 > A3)
            {
                Console.Write("Истина \n");
            }
            else 
            {
                Console.Write("Ложь \n");
            }

            //Даны два целых положительных числа: D (день, от 1 до 31) и M (месяц, от 1 до 12),
            //определяющие правильную дату не високосного года. Вывести значения D и M для даты, следующей за указанной.

       m300:
            Console.Write("Введите день ( от 1 до 31 ) \n");
            int D = Convert.ToInt32(Console.ReadLine());
            if ( D >= 31 && D <= 1 )
            {
                Console.Write("Число неправильное");
                goto m300;
            }

            Console.Write("Введите месяц ( от 1 до 12 ) \n");
            int M = Convert.ToInt32(Console.ReadLine());
            if (M >= 12 && M <= 1)
            {
                Console.Write("Число неправильное");
                goto m300;
            }


            switch(M)
            {
                    case 1: 
                {
                    Console.Write("Январь {0}", D);
                    break;
                }

                    case 2:
                {
                    if (D > 28)
                    {
                        D = D - 28;
                        Console.Write("Март {0}", D);
                        goto end;
                    }
                    Console.Write("Февраль {0}", D);
                    break;
                }
                    case 3:
                {
                        Console.Write("Март {0}", D);
                        break;
                }
                    case 4:
                {
                    if (D > 30)
                    {
                        D = D - 30;
                        Console.Write("Май {0}", D);
                        goto end;
                    }
                    Console.Write("Апрель {0}", D);
                    break;
                }
                    case 5:
                {
                    Console.Write("Май {0}", D);
                    break;
                }
                    case 6:
                {
                    if (D > 30)
                    {
                        D = D - 30;
                        Console.Write("Июль {0}", D);
                        goto end;
                    }
                    Console.Write("Июнь {0}", D);
                    break;
                }
                    case 7:
                {

                    Console.Write("Июль {0}", D);
                    break;
                }
                    case 8:
                {

                    Console.Write("Август {0}", D);
                    break;
                }
                    case 9:
                {
                    if (D > 30)
                    {
                        D = D - 30;
                        Console.Write("Октябрь {0}", D);
                        goto end;
                    }
                    Console.Write("Сентябрь {0}", D);
                    break;
                }
                    case 10:
                {
                    Console.Write("Октябрь {0}", D);
                    break;
                }
                    case 11:
                {
                    if (D > 30)
                    {
                        D = D - 30;
                        Console.Write("декабрь {0}", D);
                        goto end;
                    }
                    Console.Write("ноябрь {0}", D);
                    break;
                }
                    case 12:
                {
                    Console.Write("Декабрь {0}", D);
                    break;
                }
          }
         end:
            Console.Write("Введите число чтобы выйти \n");
        }
    }
}
