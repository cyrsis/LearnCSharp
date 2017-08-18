using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;

namespace Sixeyed.ExtensionLibrary.Stubs.Web.Models
{
    public class UserModel
    {
        public string Name { get; set; }

        public Module CurrentModule { get; set; }

        public ModuleStatus Status { get; set; }
    }

    public enum Module
    {
        [System.ComponentModel.Description("<Please Select>")]
        None = 0,
        [System.ComponentModel.Description("Introducing Extension Methods")]
        Intro,
        Advanced,
        Library
    }

    public enum ModuleStatus
    {
        [System.ComponentModel.Description("<Please Select>")]
        None = 0,
        Todo = 1,
        [System.ComponentModel.Description("In Progress")]
        InProgress = 2,
        Complete = 3
    }

}