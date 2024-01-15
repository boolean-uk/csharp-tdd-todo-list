using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {

        public List<Task> tasks { get; set; }
        private int _idHolder = 0;
        public struct Task {
            public int _id;
            public string task;
            public bool isCompleted;

            public Task(int _id, string task, bool isCompleted) {
                this._id = _id;
                this.task = task;
                this.isCompleted = isCompleted;
            }
        }

        public TodoList() {
            tasks = new List<Task>();
        }

        public bool AddTask(string task) {
            int tmp = tasks.Last()._id;
            tasks.Add(new Task(++tmp, task, false));

            return true;
        }

        public bool RemoveTask(int v)
        {
            foreach (Task item in tasks) {
                if (item._id == v) {
                    tasks.Remove(item);
                    return true;
                }
            }
            return false;
        }

        public List<string> DisplayTasks() {
            List<string> res = new List<string>();

            foreach (Task item in tasks) {
                res.Add($"{item.task} is completed: {item.isCompleted}");
            }

            return res;
        }

        public bool ChangeStatus(int index, bool state) {

            for (int i = 0; i < tasks.Count; i++) {
                if (tasks[i]._id == index && tasks[i].isCompleted != state) {
                    Task tmpTask = tasks[i];
                    tmpTask.isCompleted = state;
                    tasks[i] = tmpTask;
                    return true;
                }
            }
            return false;
        }

        public List<string> GetCompletedTasks()
        {
            List<string> completedTasks = new List<string>();
            foreach (Task item in tasks) {
                if (item.isCompleted == true) {
                    completedTasks.Add(item.task);
                }
            }

            return completedTasks;
        }

        public List<string> GetIncompletedTaska()
        {
            List<string> inCompletedTasks = new List<string>();
            foreach (Task item in tasks) {
                if (item.isCompleted == false) {
                    inCompletedTasks.Add(item.task);
                }
            }

            return inCompletedTasks;
        }

        public Task SearchTask(int _id) {
            foreach (Task item in tasks) {
                if (item._id == _id) {
                    return item;
                }
            }
            
            throw new InvalidDataException();
        }

        public List<string> GetOrderedList(char order)
        {
            if (order.Equals('a')) {
                return AscendingOrder(tasks);
            } else if (order.Equals('d')) {
                return DescendingOrder(tasks);
            }
            else {
                throw new InvalidOperationException();
            }
        }

        private List<string> DescendingOrder(List<Task> tasks) {
            List<Task> orderedTasks = tasks.OrderByDescending(t => t.task).ToList();
            List<string> orderedTaskNames = orderedTasks.Select(t => t.task).ToList();
            return orderedTaskNames;
        }

        private List<string> AscendingOrder(List<Task> tasks) {
            List<Task> orderedTasks = tasks.OrderBy(t => t.task).ToList();
            List<string> orderedTaskNames = orderedTasks.Select(t => t.task).ToList();
            return orderedTaskNames;
        }
    }
}
