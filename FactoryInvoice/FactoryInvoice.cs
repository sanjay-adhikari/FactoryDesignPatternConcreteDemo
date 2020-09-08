using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoiceInterface;
using Invoice;



namespace FactoryInvoice
{
    public class clsFactoryInvoice
    {
        static public Iinterface GetIinvoice(int invoiceType) {
            Iinterface iinterface;
            if (invoiceType == 1)
            {
                iinterface = new InvoiceWithHeader();
            }
            else if (invoiceType == 2)
            {
                iinterface = new InvoiceWithoutHeader();
            }
            else {
                return null;
            }
            return iinterface;
        }
    }
}
