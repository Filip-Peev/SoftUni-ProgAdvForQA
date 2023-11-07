string[] text = Console.ReadLine().Split();

string output = "";

for (int i = 0; i < text.Length; i++)
{
    string currentText = text[i];
    for (int j = 0; j < currentText.Length; j++)
    {
        output += currentText;
    }
}
Console.WriteLine(output);