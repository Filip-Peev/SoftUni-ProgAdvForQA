using System.Text.RegularExpressions;

string pattern = @"\b(?<day>\d{2})(?<separator>[\.\-\/])(?<month>[A-Z][a-z]{2})\k<separator>(?<year>\d{4}\b)";
Regex regex = new Regex(pattern);


string input = Console.ReadLine();

MatchCollection matches = regex.Matches(input);

foreach (Match match in matches)
{
    Console.WriteLine($"Day: {match.Groups[1]}, Month: {match.Groups[3]}, Year: {match.Groups[4]}");
}