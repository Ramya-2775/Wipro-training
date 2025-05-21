using System;
class program
{
    static void Main(string[] args)
    {
        int n = 3;
        TowerofHanoi(n, 'A', 'B', 'C');
    }
    static void TowerofHanoi(int n , char from, char to,char aux)
    {
        if(n == 1)
        {
            Console.WriteLine($"Move disk 1 from {from} to {to}");
            return;
        }
        TowerofHanoi(n-1, from, to, aux);
        Console.WriteLine($"Move disk from {from} to {to}");
        TowerofHanoi(n-1, from, to, aux);
    }

}