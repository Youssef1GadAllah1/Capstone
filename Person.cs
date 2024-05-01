using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    abstract internal class Person
    {
        // att
        protected string Name;
        protected string ID;
        protected string Password;

        // methods 

        public virtual void SetName(string name)
        {
            Name = name;
        }
        public virtual string GetName()
        {
            return Name;
        }
        public virtual void SetID(string Id)
        {
            Id = ID;
        }
        public virtual string GetID()
        {
            return ID;
        }
        public virtual void SetPassword(string password)
        {
            this.Password = password;
        }
        public virtual string GetPassword()
        {
            return Password;
        }
    }
}