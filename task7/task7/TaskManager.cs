using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace task7
{
    internal class TaskManager
    {
        Dictionary<int, Task> tasks = new Dictionary<int, Task>();
        Stack<Task> trash = new Stack<Task>();
        public void addTask(Task task)
        {
            tasks.Add(task.taskId, task);
        }   
        public Task getTask(int taskID)
        {
            return tasks[taskID];
        }
        public void removeTask(int taskID)
        {
            trash.Push(tasks[taskID]);
            tasks.Remove(taskID);
        }
        public void unremoveTask()
        {
            Task task = trash.Pop();
            tasks.Add(task.taskId, task);
        }
        public void PrintAllSorted()
        {
            var list = new List<Task>(tasks.Values);
            list.Sort();
            foreach (Task task in list) { 
                Console.WriteLine(task.taskId+" "+task.description+" "+task.priority);
            }
        }

    }
}
