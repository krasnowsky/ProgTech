using Presentation.ViewModel;
using System;
using System.Windows;


namespace PresentationView
{
    /// <summary>
    /// Logika interakcji dla klasy SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window, IWindow
    {
        public SecondWindow()
        {
            InitializeComponent();
        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
            ProductViewModel productViewModel = (ProductViewModel)DataContext;
            productViewModel.ChildWindow = new Lazy<IWindow>(() => new ThirdWindow());
            productViewModel.MessageBoxShowDelegate = text => MessageBox.Show(text, "Warning", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
