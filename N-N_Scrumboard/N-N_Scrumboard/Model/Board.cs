using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_N_Scrumboard.Model
{
    class Board
    {
        private List<Task> _todo;
        private List<Task> _inprogress;
        private List<Task> _review;
        private List<Task> _done;

        public Board() 
        {
            ToDo = new List<Task>();
            InProgress = new List<Task>();
            Review = new List<Task>();
            Done = new List<Task>();
        }

        public List<Task> ToDo
        {
            get { return _todo; }
            set { _todo = value; }
        }

        public List<Task> InProgress
        {
            get { return _inprogress; }
            set { _inprogress = value; }
        }

        public List<Task> Review
        {
            get { return _review; }
            set { _review = value; }
        }

        public List<Task> Done
        {
            get { return _done; }
            set { _done = value; }
        }

    }
}
