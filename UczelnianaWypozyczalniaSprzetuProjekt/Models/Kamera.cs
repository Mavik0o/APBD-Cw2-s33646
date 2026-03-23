namespace UczelnianaWypozyczalniaSprzetuProjekt.Models;

public class Kamera : Przedmioty
{
    private int ResolutionMp { get; set; }
    private bool IsDslr { get; set; }

    private Kamera(string name, int resolutionMp, bool isDslr) : base(name)
    {
        ResolutionMp = resolutionMp;
        IsDslr = isDslr;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Type: Camera, Resolution: {ResolutionMp} MP, DSLR: {IsDslr}";
    }
}