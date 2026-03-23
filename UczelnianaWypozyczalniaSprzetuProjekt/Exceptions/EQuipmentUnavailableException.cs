namespace UczelnianaWypozyczalniaSprzetuProjekt.Exceptions;

public class EquipmentUnavailableException(int equipmentId)
    : Exception($"Przedmiot z id {equipmentId} jest aktualnie niedostepny do wypozyczenia.");