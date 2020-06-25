using N_N_Scrumboard.Model;
using N_N_Scrumboard.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            _board = Board.getInstance();
        }

        public ObservableCollection<Task> ToDo 
        {
            get { return _board.ToDo; }
            set
            {
                if (_board.ToDo != value)
                {
                    _board.ToDo = value;
                    OnPropertyChange("ToDo");
                }
            }
        }

        public ObservableCollection<Task> InProgress
        {
            get { return _board.InProgress; }
            set
            {
                if (_board.InProgress != value)
                {
                    _board.InProgress = value;
                    OnPropertyChange("InProgress");
                }
            }
        }

        public ObservableCollection<Task> Review
        {
            get { return _board.Review; }
            set
            {
                if (_board.Review != value)
                {
                    _board.Review = value;
                    OnPropertyChange("Review");
                }
            }
        }

        public ObservableCollection<Task> Done
        {
            get { return _board.Done; }
            set
            {
                if (_board.Done != value)
                {
                    _board.Done = value;
                    OnPropertyChange("Done");
                }
            }
        }


        public void CreateNewTask() 
        {
            CreateTaskView createTaskView = new CreateTaskView();
            createTaskView.ShowDialog();
        }

        public void CreateNewUser()
        {
            CreateUserView createUserView = new CreateUserView();
            createUserView.ShowDialog();
        }

        public void DeleteTask(Task task)
        {
            if (_board.ToDo.Contains(task))
            {
                _board.ToDo.Remove(task);
            }
            else if (_board.InProgress.Contains(task)) 
            {
                _board.InProgress.Remove(task);
            }
            else if (_board.Review.Contains(task))
            {
                _board.Review.Remove(task);
            }
            else if (_board.Done.Contains(task))
            {
                _board.Done.Remove(task);
            }
        }

        public void EditTask(Task task)
        {
            CreateTaskView createTaskView = new CreateTaskView(task);
            createTaskView.ShowDialog();
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
