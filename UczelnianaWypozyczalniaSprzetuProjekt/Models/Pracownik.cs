namespace UczelnianaWypozyczalniaSprzetuProjekt.Models;

public class Employee(string firstName, string lastName) : Uzytkownik(firstName, lastName)
{
    public override int GetLoanLimit() => 5;

    protected override string GetUserType() => "Employee";
}