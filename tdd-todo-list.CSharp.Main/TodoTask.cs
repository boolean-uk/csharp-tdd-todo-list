namespace tdd_todo_list.CSharp.Main
{
    public class TodoTask
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
        public TodoTask(string taskName)
        {
            Name = taskName;
            IsComplete = false;
        }
    }
}
