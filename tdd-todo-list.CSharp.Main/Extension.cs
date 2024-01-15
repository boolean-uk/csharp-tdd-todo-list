

namespace tdd_todo_list.CSharp.Main
{
    public class Task {
        private string _name;
        private bool _status;
        private DateOnly _date;

        public Task(string task) {
            _name = task;
            _status = false;
            _date = new DateOnly();
        }

        public string Name {get => _name; set { _name = value; }}
        public bool Status {get => _status; set { _status = value; }}
        public DateOnly Date {get => _date;}
    }
    public class Extension
    {
        private Dictionary<int, Task> _todoList;

        public Extension(Dictionary<int, Task> tasks) {
            _todoList = tasks;
        }

        public bool Add(string name) {
            _todoList.Add(_todoList.Count+1, new Task(name));
            return true;
        }

        public Task GetTaskById(int id) {
            if(_todoList.ContainsKey(id))
                return _todoList[id];
            return null;
        }

        public bool UpdateTask(int id, string name) {
            Task task = GetTaskById(id);
            if(task != null) {
                task.Name = name;
                return true;
            }
            return false;
        }
        public bool UpdateTask(int id, string name, bool update) {
            Task task = GetTaskById(id);
            if(task != null) {
                task.Name = name;
                task.Status = update;
                return true;
            }
            return false;
        }
        public bool UpdateTask(int id, bool update) {
            Task task = GetTaskById(id);
            if(task != null) {
                task.Status = update;
                return true;
            }
            return false;
        }


        public bool ChangeStatus(int id, int newStatus) {
            return false;
        }
    }
}
