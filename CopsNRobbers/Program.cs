namespace CopsNRobbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) // Gfx display loop
            {
                // Single color graphics
            Gfx.DrawRobberySingleCol();
            Console.WriteLine();
            Gfx.DrawBustedSingleCol();
            Console.WriteLine();
            Console.ReadKey();

                // Dual color graphics
            Console.Clear();
            Gfx.DrawRobbery();
            Console.WriteLine();
            Gfx.DrawBusted();
            Console.WriteLine();
            Console.ReadKey();
            }
        }
    }
}