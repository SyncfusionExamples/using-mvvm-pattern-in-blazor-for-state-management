﻿using UsingMVVMPattern.Models;
using System.Collections.Generic;
using System.ComponentModel;

namespace UsingMVVMPattern.ViewModels
{
    public interface IToDoViewModel
    {
        bool IsBusy { get; set; }
        int ToDoItems { get; }
        ToDoItem ToDoItem { get; set; }
        List<ToDoItem> ToDoItemList { get; }

        event PropertyChangedEventHandler PropertyChanged;

        void SaveToDoItem(ToDoItem todoitem);
    }
}