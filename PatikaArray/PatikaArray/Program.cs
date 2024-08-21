using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        // 1. uygulama
        int[] sayilar = new int[10];  // 10 elemanlı bir dizi oluşturma



        // 2. uygulama
        Console.WriteLine("Dizinin elemanlarını giriniz:"); // kullanıcıdan sayı alma

        for (int i = 0; i < sayilar.Length; i++) // for döngüsü ile 10 elemanlı diziyi oluşturma
        {
            Console.Write($"Eleman {i + 1}: ");
            sayilar[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\nDizi elemanları:");
        foreach (int sayi in sayilar)             // foreach döngüsü ile her bir elemanı konsola yazdırma
        {
            Console.WriteLine(sayi);
        }

        // 3. uygulama
        Console.Write("\nYeni bir değer giriniz: ");  // kullanıcıdan yeni sayı değeri alma 
        int yeniDeger = Convert.ToInt32(Console.ReadLine()); 

        
        int[] yeniDizi = new int[sayilar.Length + 1];  // Mevcut diziye 1 eleman daha ekleneceği için öncelikle boyutu arttırılıyor
        Array.Copy(sayilar, yeniDizi, sayilar.Length);  // Copy komutu ile oluşturulan eski dizi elemanları, yeni diziye kopyalanıyor
        yeniDizi[yeniDizi.Length - 1] = yeniDeger;      // Yeni dizinin son indeksine yeni değeri ekleme

        // 4. uygulama
        Array.Sort(yeniDizi);    // Küçükten büyüğe sıralama
        Array.Reverse(yeniDizi); // Varolan dizilimi tersine sıralama

        Console.WriteLine("\nBüyükten küçüğe sıralanmış dizi elemanları:");
        foreach (int sayi in yeniDizi)
        {
            Console.WriteLine(sayi);
        }
    }
}