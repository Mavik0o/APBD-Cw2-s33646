namespace UczelnianaWypozyczalniaSprzetuProjekt.Models;

public class Laptop(string name, string cpu, int ramGb) : Przedmioty(name)
{
    public string Cpu { get; set; } = cpu;
    public int RamGb { get; set; } = ramGb;

    public override string ToString()
    {
        return $"{base.ToString()}, Type: Laptop, CPU: {Cpu}, RAM: {RamGb} GB";
    }
}