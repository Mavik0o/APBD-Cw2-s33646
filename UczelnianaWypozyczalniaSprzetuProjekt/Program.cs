using UczelnianaWypozyczalniaSprzetuProjekt.Models;
using UczelnianaWypozyczalniaSprzetuProjekt.Services.Equipment;
using UczelnianaWypozyczalniaSprzetuProjekt.Services.Loans;
using UczelnianaWypozyczalniaSprzetuProjekt.Services.Reports;
using UczelnianaWypozyczalniaSprzetuProjekt.Services.Users;

var equipmentService = new EquipmentService();
var usersService = new UsersService();
var loanService = new LoanService();
var reportsService = new ReportsService();

var laptop1 = new Laptop("Dell Latitude 5420", "Intel i5", 16);
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