using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityActionAbstractFactory
{
    public class ContainerEntityActionViewModelFactory : IEntityActionViewModelFactory
    {
        public IEntityActionViewModel CreateEntityActionViewModel(IEntityAction entityAction)
        {
            return Program.Container.Resolve<IEntityActionViewModel>(
                entityAction.EntityName + entityAction.ActionName);
        }
    }
}
