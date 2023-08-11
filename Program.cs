/*  1. Soru
Console.WriteLine("Pozitif bir tam sayı giriniz: ");
var n = Convert.ToInt32(Console.ReadLine());
int count = 0;
List<int> numbers = new List<int>();

Console.WriteLine($"{n} adet sayı giriniz: ");

while (count < n)
{
    numbers.Add(Convert.ToInt32(Console.ReadLine()));

    count++;
}

System.Console.WriteLine($" ------------------ Girdiğiniz Çift Pozitif Tam Sayılar ------------------");
foreach (var item in numbers)
{
    if (item % 2 == 0)
    {
        Console.WriteLine(item);
    }
}
*/


/* 2. Soru
System.Console.WriteLine("Pozitif İki sayı giriniz: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

int count = 0;
List<int> numbers = new List<int>();

Console.WriteLine($"{number1} adet sayı giriniz: ");

while (count < number1)
{
    numbers.Add(Convert.ToInt32(Console.ReadLine()));

    count++;
}

System.Console.WriteLine($" ------------------ Girmiş Olduğunuz Sayılardan {number2}'ye tam bölünenleri ------------------");
foreach (var item in numbers)
{
    if (item == number2 || item % number2 == 0 )
    {
        Console.WriteLine(item);
    }
}
*/


/* 3. Soru
Console.WriteLine("Pozitif bir tam sayı giriniz: ");
var n = Convert.ToInt32(Console.ReadLine());

int count = 0;
List<string> words = new List<string>();
Console.WriteLine($"{n} adet kelime giriniz: ");
while (count < n)
{
    var word = Console.ReadLine();
    words.Add(word);

    count++;
}

Console.WriteLine("Kelimeler descending sıralı:");
words.OrderByDescending(word => word).ToList().ForEach(word => Console.WriteLine(word));
*/
// var descendingWords = words.OrderByDescending(word => word);

// Console.WriteLine("Kelimeler descending sıralı:");
// foreach (var word in descendingWords)
// {
//     Console.WriteLine(word);
// }


System.Console.Write("Bir Cümle Yazınız: ");
var sentence = Console.ReadLine();
System.Console.WriteLine($"Girdiğiniz Cümledeki Toplam Kelime Sayısı: {sentence.Split(' ').Length}");
System.Console.WriteLine($"Girdiğiniz Cümledeki Toplam Harf Sayısı: {sentence.Length}");