using System;

class DoorMachine
{
    private string state = "Terkunci";

    public void BukaPintu()
    {
        if (state == "Terkunci")
        {
            state = "Terbuka";
            Console.WriteLine("Pintu tidak terkunci");
        }
    }

    public void KunciPintu()
    {
        if (state == "Terbuka")
        {
            state = "Terkunci";
            Console.WriteLine("Pintu terkunci");
        }
    }
}