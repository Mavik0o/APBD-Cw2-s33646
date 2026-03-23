namespace UczelnianaWypozyczalniaSprzetuProjekt.Exceptions;


public class EquipmentAlreadyReturnedException(int loanId)
    : Exception($"Loan with id {loanId} has already been returned.");