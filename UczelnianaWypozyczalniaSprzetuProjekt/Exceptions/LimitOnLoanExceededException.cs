namespace UczelnianaWypozyczalniaSprzetuProjekt.Exceptions;

public class LoanLimitExceededException(int userId)
    : Exception($"User with id {userId} exceeded the maximum number of active loans.");