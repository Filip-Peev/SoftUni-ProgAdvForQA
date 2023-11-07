string wordToRemove = Console.ReadLine();

string text = Console.ReadLine();

while (text.Contains(wordToRemove)){

    int indexOfTextToRemove = text.IndexOf(wordToRemove);
    text = text.Remove(indexOfTextToRemove, wordToRemove.Length);     
}

Console.WriteLine(text);