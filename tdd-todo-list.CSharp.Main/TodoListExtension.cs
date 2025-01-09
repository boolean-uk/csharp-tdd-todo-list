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
        public void addTaskByTask(TodoTaskExtension newTask)
        {
            this.todoTaskDict.Add(newTask.taskId, newTask);
        }

        public TodoTaskExtension findTaskById(Guid findTaskId)
        {
            TodoTaskExtension? foundTask;

            if (!this.todoTaskDict.TryGetValue(findTaskId, out foundTask)) {

                //task not found
                throw new KeyNotFoundException("Task not found"); 
            }

            return foundTask;
        }

        public void setTaskStatus(Guid setTaskId, bool isFinished)
        {
            try
            {
                findTaskById(setTaskId).isFinished = isFinished;
            }
            catch (KeyNotFoundException) {
                throw new KeyNotFoundException("Task not found, could not change status.");
            }
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
                        .OrderBy(t => t.Value.taskName)
                        .Select(t => t.Value).ToList();

                case SortCriteria.AllTaskAlphabeticDesc:
                    return this.todoTaskDict
                        .OrderByDescending(t => t.Value.taskName)
                        .Select(t => t.Value).ToList();

                default:
                    return this.todoTaskDict.Values.ToList();
            }

        }

        public void removeTask(Guid taskId)
        {
            try
            {
                findTaskById(taskId);
                this.todoTaskDict.Remove(taskId);
            }
            catch (KeyNotFoundException) {
                throw new KeyNotFoundException("Could not remove task.");
            }
            
        }

        public void setTaskNameById(Guid taskId, string newTaskName)
        {
            findTaskById(taskId).taskName = newTaskName;
        }
    }
}
