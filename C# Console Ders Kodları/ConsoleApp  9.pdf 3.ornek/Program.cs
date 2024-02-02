using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Adım 1: Yeni bir string listesi oluşturuluyor.
        var items = new List<string>();

        // Adım 2: List'in Count ve Capacity değerleri eklenmeden önce ekrana yazdırılıyor.
        Console.WriteLine("Before adding elements to items:");
        Console.WriteLine($"Count: {items.Count}, Capacity: {items.Capacity}");

        // Adım 3: İki öğe ekleniyor ve Count ve Capacity değerleri ekrana yazdırılıyor.
        Console.WriteLine("Adding two elements to items:");
        items.Add("red");
        items.Add("yellow");
        Console.WriteLine($"Count: {items.Count}, Capacity: {items.Capacity}");

        // Adım 4: Liste içindeki renkler bir döngü kullanılarak ekrana yazdırılıyor.
        Console.WriteLine("Display list contents with counter-controlled loop:");
        for (var i = 0; i < items.Count; i++)
        {
            Console.Write($"{items[i]} ");
        }

        // Adım 5: Liste içindeki renkler bir foreach döngüsü kullanılarak ekrana yazdırılıyor.
        Console.WriteLine("\nDisplay list contents with foreach statement:");
        foreach (var item in items)
        {
            Console.Write($"{item} ");
        }

        // Adım 6: "green" ve "yellow" ekleniyor ve Count ve Capacity değerleri ekrana yazdırılıyor.
        Console.WriteLine("\nAdding two more elements to items:");
        items.Add("green");
        items.Add("yellow");
        Console.WriteLine($"Count: {items.Count}, Capacity: {items.Capacity}");

        // Adım 7: Liste içindeki elemanlar ekrana yazdırılıyor.
        Console.WriteLine("Displaying list contents with two new elements:");
        foreach (var item in items)
        {
            Console.Write($"{item} ");
        }

        // Adım 8: İlk "yellow" öğesi ekrana yazdırılıyor ve sonra kaldırılıyor.
        Console.WriteLine("\nDisplay the first instance of yellow:");
        foreach (var item in items)
        {
            Console.Write($"{item} ");
        }
        items.RemoveAt(1);

        // Adım 9: Liste içindeki elemanlar ekrana yazdırılıyor.
        Console.WriteLine("\nDisplaying list contents after removing the second element (green):");
        foreach (var item in items)
        {
            Console.Write($"{item} ");
        }

        // Adım 10: İki öğe çıkarıldıktan sonra Count ve Capacity değerleri ekrana yazdırılıyor.
        Console.WriteLine("\nRemoving two elements from Items:");
        Console.WriteLine($"Count: {items.Count}, Capacity: {items.Capacity}");

        // Adım 11: "red" içerip içermediği kontrol ediliyor ve "orange" ve "violet" ekleniyor.
        Console.WriteLine(items.Contains("red") ? "red is in the list" : "red is not in the list");
        items.Add("orange");
        items.Add("violet");

        // Adım 12: "Count" ve "Capacity" değerleri ekrana yazdırılıyor.
        Console.WriteLine("\nAdding three more elements to items:");
        Console.WriteLine($"Count: {items.Count}, Capacity: {items.Capacity}");

        // Adım 13: List içindeki elemanlar ekrana yazdırılıyor.
        Console.WriteLine("Displaying list contents with three new elements:");
        foreach (var item in items)
        {
            Console.Write($"{item} ");
        }

        Console.WriteLine();
        Console.ReadLine();
    }
}
