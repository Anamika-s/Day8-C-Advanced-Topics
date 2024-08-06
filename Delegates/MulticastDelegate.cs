namespace Delegates
{
    internal class MulticastDelegate
    {
        // declare a delegate
        delegate void Del(int x, int y);

        static void Main(string[] args)
        {
            // pointers are variables that contains address of other variables
            // delegates are function pointers
            Del del = new Del(Add);
            del += new Del(Difference);
            del += new Del(Product);
            del += new Del(Quotient);
            del(100, 20);
            del -= new Del(Add);
            del(100, 20);

            // delegates can be single cast or multi cast
            // singlecast delegates can point to 1 function at a time
            // multicast delegates can point to multiple functions in a sequence
            // we use += to add functions in a chain
            // we use -= to remove functions in a chain
        }
        static void Add1(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        static void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        static void Difference (int x, int y)
        {
            Console.WriteLine(x - y);
        }
        static void Product(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        static void Quotient(int x, int y)
        {
            Console.WriteLine(x / y);
        }

    }
}
