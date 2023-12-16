class Article
{
    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }

    // constructor
    public Article(string title, string content, string author)
    {
        Title = title;
        Content = content;
        Author = author;
    }

    // Действия - методи:
    public void Edit(string newContent)
    {
        Content = newContent;
    }
    public void ChangeAuthor(string newAuthor)
    {
        Author = newAuthor;
    }
    public void Rename(string newTitle)
    {
        Title = newTitle;
    }

    // пренаписваме метода .ToString()
    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }
}
