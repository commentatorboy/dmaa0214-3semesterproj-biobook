﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq.Mapping;

namespace ServerProject.ModelLayer
{
    public class Customer : DatabaseLayer.Customer
    {

        private string name;
        private int cusID;

        public Customer()
        {
            name = null;
            cusID = -1;
        }

        public Customer(string name, int cusID)
        {
            this.name = name;
            this.cusID = cusID;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int CusID
        {
            get { return cusID; }
            set { cusID = value; }
        }

        public Customer(int ID, string Name)
        {
            this.CusID = ID;
            this.Name = Name;
        }


    }
}