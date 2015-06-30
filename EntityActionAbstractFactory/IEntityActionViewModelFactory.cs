using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityActionAbstractFactory
{
    public interface IEntityActionViewModelFactory
    {
        IEntityActionViewModel CreateEntityActionViewModel(IEntityAction entityAction);
    }
}
