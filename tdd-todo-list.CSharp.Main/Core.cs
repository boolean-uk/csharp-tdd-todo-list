using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        public Dictionary<string, bool> todolist = new Dictionary<string, bool>()
        {
            { "testing", false },
            { "coding", false },
            { "running", false },
            { "traveling", false }
        };

        public Dictionary<string, bool> todolisttrue = new Dictionary<string, bool>();
        public Dictionary<string, bool> todolistfalse = new Dictionary<string, bool>();
        public SortedDictionary<string, bool> todolistascending = new SortedDictionary<string, bool>();

        public Dictionary<string, bool> addToDo(string todo, bool status)
        {
            if (todolist.ContainsKey(todo))
            {
                Console.WriteLine("Todo is already in list");
            }
            else
            {
                todolist.Add(todo, status);
            }
            return todolist;
        }

        public Dictionary<string, bool> removeToDo(string todo)
        {
            if (todolist.ContainsKey(todo))
            {
                todolist.Remove(todo);
            }
            return todolist;
        }

        public Dictionary<string, bool> changeStatus(string todo, bool status)
        {
            if (status == false)
            {
                todolist[todo] = true;
            } 
            else if (status == true) {
                todolist[todo] = false;
            }
            return todolist;
        }

        public Dictionary<string, bool> sortStatus()
        {
            foreach (KeyValuePair<string, bool> todo in todolist)
            {
                if (todo.Value == true) {
                    todolisttrue.Add(todo.Key, todo.Value);
                } else
                {
                    todolistfalse.Add(todo.Key, todo.Value);
                }
            }
            return todolisttrue;
        }

        public bool searchToDo(string todo)
        {
            if (todolist.ContainsKey (todo))
            {
                Console.WriteLine("Todo was found");
                return true;
            }
            else
            {
                Console.WriteLine("Todo was not found");
                return false;
            }
        }

        public SortedDictionary<string, bool> sortByAscending()
        {
            foreach (KeyValuePair<string, bool> todo in todolist)
            {
                todolistascending.Add(todo.Key, todo.Value);
            }
            return todolistascending;
        }
    }
}
