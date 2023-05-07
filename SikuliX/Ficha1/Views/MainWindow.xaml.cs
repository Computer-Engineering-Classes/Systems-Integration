using System.Windows;
using Ficha1.ViewModels;

namespace Ficha1.Views;

/// <summary>
///     Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow
{
    private readonly MainWindowViewModel _context;

    public MainWindow()
    {
        InitializeComponent();
        _context = (MainWindowViewModel)DataContext;
    }

    private void BtAddStudent_Click(object sender, RoutedEventArgs e)
    {
        var valid = _context.ValidateFields();
        if (!valid)
        {
            MessageBox.Show("Invalid fields", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        else
        {
            _context.AddStudent();
            _context.ClearFields();
        }
    }

    private void BtListStudents_Click(object sender, RoutedEventArgs e)
    {
        var listWindow = new ListWindow();
        listWindow.Show();
    }

    private void BtRemoveStudent_Click(object sender, RoutedEventArgs e)
    {
        var valid = _context.ValidateFields();
        if (!valid)
        {
            MessageBox.Show("Invalid fields", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        else
        {
            _context.RemoveStudent();
            _context.ClearFields();
        }
    }
}