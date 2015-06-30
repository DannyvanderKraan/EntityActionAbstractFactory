using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityActionAbstractFactory
{
    public class EntityActionViewModelFactory : IEntityActionViewModelFactory
    {
        public IEntityActionViewModel CreateEntityActionViewModel(IEntityAction entityAction)
        {
            switch (entityAction.EntityID)
            {
                case 1:
                    switch (entityAction.ActionID)
                    {
                        case 1:
                            return new PatientAdd();
                        case 2:
                            return new PatientRemove();
                        default:
                            return null;
                    }
                case 2:
                    switch (entityAction.ActionID)
                    {
                        case 1:
                            return new ContactAdd();
                        case 2:
                            return new ContactRemove();
                        default:
                            return null;
                    }
                default:
                    return null;
            }
        }
    }
}
