namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension : TodoList
    {
        public TodoTask GetTask(int id)
        {
            try
            {
                return _tasks[id];
            }
            catch
            {
                throw new Exception("Task not found");
            }
        }
        
        public void SetName(int id, string name)
        {
            _tasks[id].SetName(name);
        }
        
        public void SetStatus(int id, bool status)
        {
            _tasks[id].SetStatus(status);
        }
        
        public DateTime GetDateTimeStamp(int id)
        {
            return _tasks[id].GetDateTimeStamp();
        }
    }
}
