using Atalasoft.Imaging;

namespace Net8AtalaConsole_embedded_licensing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating AtalaImage");

            AtalaImage img = new AtalaImage("images/Tiger.jpg");
            Console.WriteLine("  Size: " + img.Size);
            Console.WriteLine("  Size: " + img.PixelFormat);
            img.Dispose();

            Console.WriteLine("Hit ENTER to quit");
            Console.ReadLine();
        }
    }
}
