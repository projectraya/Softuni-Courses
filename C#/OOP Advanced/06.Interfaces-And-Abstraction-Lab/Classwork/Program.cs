namespace Interfaces_And_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPrintable printable = new Invoice(); // you cannot create a new IPrintable cuz it's abstract
            printable.Print();
            Invoice invoice = new Invoice();

            PrintDocuments(invoice); // 
            PrintDocumentsI(printable); // 

            printable.Print();
            invoice.Print();
            invoice.Hi();

            printable.Print();
            
        }

        public static void PrintDocuments(Invoice doc)
        {//awaits for an implementation of the interface
            doc.Print();
        }

        public static void PrintDocumentsI(IPrintable doc)
        {
            doc.Print();
        }
       
    }
}
