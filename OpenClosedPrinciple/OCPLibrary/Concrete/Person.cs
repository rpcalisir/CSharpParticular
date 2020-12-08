﻿using OpenClosedPrinciple.OCPLibrary.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.OCPLibrary.Concrete
{
    public class Person : IApplicant
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccounts AccountGenerator { get; set; }
    }
}
