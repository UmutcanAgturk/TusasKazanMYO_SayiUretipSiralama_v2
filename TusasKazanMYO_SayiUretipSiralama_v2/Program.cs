using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TusasKazanMYO_SayiUretipSiralama_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(); //Rastgele oluşturulan sayımız
            List<int> sayiList = new List<int>(); //Sayı Listemioluşturdum
            while (true) //Sonsuz Döngü
            {
                sayiList.Clear();
                Console.WriteLine("Lütfen giriceğiniz sayı araalığını belirleyip kaç tane benzersiz sayı üreteceğinizi belirtiniz araya \"-\" koyarak belirtiniz. Çıkış için \"q\" harfini kullanabilirsiniz. (Örnek: 2-25-6 [2 ile 25 arasıda 6 tane benzersiz sayı])");
                Console.WriteLine();
                Console.WriteLine();
               
                string girilen = Console.ReadLine();// verileri çekimimiz yeri
                if (girilen == "q") //Kullanıcı çıkış işlemi
                {
                    break;
                }
                int num1 = Convert.ToInt32(girilen.Split('-')[0]);//ilk girilen sayı
                int num2 = Convert.ToInt32(girilen.Split('-')[1]);//ikince girilen sayı
                int num3 = Convert.ToInt32(girilen.Split('-')[2]);//benzersiz sayı 
                for (int i = 0; i < num3; i++)
                {
                    int temp = rnd.Next(num1, num2);

                    if (sayiList.Contains(temp))
                    {
                        i--;
                        continue;
                    }
                    else
                    {
                        sayiList.Add(temp);
                    }
                }
                sayiList.Sort();
                sayiList.Reverse();

                foreach (var item in sayiList)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
                Console.WriteLine();
                
            }

        }
    }
}
