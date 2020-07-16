using BlazorMVVMToDo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace BlazorMVVMToDo.ViewModels
{

    public class ToDoFinalViewModel : BaseViewModel, IToDoViewModel
    {
        private List<ToDoItem> toDoItemList = new List<ToDoItem>();
        public List<ToDoItem> ToDoItemList
        {
            get => toDoItemList;
            private set
            {
                SetValue(ref toDoItemList, value);
            }

        }

        private ToDoItem toDoItem = new ToDoItem();
        public ToDoItem ToDoItem
        {
            get => toDoItem;
            set
            {
                SetValue(ref toDoItem, value);
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
    }
}
