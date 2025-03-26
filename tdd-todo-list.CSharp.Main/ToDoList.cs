using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        public Dictionary<string, string> _toDoList = new Dictionary<string, string>();


        /// <summary>
        /// This method make it possible to add task to the toDoList.
        /// </summary>
        /// <param name="taskName"> Name of the task to add </param>
        public Dictionary<string, string> addTask(string taskName)
        {
            _toDoList.Add(taskName, "incompleted");
            return _toDoList;
        }


        /// <summary>
        /// This method is used to display task based on sorting option.
        /// Available options: completed,incompleted,ascending,descending 
        /// </summary>
        /// <param name="sorting"> order method </param>
        /// <returns> the list of the task</returns>
        /// <exception cref="NotImplementedException"></exception>
        public List<string> showTask(string sorting)
        {
            List<string> outputList;
            // By status completed
            if (sorting.ToLower() == "completed")
            {
                //_toDoList.Foreach(pairTask => {pairTask. })
                outputList = _toDoList.OrderBy(x => x.Value).Select(x => x.Key).ToList();
                return outputList;
            }

            // By status incompleted
            else if (sorting.ToLower() == "incompleted")
            {
                outputList = _toDoList.OrderByDescending(x => x.Value).Select(x => x.Key).ToList();
                return outputList;
            }


            // By ascending order
            else if (sorting.ToLower() == "ascending")
            {
                outputList = _toDoList.OrderBy(x => x.Key).Select(x => x.Key).ToList();
                return outputList;
            }

            // By descending order
            else if (sorting.ToLower() == "descending")
            {
                outputList = _toDoList.OrderByDescending(x => x.Key).Select(x => x.Key).ToList();
                return outputList;
            }

            else
            {
                throw new Exception("incorrect sorting type");
            }
        }


        /// <summary>
        /// This method changing the status of the input taskName to newStatus
        /// </summary>
        /// <param name="taskName"> Task that the user wants to change the status</param>
        /// <param name="newStatus"> The new status of the task</param>
        public void changeStatus(string taskName, string newStatus)
        {
            /*foreach (var item in _toDoList)
            {
                if (item.Key == taskName)
                {
                    item.Value = newStatus;
                }
            }*/

            if (_toDoList.ContainsKey(taskName)) {
                _toDoList[taskName] = newStatus;
                }
            else
            {
                throw new Exception("no task");
            }
        }

        /// <summary>
        /// This method is used to look up the task.
        /// </summary>
        /// <param name="taskName"> The task user wants to look up</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public string searchingTask(string taskName)
        {
            if (_toDoList.ContainsKey(taskName))
            {
                return "In the toDoList";
            }
            else
            {
                return "it wasn't found";
            }
        }

        /// <summary>
        /// This method is used to remove task from toDoList
        /// </summary>
        /// <param name="taskName"></param>
        public void removeTask(string taskName)
        {
            if (_toDoList.ContainsKey(taskName))
            {
                _toDoList.Remove(taskName);
            }
            else
            {
                throw new Exception("no task");
            }

        }





    }
}
