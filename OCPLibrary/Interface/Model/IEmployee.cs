﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibrary.Interface.Model
{
    public interface IEmployee
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string EmailAddress { get; set; }
        bool isManager { get; set; }
        bool isExecutive { get; set; }
    }
}
