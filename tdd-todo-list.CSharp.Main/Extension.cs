using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension : TodoList
    {
        public void AddEx(string task, int id)
        {
            foreach (TodoTask sss in _todo)
                if (sss._id == id)
                {
                    return;
                }
            _todo.Add(new TodoTask(task, id));
        }
        public void UpdateTask(int id, string task)
        {
            foreach (TodoTask t in _todo)
            {
                if (t._id == id)
                {
                    t._task = task;
                }
            }
        }

        public void ChangeStatusEx(int id)
        {
            foreach (TodoTask t in _todo)
            {
                if (t._id == id)
                {
                    t._completed = !t._completed;
                }
            }
        }

        public string? TimeOfTasks(int id)
        {
            return _todo.First(a => a._id == id)._time;
        }
    }
}
