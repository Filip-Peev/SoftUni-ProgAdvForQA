internal class Student
{
    // fields -> полета, характеристики на класа
    private string firstName;
    private string lastName;
    private double grade;

    // properties -> дава ни достъп до полетата
    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }
    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }
    public double Grade
    {
        get { return grade; }
        set { grade = value; }
    }

    // constructor -> метод, чрез който създаваме обекти от класа
    public Student (string firstName, string lastName, double grade)
    {
        FirstName = firstName;
        LastName = lastName;
        Grade = grade;
    }
}
