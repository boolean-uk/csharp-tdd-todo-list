using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        public TodoListExtension() { }


        private List<int> tasksIDList = new List<int>();
        private Dictionary<int, string> _taskNames = new Dictionary<int, string>();
        private Dictionary<int, string> _timestamps = new Dictionary<int, string>();
        private Dictionary<int, bool> _taskCompletion = new Dictionary<int, bool>();

        public Dictionary<int, string> addTask(string v)
            {
                //adding unique id
              int id = tasksIDList.Count;
            DateTime timeStamp = DateTime.Now;
            string time = timeStamp.ToLocalTime().ToString();
            tasksIDList.Add(id);
            _taskNames.Add(id, v);
            _timestamps.Add(id, time);
            _taskCompletion.Add(id, false);

               return _taskNames;
            }

        public Dictionary<int, string> addTask(string v,bool status)
        {
            //adding unique id
            int id = tasksIDList.Count;
            DateTime timeStamp = DateTime.Now;
            string time = timeStamp.ToLocalTime().ToString();
            tasksIDList.Add(id);
            _taskNames.Add(id, v);
            _timestamps.Add(id, time);
            _taskCompletion.Add(id, status);

            return _taskNames;
        }

        public string[] getTaskById(int id)
        {
            string[] task =
            [
                tasksIDList[id].ToString(),
                _taskNames[id],
                _timestamps[id].ToString(),
                _taskCompletion[id].ToString(),
            ];
            
            return task;
        }

        public string[] changeName(int id, string name)
        {
            _taskNames[id] = name;
            return getTaskById(id);
        }

        public string[] changeTaskStatus(int id)
        {
            if (_taskCompletion[id]==true)
            {
                _taskCompletion[id] = false;
            }
            else { _taskCompletion[id] = true; }
            
            return getTaskById(id);
        }

        public string getTimeStamp(int id)
        {
            return _timestamps[id];
            
        }

        public List<int> Tasks { get{ return tasksIDList; } }
    public Dictionary<int, string> TaskNames { get { return _taskNames; }set { _taskNames = TaskNames; } }
    public Dictionary<int, string> TaskTime
        {
            get { return _timestamps; } set { _timestamps = value; } }
    public Dictionary<int, bool> TaskCompletion { get { return _taskCompletion; }set { _taskCompletion = value; } }


            }
    public struct Task
    {


        private int _taskID = 0;
        private string _name;
        private string _time;
        private bool _completion = false;
        public Task(string taskName)
        {
            _taskID = 0;
            _name = taskName;
            _time = DateTime.Now.ToString();
            _completion = false;

      }  }
   //     public int TaskID { get { return _taskID; } set { TaskID = value; } }
     //   public string Name { get { return _name; } set { _name = value; } }
       // public string Time { get { return _time; } set { _time = value; } }
   //     public bool Completion { get { return _completion; } set { _completion = value; } }
    
}
   
    


    

    
