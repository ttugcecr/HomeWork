using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CA_IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Karar Yapıları (If, else, else if)

            //Ödev

            /*
             /uygulama çalışmadan önce not ortalaması hesaplanacak öğrencinin ad ve soyad bilgisi alınsın. ad ve soyad bilgisi bulunmuyorsa not ortalama işlemi yapılmasın. Kullanıcıya uyarı mesajı gösterilsin.


//0 dan küçük ve 100'den büyük not girilemesin.
//kullanıcıdan vize değeri alın
//kullanıcıdan final değeri alın
//vizenin %30'u
//finalin %70'i
//alarak not ortalamasını bulun.

not ortalaması eğer;

0 ile 44 => FF
45 ile 59=> DD
60 ile 69=> CC
70 ile 84 => BB
85 ile 100=> AA

harf notunu da kullanıcıya gösterin.

             */
            try
            {

            
            Console.WriteLine("**Nort Hesaplama Uygulaması**");
            Console.WriteLine("Lütfen adınızı girin:");
            string firstName = Console.ReadLine();
            if (firstName == "")
            {
                Console.WriteLine("lütfen adınızı girin..");
            }
            else
            {
                Console.WriteLine("Lütfen soyadınızı girin:");
                string lastName = Console.ReadLine();
                if (lastName == "")
                {
                    Console.WriteLine("lütfen soyadınızı girin.");
                }
                else
                {
                    Console.WriteLine("Lütfen vize notunu giriniz:");
                    string stringDouble = Console.ReadLine();
                    double vize = double.Parse(stringDouble);

                    bool vizeDurum = vize >= 0 && vize <= 100;

                    if (vizeDurum)//true
                    {

                        Console.WriteLine("Final notu giriniz:");
                        double final = double.Parse(Console.ReadLine());

                        bool finalDurum = final >= 0 && final <= 100;
                        if (finalDurum)
                        {
                            Console.WriteLine("girilen not bilgileri DOĞRU!");

                            double vize30 = vize * 0.30;
                            double final70 = final * 0.70;
                            double ortalama = vize30 + final70;
                            /*
                             0 ile 44 => FF
45 ile 59=> DD
60 ile 69=> CC
70 ile 84 => BB
85 ile 100=> AA
                             */


                            string format = "Ortalama " + ortalama + " ";
                            if (ortalama <= 44)
                            {
                                format += "Harf notu FF ";
                                format += firstName + " " + lastName;
                                Console.WriteLine(format);

                            }
                            else if (ortalama <= 59)
                            {
                                format += "Harf notu DD ";
                                format += firstName + " " + lastName;
                                Console.WriteLine(format);
                            }
                            else if (ortalama <= 69)
                            {
                                format += "Harf notu CC ";
                                format += firstName + " " + lastName;
                                Console.WriteLine(format);
                            }
                            else if (ortalama <= 84)
                            {
                                format += "Harf notu BB ";
                                format += firstName + " " + lastName;
                                Console.WriteLine(format);
                            }
                            else if (ortalama <= 100)
                            {
                                format += "Harf notu AA ";
                                format += firstName + " " + lastName;
                                Console.WriteLine(format);
                            }

                        }
                        else
                        {
                            Console.WriteLine("0 ile 100 arasında bir değer girin.");
                        }



                    }
                    else
                    {
                        Console.WriteLine("0 ile 100 arasında bir değer girin.");
                    }


                }
            }
            }
            catch (Exception ex)
            {

                Console.WriteLine("aşko saçmalama böyle not mu olur!!!!!"+" "+ex.Message);
                Console.Beep(659, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(523, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(375); Console.Beep(392, 125); Thread.Sleep(375); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(375); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125); Thread.Sleep(1125); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125);
            }


            Console.Read();
        }
    }
}
