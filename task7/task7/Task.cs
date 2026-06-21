using System;
using System.Collections.Generic;
using System.Text;

namespace task7
{
    internal class Task : IComparable<Task>
    {
        public int taskId { get; set; }
        public string description { get; set; }
        public int priority { get; set; }

        public Task(int taskId, string description, int priority)
        {
            this.taskId = taskId;
            this.description = description;
            this.priority = priority;
        }

        public int CompareTo(Task? other)
        {       
           return this.priority.CompareTo(other?.priority);
        }
        
    }
}
