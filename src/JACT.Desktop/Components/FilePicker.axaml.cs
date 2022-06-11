using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace JACT.Desktop.Components;

public partial class FilePicker : UserControl
{
    public FilePicker()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}