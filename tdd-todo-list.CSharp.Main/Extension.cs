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
        public string DateTime { get; set; }


        public TaskExtend(int id, string name, string datetime)
        {
            Name = name;
            ID = id;
            IsCompleted = false;
            DateTime = datetime;
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

        public bool addTask(int id, string taskName, string datetime)
        {

            Tasks.Add(new TaskExtend(id,taskName,datetime));

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
            string tempDateTime = "";
            TaskExtend oldTask = new TaskExtend();
            foreach(TaskExtend task in Tasks)
            {
                if(task.ID == id)
                {
                    oldTask = task;
                    tempDateTime = task.DateTime;
                    result = true;
                }
            }

            if(result == true)
            {
                Tasks.Remove(oldTask);
                oldTask.Name = newName;
                Tasks.Add(oldTask);
            }

            return result;
        }
        public bool changeCompletion(int id)
        {
            TaskExtend temp = new TaskExtend();
            bool result = false;
            foreach (TaskExtend task in Tasks)
            {
                if(task.ID == id)
                {
                    temp = task;
                    result = true;
                }
            }

            if(result == true)
            {
                Tasks.Remove(temp);
                temp.IsCompleted = true;
                Tasks.Add(temp);
            }


            return result;
        }
        public List<string> dateTimeTasks()
        {
            List<string> result = new List<string>();

            foreach (TaskExtend task in Tasks)
            {
                result.Add(task.ID.ToString()+" Created on the:"+task.DateTime);
            }


            return result;
        }



    }
}
