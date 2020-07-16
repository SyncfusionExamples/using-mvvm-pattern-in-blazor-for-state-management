using BlazorMVVMToDo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace BlazorMVVMToDo.ViewModels
{
    public class ToDoBasicViewModel : INotifyPropertyChanged, IToDoViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private bool isBusy = false;
        public bool IsBusy
        {
            get => isBusy;
            set
            {
                isBusy = value;
                OnPropertyChanged();
            }
        }

        private List<ToDoItem> toDoItemList = new List<ToDoItem>();
        public List<ToDoItem> ToDoItemList
        {
            get => toDoItemList;
            private set
            {
                toDoItemList = value;
                OnPropertyChanged();
            }

        }

        private ToDoItem toDoItem = new ToDoItem();
        public ToDoItem ToDoItem
        {
            get => toDoItem;
            set
            {
                toDoItem = value;
                OnPropertyChanged();
            }
        }

        public int ToDoItems
        {
            get
            {
                return ToDoItemList.Where(i => i.Done.Equals(false)).Count();
            }
        }

        public void SaveToDoItem(ToDoItem todoitem)
        {
            IsBusy = true;
            if (todoitem.Id.Equals(Guid.Empty))
            {
                todoitem.Id = Guid.NewGuid();
            }
            else
            {
                toDoItemList.Remove(todoitem);
            }

            toDoItemList.Add(todoitem);

            OnPropertyChanged(nameof(ToDoItemList));
            IsBusy = false;
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

