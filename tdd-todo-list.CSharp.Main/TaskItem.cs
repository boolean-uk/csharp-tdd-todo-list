namespace tdd_todo_list.CSharp.Main
{
    public class TaskItem
    {
        private string _description;
        private bool _completed;
        
        public string Description { get => _description; set => _description = value; }
        public bool IsCompleted { get => _completed; set => _completed = value; }

        //public string DateAndTimeCreated { get; set; }

        public TaskItem(string description, bool isCompleted) 
        {
            _description = description;
            _completed = isCompleted;
        }
    }
}