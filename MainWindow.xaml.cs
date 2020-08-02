using System.Windows;

namespace MVVM
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new NoteWorkViewModel();
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            ((NoteWorkViewModel)DataContext).AddNote();
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            ((NoteWorkViewModel)DataContext).DeleteNote();
        }
    }
}