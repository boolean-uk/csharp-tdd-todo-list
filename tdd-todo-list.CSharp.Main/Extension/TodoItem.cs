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
            throw new NotImplementedException();
        }

        public void MarkDone()
        {
            throw new NotImplementedException();
        }

        public void MarkUndone()
        {
            throw new NotImplementedException();
        }

        public string Description { get => description; set => description = value; }
        public DateTime CreationTime { get => creationTime; }
        public bool IsDone { get => isDone; }
        public int ID { get => id; set => id = value; }
    }
}
