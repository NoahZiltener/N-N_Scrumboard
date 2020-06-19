using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_N_Scrumboard.Model
{
    class Board
    {
        private static Board _board = null;

        private ObservableCollection<Task> _todo;
        private List<Task> _inprogress;
        private List<Task> _review;
        private List<Task> _done;

        private Board() 
        {
            ToDo = new ObservableCollection<Task>();
            InProgress = new List<Task>();
            Review = new List<Task>();
            Done = new List<Task>();
        }

        public ObservableCollection<Task> ToDo
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

        public static Board getInstance()
        {
            if (_board == null)
                _board = new Board();
            return _board;
        }

    }
}
