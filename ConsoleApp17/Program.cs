
class Program
{
    struct Student
    {
        public int öğrencino; // Öğrenci numarasını tutar
        public string tamad;   // Öğrenci adını tutar
    }

    static void Main()
    {
        Student[] öğrenciler = new Student[100]; // Maksimum 100 öğrenci için dizi oluştur
        int count = 0; // Mevcut öğrenci sayısını tutar

        while (true) // kullanıcı çıkana kadar devam eden döngü
        {
            Console.WriteLine("\n1. Yeni öğrenci ekle\n2. Öğrenci sil\n3. Listele\n4. Sıralı listele\n5. Çıkış");
            var seç = Console.ReadLine(); // Kullanıcıdan seçimi al
            if (seç == "5") break; // Eğer "5" seçilirse döngüden çık

            if (seç == "1" && count < 100) // Yeni öğrenci ekleme yeri
            {
                Console.Write("Numara: "); // ekrana numara yazdırır
                öğrenciler[count].öğrencino = int.Parse(Console.ReadLine()); // Öğrenci numarasını al
                Console.Write("İsim: "); // ekrana isim yazdırır
                öğrenciler[count].tamad = Console.ReadLine(); // Öğrenci adını al
                count++; // Öğrenci sayısını bir artır
            }
            else if (seç == "2") // Öğrenci silme yeri
            {
                Console.Write("Silinecek numara: "); // silinecek numara yazar
                int silinecekno = int.Parse(Console.ReadLine()); // Silinecek öğrencinin numarasını al
                for (int i = 0; i < count; i++) // Tüm öğrencileri kontrol et
                {
                    if (öğrenciler[i].öğrencino == silinecekno) // Eğer numara bulunursa
                    {
                        for (int j = i; j < count - 1; j++) // Öğrenciyi sil
                        {
                            öğrenciler[j] = öğrenciler[j + 1]; // Silinen öğrenciyi diziden çıkartır
                        }
                        count--; // Öğrenci sayısını bir azalt
                        break; // Döngüden çık
                    }
                }
            }
            else if (seç == "3") // Tüm öğrencileri listeleme yeri
            {
                for (int i = 0; i < count; i++) // Mevcut öğrencileri döngü ile gez
                {
                    Console.WriteLine($"Numara: {öğrenciler[i].öğrencino}, İsim: {öğrenciler[i].tamad}"); // Öğrenci bilgilerini yazdırır
                }
            }
            else if (seç == "4") // Öğrencileri sıralı listeleme
            {
                // Sıralama işlemi (bubble sort)
                for (int i = 0; i < count - 1; i++) // Dış döngü
                {
                    for (int j = i + 1; j < count; j++) // İç döngü
                    {
                        if (öğrenciler[i].öğrencino > öğrenciler[j].öğrencino) // Eğer sıralama hatalıysa
                        {
                            var temp = öğrenciler[i]; // Geçici değişken ile takas yap
                            öğrenciler[i] = öğrenciler[j];
                            öğrenciler[j] = temp;
                        }
                    }
                }

                for (int i = 0; i < count; i++) // Sıralanan öğrencileri yazdırır
                {
                    Console.WriteLine($"Numara: {öğrenciler[i].öğrencino}, İsim: {öğrenciler[i].tamad}");
                }
            }
            else // Geçersiz seçim olursa
            {
                Console.WriteLine("Geçersiz seçim veya liste dolu."); // Hatalı girdi mesajı
            }
        }
    }
}



