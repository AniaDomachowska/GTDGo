using System;
using System.Collections.Generic;

namespace GTDGo.Repository.Model
{
    public class Task : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<TaskContext> ContextList { get; set; }
        public int TimeEffort { get; set; }
        public int Energy { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public int Priority { get; set; }
    }
}