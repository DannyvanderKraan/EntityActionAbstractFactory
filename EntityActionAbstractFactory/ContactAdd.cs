﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityActionAbstractFactory
{
    public class ContactAdd : IEntityActionViewModel
    {
        public void Operate()
        {
            Console.WriteLine("Class: {0}, Method: {1}", nameof(ContactAdd), nameof(Operate));
        }
    }
}
