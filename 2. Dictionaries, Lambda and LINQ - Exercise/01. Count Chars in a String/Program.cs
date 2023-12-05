Dictionary<char, int> characters = new();

string input = Console.ReadLine();

foreach (char ch in input)
{
    if (ch == ' ')
    {
        continue;
    }
    //if (characters.ContainsKey(ch))
    //{
    //    characters[ch]+=1;
    //}
    //else
    //{
    //    characters.Add(ch, 1);
    //}
    if (!characters.ContainsKey(ch))
    {
        characters.Add(ch, 1);
    }
    else
    {
        characters[ch] += 1;
    }
}
foreach (KeyValuePair <char, int> pair in characters)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}