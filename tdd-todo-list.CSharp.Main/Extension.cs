namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension : TodoList
    {

        public Todo? getTaskById(int id)
        {
            return tasks.Find(t => t.Id.Equals(id));

        }

        public void updateName(int id, string newDesc)
        {
            int index = tasks.FindIndex(t => t.Id.Equals(id));
            if (index != -1) tasks[index].Description = newDesc;
        }

        public List<DateTime> getDateTime()
        {
            List<DateTime> dateTimes = new List<DateTime>();
            foreach (var task in tasks)
            {

                dateTimes.Add(task.CreatedAt);
            }

            return dateTimes;
        }
    }
}
