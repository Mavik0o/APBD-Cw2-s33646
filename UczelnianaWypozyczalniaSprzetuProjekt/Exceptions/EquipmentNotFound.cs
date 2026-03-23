namespace UczelnianaWypozyczalniaSprzetuProjekt.Exceptions;

public class EquipmentNotFoundException(int equipmentId)
    : Exception($"Przedmiot z id {equipmentId} nie zostal znaleziony.");