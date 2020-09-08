using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoiceInterface;
using FactoryInvoice;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            int invType = 0;
            Iinterface objInterface;
            Console.WriteLine("Enter the invoice type: ");
            invType = Convert.ToInt32(Console.ReadLine());
            objInterface = clsFactoryInvoice.GetIinvoice(invType);
            objInterface.print();
            Console.ReadLine();
        }
    }
}
