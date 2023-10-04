using System;

namespace hafta2_odev1_kisisellestirilmisTakvim
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //      Sadi Enis GÜÇLÜER      \\

            Console.WriteLine("Sadi Enis GÜÇLÜER    \n\nHafta 2 Ödev 1 - Kişiselleştirilmiş Takvim  \n");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            Console.Write("Adınız: ");
            string ad = Console.ReadLine();
            Console.Write("Soyadınız: ");
            string soyad = Console.ReadLine();

            Console.Write("Numaranız: ");
            long num = Convert.ToInt64(Console.ReadLine());

            Console.Write("Doğum tarihiniz(örnek {0}.{1}.{2}): ", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            DateTime dogumGunu = Convert.ToDateTime(Console.ReadLine());
            bool yas = false; // true = 21 yaşından gün almış - false = 21 yaşından gün almamış

            if (DateTime.Now.Year - dogumGunu.Year == 20)
            {
                if (DateTime.Now.Month == dogumGunu.Month)
                {
                    if (DateTime.Now.Day >= dogumGunu.Day)
                    {
                        yas = true; // Eğer 20 yaşında olduğu kesin ise hangi ayda doğduğuna göre ayına ve gününe bakarak 21 yaşından gün almış mı diye kontrol ediyoruz.
                    }
                }
                else if (DateTime.Now.Month > dogumGunu.Month)
                {
                    yas = true;
                }
                else
                {
                    yas = false;
                }
            }
            else if (DateTime.Now.Year - dogumGunu.Year > 20)
            {
                yas = true; // (DateTime.Now.Year - dogumGunu.Year > 20) boolean işlemi zaten 21 yaşından da gün almıştır demektir.
            }
            else
            {
                yas = false; 
            }

            Console.Write("Cinsiyetiniz(erkek=10001/kadın=10002): ");
            int cins = Convert.ToInt32(Console.ReadLine());
            string kisi = null; // Kişinin gireceği cinsiyete göre bey yada hanım ekini kisi değişkeninde tutuyoruz. 

            if (cins == 10001)
            {
                kisi = "bey";
            }
            else if (cins == 10002)
            {
                kisi = "hanım";
            }

            Console.Write("İşinizin tarihini öğrenmek için işinizin kaç gün sonra olduğunu giriniz: ");
            int isGun = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(); Console.WriteLine();
            int hafta, ay, tempAy;

            // Aşağıdaki uzunca if kod bloğunda kişini yaşına ve cinsiyetine göre haftanın günlerini ve bir ayın kaç hafta olacağına karar veriyoruz.
            // Ona göre kullanıcının girdiği gün sayısına göre kendine özel kişiselleştirilmiş takvimine göre işin hangi ayın hangi gününde olduğunu çıktı olarak müşteriye veriyoruz.

            if (cins == 10001 && yas == true)
            {
                hafta = 8;//gün
                ay = 5;//hafta
                tempAy = isGun / (hafta * ay); 

                Console.WriteLine("Sayın {0} isimli {1} soyisimli {2} {3} yaşındasınız. {4}.ayın {5}.gününde işiniz bulunmaktadır.", ad, soyad, kisi, (DateTime.Now.Year - dogumGunu.Year), tempAy+1, isGun - (tempAy*(hafta*ay)));
            }
            else if (cins == 10001 && yas == false)
            {
                hafta = 8;//gün
                ay = 6;//hafta
                tempAy = isGun / (hafta * ay);

                Console.WriteLine("Sayın {0} isimli {1} soyisimli {2} {3} yaşındasınız. {4}.ayın {5}.gününde işiniz bulunmaktadır.", ad, soyad, kisi, (DateTime.Now.Year - dogumGunu.Year), tempAy + 1, isGun - (tempAy * (hafta*ay)));
            }
            else if (cins == 10002 && yas == true)
            {
                hafta = 6;//gün
                ay = 5;//hafta
                tempAy = isGun / (hafta * ay);

                Console.WriteLine("Sayın {0} isimli {1} soyisimli {2} {3} yaşındasınız. {4}.ayın {5}.gününde işiniz bulunmaktadır.", ad, soyad, kisi, (DateTime.Now.Year - dogumGunu.Year), tempAy + 1, isGun - (tempAy * (hafta * ay)));
            }
            else if (cins == 10002 && yas == false)
            {
                hafta = 6;//gün
                ay = 6;//hafta
                tempAy = isGun / (hafta * ay);

                Console.WriteLine("Sayın {0} isimli {1} soyisimli {2} {3} yaşındasınız. {4}.ayın {5}.gününde işiniz bulunmaktadır.", ad, soyad, kisi, (DateTime.Now.Year - dogumGunu.Year), tempAy + 1, isGun - (tempAy * (hafta * ay)));
            }
            Console.ReadKey();
        }
    }
}
