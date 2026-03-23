namespace UczelnianaWypozyczalniaSprzetuProjekt.Exceptions;


public class LoanNotFoundException(int loanId)
    : Exception($"Loan with id {loanId} was not found.");