namespace UczelnianaWypozyczalniaSprzetuProjekt.Exceptions;

public class EquipmentNotFoundException(int equipmentId)
    : Exception($"Equipment with id {equipmentId} was not found.");