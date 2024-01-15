using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension {


        public List<Task> tasks { get; set; }
        public struct Task {
            public int _id;
            public string task;
            public bool state;
            
            public string dateTime;

            public Task(int _id, string task, bool state) {
                this._id = _id;
                this.task = task;
                this.state = state;
                dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }


        public TodoListExtension() {
            tasks = new List<Task>();
        }

        public void UpdateData(int _id, string task) {
             for (int i = 0; i < tasks.Count; i++) {
                if (tasks[i]._id == _id && tasks[i].task != task) {
                    Task tmpTask = tasks[i];
                    tmpTask.task = task;
                    tasks[i] = tmpTask;
                }
            }
        }

        public Task GetTask(int _id) {
            foreach (Task item in tasks) {
                if (item._id == _id) {
                    return item;
                }
            }
            throw new InvalidDataException();
        }

        public void ChangeStatus(int _id, bool state) {
             for (int i = 0; i < tasks.Count; i++) {
                if (tasks[i]._id == _id && tasks[i].state != state) {
                    Task tmpTask = tasks[i];
                    tmpTask.state = state;
                    tasks[i] = tmpTask;
                }
            }
        }

        public List<string> DisplayList() {
            List<string> result = new List<string>();
            
            foreach (Task item in tasks) {
                result.Add($"{item.task} created at: {item.dateTime}");
            }
            
            return result;
            
        }
    }
}
