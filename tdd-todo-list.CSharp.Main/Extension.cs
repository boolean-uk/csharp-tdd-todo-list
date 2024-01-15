using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {

        public List<Tuple<string, bool, int>> _tasks;
        private int count = 0;
        public DateTime[] _date;

        public TodoListExtension()
        {
            _tasks = new List<Tuple<string, bool, int>>();
            _date = new DateTime[20];
        }

        public void Add(string taskName)
        {
            _date[count] = DateTime.Now;
            count++;
            Tuple<string, bool, int> addedTuple = new Tuple<String, bool, int>(taskName, false, count);
            _tasks.Add(addedTuple);


        }

        public void Add(string taskName, bool completed, int id)
        {
            Tuple<string, bool, int> addedTuple = new Tuple<String, bool, int>(taskName, completed, id);
            _tasks.Add(addedTuple);
        }

        public Tuple<string, bool, int> FindTaskByID(int id)
        {
            Tuple<string, bool, int> returnTuple = new Tuple<string, bool, int>("Not found", false, -1);
            foreach (var task in _tasks)

            {
                if (task.Item3 == id)
                {
                    returnTuple = task;
                }
            }
            return returnTuple;


        }

        public void UpdateName(int id, string name)
        {
            Tuple<string, bool, int> returnTuple;// = new Tuple<string, bool, int>("Not found", false, -1);

            foreach (var task in _tasks)
            {
                if (task.Item3 == id)
                {
                    returnTuple = new Tuple<string, bool, int>(name, task.Item2, id);
                    _tasks.Add(returnTuple);
                    _tasks.Remove(task);
                    return;

                }
            }
        }

        public void UpdateStatus(int id, bool val)
        {
            Tuple<string, bool, int> returnTuple;// = new Tuple<string, bool, int>("Not found", false, -1);

            foreach (var task in _tasks)
            {
                if (task.Item3 == id)
                {
                    returnTuple = new Tuple<string, bool, int>(task.Item1, val, id);
                    _tasks.Add(returnTuple);
                    _tasks.Remove(task);
                    return;

                }
            }
        }

        public DateTime findDate(int id)
        {
            DateTime returnDate = DateTime.MinValue;

            foreach (var task in _tasks)
            {
                if(task.Item3 == id)
                {
                    returnDate = _date[id - 1];
                }
            }

            return returnDate;
        }













            /*     public Dictionary<string, bool> _taskDictionary;
                 public TodoListExtension()
                 {
                     _taskDictionary = new Dictionary<string, bool>();
                 }

                 public void Add(string taskName)
                 {
                     _taskDictionary.Add(taskName, false);
                 }

                 public string Remove(string task1)
                 {
                     if (_taskDictionary.ContainsKey(task1))
                     {
                         _taskDictionary.Remove(task1);
                         return task1;
                     }
                     else
                     {
                         return "Could not find task to delete";
                     }
                 }

                 public string Search(string task2)
                 {
                     if (_taskDictionary.ContainsKey(task2))
                     {
                         return task2;
                     }
                     else
                     {
                         return "Task wasn't found";
                     }
                 }

                 public bool SetStatus(string task1)
                 {
                     if (_taskDictionary.ContainsKey(task1))
                     {
                         if (_taskDictionary[task1] == false)
                         {
                             _taskDictionary[task1] = true;
                             return true;
                         }
                         else
                         {
                             _taskDictionary[task1] = false;
                             return true;
                         }

                     }
                     else { return false; }
                 }

                 public string ShowCompleted()
                 {
                     StringBuilder sb = new StringBuilder();

                     foreach (var task in _taskDictionary)
                     {
                         if (task.Value == true)
                         {
                             sb.Append(task.ToString() + "\n");
                         }
                     }

                     if (sb.ToString().Length == 0)
                     {
                         sb.Append("There are no complete tasks");
                     }
                     return sb.ToString();
                 }

                 public string ShowIncomplete()
                 {
                     StringBuilder sb = new StringBuilder();

                     foreach (var task in _taskDictionary)
                     {
                         if (task.Value == false)
                         {
                             sb.Append(task.ToString() + "\n");
                         }
                     }

                     if (sb.ToString().Length == 0)
                     {
                         sb.Append("There are no incomplete tasks");
                     }
                     return sb.ToString();
                 }

                 public void ShowList()
                 {
                     if (_taskDictionary.Count > 0)
                     {
                         foreach (var task in _taskDictionary)
                         {
                             Console.WriteLine(task.Key + _taskDictionary[task.Key]);
                         }
                     }
                     else
                     {
                         Console.WriteLine("ToDo List is empty");
                     }
                 }

                 public List<string> ShowAlphabeticalList()
                 {
                     Dictionary<string, bool> dic = _taskDictionary;
                     var list = new List<string>();
                     if (_taskDictionary.Count > 0)
                     {
                         foreach (var task in dic)
                         {
                             list.Add(task.Key);
                         }
                         list.Sort();
                     }

                     return list;

                 }

                 public List<string> ShowDescendingAlphabeticalList()
                 {
                     Dictionary<string, bool> dic = _taskDictionary;
                     var list = new List<string>();
                     if (_taskDictionary.Count > 0)
                     {
                         foreach (var task in dic)
                         {
                             list.Add(task.Key);
                         }
                         list.Sort();
                         list.Reverse();
                     }

                     return list;
                 } */
        }
}
