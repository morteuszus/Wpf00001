using System;

namespace Wpf00001.Core
{
    internal class IssueDto
    {
         
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Priority Priority { get; set; }
        public IssueType Type { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? CompletedDate { get; set; }

    }

    public enum Priority
    {
        Low,
        Medium,
        High
    }
    public enum IssueType
    {
        Feature,
        Bug,
        Documeentation
    }
}
