namespace UczelnianaWypozyczalniaSprzetuProjekt.Models;

public class Laptop : Przedmioty
{
    public string Cpu { get; set; }
    public int RamGb { get; set; }

    public Laptop(string name, string cpu, int ramGb) : base(name)
    {
        Cpu = cpu;
        RamGb = ramGb;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Type: Laptop, CPU: {Cpu}, RAM: {RamGb} GB";
    }
}