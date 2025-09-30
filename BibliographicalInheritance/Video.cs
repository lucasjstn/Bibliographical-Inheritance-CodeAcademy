using System;

namespace BiblioInheritance
{
    class Video : Resource
    {
        public string Director { get; protected set; }
        public int Runtime { get; protected set; }
        public string MediaType { get; protected set; }

        public Video(string director, int runtime, string mediaType, string title, string category)
            : base(title, category)
        {
            Director = director;
            Runtime = runtime;
            MediaType = mediaType;
        }

        public override void UpdateStatus() { }
    }
}
