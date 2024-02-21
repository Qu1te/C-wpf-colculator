using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace MyWpfApp;


public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void Button_Click(object sender, RoutedEventArgs e)
    {
        Button button = (Button)sender;
        InputBox.Text += button.Content.ToString();
    }
    private void Operator_Click(object sender, RoutedEventArgs e)
    {
        Button button = (Button)sender;
        InputBox.Text += " " + button.Content.ToString() + " ";

    }
    private void Equal_Click(object sender, RoutedEventArgs e)
    {
        string expression = InputBox.Text;
        DataTable dt = new DataTable();
        var result = dt.Compute(expression, "");
        InputBox.Text = result.ToString();
    }

    private void Clear_Click(object sender, RoutedEventArgs e)
    {
        InputBox.Clear();
    }
}