namespace tdd_todo_list.CSharp.Main
{
    public class ToDoTask
    {
        public string Id {get; set;}
        public string Name {get; set;}
        public bool IsComplete {get; set;}
        public DateTime CreatedAt {get; set;}
        public ToDoTask(string name) {
        
            this.Name = name;
            this.IsComplete = false;
            this.CreatedAt = DateTime.Now;
            this.Id = Guid.NewGuid().ToString();
        }

        public void CompleteTask()
        {
            this.IsComplete = true;
        }
    }
}
