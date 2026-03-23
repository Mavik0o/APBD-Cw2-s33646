namespace UczelnianaWypozyczalniaSprzetuProjekt.Models;

public class Pracownik(string firstName, string lastName) : Uzytkownik(firstName, lastName)
{
    public override int GetLoanLimit() => 5;

    public override string GetUserType() => "Pracownik";
}