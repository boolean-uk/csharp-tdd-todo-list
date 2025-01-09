using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        public enum SortCriteria
        {
            OnlyComplete,
            OnlyIncomplete,
            AllTaskAlphabeticAsc,
            AllTaskAlphabeticDesc,
            Default
        }

        public Dictionary<Guid, TodoTaskExtension> todoTaskDict {  get; private set; }
        public TodoListExtension() {
            this.todoTaskDict = new Dictionary<Guid, TodoTaskExtension>();
        }

        public void addTask(String taskName) { 
            TodoTaskExtension newTask = new TodoTaskExtension(taskName);
            this.todoTaskDict.Add(newTask.taskId, newTask);
        }

        public TodoTaskExtension findTaskById(Guid findTaskId)
        {
            TodoTaskExtension? foundTask;
            this.todoTaskDict.TryGetValue(findTaskId, out foundTask);

            return foundTask;
        }

        public void setTaskStatus(Guid setTaskId, bool isFinished)
        {
            findTaskById(setTaskId).isFinished = isFinished;
        }
        
        public List<TodoTaskExtension> getAllTasksSorted(SortCriteria ?criteria)
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

        public void removeTask(Guid taskId)
        {
            var taskToRemove = findTaskById(taskId);
            this.todoTaskDict.Remove(taskId);
        }
    }
}
