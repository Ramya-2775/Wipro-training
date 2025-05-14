using System;
namespace foodordering
{
    abstract class foodorder
    {
        public abstract void placeorder(string item);

        public void orderinfo()
        {
            Console.WriteLine("placing food order");
        }
    }

    class fastfoodorder : foodorder
    {
        public override void placeorder(string item)
        {
            Console.WriteLine($"order placed for {item} at fastfood outlet");
        }
    }

    class finediningorder : foodorder
    {
        public override void placeorder(string item)
        {
            Console.WriteLine($"order placed for {item} at fine dininng restaurant ");
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            foodorder fastfood = new fastfoodorder();
            foodorder finedining = new finediningorder();

            fastfood.orderinfo();
            fastfood.placeorder("Biryani");
            Console.WriteLine();

            finedining.orderinfo();
            finedining.placeorder("Chicken");
            
        }
    }
}