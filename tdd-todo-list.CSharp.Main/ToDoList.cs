using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        public Dictionary<string, bool> ToDoList { get; set; } = new Dictionary<string, bool>();
        public TodoList()
        {

        }

        public bool Add(string task, bool status)
        {
            return ToDoList.TryAdd(task.ToLower(), status);
        }

        public int PrintAll()
        {
            for (var i = 0; i < ToDoList.Count; i++)
            {
                Console.WriteLine($"{i}: [{ToDoList.ElementAt(i).Key}], Complete?: {ToDoList.ElementAt(i).Value}");
            }

            return ToDoList.Count;
        }

        public bool ChangeStatus(string task, bool b)
        {
            if (!ToDoList.ContainsKey(task.ToLower())) return false;

            ToDoList[task] = b;
            bool result = ToDoList[task] == b;

            return result;

        }

        public int PrintAllCompleteTasks()
        {
            for (var i = 0; i < ToDoList.Count; i++)
            {
                if(!ToDoList.ElementAt(i).Value) continue;
                Console.WriteLine($"{i}: [{ToDoList.ElementAt(i).Key}], Complete?: {ToDoList.ElementAt(i).Value}");
            }

            return ToDoList.Where(x => x.Value == true).ToList().Count;
        }

        public int PrintAllIncompleteTasks()
        {
            for (var i = 0; i < ToDoList.Count; i++)
            {
                if (!ToDoList.ElementAt(i).Value) continue;
                Console.WriteLine($"{i}: [{ToDoList.ElementAt(i).Key}], Complete?: {ToDoList.ElementAt(i).Value}");
            }

            return ToDoList.Where(x => x.Value == false).ToList().Count;
        }

        public bool Search(string key)
        {
            return ToDoList.ContainsKey(key.ToLower());
        }

        public bool Remove(string key)
        {
            return ToDoList.Remove(key.ToLower());
        }

        public string PrintAllAlphabeticAsc()
        {
            SortedDictionary<string, bool> newList = new SortedDictionary<string, bool>();

            foreach (var keyValuePair in ToDoList)
            {
                newList.Add(keyValuePair.Key, keyValuePair.Value);
            }

            for (var i = 0; i < newList.Count; i++)
            {
                Console.WriteLine($"{i}: [{newList.ElementAt(i).Key}], Complete?: {newList.ElementAt(i).Value}");
            }

            return newList.First().Key;
        }

        public string PrintAllAlphabeticDesc()
        {
            SortedDictionary<string, bool> newList = new SortedDictionary<string, bool>();

            foreach (var keyValuePair in ToDoList)
            {
                newList.Add(keyValuePair.Key, keyValuePair.Value);
            }

            ToDoList = newList.Reverse().ToDictionary();

            for (var i = 0; i < ToDoList.Count; i++)
            {
                Console.WriteLine($"{i}: [{ToDoList.ElementAt(i).Key}], Complete?: {ToDoList.ElementAt(i).Value}");
            }

            return ToDoList.First().Key;
        }
    }
}
