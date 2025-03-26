namespace tdd_todo_list.CSharp.Main
{

    public class task
    {
        private int _id;
        private string _name;
        private bool _status;
        private DateTime _date = DateTime.Now;

        public task(string name, int id)
        {
            _date = DateTime.Now;
            _id = id;
            _name = name;
            _status = false;
        }

        public int Id
        {

            get
            { return _id; }

            set
            { _id = value; }
        }

        public string Name { get => _name; set { _name = value; } }

        public bool Status { get => _status; set { _status = value; } }

        public DateTime Date { get { return _date; }  }
    }
    public class TodoListExtension
    {
        public Dictionary<int, task> toDoList = new Dictionary<int, task>();

        public void Add(int inputId, string inputTaskName)
        {
            toDoList.Add(inputId, new task(inputTaskName, inputId));

        }

        public string getTask(int id)
        {

            if (toDoList.ContainsKey(id))
            {
                return toDoList[id].Name;
            }

            else
            {

                return null;
            }
        }

        public void upDateName(int id, string newName) {
            if (toDoList.ContainsKey(id))
            {
                toDoList[id].Name = newName;
                //return toDoList[id].Name;

            }
            else {
                throw new Exception("no task ID");
            }
        }

        public bool getStatus(int id)
        {
            if (toDoList.ContainsKey(id))
            {
                return toDoList[id].Status;
                //return toDoList[id].Name;

            }
            else
            {
                throw new Exception("no task ID");
            }
        }
        public void upDateStatus(int id, bool newStatus)
        {
            if (toDoList.ContainsKey(id))
            {
                toDoList[id].Status = newStatus;
                //return toDoList[id].Name;

            }
            else
            {
                throw new Exception("no task ID");
            }
        }

        public Dictionary<string, DateTime> getDatesInfo() {
            Dictionary<string, DateTime> result = new Dictionary<string, DateTime>();
            foreach (var kvp in toDoList)
            {
                result.Add(kvp.Value.Name, kvp.Value.Date);
                
            }
            return result;
        }

        public DateTime getDates(int id)
        {
            if (toDoList.ContainsKey(id))
            {
              

                return toDoList[id].Date;
                //return toDoList[id].Name;

            }
            else
            {
                throw new Exception("no task ID");
            }
        }

    }
}
