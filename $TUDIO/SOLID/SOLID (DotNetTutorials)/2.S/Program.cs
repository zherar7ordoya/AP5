using System;

namespace _2.O
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice FInvoice = new FinalInvoice();
            Invoice PInvoice = new ProposedInvoice();
            Invoice RInvoice = new RecurringInvoice();

            double FInvoiceAmount = FInvoice.GetInvoiceDiscount(10000);
            double PInvoiceAmount = PInvoice.GetInvoiceDiscount(10000);
            double RInvoiceAmount = RInvoice.GetInvoiceDiscount(10000);

            Console.WriteLine(FInvoiceAmount.ToString());
            Console.WriteLine(PInvoiceAmount.ToString());
            Console.WriteLine(RInvoiceAmount.ToString());

            Console.ReadKey();
        }
    }
}
