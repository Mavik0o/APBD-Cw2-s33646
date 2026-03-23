namespace UczelnianaWypozyczalniaSprzetuProjekt.Models;

public class Student(string firstName, string lastName) : Uzytkownik(firstName, lastName)
{
    public override int GetLoanLimit() => 2;

    protected override string GetUserType() => "Student";
}