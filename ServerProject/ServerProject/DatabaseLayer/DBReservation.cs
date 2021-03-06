﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading;

namespace ServerProject.DatabaseLayer
{
    class DBReservation
    {
        private object lockToken = new object();        

        public IEnumerable GetReservation()
        {
            ConnectToDatabaseDataContext db = new ConnectToDatabaseDataContext();
            DBCustomer dbCustomer = new DBCustomer();
            List<Customer> customers = dbCustomer.GetAllCustomers().Cast<Customer>().ToList();
            List<Reservation> reservation = db.Reservations.Select(x => x).AsEnumerable().ToList();

            var cusResJoin = from res in reservation
                             join cust in customers on res.CustomerID equals cust.CusID
                             select res;

            return cusResJoin;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="resID">The reservation ID, of the reservation that has to be edited</param>
        /// <param name="customerID">Customer ID, if it needs to be changes to a new customer</param>
        /// <param name="row">The rows the reservation has made</param>
        /// <param name="seat">The seats the reservation has made</param>
        /// <param name="schID">Scheduler ID for the reservation, if it needs to be changed</param>
        public void UpdateReservation(int resID, int customerID, string row, string seat, int schID)
        {
            ConnectToDatabaseDataContext db = new ConnectToDatabaseDataContext();
            db.Connection.Open();
            db.Transaction = db.Connection.BeginTransaction(IsolationLevel.RepeatableRead);
            Reservation reservation = db.Reservations.First(r => r.ResID == resID);

            reservation.CustomerID = customerID;
            reservation.Row = row;
            reservation.Seat = seat;
            reservation.SchedulerID = schID;
                
                try
                {
                     
                    db.Transaction.Commit();
                    db.Transaction.Dispose();
                    db.Connection.Close();

                }
                catch (Exception e)
                {
                    db.Transaction.Rollback();
                    Console.WriteLine(e);
                    db.Connection.Close();
                }
        }

        /// <summary>
        /// Inserts a new reservation to the database
        /// </summary>
        /// <param name="res">A reservation object, that needs to be uploaded</param>
        public void insertReservation(Reservation res)
        {
            //make it a reservation
            Reservation reservation = new Reservation();
            reservation = res;

            ConnectToDatabaseDataContext db = new ConnectToDatabaseDataContext();
            db.Connection.Open();
            db.Transaction = db.Connection.BeginTransaction(IsolationLevel.RepeatableRead);
            db.Reservations.InsertOnSubmit(reservation);
            try
            {
                 
                db.Connection.Close();
            }
            catch (Exception e)
            {
                db.Transaction.Rollback();
                Console.WriteLine(e);
                db.Connection.Close();

            }

        }

        /// <summary>
        /// Gets a list reservations by phone number of the customer
        /// </summary>
        /// <param name="phone">The customers phone number</param>
        /// <returns>Returns the list of the reservations</returns>
        public List<Reservation> GetReservationByCusPhone(string phone)
        {
            DBCustomer dbC = new DBCustomer();
            Customer cus = dbC.GetByPhone(phone);
            int id = cus.CusID;

            List<Reservation> list = new List<Reservation>();
            var db = new ConnectToDatabaseDataContext();
            list = db.Reservations.Select(x => x).Where(x => x.CustomerID == id).ToList();
            return list;

        }
    }
}
