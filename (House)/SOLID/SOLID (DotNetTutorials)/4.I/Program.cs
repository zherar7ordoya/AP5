using static System.Console;

namespace _4.I
{
    class Program
    {
        static void Main()
        {
        }
    }



    public interface IPrinterTasks
    {
        void Print(string PrintContent);
        void Scan(string ScanContent);
    }
    interface IFaxTasks
    {
        void Fax(string content);
    }
    interface IPrintDuplexTasks
    {
        void PrintDuplex(string content);
    }


    public class HPLaserJetPrinter : IPrinterTasks,
                                     IFaxTasks,
                                     IPrintDuplexTasks
    {
        public void Print(string PrintContent) => WriteLine("Print Done");
        public void Scan(string ScanContent) => WriteLine("Scan content");
        public void Fax(string FaxContent) => WriteLine("Fax content");
        public void PrintDuplex(string PrintDuplexContent) => WriteLine("Print Duplex content");
    }


    class LiquidInkjetPrinter : IPrinterTasks
    {
        public void Print(string PrintContent) => WriteLine("Print Done");
        public void Scan(string ScanContent) => WriteLine("Scan content");
    }



}
