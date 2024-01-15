using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public struct TaskExtend
    {
        public string Name { get; set; }
        public bool IsCompleted { get; set; }
        public int ID { get; set; }
        public string Date { get; set; }


        public TaskExtend(int id, string name, string date)
        {
            Name = name;
            ID = id;
            IsCompleted = false;
            Date = date;
        }
        public void setName(string name)
        {
            Name = name;
        }

    }
    public class TodoListExtension
    {

        public List<TaskExtend> Tasks { get; set; }

        public TodoListExtension()
        {
            Tasks = new List<TaskExtend>();
        }

        public bool addTask(int id, string taskName, string date)
        {

            Tasks.Add(new TaskExtend(id,taskName,date));

            return true;
        }

        public TaskExtend getByID(int id)
        {
            TaskExtend result = new TaskExtend(0,"None","0");

            foreach (TaskExtend task in Tasks)
            {
                if(task.ID == id)
                {
                    result = task;
                }
            }

            return result;
        }
        public bool updateName(int id, string newName)
        {
            bool result = false;

            foreach(TaskExtend task in Tasks)
            {
                if(task.ID == id)
                {
                    string tempDate = task.Date;
                    Tasks.Remove(task);
                    Tasks.Add(new TaskExtend(id, newName, tempDate));
                    result = true;
                }
            }

            Console.WriteLine(result);
            return result;
        }




    }
}
