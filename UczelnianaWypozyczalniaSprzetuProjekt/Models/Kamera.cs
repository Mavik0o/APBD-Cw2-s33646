namespace UczelnianaWypozyczalniaSprzetuProjekt.Models;

public class Kamera : Przedmioty
{
    public int ResolutionMp { get; set; }
    public bool IsDslr { get; set; }

    public Kamera(string name, int resolutionMp, bool isDslr) : base(name)
    {
        ResolutionMp = resolutionMp;
        IsDslr = isDslr;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Typ: Kamera, Rezolucja: {ResolutionMp} MP, DSLR: {IsDslr}";
    }
}