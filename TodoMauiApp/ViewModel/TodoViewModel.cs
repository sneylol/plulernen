using CommunityToolkit.Mvvm.ComponentModel;
using TodoMauiApp.Model;

namespace TodoMauiApp.ViewModel;

public partial class TodoViewModel : ObservableObject {
    private readonly Todo _todo;

    public TodoViewModel(Todo todo)
    {
        _todo = todo;
    }

    public string Title
    {
        get => _todo.Title;
        set => SetProperty(_todo.Title, value, _todo, (model, v) => model.Title = v);
    }

    public DateTime Due
    {
        get => _todo.Due;
        set => SetProperty(_todo.Due, value, _todo, (model, v) => model.Due = v);
    }

    public bool Finished
    {
        get => _todo.Finished;
        set => SetProperty(_todo.Finished, value, _todo, (model, v) => model.Finished = v);
    }
}
