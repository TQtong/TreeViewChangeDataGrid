using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeViewChangeDataGrid.Common.Models;
using TreeViewChangeDataGrid.Interface;

namespace TreeViewChangeDataGrid.Common.Managers
{
    public class TreeViewManager : TreeViewInterface
    {
		private static ObservableCollection<TreeModel> treeModels = new ObservableCollection<TreeModel>();

		public static ObservableCollection<TreeModel> TreeModels
        {
			get => treeModels;
			set
			{
                treeModels = value;
                OnTreeModelsChanged();
			}
		}

        public static event EventHandler TreeModelsChanged;
        public static void OnTreeModelsChanged()
        {
            TreeModelsChanged?.Invoke(TreeModels, new EventArgs());
        }

        public void InitTree()
        {
            TreeModel treeModel = new TreeModel()
            {
                Guid = Guid.NewGuid(),
                Name = "三年级二班",
                Node = Enums.NodeType.Grade
            };

            StudentInfo student = new StudentInfo()
            {
                Name = "小红",
                Guid = treeModel.Guid,
                Age = 8,
                Gender = "女",
                Address = "天河路",
                Node = Enums.NodeType.Student,
                Number = "111111"
            };

            treeModel.Student.Add(student);

            student = new StudentInfo()
            {
                Name = "小明",
                Guid = treeModel.Guid,
                Age = 8,
                Gender = "男",
                Address = "尧新路",
                Node = Enums.NodeType.Student,
                Number = "222222"
            };

            treeModel.Student.Add(student);

            student = new StudentInfo()
            {
                Name = "小黑",
                Guid = treeModel.Guid,
                Age = 7,
                Gender = "男",
                Address = "水西路",
                Node = Enums.NodeType.Student,
                Number = "333333"
            };

            treeModel.Student.Add(student);

            TreeModels.Add(treeModel);
        }

    }
}
