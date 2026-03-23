using UczelnianaWypozyczalniaSprzetuProjekt.Models;

namespace UczelnianaWypozyczalniaSprzetuProjekt.PolitykaWypozyczania;

public static class Polityka
{
    public const decimal DailyPenaltyRate = 15m;

    public static int GetLoanLimit(Uzytkownik uzytkownik)
    {
        return uzytkownik.GetLoanLimit();
    }

    public static decimal CalculatePenalty(DateTime dueDate, DateTime returnDate)
    {
        var daysLate = (returnDate.Date - dueDate.Date).Days;
        if (daysLate <= 0)
            return 0;
        return daysLate * DailyPenaltyRate;
    }
}