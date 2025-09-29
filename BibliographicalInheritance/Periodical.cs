using System;

namespace BiblioInheritance
{
    class Periodical : Resource
    {
        public string Period { get; private set; }

        public Periodical(string title, string category, string period)
            : base(title, category)
        {
            Period = period;
            Status = "Available";
        }

        public override void UpdateStatus()
        {
            if (Status == "In-use")
            {
                Status = "Available";
            }

            Status = "In-use";
        }
    }
}
