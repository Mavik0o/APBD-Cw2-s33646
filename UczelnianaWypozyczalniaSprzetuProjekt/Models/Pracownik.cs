namespace UczelnianaWypozyczalniaSprzetuProjekt.Models;

public class Employee : Uzytkownik
{
    public Employee(string firstName, string lastName) : base(firstName, lastName)
    {
    }

    public override int GetLoanLimit() => 5;

    public override string GetUserType() => "Employee";
}