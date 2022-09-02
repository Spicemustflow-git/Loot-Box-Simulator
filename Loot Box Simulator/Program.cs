
namespace Loot_Box_Simulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var newBox = new LootBox();
            Console.WriteLine(newBox.Rarity);
            Console.WriteLine(newBox.ShowRarityInPercent());
            Console.WriteLine(newBox.AmountOfLoot);
        }
    }
}