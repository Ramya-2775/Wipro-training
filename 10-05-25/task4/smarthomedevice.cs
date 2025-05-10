using System;
class smartdevice
{
    public string devicename;
    public bool powerstatus;
    public void togglepower()
    {
        powerstatus = !powerstatus;
        Console.WriteLine($"{devicename} is {(powerstatus ? "ON" : "OFF")}");
    }

}
class smartlight : smartdevice
{
    public int brightness;
    public void setbrightness(int level)
    {
        brightness = level;
        Console.WriteLine($"{devicename} brightness:{brightness}");
    }
}
class smartthermostat : smartdevice
{
    public double temperature;
    public void settemperature(double level)
    {
        temperature = level;
        Console.WriteLine($"{devicename} temperature :{temperature}");
    }
    
}
class program
{
    static void Main()
    {
        smartlight light = new smartlight();
        light.devicename = "hall light";
        light.togglepower();
        light.setbrightness(80);

        smartthermostat smartthermostat = new smartthermostat();
        smartthermostat.devicename = "hall thermostat";
        smartthermostat.togglepower();
        smartthermostat.settemperature(30.5);
    }
}