// Written by Jay Gunderson
// 07/14/2024

namespace Labeling_Inventory__Polymorphism__Page_209_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pack aPack = new Pack(10, 15, 15);

            Sword aSword = new Sword();
            Bow aBow = new Bow();
            Rope aRope = new Rope();
            Water _water = new Water();

            aPack.AddItem(aSword);
            aPack.AddItem(aBow);
            aPack.AddItem(aRope);
            Console.WriteLine(aPack.ToString());
        }
    }
}
