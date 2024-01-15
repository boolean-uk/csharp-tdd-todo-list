using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        private List<TodoTaskExstension> _tasks = [];
        public List<TodoTaskExstension> Tasks { get { return _tasks; } set { _tasks = value; } }

        public void AddTask(TodoTaskExstension task)
        {
            if(!Tasks.Contains(task))
            {
                Tasks.Add(task);
            }
        }

        public TodoTaskExstension GetTaskByID(Guid id)
        {
            return Tasks.Find(x => x.Id == id); 
        }

        public void ChangeNameByID(Guid id, string newName)
        {
            var result = GetTaskByID(id);
            if(result != null)
            {
                result.Name = newName;
            }
        }

        public void ChangeStatusByID(Guid id)
        {
            var result = GetTaskByID(id);
            if(result != null)
            {
                result.ToggleStatus();
            }
        }
    }

    public class TodoTaskExstension
    {
        private bool _status = false;
        private Guid _id;
        private string _name;
        private string _description;
        private static DateTime _created = DateTime.Now;

        public TodoTaskExstension(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public void ToggleStatus()
        {
            _status = !_status;
        }

        public bool Status { get { return _status; } set { _status = value; } }
        public Guid Id { get { return _id; } }
        public string Name { get { return _name; } set { _name = value;  } }
        public string Description { get { return _description;} set { _description = value; } } 
        public DateTime Created { get { return _created; } }
    }
}
