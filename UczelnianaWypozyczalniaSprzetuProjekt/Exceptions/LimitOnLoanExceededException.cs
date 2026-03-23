namespace UczelnianaWypozyczalniaSprzetuProjekt.Exceptions;

public class LoanLimitExceededException(int userId)
    : Exception($"Uzytkownik z id {userId} przekroczyl swoj limit wypozyczen");