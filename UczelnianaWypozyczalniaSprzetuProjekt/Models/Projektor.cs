namespace UczelnianaWypozyczalniaSprzetuProjekt.Models;

public class Projektor(string name, int brightnessLumens, bool hasHdmi) : Przedmioty(name)
{
    private int BrightnessLumens { get; set; } = brightnessLumens;
    private bool HasHdmi { get; set; } = hasHdmi;

    public override string ToString()
    {
        return $"{base.ToString()}, Type: Projector, Brightness: {BrightnessLumens} lm, HDMI: {HasHdmi}";
    }
}