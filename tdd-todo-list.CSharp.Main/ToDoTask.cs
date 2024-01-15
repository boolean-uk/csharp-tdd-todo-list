using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace tdd_todo_list.CSharp.Main
{
    public class ToDoTask(string name, Status status)
    {
        public string Id { get; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = name;
        public Status Status { get; set; } = status;
    }
}
