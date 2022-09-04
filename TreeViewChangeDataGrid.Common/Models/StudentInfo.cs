using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewChangeDataGrid.Common.Models
{
    public class StudentInfo : BaseModel
    {
        private string gender;

        public string Gender
        {
            get => gender;
            set
            {
                gender = value;
                OnPropertyChanged();
            }
        }

        private int age;

        public int Age
        {
            get => age;
            set
            {
                age = value;
                OnPropertyChanged();
            }
        }

        private string address;

        public string Address
        {
            get => address;
            set
            {
                address = value;
                OnPropertyChanged();
            }
        }

        private string number;

        public string Number
        {
            get => number;
            set
            {
                number = value;
                OnPropertyChanged();
            }
        }

    }
}
