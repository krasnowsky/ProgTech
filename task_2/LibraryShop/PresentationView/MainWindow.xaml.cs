using Presentation.ViewModel;
using System;
using System.Windows;

namespace PresentationView
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
            CustomerViewModel customerViewModel = (CustomerViewModel)DataContext;
            customerViewModel.ChildWindow = new Lazy<IWindow>(() => new SecondWindow());
            customerViewModel.MessageBoxShowDelegate = text => MessageBox.Show(text, "Warning", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
