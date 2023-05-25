using System;

namespace egitimTry
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Bir sayi giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayi:"+sayi);
            }
            catch(Exception ex)
            {
                 Console.WriteLine("Hata" + ex.Message.ToString());

            }
            //finally
            //{
              //  Console.WriteLine("İşlem tamamlandı.");
                
            //}
            try
            {
                int a = int.Parse("A");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş Değer Girdiniz.");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil.");
                Console.WriteLine(ex);
                
            }
            
                  
        }
    }
}