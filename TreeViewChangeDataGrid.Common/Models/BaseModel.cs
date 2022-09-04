using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeViewChangeDataGrid.Common.Enums;

namespace TreeViewChangeDataGrid.Common.Models
{
    public abstract class BaseModel : BindableObject
    {
        public virtual string Name { get;  set; }

        public virtual Guid Guid { get;  set; }

        public virtual NodeType Node { get;  set; } = NodeType.Grade;
    }
}
