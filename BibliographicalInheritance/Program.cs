using System;

namespace BiblioInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Resource test = new Resource("title example", "category example");
            test.GetInfo();
            test.UpdateStatus();
            test.GetInfo();
        }
    }
}
