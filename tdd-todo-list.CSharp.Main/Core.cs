namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        List<Tuple<string, int, bool>> _tasks;
        /// <summary>
        /// initiating the dictionray of tasks inside the constructor
        /// </summary>
        public TodoList()
        {
            _tasks = new List<Tuple<string, int, bool>>();
            _tasks.Add(Tuple.Create("walking", 1, false));
            _tasks.Add(Tuple.Create("shopping", 2, false));






        }


        public List<Tuple<string, int, bool>> tasks { get { return _tasks; } }


        public bool add(string todo, int id, bool completed)
        {
            foreach (var task in _tasks)
            {
                if (task.Item1.ToUpper() == todo.ToUpper() || task.Item2 == id)
                {

                    return false;

                }

            }
            _tasks.Add(Tuple.Create(todo, id, completed));

            return true;
        }

        public bool changedStatus(int id)
        {
            bool result = false;
            foreach (var task in _tasks)
            {

                if (task.Item2 != id)
                {

                    result = false;

                }
                else
                {
                    Tuple<string, int, bool> updatedTask = Tuple.Create(task.Item1, task.Item2, !task.Item3);
                    _tasks.Remove(task);
                    _tasks.Add(updatedTask);
                    result = true;
                    break;


                }

            }

            //if (task.Item2 != id)
            //{

            //    result = false; 
            //    break;

            //}
            //else if(newstatus == task.Item3)
            //{
            //    Console.WriteLine("same status");
            //    result = false; 
            //    break;
            //}
            //else
            //{
            //    Tuple<string,int,bool> updatedTask = Tuple.Create(task.Item1, task.Item2, newstatus);
            //    _tasks.Remove(task);
            //    _tasks.Add(updatedTask);

            //    result = false;
            //    break;
            //}
            return result;




        }

        public int count()
        {
            int count = 0;
            foreach (var s in _tasks)
            {
                Console.WriteLine($"{s.Item1} with id {s.Item2} is completed: {s.Item3}");
                count++;
            }
            return count;
        }

        public List<Tuple<string, int, bool>> GetCompletedTasks()
        {
            List<Tuple<string, int, bool>> completedtasks = new List<Tuple<string, int, bool>>();
            foreach (var task in _tasks)
            {
                if (task.Item3 == true)
                {
                    completedtasks.Add(Tuple.Create(task.Item1, task.Item2, task.Item3));
                }
            }

            return completedtasks;


        }
        public List<Tuple<string, int, bool>> GetInCompletedTasks()
        {
            List<Tuple<string, int, bool>> incompletedtasks = new List<Tuple<string, int, bool>>();
            foreach (var task in _tasks)
            {
                if (task.Item3 == false)
                {
                    incompletedtasks.Add(Tuple.Create(task.Item1, task.Item2, task.Item3));
                }
            }

            return incompletedtasks;


        }

        public string SearchTask(int id)
        {
            string result = "";
            foreach (var task in _tasks)
            {
                if (task.Item2.Equals(id))
                {
                    result = "Found";
                    break;
                }
                else
                {
                    result = "it wasn't found";
                }
            }
            return result;
        }

        public bool RemoveTask(int id)
        {
            bool result = false;
            foreach (var task in _tasks)
            {
                if(task.Item2.Equals(id)) {
                    _tasks.Remove(task);
                    result = true;
                    break;
                }
                else
                {
                    Console.WriteLine("task wasnt found");
                }
            }
            return result;
        }

        public List<Tuple<string, int, bool>> GetTasksAscending()
        {
            List<Tuple<string, int, bool>> result = _tasks.OrderBy(x => x.Item1).ToList();

            return result;



        }
        public List<Tuple<string, int, bool>> GetTasksDescending()
        {
            List<Tuple<string, int, bool>> result = _tasks.OrderBy(x => x.Item1).ToList();
            result.Reverse();
            return result;



        }




    }
}


