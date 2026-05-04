class Program
{
    static void Main()
    {
        KodePos kp = new KodePos();
        Console.WriteLine(kp.getKodePos("Batununggal"));

        DoorMachine pintu = new DoorMachine();

        pintu.BukaPintu();
        pintu.KunciPintu();
    }
}