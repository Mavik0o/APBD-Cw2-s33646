using UczelnianaWypozyczalniaSprzetuProjekt.Enums;
using UczelnianaWypozyczalniaSprzetuProjekt.Models;

namespace UczelnianaWypozyczalniaSprzetuProjekt.Services.Reports;

public class ReportsService
{
    public void PrintSummary(List<Przedmioty> equipment, List<Pozyczka> loans)
    {
        Console.WriteLine("\n===== RAPORT WYPOŻYCZALNI =====");

        Console.WriteLine($"Liczba sprzętów: {equipment.Count}");
        Console.WriteLine($"Dostępne: {equipment.Count(e => e.Status == StatusPrzedmiotow.Available)}");
        Console.WriteLine($"Wypożyczone: {equipment.Count(e => e.Status == StatusPrzedmiotow.Borrowed)}");
        Console.WriteLine($"Niedostępne: {equipment.Count(e => e.Status == StatusPrzedmiotow.Unavailable)}");

        Console.WriteLine($"Liczba wszystkich wypożyczeń: {loans.Count}");
        Console.WriteLine($"Aktywne wypożyczenia: {loans.Count(l => l.IsActive)}");
        Console.WriteLine($"Zwrócone wypożyczenia: {loans.Count(l => l.IsReturned)}");
        Console.WriteLine($"Przeterminowane wypożyczenia: {loans.Count(l => l.IsOverdue)}");

        var totalPenalties = loans.Sum(l => l.Penalty);
        Console.WriteLine($"Łączna kwota kar: {totalPenalties} PLN");
    }
}