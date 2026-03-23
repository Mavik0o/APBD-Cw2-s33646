using UczelnianaWypozyczalniaSprzetuProjekt.Enums;

namespace UczelnianaWypozyczalniaSprzetuProjekt.Models;

public abstract class Przedmioty
{
    private static int _nextId = 1;

    private int Id { get; }
    public string Name { get; set; }
    private StatusPrzedmiotow Status { get; set; }

    protected Przedmioty(string name)
    {
        Id = _nextId++;
        Name = name;
        Status = StatusPrzedmiotow.Available;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Name: {Name}, Status: {Status}";
    }
}