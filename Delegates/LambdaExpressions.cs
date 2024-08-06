namespace Delegates
{
    internal class LambdaExpressions
    {
        // declare a delegate
        delegate int Del(int x, int y);

        static void Main(string[] args)
        {
            // delegates are used to write anonymous method
            Del del = (x, y) => x + y;
             
            Console.WriteLine(del(10,90));
            // Lambda Expression
            //(input) => ouput
            del = (x, y)=>
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

