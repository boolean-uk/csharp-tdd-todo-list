using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        private int _idCounter = 0;
        private Dictionary<int, TodoTask> _todoList { get; set; } = new Dictionary<int, TodoTask>();

        public void Add(string taskName)
        {
            TodoTask task = new TodoTask(taskName);
            _todoList.Add(_idCounter, task);
            _idCounter++;
        }

        public string GetTask(int v) => _todoList[v]._name;

    }
}
