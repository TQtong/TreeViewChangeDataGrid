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
using System.Windows.Shapes;
using TreeViewChangeDataGrid.Common.Models;
using TreeViewChangeDataGrid.ViewModels;

namespace TreeViewChangeDataGrid.Views
{
    /// <summary>
    /// DataGridView.xaml 的交互逻辑
    /// </summary>
    public partial class DataGridView : Window
    {
        public DataGridView(TreeModel model)
        {
            InitializeComponent();
            this.DataContext = new DataGridViewModel(model);
        }

        /// <summary>
        /// 鼠标滚轮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            ScrollViewer scrollviewer = sender as ScrollViewer;
            if (e.Delta > 0)
            {
                scrollviewer.LineUp();
            }
            else
            {
                scrollviewer.LineDown();
            }
            e.Handled = true;
        }
    }

}
