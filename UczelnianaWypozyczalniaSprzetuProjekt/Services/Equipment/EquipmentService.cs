using UczelnianaWypozyczalniaSprzetuProjekt.Enums;
using UczelnianaWypozyczalniaSprzetuProjekt.Exceptions;
using UczelnianaWypozyczalniaSprzetuProjekt.Models;

namespace UczelnianaWypozyczalniaSprzetuProjekt.Services.Equipment;

public class EquipmentService
{
    private readonly List<Przedmioty> _equipment = [];

    public void AddEquipment(Przedmioty equipment)
    {
        _equipment.Add(equipment);
    }

    public Przedmioty GetById(int id)
    {
        return _equipment.FirstOrDefault(e => e.Id == id)
               ?? throw new EquipmentNotFoundException(id);
    }

    public List<Przedmioty> GetAll()
    {
        return _equipment;
    }

    public List<Przedmioty> GetAvailable()
    {
        return _equipment.Where(e => e.Status == StatusPrzedmiotow.Available).ToList();
    }

    public void MarkUnavailable(int id)
    {
        var equipment = GetById(id);
        equipment.Status = StatusPrzedmiotow.Unavailable;
    }
}