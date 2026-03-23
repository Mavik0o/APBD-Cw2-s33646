namespace UczelnianaWypozyczalniaSprzetuProjekt.Models;

public abstract class Uzytkownik
{
    private static int _nextId = 1;

    private int Id { get; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    protected Uzytkownik(string firstName, string lastName)
    {
        Id = _nextId++;
        FirstName = firstName;
        LastName = lastName;
    }

    public abstract int GetLoanLimit();
    protected abstract string GetUserType();

    public override string ToString()
    {
        return $"ID: {Id}, {FirstName} {LastName}, Type: {GetUserType()}, Limit: {GetLoanLimit()}";
    }
}