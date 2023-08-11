using System.Collections;

var array = new int[20];

try
{
    for (int i = 0; i < 20; i++)
    {
        System.Console.Write($"Sayı {i+1}: ");
        var number = Convert.ToInt32(Console.ReadLine());
        array[i] = number;
    }

    Array.Sort(array);

    int[] largestThree = new int[3];
    Array.Copy(array, array.Length - 3, largestThree, 0, 3);

    int[] min3 = new int[3];
    Array.Copy(array, array[2], min3, 0, 3);

    var topAve = Top3Average(largestThree);
    var minAve = Top3Average(min3);

    var result = topAve + minAve;

    Console.WriteLine($"Dizinin en büyük 3 elemanının ortalaması: {topAve}");
    Console.WriteLine($"Dizinin en küçük 3 elemanının ortalaması: {minAve}");
    Console.WriteLine($"Ortalamaların Toplamı: {result}");

}
catch (System.Exception ex)
{
    System.Console.WriteLine(ex.Message);
}


static int Top3Average(int[] top3)
{
    var toplam = 0;
    foreach (var item in top3)
    {
        toplam += item;
    }
    var average = toplam / 3;
    return average;
}

static int Min3Average(int[] min3)
{
    var toplam = 0;
    foreach (var item in min3)
    {
        toplam += item;
    }
    var average = toplam / 3;
    return average;
}