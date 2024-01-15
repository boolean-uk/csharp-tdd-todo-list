using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        Dictionary<string, ToDoItem> _items = new Dictionary<string, ToDoItem>();

        public bool Add(string task, out string ID) 
        {
            ID = GenerateID();
            return _items.TryAdd(ID, new ToDoItem(task));
        }

        private string GenerateID() 
        {
            long time = DateTime.Now.Ticks;
            int random = new Random().Next();
            // Combine to make the unique timestamp
            return $"{time}-{random}";
        }

        public ToDoItem RetrieveTask(string ID) 
        {
            return _items.Where(i => i.Key == ID)
                .FirstOrDefault(new KeyValuePair<string, ToDoItem>("1", new ToDoItem("invalid")))
                .Value;
        }

        public bool UpdateTaskName(string ID, string newName) 
        {
            ToDoItem item = RetrieveTask(ID);
            if (item.Name == "invalid")
            {
                return false;
            } else
            {
                item.Name = newName;
                return true;
            }
        }

        public bool ChangeTaskStatus(string ID) 
        {
            ToDoItem item = RetrieveTask(ID);
            if (item.Name == "invalid") 
            {
                return false;
            } 
            else 
            {
                item.Status = !item.Status;
                return true;
            }
            
        }

        public void RetrieveTaskDate() 
        {
            List<KeyValuePair<string, ToDoItem>> items = _items.OrderBy(i => i.Value.RetrieveDateTime()).ToList();
            foreach (KeyValuePair<string, ToDoItem> pair in items) 
            {
                Console.WriteLine($"{pair.Value.RetrieveDateTime()}\t{pair.Value.Name}");
            }
        }
    }
}
