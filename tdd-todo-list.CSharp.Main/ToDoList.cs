using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private List<TodoTaskObj> taskList;

        public TodoList() {
            taskList = new List<TodoTaskObj>();
        }

        public void AddTaskToList(string text)
        {
            taskList.Add(new TodoTaskObj(text));
        }

        public void AddTaskToList(TodoTaskObj obj)
        {
            taskList.Add(obj);
        }

        public void ChangeObjStatus(TodoTaskObj obj)
        {
            if (taskList.Contains(obj))
            {
                obj.ChangeStatus();
            };
        }
        public void ChangeObjStatus(TodoTaskObj obj, bool b)
        {
            if (taskList.Contains(obj))
            {
                obj.Complete = b;
            };
        }

        public List<TodoTaskObj> getSomeTasks(bool b)
        {
            List < TodoTaskObj > objList = new List < TodoTaskObj >();

            foreach (TodoTaskObj obj in taskList)
            {
                if (obj.Complete == b) { 
                    objList.Add(obj);
                }
            }
            return objList;

        }


        public TodoTaskObj getIndividualTasks(string search)
        {
            foreach (TodoTaskObj obj in taskList)
            {
                if (obj.ContentText == search)
                {
                    return obj;
                }
            }
            throw new KeyNotFoundException();
        }


        public List<TodoTaskObj> getOrderedTasks()
        {
            List<TodoTaskObj> SortedList = taskList.OrderBy(obj => obj.ContentText).ToList();
            return SortedList;
        }

        public void getOrderedTasksReversed()
        {
            throw new NotImplementedException();
        }

        public void removeTask(TodoTaskObj obj)
        {
            taskList.Remove(obj);
        }

        public int getListLenght()
        {
            return taskList.Count;
        }

        override
        public string ToString() 
        {
            string returnString = "Current Tasks: ";

            foreach (TodoTaskObj obj in taskList) { returnString += obj.ToString() + ": "; }
            return returnString;
        }
    }
}
