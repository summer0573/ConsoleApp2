namespace ConsoleApp1
{
    class Math
    {
        public static int abs(int i)
        {
            return 0;
        }
    }
    internal class FileClass
    {
        static void Main(string[] args)
        {
            Math.abs(-3);

            OtherClass oc = new OtherClass();

            Console.WriteLine("Hello World");
        }

        class ThridClass
        {

        }
    }
    internal class OtherClass
    {
        public OtherClass()
        {
        }
    }
}
