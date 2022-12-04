using System.IO;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace JACT.Desktop.Components;

public class FilePickerViewModel
{
    public string Path { get; set; }
}

public partial class FilePicker : UserControl
{

    public string Path;
    public FilePicker()
    {
        InitializeComponent();
        Path = "";
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        var picker = new OpenFolderDialog();
        var mw = Parent.FindControl<Window>("HomeWindow");
        var result = picker.ShowAsync(mw);
        result.Wait();
        if (result.Result != null)
        {
            this.PathBox.Text = result.Result;
        }
    }
}