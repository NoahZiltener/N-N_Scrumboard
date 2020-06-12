using N_N_Scrumboard.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace N_N_Scrumboard.ModelView
{
    class BoardViewModel : INotifyPropertyChanged
    {
        private Board _board;

        public BoardViewModel() 
        {
            _board = new Board();

            Task task1 = new Task();
            Task task2 = new Task();
            Task task3 = new Task();
            Task task4 = new Task();
            task1.Title = "Task1";
            task2.Title = "Task2";
            task3.Title = "Task3";
            task4.Title = "Task4";
            _board.ToDo.Add(task1);
            _board.ToDo.Add(task2);
            _board.ToDo.Add(task3);
            _board.ToDo.Add(task4);
        }

        public List<Task> ToDo 
        {
            get { return _board.ToDo; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
