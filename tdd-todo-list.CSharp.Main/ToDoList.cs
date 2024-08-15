using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private List<Todo> todoList = new List<Todo>();

        public bool add(string task)
        {
            int listLength = todoList.Count;
            todoList.Add(new Todo(task, todoList.Count + 1));
            if (listLength < todoList.Count) {
                return true;
            }
            return false;
        }

        public List<Todo> listTasks() { return todoList; } //works, just print the list

        public bool taskStatus(int id) //switches task status
        {
            foreach (Todo todo in todoList)
            {
                if (todo.id == id)
                {
                    todo.Complete = !todo.Complete;
                    return true;
                }
            }
            return false;
        }

        public IEnumerable<Todo> fetchTasks(bool complete) {
            if (complete)
            {
                return todoList.Where(item => item.Complete).OrderBy(item => item.Complete);
            }
            return todoList.Where(item => !item.Complete).OrderBy(item => item.Complete);
        } //return based on bool

        public Todo searchTask(int id) { return todoList.FirstOrDefault(item => item.id == id); }

        public bool remove(int id) {  todoList.Remove(todoList.FirstOrDefault(item => item.id == id)); return true;}

        public List<Todo> listTasksSort(bool descending) { 
            if (descending)
            {
                return todoList.OrderByDescending(item => item.task).ToList();

            }
            return todoList.OrderBy(item => item.task).ToList();
            

        }

        public bool updateTask(int id, string name)
        {
            Todo todo = todoList.FirstOrDefault(item => item.id == id);
            if (todo != null)
            {
                todo.task = name;
                return true;
            }
            return false;
        }

    }
}
