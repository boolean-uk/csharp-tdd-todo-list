using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Task
    {
        private string _description;
        public string description
        {
            get { return _description; }
            set { _description = value; }
        }
        private bool _completed;
        public bool completed
        {
            get { return _completed; }
            set { _completed = value; }
        }

    
}

