using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityActionAbstractFactory
{
    class Program
    {

        static IEntityActionViewModelFactory Factory { get; set; }

        public static IUnityContainer Container { get; set; }

        static void Main(string[] args)
        {

            //Domain Models
            IEntityAction patientAdd = new EntityAction()
            {
                EntityID = 1,
                EntityName = "Patient",
                ActionID = 1,
                ActionName = "Add"
            };
            IEntityAction patientRemove = new EntityAction()
            {
                EntityID = 1,
                EntityName = "Patient",
                ActionID = 2,
                ActionName = "Remove"
            };

            IEntityAction contactAdd = new EntityAction()
            {
                EntityID = 2,
                EntityName = "Contact",
                ActionID = 1,
                ActionName = "Add"
            };

            IEntityAction contactRemove = new EntityAction()
            {
                EntityID = 2,
                EntityName = "Contact",
                ActionID = 2,
                ActionName = "Remove"
            };


            IEntityActionViewModel entityActionViewModel;

            Factory = new EntityActionViewModelFactory();

            Console.WriteLine("---{0}---", nameof(EntityActionViewModelFactory));

            entityActionViewModel = Factory.CreateEntityActionViewModel(patientAdd);

            entityActionViewModel?.Operate();

            entityActionViewModel = Factory.CreateEntityActionViewModel(patientRemove);

            entityActionViewModel?.Operate();

            entityActionViewModel = Factory.CreateEntityActionViewModel(contactAdd);

            entityActionViewModel?.Operate();

            entityActionViewModel = Factory.CreateEntityActionViewModel(contactRemove);

            entityActionViewModel?.Operate();

            Factory = new ConcatEntityActionViewModelFactory();

            Console.WriteLine("---{0}---", nameof(ConcatEntityActionViewModelFactory));

            entityActionViewModel = Factory.CreateEntityActionViewModel(patientAdd);

            entityActionViewModel?.Operate();

            entityActionViewModel = Factory.CreateEntityActionViewModel(patientRemove);

            entityActionViewModel?.Operate();

            entityActionViewModel = Factory.CreateEntityActionViewModel(contactAdd);

            entityActionViewModel?.Operate();

            entityActionViewModel = Factory.CreateEntityActionViewModel(contactRemove);

            entityActionViewModel?.Operate();

            //Composition Root
            Container = new UnityContainer();
            Container.RegisterType<IEntityActionViewModelFactory, ContainerEntityActionViewModelFactory>();
            Container.RegisterType<IEntityAction, EntityAction>();
            Container.RegisterType<IEntityActionViewModel, PatientAdd>(nameof(PatientAdd));
            Container.RegisterType<IEntityActionViewModel, PatientRemove>(nameof(PatientRemove));
            Container.RegisterType<IEntityActionViewModel, ContactAdd>(nameof(ContactAdd));
            Container.RegisterType<IEntityActionViewModel, ContactRemove>(nameof(ContactRemove));

            Factory = Container.Resolve<IEntityActionViewModelFactory>();

            Console.WriteLine("---{0}---", nameof(ContainerEntityActionViewModelFactory));

            IEntityAction resolvedPatientAdd = Container.Resolve<IEntityAction>();
            resolvedPatientAdd.EntityID = 1;
            resolvedPatientAdd.EntityName = "Patient";
            resolvedPatientAdd.ActionID = 1;
            resolvedPatientAdd.ActionName = "Add";

            IEntityAction resolvedPatientRemove = Container.Resolve<IEntityAction>();
            resolvedPatientRemove.EntityID = 1;
            resolvedPatientRemove.EntityName = "Patient";
            resolvedPatientRemove.ActionID = 2;
            resolvedPatientRemove.ActionName = "Remove";

            IEntityAction resolvedContactAdd = Container.Resolve<IEntityAction>();
            resolvedContactAdd.EntityID = 2;
            resolvedContactAdd.EntityName = "Contact";
            resolvedContactAdd.ActionID = 1;
            resolvedContactAdd.ActionName = "Add";

            IEntityAction resolvedContactRemove = Container.Resolve<IEntityAction>();
            resolvedContactRemove.EntityID = 2;
            resolvedContactRemove.EntityName = "Contact";
            resolvedContactRemove.ActionID = 2;
            resolvedContactRemove.ActionName = "Remove";

            entityActionViewModel = Factory.CreateEntityActionViewModel(resolvedPatientAdd);

            entityActionViewModel?.Operate();

            entityActionViewModel = Factory.CreateEntityActionViewModel(resolvedPatientRemove);

            entityActionViewModel?.Operate();

            entityActionViewModel = Factory.CreateEntityActionViewModel(resolvedContactAdd);

            entityActionViewModel?.Operate();

            entityActionViewModel = Factory.CreateEntityActionViewModel(resolvedContactRemove);

            entityActionViewModel?.Operate();

            Console.ReadKey();

        }
    }
}
