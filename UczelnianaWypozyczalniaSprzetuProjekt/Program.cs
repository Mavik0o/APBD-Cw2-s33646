using UczelnianaWypozyczalniaSprzetuProjekt.Models;
using UczelnianaWypozyczalniaSprzetuProjekt.Services.Equipment;
using UczelnianaWypozyczalniaSprzetuProjekt.Services.Loans;
using UczelnianaWypozyczalniaSprzetuProjekt.Services.Reports;
using UczelnianaWypozyczalniaSprzetuProjekt.Services.Users;

var equipmentService = new EquipmentService();
var usersService = new UsersService();
var loanService = new LoanService();
var reportsService = new ReportsService();

var laptop1 = new Laptop("Dell", "Intel i5", 16);
var laptop2 = new Laptop("Lenovo ThinkPad", "AMD Ryzen 5", 8);
var projector1 = new Projektor("Epson", 3200, true);
var camera1 = new Kamera("Canon", 24, true);
var camera2 = new Kamera("Sony", 20, false);

equipmentService.AddEquipment(laptop1);
equipmentService.AddEquipment(laptop2);
equipmentService.AddEquipment(projector1);
equipmentService.AddEquipment(camera1);
equipmentService.AddEquipment(camera2);

var student1 = new Student("Jan", "Kowalski");
var student2 = new Student("Anna", "Nowak");
var employee1 = new Pracownik("Piotr", "Wisniewski");

usersService.AddUser(student1);
usersService.AddUser(student2);
usersService.AddUser(employee1);

Console.WriteLine("\nCaly sprzet");
foreach (var eq in equipmentService.GetAll())
{
    Console.WriteLine(eq);
}

Console.WriteLine("\nDostepny sprzet");
foreach (var eq in equipmentService.GetAvailable())
{
    Console.WriteLine(eq);
}

try
{
    Console.WriteLine("\nPoprawne wypozyczenie");
    var loan1 = loanService.BorrowEquipment(student1, laptop1, new DateTime(2026, 3, 1), 7);
    Console.WriteLine(loan1);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

equipmentService.MarkUnavailable(projector1.Id);

try
{
    Console.WriteLine("\nProba wypozyczenia niedostepnego sprzetu");
    loanService.BorrowEquipment(student2, projector1, new DateTime(2026, 3, 2), 5);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    Console.WriteLine("\nProba przekroczenia limitu wypozyczen przez studenta");
    var loan2 = loanService.BorrowEquipment(student1, camera1, new DateTime(2026, 3, 2), 5);
    Console.WriteLine(loan2);

    var loan3 = loanService.BorrowEquipment(student1, camera2, new DateTime(2026, 3, 2), 5);
    Console.WriteLine(loan3);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    Console.WriteLine("\nZwrot w terminie");
    loanService.ReturnEquipment(1, new DateTime(2026, 3, 5));
    Console.WriteLine("Pierwsze wypozyczenie zwrocone na czas.");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    Console.WriteLine("\nZwrot opozniony");
    var lateLoan = loanService.BorrowEquipment(employee1, laptop2, new DateTime(2026, 3, 1), 3);
    Console.WriteLine(lateLoan);

    loanService.ReturnEquipment(lateLoan.Id, new DateTime(2026, 3, 10));
    Console.WriteLine($"Wypozyczenie {lateLoan.Id} zwrocone po terminie.");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("\nAktywne wypozyczenia uzytkownika:");
foreach (var loan in loanService.GetActiveLoansForUser(student1.Id))
{
    Console.WriteLine(loan);
}

Console.WriteLine("\nPrzeterminowane wypozyczenia:");
foreach (var loan in loanService.GetOverdueLoans())
{
    Console.WriteLine(loan);
}

reportsService.PrintSummary(equipmentService.GetAll(), loanService.GetAllLoans());