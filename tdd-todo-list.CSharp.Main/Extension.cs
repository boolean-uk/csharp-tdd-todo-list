using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.ObjectModel;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        private List<Tuple<int, string, bool, DateTime>> taskList = new List<Tuple<int, string, bool, DateTime>>();
        public bool AddTask(int id, string task, bool status)
        {
            
            

            for(int i = 0; i < taskList.Count; i++) 
            {
                if(taskList[i].Item1 == id)
                {
                    Console.WriteLine("ID already exists");
                    return false;
                }

            }

            taskList.Add((new Tuple<int, string, bool, DateTime>(id, task, status, DateTime.Now)));
            Console.WriteLine("Added task " +  task);
            return true;
        }

        public Tuple<int, string, bool, DateTime> GetTask(int id)
        {
            var temp = new Tuple<int, string, bool, DateTime>(0, "", false, DateTime.Now);
            for (int i = 0; i < taskList.Count; i++)
            {
                if(taskList[i].Item1 == id)
                {
                    temp = taskList[i];
                    break;
                }
                    
            }
            return temp;
        }

        public void ChangeName(int id, string newName)
        {
            for (int i = 0; i < taskList.Count; i++)
            {
                if (taskList[i].Item1 == id)
                {
                    int tempid = taskList[i].Item1;
                    bool tempStatus = taskList[i].Item3;
                    taskList.RemoveAt(i);
                    AddTask(tempid, newName, tempStatus);
                    break;
                }
            }
        }

        public DateTime TimeCreated(int id)
        {
            for (int i = 0; i < taskList.Count; i++)
            {
                if (taskList[i].Item1 == id)
                {
                    return taskList[i].Item4;
                }
            }
            return DateTime.MinValue;


        }

        public void ChangeStatus(int id)
        {
            for (int i = 0; i < taskList.Count; i++)
            {
                if (taskList[i].Item1 == id)
                {
                    int tempid = taskList[i].Item1;
                    string tempName = taskList[i].Item2;
                    bool tempStatus = taskList[i].Item3;
                    taskList.RemoveAt(i);
                    AddTask(tempid, tempName, !tempStatus);
                    break;
                }
            }
        }

        public List<Tuple<int, string, bool, DateTime>> GetList { get { return taskList; }}


    }
}
