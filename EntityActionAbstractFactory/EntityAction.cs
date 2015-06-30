using System;

namespace EntityActionAbstractFactory
{
    public class EntityAction : IEntityAction
    {
        public int ActionID { get; set; }

        public string ActionName { get; set; }

        public int EntityID { get; set; }

        public string EntityName { get; set; }
    }
}