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

        public Todo searchTask(int id) { return todoList[id]; }

        public bool remove(int id) {  todoList.RemoveAt(id); return true;}

        public List<Todo> listTasksSort(bool descending) { return todoList; } //add sort  

    }
}
