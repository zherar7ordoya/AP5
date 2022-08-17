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
 *  (Ver ejemplo en C# 9.0 IN A NUTSHELL, p183)
 */

// .NET Framework 4.7.2
// C# 7.3

using static System.Console;

namespace Interfaces
{
    class Program
    {
        static void Main()
        {
            int[] values = { 1, 2, 3 };
            Util.TransformAll(values, new Squarer());
            foreach (int i in values) { Write(i + "  "); }         // 1   4   9
            ReadKey();
        }
    }

    // ================================INTERFAZ================================

    public interface ITransformer
    {
        int Transform(int x);
    }

    // ==================================UTIL==================================

    public class Util
    {
        public static void TransformAll(int[] values, ITransformer t)
        {
            for (int i = 0; i < values.Length; i++) { values[i] = t.Transform(values[i]); }
        }
    }

    //=================================SQUARER=================================

    class Squarer : ITransformer
    {
        public int Transform(int x) => x * x;
    }
}
