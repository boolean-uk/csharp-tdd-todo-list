namespace tdd_todo_list.CSharp.Main
{
    public class TodoTask
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
        public DateTime creationTime { get; set; }
        public TodoTask(string taskName)
        {
            Id = Guid.NewGuid().ToString();
            Name = taskName;
            IsComplete = false;
            creationTime = DateTime.Now;
        }
    }
}
