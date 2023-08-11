

Console.Write("Bir cümle giriniz: ");
string sentence = Console.ReadLine();

List<char> vowels = new List<char>();
char[] vowelCharacters = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

foreach (char c in sentence)
{
    if (Array.IndexOf(vowelCharacters, c) >= 0)
    {
        vowels.Add(c);
    }
}

vowels.Sort();

Console.WriteLine("Cümle içerisindeki sesli harfler sıralanmış hali:");
foreach (char vowel in vowels)
{
    Console.WriteLine(vowel);
}