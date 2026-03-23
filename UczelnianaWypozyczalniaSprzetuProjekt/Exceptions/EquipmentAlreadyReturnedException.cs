namespace UczelnianaWypozyczalniaSprzetuProjekt.Exceptions;


public class EquipmentAlreadyReturnedException(int loanId)
    : Exception($"Wypozyczenie z id {loanId} zostalo juz zwrocone.");