using Capstone;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Capstone
{
    internal class Admin : Person
    {
        //att

        //Methods
        public override void SetName(string name)
        {
            Name = name;
        }
        public override string GetName()
        {
            return Name;
        }
        public override void SetID(string Id)
        {
            ID = Id;
        }
        public override string GetID()
        {
            return ID;
        }
        public override void SetPassword(string password)
        {
            Password = password;
        }
        public override string GetPassword()
        {
            return Password;
        }

    }

}
