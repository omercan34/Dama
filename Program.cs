using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ö.d_Dama
{
    class Program
    {
        static void Main(string[] args)
        {

            DamaTahtasiCizV2();                   // Başlık getirme metodu çağırmış.
            Console.ReadLine();

        }    
                        
            static void DamaTahtasiCizV2()           // methot tanımladı bu metod bir değer dönmecektir.
            {
                string tahta = "";                    //  bos bir  tahta giğşkeni  tanımladık.
                string karakter = "*";                 // karakter değişkeni ile bir *  değişkeni tanımladık 
                for (int r = 0; r < 8; r++)           // for döngüsü belirli bir başlangıç, adım ve bitiş değeri(şart) ile işlemleri gerçekleştirmek için kullanılan bir döngüdür.
                {
                    if (karakter == " ")              // belirli bir şarta bağlı olarak yerine getirilmesi istenen komuttur
                        karakter = "*";
                    else                             // belirli bir şarta bağlı olarak yerine getirilmesi istenen komut
                        karakter = " ";
                    for (int c = 0; c < 8; c++)       // for döngüsü belirli bir başlangıç, adım ve bitiş değeri(şart) ile işlemleri gerçekleştirmek için kullanılan bir döngüdür.
                    {
                        if (karakter == " ")         // belirli bir şarta bağlı olarak yerine getirilmesi istenen komut
                            karakter = "*";
                        else                        // belirli bir şarta bağlı olarak yerine getirilmesi istenen komut
                            karakter = " ";
                        tahta += karakter;
                    }
                    tahta += "\n";                // her seferinde bir alt bölüme geçme komotu yaztık.                 
                }
                Console.WriteLine(tahta);            // girilen veriyi ekrana yazdırır
            }

        
        
    }
}
