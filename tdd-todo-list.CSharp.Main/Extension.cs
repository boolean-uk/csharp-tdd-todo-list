using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension : TodoList
    {
        
        public Todo? getTaskById(int id)
        {
            return tasks.Find(t => t.id.Equals(id));
            
        }

        public void updateName(int id, string newDesc)
        {
            int index = tasks.FindIndex(t => t.id.Equals(id));
            if (index != -1) tasks[index].description = newDesc;
        }

        public List<string> getDateTime()
        {
            List<string> dateTimes = new List<string>();
            foreach (var task in tasks)
            {
                
                dateTimes.Add(task.creationDateTime.ToString());
            }
            
            return dateTimes;
        }
    }
}
