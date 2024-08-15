
namespace tdd_todo_list.CSharp.Main
{
    public class Todo
    {
        private Dictionary<string, bool> _todoList = [];
        public Dictionary<int, string> TodoIDList { get {return _todoList.ToDictionary(x => x.Key.GetHashCode(), x=> x.Key);} }
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
            if (todo == emptyString.GetHashCode()) return false;
            bool result = TodoIDList.ContainsKey(todo);
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

        public bool UpdateTodo(int id, string newName) 
        {
            if (newName.Length == 0) return false;
            if (TodoIDList.TryGetValue(id, out var value)) 
            {
                Remove(value);
                Add(newName);
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
