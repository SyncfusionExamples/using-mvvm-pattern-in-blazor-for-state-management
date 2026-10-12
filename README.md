# MVVM Pattern in Blazor for State Management

## Overview

This sample demonstrates how to implement the Model-View-ViewModel (MVVM) architectural pattern in a Blazor application to manage and share application state across pages and reusable components. The project separates presentation logic from UI rendering by organizing functionality into Models, ViewModels, Razor pages, and reusable components. By using ViewModels as a centralized state layer, the sample shows how application data can remain synchronized across multiple UI elements without relying on complex parameter passing. The approach improves maintainability, testability, and scalability for real-world Blazor applications.

## Key Features

- Demonstrates the Model-View-ViewModel (MVVM) architectural pattern in a Blazor application.
- Uses the `IToDoViewModel` interface to abstract application state and presentation logic from UI components.
- Implements shared state management through dependency injection and a centralized ViewModel instance.
- Uses `CascadingValue` to distribute the ViewModel across multiple Razor components without parameter chaining.
- Implements UI change notifications using the `INotifyPropertyChanged` interface.
- Provides a reusable `BaseViewModel` class with `INotifyPropertyChanged`, `SetValue<T>()`, and `OnPropertyChanged()` implementations.
- Demonstrates ViewModel inheritance through `ToDoFinalViewModel` extending `BaseViewModel`.
- Maintains application state using the `ToDoItemList` collection and current `ToDoItem` properties.
- Supports creating and updating to-do items through the `SaveToDoItem(ToDoItem todoitem)` method.
- Uses the `IsBusy` property to control UI interaction during ViewModel operations.
- Implements two-way form binding with Blazor `EditForm`, `InputText`, `InputTextArea`, `InputDate`, and `InputCheckbox` components.
- Uses model binding to edit `ToDoItem` properties including `Title`, `Notes`, `Date`, and `Done`.
- Generates unique identifiers for newly created items using `Guid.NewGuid()`.
- Provides in-place editing by selecting existing items from the to-do list and assigning them to the active ViewModel item.
- Displays a dynamically calculated pending-item count through the `ToDoItems` property.
- Automatically refreshes UI components when ViewModel properties change using `PropertyChanged` event notifications.
- Demonstrates component-to-component state synchronization between `ToDoListComponent` and `ToDoFormComponent`.
- Supports task status tracking through the `Done` property with visual styling differences for completed and pending items.
- Sorts to-do items by date and completion status before rendering the list view.

## Prerequisites

- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or [Visual Studio Code](https://code.visualstudio.com/)
- [.NET SDK](https://dotnet.microsoft.com/en-us/download/dotnet) compatible with the project's target framework

## How to Run the Project

**Visual Studio 2022**

1. Clone or download this repository.
2. Open `UsingMVVMPattern.sln`.
3. Restore all NuGet packages.
4. Ensure `UsingMVVMPattern` is selected as the startup project.
5. Build the solution.
6. Run the application using `Ctrl+F5`.

**Visual Studio Code**

1. Open the repository folder.
2. Navigate to the project directory containing `UsingMVVMPattern.csproj`.

```bash
dotnet restore
dotnet run
```

3. Open the URL displayed in the terminal after the application starts.

## Project Structure

`Pages/ToDoPage.razor` - Main MVVM demonstration page that injects `IToDoViewModel`, provides it through `CascadingValue`, and coordinates UI updates through `PropertyChanged` events.

`Components/ToDoListComponent.razor` - Displays the to-do collection, sorts items by date and completion status, and supports item selection for editing.

`Components/ToDoFormComponent.razor` - Edit form used to create and update to-do items using Blazor form components and ViewModel data binding.

`Models/ToDoItem.cs` - Domain model representing a task with `Id`, `Title`, `Notes`, `Date`, and `Done` properties.

`ViewModels/IToDoViewModel.cs` - ViewModel contract defining shared state, events, and operations used by the application.

`ViewModels/BaseViewModel.cs` - Reusable ViewModel base class implementing `INotifyPropertyChanged`, `SetValue<T>()`, and busy-state management.

`ViewModels/ToDoBasicViewModel.cs` - Initial MVVM implementation showing direct `INotifyPropertyChanged` usage without a base ViewModel abstraction.

`ViewModels/ToDoFinalViewModel.cs` - Refactored MVVM implementation that inherits from `BaseViewModel` and centralizes property change notification logic.

## Support and Feedback

- For general product questions, visit the [Syncfusion Community Forum](https://www.syncfusion.com/forums) or [Syncfusion Support](https://www.syncfusion.com/support).
- To report an issue specific to this sample, open a GitHub issue in this repository.
- [Getting Started with .NET MAUI Blazor App](https://blazor.syncfusion.com/documentation/getting-started/maui-blazor-app)

## License

This is a Syncfusion sample project provided to demonstrate product usage. Review the [Syncfusion license terms](https://www.syncfusion.com/sales/pricing?category=ui-components) before using Syncfusion components in your own applications.