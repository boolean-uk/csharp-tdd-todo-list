namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        public List<TodoTask> tasks { get; set; }
        public TodoListExtension()
        {
            tasks = new();
        }
    }
}
