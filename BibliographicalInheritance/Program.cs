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

            Book bookTest = new Book(
                title: "Code",
                pageCount: 396,
                author: "Charles Petzold",
                category: "Non Fiction"
            );

            bookTest.GetInfo();

            Periodical p = new Periodical(
                title: "Wired",
                category: "Technology",
                period: "Monthly"
            );

            p.UpdateStatus();
        }
    }
}
