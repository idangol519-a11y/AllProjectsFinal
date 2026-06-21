namespace task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskManager tm = new TaskManager();
            tm.addTask(new Task(1, "Task A", 3));
            tm.addTask(new Task(2, "Task B", 1));
            tm.addTask(new Task(3, "Task C", 2));
            tm.addTask(new Task(4, "Task D", 1));
            string useLess = tm.getTask(2).ToString();
            tm.removeTask(3);
            tm.unremoveTask();
            tm.PrintAllSorted();
        }
    }
}
