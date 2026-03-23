namespace UczelnianaWypozyczalniaSprzetuProjekt.Exceptions;

public class EquipmentUnavailableException(int equipmentId)
    : Exception($"Equipment with id {equipmentId} is not available for borrowing.");