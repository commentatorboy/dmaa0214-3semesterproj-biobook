﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ServerProject.DatabaseLayer
{
    class DBReservation
    {
        private object lockToken = new object();
        ConnectToDatabaseDataContext db = new ConnectToDatabaseDataContext();
        public IEnumerable getReservation()
        {
            
            DBCustomer dbCustomer = new DBCustomer();
            List<Customer> customers = dbCustomer.GetAllCustomers().Cast<Customer>().ToList();
            List<Reservation> reservation = db.Reservations.Select(x => x).AsEnumerable().ToList();

            var cusResJoin = from res in reservation
                             join cust in customers on res.CustomerID equals cust.CusID
                             select res;

            return cusResJoin;
        }

        public void insertReservation(Reservation res)
        {
            //make it a reservation
           
            Reservation reservation = new Reservation();
            reservation = res;

            //lock it so only one at a time can work with it?

            lock (lockToken)
            {
                db.Reservations.InsertOnSubmit(reservation);
                try
                {
                    db.SubmitChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

        }
    }
}
