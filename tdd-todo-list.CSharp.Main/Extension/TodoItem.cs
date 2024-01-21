using Newtonsoft.Json.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main.Extension
{
    public class TodoItem
    {
        private static int nextID = 0;

        private int id;
        private string description;
        private DateTime creationTime;
        private bool isDone;

        public TodoItem(string description)
        {
            this.creationTime = DateTime.Now;
            this.id = nextID++;
            this.description = description;
            this.isDone = false;
        }

        public void MarkDone()
        {
            isDone = true;
        }

        public void MarkUndone()
        {
            isDone = false;
        }

        public string Description { get => description; set => description = value; }
        public string CreationTime { get => creationTime.ToString(); }
        public bool IsDone { get => isDone; }
        public int ID { get => id; set => id = value; }
    }
}
