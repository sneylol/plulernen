using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TodoMauiApp.Model;

namespace TodoMauiApp.ViewModel;
public partial class MainPageViewModel : ObservableObject {
    #region Fields

    private ObservableCollection<TodoViewModel> _todos = new();
    private TodoViewModel _selectedItem = null!;
    #endregion


    #region Properties
    public TodoViewModel NewTodo
    {
        get;
        set;
    } = new TodoViewModel(new Todo(title: "", due: DateTime.Now, finished: false));

    public TodoViewModel SelectedItem2
    {
        get => _selectedItem;
        set
        {
            _selectedItem = value;
            //OnPropertyChanged("SelectedItem2");
            //OnPropertyChanged("AndereProperty");
            // weiterer 
            //TueWas(value.Title);
        }
    }
    public ObservableCollection<TodoViewModel> Todos
    {
        get => _todos;
        set
        {
            _todos = value;
            OnPropertyChanged("Todos");
        }
    }

    public ICommand AddTodoCommand { get; }
    public ICommand ChangeTodoCommand { get; }
    
    #endregion


    #region Constructor
    public MainPageViewModel()
    {
        AddTodoCommand = new RelayCommand(AddTodo);
        ChangeTodoCommand = new RelayCommand(ChangeTodo);
    }
    #endregion

    #region Methods

    private void ChangeTodo()
    {
        // Just for fun ...
        if (!Todos.Any()) return;
        Todos[0].Finished = !Todos[0].Finished;
        if(SelectedItem2 is not null)
        {
            Debug.WriteLine(SelectedItem2.Title);
        }
        
    }

    private  void AddTodo()
    {
        var newTodo = new TodoViewModel(new Todo(title: NewTodo.Title, due: NewTodo.Due, finished: false ));
        Todos.Add(newTodo);
    }
    #endregion

    //#region Interface Member
    // mit:
    //public partial class MainPageViewModel : INotifyPropertyChanged {
    // ...
    //public event PropertyChangedEventHandler PropertyChanged;

    //public void OnPropertyChanged(string name)
    //{
    //    if (this.PropertyChanged != null)
    //        this.PropertyChanged(this, new PropertyChangedEventArgs(name));
    //}

    //#endregion
}
