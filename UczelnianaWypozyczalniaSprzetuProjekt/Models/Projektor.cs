namespace UczelnianaWypozyczalniaSprzetuProjekt.Models;

public class Projektor(string name, int brightnessLumens, bool hasHdmi) : Przedmioty(name)
{
    public int BrightnessLumens { get; set; } = brightnessLumens;
    public bool HasHdmi { get; set; } = hasHdmi;

    public override string ToString()
    {
        return $"{base.ToString()}, Typ: Projector, Jasność: {BrightnessLumens} lm, HDMI: {HasHdmi}";
    }
}