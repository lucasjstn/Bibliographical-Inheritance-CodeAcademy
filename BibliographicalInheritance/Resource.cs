using System;

namespace BiblioInheritance
{
    class Resource
    {
        public string Title { get; private set; }
        public string Category { get; private set; }
        public string Status { get; private set; }

        public Resource(string title, string category)
        {
            Title = title;
            Category = category;
            Status = "Available";
        }

        public void UpdateStatus()
        {
            if (Status == "Out")
            {
                Status = "Available";
            }

            Status = "Out";
        }

        public void GetInfo()
        {
            Console.WriteLine($"Title: {Title}\nCategory: {Category}\nStatus: {Status}");
        }
    }
}
