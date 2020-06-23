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

            Task task1 = new Task();
            Task task2 = new Task();
            Task task3 = new Task();
            Task task4 = new Task();
            Task task5 = new Task();
            task1.Title = "Task1";
            task2.Title = "Task2";
            task3.Title = "Task3";
            task4.Title = "Task4";
            task5.Title = "Task5";
            task1.AssinedTo = new User();
            task1.AssinedTo.Name = "Franz jürgen Otto";
            task1.Description = "ljkjslkfjlksdjflkjslkdfsdjflsjdflklsdfjlskdjflksdjflksdjflksjdflkjsdflksjlkfjsdlkfjslkfjsdjflksjflksjdflkjsdlkfjslkdfjlksdfj";
            _board.ToDo.Add(task1);
            _board.ToDo.Add(task2);
            _board.ToDo.Add(task3);
            _board.ToDo.Add(task4);
            _board.ToDo.Add(task5);
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

        public ObservableCollection<Task> ToDInProgresso
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
