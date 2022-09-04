using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewChangeDataGrid.Common.Models
{
    public class TreeModel : BaseModel
    {
        private ObservableCollection<StudentInfo> student = new ObservableCollection<StudentInfo>();

        public ObservableCollection<StudentInfo> Student
        {
            get => student;
            set
            {
                student = value;
                OnPropertyChanged();
            }
        }

    }

}
