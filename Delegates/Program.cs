namespace Delegates
{
    internal class Program
    {
        // declare a delegate
        delegate int Del(int x, int y);

        static void Main(string[] args)
        {
            // pointers are variables that contains address of other variables
            // delegates are function pointers
            Del del = new Del(Add);
            Console.WriteLine(del(10, 90));
            del = new Del(Difference);
            Console.WriteLine(del(10, 90));
            del = new Del(Product);
            Console.WriteLine(del(10, 90));
            del = new Del(Quotient);
            Console.WriteLine(del(10, 9));
            //del = new Del(Add1);

            // delegates can be single cast or multi cast
            // singlecast delegates can point to 1 function at a time
            // multicast delegates can point to multiple functions in a sequence
            // we use += to add functions in a chain
            // we use -= to remove functions in a chain
            // also for multicast delegates, return type of all functions shud be void
        }
        static void Add1(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        static int Add(int x, int y)
        {
            return x + y;
        }
        static int Difference (int x, int y)
        {
            return x - y;
        }
        static int Product(int x, int y)
        {
            return x * y;
        }
        static int Quotient(int x, int y)
        {
            return x / y;
        }

    }
}
