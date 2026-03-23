namespace UczelnianaWypozyczalniaSprzetuProjekt.Exceptions;


public class LoanNotFoundException(int loanId)
    : Exception($"Wypozyczenie o id {loanId} nie zostalo znalezione.");