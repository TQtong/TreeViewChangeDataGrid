using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using TreeViewChangeDataGrid.Common.Extension;
using TreeViewChangeDataGrid.Common.Managers;
using TreeViewChangeDataGrid.Common.Models;
using TreeViewChangeDataGrid.Interface;
using TreeViewChangeDataGrid.Views;
using TreeView = System.Windows.Controls.TreeView;

namespace TreeViewChangeDataGrid.ViewModels
{
    public class TreeViewModel : BindableObject
    {
        private readonly TreeViewInterface @interface;

        public ObservableCollection<TreeModel> TreeModels => TreeViewManager.TreeModels;

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


        private StudentInfo student;

        public StudentInfo Student
        {
            get => student;
            set
            {
                student = value;
                OnPropertyChanged();
            }
        }

        private BaseModel baseModel;

        public BaseModel BaseModel
        {
            get => baseModel;
            set
            {
                baseModel = value;
                OnPropertyChanged();
            }
        }

        public DelegateCommand<TreeView> SelectChangeCommand { get; private set; }

        public DelegateCommand<TreeModel> OpenTableCommand { get; private set; }

        public TreeViewModel(TreeViewInterface @interface)
        {
            this.@interface = @interface;
            this.SelectChangeCommand = new DelegateCommand<TreeView>(SelectChange);
            OpenTableCommand = new DelegateCommand<TreeModel>(OpenTable);
            InitTree();
        }

        #region 命令
        public void OpenTable(TreeModel model)
        {
            var win = new DataGridView(model);
            win.Show();
        }
        #endregion

        #region 事件
        public void SelectChange(TreeView tree)
        {
            BaseModel = (BaseModel)tree.SelectedItem;
            JudgeNode();
        }
        #endregion

        #region 方法
        private void InitTree()
        {
            this.@interface.InitTree();
            BaseModel = TreeModels[0];
        }

        private void JudgeNode()
        {
            switch (BaseModel.Node)
            {
                case TreeViewChangeDataGrid.Common.Enums.NodeType.Grade:
                    TreeModel = (TreeModel)BaseModel;
                    break;
                case TreeViewChangeDataGrid.Common.Enums.NodeType.Student:
                    Student = (StudentInfo)BaseModel;
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
