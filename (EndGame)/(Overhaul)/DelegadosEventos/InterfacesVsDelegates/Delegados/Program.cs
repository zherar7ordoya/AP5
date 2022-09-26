/*
 * DELEGATES VERSUS INTERFACES
 * 
 * A problem that you can solve with a delegate can also be solved with an
 * interface. A delegate design might be a better choice than an interface
 * design if one or more of these conditions are true:
 * 
 *  -) The interface defines only a single method.
 *  -) Multicast capability is needed.
 *  -) The subscriber needs to implement the interface multiple times.
 *  
 *  In the  ITransformer  example, we don’t need to multicast. However, the
 *  interface defines only a single method. Furthermore, our subscriber might
 *  need to implement ITransformer multiple times, to support different
 *  transforms,  such  as  square  or cube. With interfaces, we’re forced into
 *  writing a separate type per transform because a class can implement
 *  ITransformer only once:
 *  
 *  (Ver ejemplo en C# 9.0 IN A NUTSHELL, p178)
 */

// .NET Framework 4.8
// C# 7.3

using static System.Console;

namespace Delegados
{

    public delegate int Transformer(int x);


    class Test
    {
        static void Main()
        {
            int[] values = { 1, 2, 3 };
            Util.Transform(values, Square);        // Hook in the Square method
            foreach (int i in values) { Write(i + "  "); }           // 1  4  9
            ReadKey();
        }
        static int Square(int x) => x * x;
    }


    class Util
    {
        public static void Transform(int[] values, Transformer transformer)
        {
            for (int i = 0; i < values.Length; i++) { values[i] = transformer(values[i]); }
        }
    }

}
