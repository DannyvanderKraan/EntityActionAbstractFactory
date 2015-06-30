using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityActionAbstractFactory
{
    public interface IEntityAction
    {
        int EntityID { get; set; }
        string EntityName { get; set; }
        int ActionID { get; set; }
        string ActionName { get; set; }

    }
}
