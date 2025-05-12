using System;
using System.Reflection.Metadata;
    interface idevicecontrol
{
    void turnon();
    void turnoff();

}
class smartTV : idevicecontrol
{
    public void turnon()
    {
        Console.WriteLine("smart tv is ON");
    }
    public void turnoff()
    {
        Console.WriteLine("smart tv is OFF");
    }

}
class speaker : idevicecontrol
{
    public void turnon()
    {
        Console.WriteLine("speaker is now ON");
    }
    public void turnoff()
    {
        Console.WriteLine("speaker is now OFF");
    }
}
class program
{
    static void Main()
    {
        idevicecontrol tv = new smartTV();
        idevicecontrol speaker = new speaker();

        tv.turnon();
        speaker.turnon();

        tv.turnoff();
        speaker.turnoff();
    }
}

