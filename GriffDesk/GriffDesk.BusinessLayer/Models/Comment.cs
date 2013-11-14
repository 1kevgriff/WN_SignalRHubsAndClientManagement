using System;

namespace GriffDesk.BusinessLayer.Models
{
    public class Comment
    {
        public DateTime DateAdded { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }
    }
}