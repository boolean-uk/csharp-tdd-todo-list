
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System.Collections.Immutable;
using System.Globalization;

namespace tdd_todo_list.CSharp.Main
{
    public class Todo
    {
        private Dictionary<string, bool> _todoList = [];
        private Dictionary<string, DateTime> _todoCreation = [];

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
        public bool SearchTodo(int todo)
        {
            string emptyString = "";
            bool result = false;
            if (todo == emptyString.GetHashCode()) return false;
            foreach(var item in _todoList) 
            {
                if(item.Key.GetHashCode() == todo) result = true;
            }
            return result;
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

        public bool ChangeTodoStatus(int todo) 
        {
            throw new NotImplementedException();
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
        public List<Tuple<string, DateTime>> GetCreationDateList()
        {
            throw new NotImplementedException();
        }

        public List<string> OrderByAscending() 
        { 
            _todoList.OrderBy(x => x.Key);
            return _todoList.Keys.Order().ToList();
        }
        public List<string> OrderByDescending() 
        {
            return _todoList.Keys.OrderDescending().ToList();
        }
    }
}
