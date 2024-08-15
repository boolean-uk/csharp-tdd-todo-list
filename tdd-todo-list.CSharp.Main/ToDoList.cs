using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private Dictionary<string, bool> _list = new Dictionary<string, bool>();
        public Dictionary<string, bool> List { get { return _list; } }

        public string addTask(string taskname, bool status)
        {
            _list.Add(taskname, status);
            if (_list.ContainsKey(taskname))
            {
                return "Task is added";
            }
            return "Not added any task";


        }

        public Dictionary<string, bool> viewAllTasks()
        {
            return _list;
        }

        public void changeStatus(string task1, bool status)
        {
            _list[task1] = status;
        }




        public Dictionary<string, bool> takeCompleteTask()
        {
            Dictionary<string, bool> completedtasks = new Dictionary<string, bool>();


            foreach (var task in _list)
            {
                if (task.Value == true)
                {
                    completedtasks.Add(task.Key, task.Value);
                }


            }

            return completedtasks;
        }

        public Dictionary<string, bool> takeNotCompleteTask()
        {
            Dictionary<string, bool> uncompletedtasks = new Dictionary<string, bool>();

            foreach (var task in _list)
            {
                if (task.Value == false)
                {
                    uncompletedtasks.Add(task.Key, task.Value);
                }
            }
            return uncompletedtasks;
        }

        public bool searchTask(string notexisting)
        {
            

            if (_list.ContainsKey(notexisting))
            {
                return true;
            } else
            {
                return false;
                
            }
           /* foreach (var item in _list)
            
 
                if (item.Key. != notexisting)
                {

                    resultat = "string found";
                }
                else
                {
                    resultat = "string not found";
                }

            }
           */
            
        }

        public string removeTask(string firsttask)
        {
            string resultat = "";
            foreach (var task in _list)
            {
                if (task.Key == firsttask)
                {
                    _list.Remove(task.Key);
                    resultat = "Task is removed";
                }
                else
                {
                    resultat = "Task is not removed";
                }
               
            }
            return resultat;
        }

        public Dictionary<string, bool> viewTasksAsc()
        {
            var ordered = _list.OrderBy(task => task.Key).ToDictionary(x => x.Key, x=> x.Value);
            return ordered;
        }

        public Dictionary<string, bool> viewTasksDesc()
        {
            var orderdesc = _list.OrderByDescending(task => task.Key).ToDictionary(x => x.Key, x=> x.Value);
            return orderdesc;
        }
    }
}
   

