using ISRPO_Palashicheva_PR14.ApplicationData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ISRPO_Palashicheva_PR14.PageMain
{
    /// <summary>
    /// Логика взаимодействия для PageTovars.xaml
    /// </summary>
    public partial class PageTovars : Page
    {
        public PageTovars()
        {
            InitializeComponent();
            DtGridTovar.ItemsSource = KitchenEntities.GetContext().Tovars.ToList();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.FrameMain.Navigate(new PageTovarsEditAdd((sender as Button).DataContext as Tovars));
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            var tovarForRemoving = DtGridTovar.SelectedItems.Cast<Tovars>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующее {tovarForRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    KitchenEntities.GetContext().Tovars.RemoveRange(tovarForRemoving);
                    KitchenEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");

                    DtGridTovar.ItemsSource = KitchenEntities.GetContext().Tovars.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.FrameMain.Navigate(new PageTovarsEditAdd(null));
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                KitchenEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DtGridTovar.ItemsSource = KitchenEntities.GetContext().Tovars.ToList();
            }
        }
    }
}
