using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{

    // This class is only used for Extension requirements, Core uses a dictionary
    // but extension requirement is more complex than just {Key, Value}
    public class Task
    {
        private int id;
        private string name;
        private bool complete;
        private DateTime createdAt;

        public Task() { }

        public int Id { get { return id; } set { id = value; } }
        public string Name {  get { return name; } set { name = value; } }
        public bool Complete { get { return complete; } set { complete = value; } }
        public DateTime CreatedAt { get {  return createdAt; } set { createdAt = value; } }
    }
}
