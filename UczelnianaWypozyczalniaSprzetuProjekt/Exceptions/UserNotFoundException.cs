namespace UczelnianaWypozyczalniaSprzetuProjekt.Exceptions;

public class UserNotFoundException(int userId)
    : Exception($"Uzytkownik o id {userId} zostal nie znaleziony.");