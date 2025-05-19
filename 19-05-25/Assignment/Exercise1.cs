using System;
abstract class SmartDevice
{
    public abstract void Turnon();
    public void Showstatus()
    {
        Console.WriteLine("Device status:Active");
    }
}
interface Iremotecontrol
    {
        void Increasevolume();
        void Decreasevolume();
    }
class smartlight : SmartDevice, Iremotecontrol
{
    public override void Turnon()
    {
        Console.WriteLine("Smart light turned on");
    }
    public void Increasevolume()
    {
        Console.WriteLine("Lights do not support volume control");
    }
    public void Decreasevolume()
    {
        Console.WriteLine("Lights do not support volume control");
    }
}

class smartspeaker : SmartDevice, Iremotecontrol
{
    public override void Turnon()
    {
        Console.WriteLine("Smart speaker turned on");
    }
    public void Increasevolume()
    {
        Console.WriteLine("Volume increased");
    }
    public void Decreasevolume()
    {
        Console.WriteLine("Volume decreased");
    }
}

class program
{
    static void Main()
    {
        SmartDevice light = new smartlight();
        SmartDevice speaker = new smartspeaker();

        Console.WriteLine("Smartlight");
        light.Showstatus();
        light.Turnon();
        ((Iremotecontrol)light).Increasevolume();
        ((Iremotecontrol)light).Decreasevolume();

        Console.WriteLine("\nSmartspeaker");
        speaker.Showstatus();
        speaker.Turnon();
        ((Iremotecontrol)speaker).Increasevolume();
        ((Iremotecontrol)speaker).Decreasevolume();
    }
}

