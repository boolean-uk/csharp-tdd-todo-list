
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;



namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        List<ToDoTask> todolist = new List<ToDoTask>();
        int idcounter = 0;
        public string AddTask(string name)
        {
            ToDoTask task = new ToDoTask();
            task.Name = name;
            task.Id = idcounter++;
            todolist.Add(task);
            return todolist.Last().Name;



        }

        public string ChangeStatus(string name)

        {

            ToDoTask? task = todolist.Find(x => x.Name == name);
            if (task != null)
            {
                if (task.Status == "incomplete")
                {
                    task.Status = "complete";
                    return task.Status;

                }
                else
                {
                    task.Status = "incomplete";
                    return task.Status;



                }
            }
            return "did not exist in list";


        }

        public List<ToDoTask> GetCompletedList()
        {
            List<ToDoTask> completedList = new List<ToDoTask>();

            foreach (ToDoTask task in todolist)
            {
                if (task.Status == "complete")
                {
                    completedList.Add(task);

                }
            }
            return completedList;
        }

        public List<ToDoTask> GetIncompletedList()
        {
            List<ToDoTask> incompletedList = new List<ToDoTask>();

            foreach (ToDoTask task in todolist)
            {
                if (task.Status == "incomplete")
                {
                    incompletedList.Add(task);

                }
            }
            return incompletedList;
        }


        public int ListSize()
        {
            return todolist.Count;
        }

        public string RemoveTask(string taskname)
        {
            ToDoTask? taskToRemove = todolist.Find(task => task.Name == taskname);
            if (taskToRemove != null)
            {
                todolist.Remove(taskToRemove);
                return taskToRemove.Name;
            }
            return "fantes ikke i listen";
        }

        public string SearchTask(string taskname)
        {

            ToDoTask? task = todolist.Find(x => x.Name == taskname);
            if (task != null)
            {
                return task.Name;

            }
            return "this task does not exist";
        }

        public string ShowList()

        {
            string allTasks = "";
            foreach (ToDoTask task in todolist)
            {

                allTasks += " " + task.Name + ": " + task.Status + "\n";

            }
            Console.WriteLine(allTasks);



            return allTasks;

        }

        public List<ToDoTask> SortAlphabetical()

        {
            List<ToDoTask> sorted = todolist.OrderBy(x => x.Name).ToList();
            return sorted;
        }

        public List<ToDoTask> SortAlphabeticalDescending()
        {
            List<ToDoTask> sorted = todolist.OrderByDescending(x => x.Name).ToList();
            return sorted;
        }
        public string getTaskById(int id)
        {
            ToDoTask? task = todolist.Find(x => x.Id == id);
            foreach (ToDoTask todo in todolist)
            {
                Console.WriteLine(todo.Id);
            }
           
            if (task != null)
            {
                return task.Name;
            }
            return "this id does not exist!";

        }

        public void UpdateName(int id, string name)
        {
            ToDoTask? task = todolist.Find(x => x.Id == id);
            if (task!= null)
            {
                task.Name = name;   
            }
       

        }
        public String UpdateStatusById(int id)
        {
            ToDoTask? task = todolist.Find(x => x.Id == id);
            if (task != null)
            {
                ChangeStatus(task.Name);
                return task.Status;
            }
            return "the id does not exist";

        }
        

        

    }
}
