using System;

class Program
{
    static void Main(string[] args)
    {
        KodePos kp = new KodePos();
        Console.WriteLine("Kode Pos Batununggal: " + kp.GetKodePos("Batununggal"));
        Console.WriteLine("Kode Pos Kujangsari: " + kp.GetKodePos("Kujangsari"));

        Console.WriteLine();

        DoorMachine pintu = new DoorMachine();
        pintu.BukaPintu();
        pintu.KunciPintu();
    }
}