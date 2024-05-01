using Capstone;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Capstone
{
    internal class Manager : Person
    {
        //att 
        public int NumberOfTrainee;
        public string SpecializationName;
        // methods
        #region SETGET
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
        #endregion

        public void SetNumberOfTrainee(int NumberOfTrainee)
        {
            this.NumberOfTrainee = NumberOfTrainee;
        }

        public int GetNumberOfTrainee()
        {
            return NumberOfTrainee;
        }

        public void SetSpecializationName(string NAMESP)
        {
            SpecializationName = NAMESP;
        }

        public string GetSpecializationName()
        {
            return SpecializationName;

        }

    }
}