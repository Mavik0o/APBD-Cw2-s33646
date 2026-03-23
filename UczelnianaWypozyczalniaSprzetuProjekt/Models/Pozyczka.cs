namespace UczelnianaWypozyczalniaSprzetuProjekt.Models;

public class Loan
{
    private static int _nextId = 1;

    private int Id { get; }
    private Uzytkownik User { get; }
    private Przedmioty Equipment { get; }
    private DateTime BorrowDate { get; }
    private DateTime DueDate { get; }
    private DateTime? ReturnDate { get; set; }
    private decimal Penalty { get; set; }

    private bool IsReturned => ReturnDate.HasValue;
    public bool IsActive => !IsReturned;
    public bool IsOverdue => !IsReturned && DateTime.Now.Date > DueDate.Date;

    public Loan(Uzytkownik user, Przedmioty equipment, DateTime borrowDate, DateTime dueDate)
    {
        if (dueDate < borrowDate)
            throw new ArgumentException("Due date cannot be earlier than borrow date.");

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
            throw new InvalidOperationException("Loan has already been returned.");

        ReturnDate = returnDate;
        Penalty = penalty;
    }

    public override string ToString()
    {
        var returnInfo = IsReturned
            ? $"Returned: {ReturnDate:yyyy-MM-dd}, Penalty: {Penalty} PLN"
            : "Not returned yet";

        return $"Loan ID: {Id}, User: {User.FirstName} {User.LastName}, Equipment: {Equipment.Name}, Borrowed: {BorrowDate:yyyy-MM-dd}, Due: {DueDate:yyyy-MM-dd}, {returnInfo}";
    }
}