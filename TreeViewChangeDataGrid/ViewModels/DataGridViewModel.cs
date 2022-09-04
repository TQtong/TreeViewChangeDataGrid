using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeViewChangeDataGrid.Common.Models;

namespace TreeViewChangeDataGrid.ViewModels
{
    public class DataGridViewModel : BindableObject
    {
		private TreeModel treeModel;

		public TreeModel TreeModel
        {
			get => treeModel;
			set
			{
                treeModel = value;
				OnPropertyChanged();
			}
		}

		public DataGridViewModel(TreeModel model)
        {
			this.TreeModel = model;
        }
    }
}
