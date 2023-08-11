
using System.Collections;
using Microsoft.VisualBasic;

var primeNumbers = new ArrayList();
var notPrimeNumbers = new ArrayList();

try
{
    for (int i = 1; i < 21; i++)
    {
        System.Console.Write($"Sayı {i}: ");
        var number = Convert.ToInt32(Console.ReadLine());
        if (number.IsPrime())
        {
            primeNumbers.Add(number);
        }
        else
        {
            notPrimeNumbers.Add(number);
        }
    }

    System.Console.WriteLine("Asal sayıların büyükten küçüğe sıralanmış hali");
    primeNumbers.ReverseArrayList();
    foreach (var item in primeNumbers)
    {
        System.Console.WriteLine(item);
    }

    System.Console.WriteLine("Asal olmayan sayıların büyükten küçüğe sıralanmış hali");
    notPrimeNumbers.ReverseArrayList();
    foreach (var item in notPrimeNumbers)
    {
        System.Console.WriteLine(item);
    }

    System.Console.WriteLine($"Asal sayılar dizisinin eleman sayısı: {primeNumbers.Count}");
    System.Console.WriteLine($"Asal olmayan sayılar dizisinin eleman sayısı: {notPrimeNumbers.Count}");
    PrimeNumberAve(primeNumbers);
    NotPrimeNumberAve(notPrimeNumbers);
   
}
catch (System.Exception ex)
{
    System.Console.WriteLine(ex.Message);
}

static void PrimeNumberAve(ArrayList primeNumbers)
{
    var toplam = 0;
    foreach (var item in primeNumbers)
    {
        toplam += (int)item;
    }
    var result = toplam / primeNumbers.Count;
    Console.WriteLine($"Asal sayılar dizisinin ortalaması: {result}");
}
static void NotPrimeNumberAve(ArrayList notPrimeNumbers)
{
    var toplam = 0;
    foreach (var item in notPrimeNumbers)
    {
        toplam += (int)item;
    }
    var result = toplam / notPrimeNumbers.Count;
    Console.WriteLine($"Asal olmayan sayılar dizisinin ortalaması: {result}");
}
public static class Extensions
{
    public static bool IsPrime(this int number)
    {
        bool isPrime = false;
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
            else
            {
                isPrime = true;
            }
        }
        return isPrime;
    }

    public static void ReverseArrayList(this ArrayList arrayList)
    {
        for (int i = 0; i < arrayList.Count - 1; i++)
        {
            for (int j = i + 1; j < arrayList.Count; j++)
            {
                if ((int)arrayList[j] > (int)arrayList[i])
                {
                    object temp = arrayList[i];
                    arrayList[i] = arrayList[j];
                    arrayList[j] = temp;
                }
            }
        }
    }
}