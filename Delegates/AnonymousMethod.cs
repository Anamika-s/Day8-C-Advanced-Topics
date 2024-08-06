namespace Delegates
{
    internal class AnonymousMethod
    {
        // declare a delegate
        delegate int Del(int x, int y);

        static void Main(string[] args)
        {
            // delegates are used to write anonymous method
            Del del = delegate (int x, int y)
            {
                return x + y;
            };
            Console.WriteLine(del(10,90));
            del = delegate (int x, int y)
            {
                return x - y;
            };
            Console.WriteLine(del(10,90));
        }
        static int Add(int x, int y)
        {
                return x + y;
        }
        }
         
    }

