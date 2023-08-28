using Avalonia.Controls.Primitives;

namespace MenuTemplate.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    public MenuItemVM[] Menus => new MenuItemVM[] { new () { Header = "Food",
        Items = new MenuItemVM[] { new() { Header = "Hamburger" }, new() { Header = "Pizza", IsChecked = true } } }, 
      new() { Header="Drinks", IsChecked = false } };
}
