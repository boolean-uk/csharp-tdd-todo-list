using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {

        private List<toDoTask> _taskList = new List<toDoTask>() {

                new toDoTask("exercise", true),
                new toDoTask("cook", false),
                new toDoTask("work", true),
                new toDoTask("eat", true),
                new toDoTask("sleep", false),
                new toDoTask("read", false)

            };
        public List<toDoTask> taskList { get { return _taskList; } }

        public void addTask(toDoTask toDoTask)
        {
            
            _taskList.Add(toDoTask);

        }

        public List<toDoTask> getAll()
        {
            return taskList;
        }

        public List<toDoTask> getAscending(List<toDoTask> taskList)
        {
            throw new NotImplementedException();
        }

        public List<toDoTask> getComplete(List<toDoTask> taskList)
        {
            List<toDoTask> completedList = new List<toDoTask> ();
            foreach (var item in taskList)
            {
                if (item.taskComplete == true)
                {
                    completedList.Add(item);
                }
            }
            return completedList;
        }

        public List<toDoTask> getDescending(List<toDoTask> taskList)
        {
            throw new NotImplementedException();
        }

        public List<toDoTask> getInComplete(List<toDoTask> taskList)
        {
            throw new NotImplementedException();
        }
    }
}
