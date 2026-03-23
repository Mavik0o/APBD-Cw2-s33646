using UczelnianaWypozyczalniaSprzetuProjekt.Enums;
using UczelnianaWypozyczalniaSprzetuProjekt.Exceptions;
using UczelnianaWypozyczalniaSprzetuProjekt.Models;
using UczelnianaWypozyczalniaSprzetuProjekt.PolitykaWypozyczania;

namespace UczelnianaWypozyczalniaSprzetuProjekt.Services.Loans;

public class LoanService
{
    private readonly List<Loan> _loans = [];

    public Loan BorrowEquipment(Uzytkownik user, Przedmioty equipment, DateTime borrowDate, int days)
    {
        if (equipment.Status != StatusPrzedmiotow.Available)
            throw new EquipmentUnavailableException(equipment.Id);

        var activeLoansCount = _loans.Count(l => l.User.Id == user.Id && l.IsActive);
        var limit = Polityka.GetLoanLimit(user);

        if (activeLoansCount >= limit)
            throw new LoanLimitExceededException(user.Id);

        var dueDate = borrowDate.AddDays(days);
        var loan = new Loan(user, equipment, borrowDate, dueDate);

        _loans.Add(loan);
        equipment.Status = StatusPrzedmiotow.Borrowed;

        return loan;
    }

    public void ReturnEquipment(int loanId, DateTime returnDate)
    {
        var loan = _loans.FirstOrDefault(l => l.Id == loanId)
                   ?? throw new LoanNotFoundException(loanId);

        if (loan.IsReturned)
            throw new EquipmentAlreadyReturnedException(loanId);

        var penalty = Polityka.CalculatePenalty(loan.DueDate, returnDate);
        loan.Return(returnDate, penalty);
        loan.Equipment.Status = StatusPrzedmiotow.Available;
    }

    public List<Loan> GetAllLoans()
    {
        return _loans;
    }

    public List<Loan> GetActiveLoansForUser(int userId)
    {
        return _loans.Where(l => l.User.Id == userId && l.IsActive).ToList();
    }

    public List<Loan> GetOverdueLoans()
    {
        return _loans.Where(l => l.IsOverdue).ToList();
    }
}