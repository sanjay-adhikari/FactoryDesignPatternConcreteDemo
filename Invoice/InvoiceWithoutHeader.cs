using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoiceInterface;

namespace Invoice
{
    public class InvoiceWithoutHeader:Iinterface
    {
        public void print() {
            Console.WriteLine("I am at Invoice Without Header.");
        }
    }
}
