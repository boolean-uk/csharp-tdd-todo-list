using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class IdTask : Task
    {
        private string _id;
        private DateTime _created;

        public string Id { get => _id;}
        public DateTime Created { get => _created;}

        public IdTask(string name) : base (name)
        {
            Random rnd = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            _id = new string(Enumerable.Range(1, 10).Select(_ => chars[rnd.Next(chars.Length)]).ToArray());
            _created = DateTime.Now;

            Name = name;
        }

        
        
    }
}
