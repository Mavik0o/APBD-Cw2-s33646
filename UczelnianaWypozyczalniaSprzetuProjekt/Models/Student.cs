namespace UczelnianaWypozyczalniaSprzetuProjekt.Models;

public class Student : Uzytkownik
{
    public Student(string firstName, string lastName) : base(firstName, lastName)
    {
    }

    public override int GetLoanLimit() => 2;

    public override string GetUserType() => "Student";
}