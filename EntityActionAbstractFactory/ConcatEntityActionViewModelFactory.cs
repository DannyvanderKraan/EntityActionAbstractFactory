using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityActionAbstractFactory
{
    public class ConcatEntityActionViewModelFactory : IEntityActionViewModelFactory
    {
        public IEntityActionViewModel CreateEntityActionViewModel(IEntityAction entityAction)
        {
            return (IEntityActionViewModel)Activator.CreateInstance(
                Type.GetType(
                    String.Format("{0}.{1}",
                    this.GetType().Namespace,
                    entityAction.EntityName + entityAction.ActionName)));
        }
    }
}
