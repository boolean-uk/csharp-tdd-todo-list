
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System.Globalization;

namespace tdd_todo_list.CSharp.Main
{
    public class Todo
    {
        private Dictionary<string, bool> _todoList = [];

        public bool Add(string todo)
        {
            if (todo is null ) return false;
            if (todo.Length == 0 ) return false;
            _todoList.Add(todo, false);
            return true;
        }
        public bool Remove(string todo)
        {
            if (todo is null ) return false;
            if (todo.Length == 0 ) return false; 
            return _todoList.Remove(todo);
        }
        public bool SearchTodo(string todo)
        {
            if (todo is null) return false;
            return _todoList.ContainsKey(todo);
        }
        public List<string> TodoList() 
        {
            return _todoList.Keys.ToList();
        }
        public bool ChangeTodoStatus(string todo) 
        {
            if (_todoList.TryGetValue(todo, out var value))
            {
                _todoList[todo] = !value;
                return true;
            }
            return false;
        }
        public List<string> GetComplete() 
        {
            List<string> returnList = [];
            foreach (var todo in _todoList)
            {
                if (todo.Value)
                {
                    returnList.Add(todo.Key);
                }
            }
            return returnList;
        }
        public List<string> GetIncomplete()
        {
            List<string> returnList = [];
            foreach (var todo in _todoList)
            {
                if (!todo.Value)
                {
                    returnList.Add(todo.Key);
                }
            }
            return returnList;
        }

        public List<string> OrderByAscending() 
        { 
            throw new NotImplementedException(); 
        }
        public List<string> OrderByDescending() 
        { 
            throw new NotImplementedException(); 
        }
    }
}
