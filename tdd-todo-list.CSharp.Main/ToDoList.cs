using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        public enum SortCriteria
        {
            OnlyComplete,
            OnlyIncomplete,
            AllTaskAlphabeticAsc,
            AllTaskAlphabeticDesc,
            Default
        }

        public Dictionary<string, TodoTask> todoTaskDict {  get; private set; }
        public TodoList() {
            this.todoTaskDict = new Dictionary<string, TodoTask>();
        }

        public void addTask(String taskName) { 
            TodoTask newTask = new TodoTask(taskName);
            this.todoTaskDict.Add(taskName, newTask);
        }

        public TodoTask findTaskByName(string taskName)
        {
            TodoTask? foundTask;
            if (!this.todoTaskDict.TryGetValue(taskName, out foundTask))
            {

                //task not found
                throw new KeyNotFoundException("Task not found");
            }

            return foundTask;
        }

        public void setTaskStatus(string taskName, bool isFinished)
        {
            try
            {
                findTaskByName(taskName).isFinished = isFinished;
            } catch (KeyNotFoundException)
            {
                throw new KeyNotFoundException("Task not found, could not change status.");
            }
        }
        
        public List<TodoTask> getAllTasksSorted(SortCriteria ?criteria)
        {
            switch (criteria) 
            { 
                case SortCriteria.OnlyComplete:
                    return this.todoTaskDict
                        .Where(t => t.Value.isFinished)
                        .Select(t => t.Value).ToList();

                case SortCriteria.OnlyIncomplete:
                    return this.todoTaskDict
                        .Where(t => !t.Value.isFinished)
                        .Select(t => t.Value).ToList();

                case SortCriteria.AllTaskAlphabeticAsc:
                    return this.todoTaskDict
                        .OrderBy(t => t.Key)
                        .Select(t => t.Value).ToList();

                case SortCriteria.AllTaskAlphabeticDesc:
                    return this.todoTaskDict
                        .OrderByDescending(t => t.Key)
                        .Select(t => t.Value).ToList();

                default:
                    return this.todoTaskDict.Values.ToList();
            }

        }

        public void removeTask(string taskName)
        {
            try
            {
                var taskToRemove = findTaskByName(taskName);
                this.todoTaskDict.Remove(taskName);
            }
            catch (KeyNotFoundException) {
                throw new KeyNotFoundException("Task not found, could not remove.");
            }
        }
    }
}
