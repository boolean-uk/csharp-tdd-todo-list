using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        public List<Item> items { get; set; } = new List<Item>();
        public bool Add(Item item) 
        {
            try 
            {
                items.Add(item);
                return true;
            }
            catch (Exception e) 
            {
                Console.WriteLine("error occured in: todolist.cs -> Add(Item item)");
                Console.WriteLine(e);
                return false;
            }
        }

        public bool Change(string msg, bool state)
        {
            try 
            {
                Item? item = items.Find(i => i.message == msg.ToLower());
                if (item == null) { return false; }
                item.completed = state;
                return true;
            }
            catch (Exception e) 
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public List<Item> CompletedTasks()
        {
            try 
            {
                List<Item> result = items.Where(i => i.completed).ToList();
                return result;
            }
            catch (Exception e) 
            {
                Console.WriteLine($"{e.Message}");
                return null;
            }
        }

        public List<Item> IncompletedTasks()
        {
            try
            {
                List<Item> result = items.Where(i => !i.completed).ToList();
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
                return null;
            }
        }

        public List<Item> orderAsc()
        {
            return this.items.OrderBy(i => i.message).ToList();
        }

        public List<Item> orderDesc()
        {
            return this.items.OrderByDescending(i => i.message).ToList();
        }

        public bool Remove(string taskName)
        {
            Item? item = items.Where(i => i.message == taskName.ToLower()).FirstOrDefault();
            if (item != null)
            {
                items.Remove(item);
                return true;
            }
            return false;
        }

        public Item Search(string search, out string result)
        {
            result = "Item was not found";
            try 
            {                
                Item? task = items.Find(i => i.message == search.ToLower());  
                if (task == null) { return null; }
                result = "Item was found";
                return task;
            }
            catch (Exception e) 
            {
                Console.WriteLine(e);
                return null;
            }            
        }

        public List<Item> View()
        {
            return items;
        }
    }
}
