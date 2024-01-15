using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private int _nextID = 0;
        List<PTask> _taskList = new List<PTask>();

        public enum TaskFilterType
        {
            NULL,
            Complete,
            Incomplete
        }

        public enum TaskSortType
        {
            NULL,
            AscendingAlphabetically,
            DescendingAlphabetically
        }


        public bool AddTask(PTask task)
        {
            if (task == null)
                return false;

            _taskList.Add(task);
            return true;

        }
        public bool AddTask(List<PTask> tasks)
        {
            foreach (PTask task in tasks)
            {
                if (task == null)
                    return false;

                _taskList.Add(task);
            }

            return true;
        }

        public void PrintTask()
        {
            Console.WriteLine("---Task-List------------------");
            Console.WriteLine("-Completed-|-Task-------------");

            foreach (PTask task in _taskList)
            {
                string complete = (task.IsComplete) ? "Yes" : "No ";
                Console.WriteLine($" {complete}      | {task.Name}");
            }
        }

        public bool RemoveTask(int taskID)
        {
            if (taskID >= _taskList.Count)
                return false;
            if (_taskList.ElementAt(taskID) == null)
                return false;

            _taskList.RemoveAt(taskID);
            return true;
        }

        public bool RemoveTask(PTask task)
        {
            return _taskList.Remove(task);
        }

        public bool RemoveTask(List<PTask> tasks)
        {
            foreach (var task in tasks)
                if (!_taskList.Contains(task))
                    return false;

            foreach (var task in tasks)
                _taskList.Remove(task);

            return true;
        }

        public void PrintTasks(
            string searchQuery = "", 
            TaskFilterType filterQuery = TaskFilterType.NULL, 
            TaskSortType sortBy = TaskSortType.NULL) 
        {
            throw new NotImplementedException();
        }

        public bool SetTaskState(int taskID, bool isComplete)
        {
            if (taskID >= _taskList.Count)
                return false;
            if (_taskList.ElementAt(taskID) == null)
                return false;

            _taskList.ElementAt(taskID).IsComplete = isComplete;
            return true;
        }

        public bool SetTaskState(PTask task, bool isComplete)
        {
            if (!_taskList.Contains(task))
                return false;

            _taskList.Find(x => x == task).IsComplete = isComplete;
            return true;
        }

        public bool GetTaskState(int taskID)
        {
            if (taskID >= _taskList.Count)
                return false;
            if (_taskList.ElementAt(taskID) == null)
                return false;

            return _taskList.ElementAt(taskID).IsComplete;
        }

        public bool GetTaskState(PTask task)
        {
            if (!_taskList.Contains(task))
                return false;

            return _taskList.Find(x => x == task).IsComplete;
        }

        public List<bool> GetTaskState(List<PTask> tasks)
        {
            List<bool> result = new List<bool>();
            foreach (PTask task in tasks)
            {
                if (_taskList.Contains(task) == false)
                    return null;
            }

            foreach (PTask task in tasks)
            {
                result.Add(_taskList.Find(x => x == task).IsComplete);
            }

            return result;
        }
    }
}
