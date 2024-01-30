using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Lütfen bir sayı girin: ");
            string kullaniciGirdisi = Console.ReadLine();

            int sayi = int.Parse(kullaniciGirdisi);

            int kare = sayi * sayi;

            Console.WriteLine($"{sayi} sayısının karesi: {kare}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Hata: Geçerli bir sayı girmediniz.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Bir hata oluştu: {ex.Message}");
        }
    }
}
