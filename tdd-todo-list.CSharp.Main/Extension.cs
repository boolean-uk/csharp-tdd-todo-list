using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        public List<Task> ToDo = new List<Task>();

        public void Add(string task, bool status)
        {
            ToDo.Add(new Task(task, status));
        }

        public int PrintAll()
        {
            for (var i = 0; i < ToDo.Count; i++)
            {
                Console.WriteLine($"ID:{ToDo[i].Id}: [{ToDo[i].TaskName}], Complete?: {ToDo[i].bIsComplete}");
            }
            return ToDo.Count;
        }


        public Task GetTaskById(int i)
        {
            return ToDo.Find(x => x.Id == i);
        }

        public Task UpdateNameById(int i, string newName)
        {
            ToDo.Find(x => x.Id == i).TaskName = newName;

            return ToDo.Find(x => x.Id == i);
        }

        public Task UpdateStatusById(int i, bool b)
        {
            ToDo.Find(x => x.Id == i).bIsComplete = b;

            return ToDo.Find(x => x.Id == i);
        }

        public bool PrintDateCreated()
        {
            foreach (var task in ToDo)
            {
                if (task.DateCreated == DateTime.Now)
                    return false;
                Console.WriteLine($"Task: {task.TaskName}, Date Created: {task.DateCreated}");
            }

            return true;
        }
    }
}
