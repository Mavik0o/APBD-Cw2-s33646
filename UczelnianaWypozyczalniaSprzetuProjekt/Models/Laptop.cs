namespace UczelnianaWypozyczalniaSprzetuProjekt.Models;

public class Laptop(string name, string cpu, int ramGb) : Przedmioty(name)
{
    private string Cpu { get; set; } = cpu;
    private int RamGb { get; set; } = ramGb;

    public override string ToString()
    {
        return $"{base.ToString()}, Type: Laptop, CPU: {Cpu}, RAM: {RamGb} GB";
    }
}