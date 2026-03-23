namespace UczelnianaWypozyczalniaSprzetuProjekt.Models;

public class Pozyczka
{
    private static int _nextId = 1;

    public int Id { get; }
    public Uzytkownik User { get; }
    public Przedmioty Equipment { get; }
    public DateTime BorrowDate { get; }
    public DateTime DueDate { get; }
    public DateTime? ReturnDate { get; private set; }
    public decimal Penalty { get; private set; }

    public bool IsReturned => ReturnDate.HasValue;
    public bool IsActive => !IsReturned;
    public bool IsOverdue => !IsReturned && DateTime.Now.Date > DueDate.Date;

    public Pozyczka(Uzytkownik user, Przedmioty equipment, DateTime borrowDate, DateTime dueDate)
    {
        if (dueDate < borrowDate)
            throw new ArgumentException("Data do nie moze byc wczesniejsza niz data od");

        Id = _nextId++;
        User = user;
        Equipment = equipment;
        BorrowDate = borrowDate;
        DueDate = dueDate;
        Penalty = 0;
    }

    public void Return(DateTime returnDate, decimal penalty)
    {
        if (IsReturned)
            throw new InvalidOperationException("Juz zwrocono wypozyczenie.");

        ReturnDate = returnDate;
        Penalty = penalty;
    }

    public override string ToString()
    {
        var returnInfo = IsReturned
            ? $"Zwrocono: {ReturnDate:yyyy-MM-dd}, Kara: {Penalty} PLN"
            : "nie zwrocono jeszcze";

        return $"Wypozyczenie ID: {Id}, Uzytkownik: {User.FirstName} {User.LastName}, Przedmiot: {Equipment.Name}, Pozyczono: {BorrowDate:yyyy-MM-dd}, Do: {DueDate:yyyy-MM-dd}, {returnInfo}";
    }
}