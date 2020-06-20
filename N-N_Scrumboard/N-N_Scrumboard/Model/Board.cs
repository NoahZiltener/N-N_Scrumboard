using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace N_N_Scrumboard.Model
{
    class Board
    {
        private static Board _board = null;

        private ObservableCollection<Task> _todo;
        private ObservableCollection<Task> _inprogress;
        private ObservableCollection<Task> _review;
        private ObservableCollection<Task> _done;

        private Board() 
        {
            ToDo = new ObservableCollection<Task>();
            InProgress = new ObservableCollection<Task>();
            Review = new ObservableCollection<Task>();
            Done = new ObservableCollection<Task>();
        }

        public ObservableCollection<Task> ToDo
        {
            get { return _todo; }
            set { _todo = value; }
        }

        public ObservableCollection<Task> InProgress
        {
            get { return _inprogress; }
            set { _inprogress = value; }
        }

        public ObservableCollection<Task> Review
        {
            get { return _review; }
            set { _review = value; }
        }

        public ObservableCollection<Task> Done
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
