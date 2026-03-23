namespace UczelnianaWypozyczalniaSprzetuProjekt.Models;

public class Projektor : Przedmioty
{
    public int BrightnessLumens { get; set; }
    public bool HasHdmi { get; set; }

    public Projektor(string name, int brightnessLumens, bool hasHdmi) : base(name)
    {
        BrightnessLumens = brightnessLumens;
        HasHdmi = hasHdmi;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Type: Projector, Brightness: {BrightnessLumens} lm, HDMI: {HasHdmi}";
    }
}