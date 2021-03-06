﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;

namespace ServerProject.DatabaseLayer
{
    public class DBScheduler
    {
        //Use LINQ to get the schedulers where the schedulerID is x. (See inside SchedulerController.cs)
        /// <summary>
        /// Gets a scheduler by ID
        /// </summary>
        /// <param name="schedulerID">The ID of the scheduler</param>
        /// <returns>Returns the scheduler</returns>
        public Scheduler GetSchedulerByID(int schedulerID)
        {
            var db = new ConnectToDatabaseDataContext();

            Scheduler scheduler = db.Schedulers.Single(x => x.SchID == schedulerID);

            return scheduler;
        }

        /// <summary>
        /// Find a scheduler by movie
        /// </summary>
        /// <param name="movieID">The ID of the movie</param>
        /// <returns>Returns the scheduler as a scheduler object</returns>
        public Scheduler GetSchedulerByMovieID(int movieID)
        {
            var db = new ConnectToDatabaseDataContext();

            Scheduler scheduler = db.Schedulers.Single(dbScheduler => dbScheduler.MovieID == movieID);

            return scheduler;

        }


        /// <summary>
        /// Get at list of schedulers, specified by a movie ID
        /// </summary>
        /// <param name="movieID">ID of the movie</param>
        /// <returns>A list of scheduler objects</returns>
        public List<Scheduler> GetSchedulerListByMovieID(int movieID)
        {
            var db = new ConnectToDatabaseDataContext();
            List<Scheduler> SchList = db.Schedulers.Select(x => x).Where(x => x.MovieID == movieID).ToList();
            return SchList;
            
        }


        //Innerjoin som joiner tabellerne scheduler, movie og hall


        public IEnumerable GetScheduler()
        {
            var db = new ConnectToDatabaseDataContext();

            DBMovie dbMovie = new DBMovie();
            List<Movie> movie = dbMovie.GetAllMovies().Cast<Movie>().ToList();
            List<Scheduler> scheduler = db.Schedulers.Select(x => x).AsEnumerable().ToList();

            var   InnerJoin =  from sch in scheduler
                               join mov in movie on sch.MovieID equals mov.MovieID
                                select sch;


            return InnerJoin;
        }

        /// <summary>
        /// Inserts a scheduler into the database
        /// </summary>
        /// <param name="sch">The object to insert</param>
        public void InsertScheduler(Scheduler sch)
        {
            var db = new ConnectToDatabaseDataContext();
            db.Schedulers.InsertOnSubmit(sch);
            try
            {
                 
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        /// <summary>
        /// Gets all schedulers
        /// </summary>
        /// <returns>A list of schedulers</returns>
        public List<Scheduler> GetAllSchedulers()
        {
            var db = new ConnectToDatabaseDataContext();

            var schedulerList = db.Schedulers.Select(x => x);


            return schedulerList.ToList();
        }

        /// <summary>
        /// Gets a scheduler by date and time
        /// </summary>
        /// <param name="date">Date and time writen as yyyyMMdd hhMMss</param>
        /// <returns>A list of schedulers</returns>
        public List<Scheduler> GetByDate(DateTime date)
        {
            var db = new ConnectToDatabaseDataContext();
            var Schedulerlist = db.Schedulers.Select(x => x).Where(x => x.Date == date);
            List<Scheduler> Sch = new List<Scheduler>();
            Sch = Schedulerlist.ToList();

            return Sch;
        }

        /// <summary>
        /// Inserts a scheduler into the database
        /// </summary>
        /// <param name="date"></param>
        /// <param name="time"></param>
        /// <param name="movieID">The ID of the movie that is to be scheduled</param>
        /// <param name="hallID">The ID of the hall in which the movie will be shown</param>
        public void InsertScheduler(DateTime date, TimeSpan time, int movieID, int hallID)
        {
            var db = new ConnectToDatabaseDataContext();

            Scheduler sch = new Scheduler();
            sch.Date = date;
            sch.Starttime = time;
            sch.MovieID = movieID;
            sch.HallID = hallID;

            db.Schedulers.InsertOnSubmit(sch);
             

            var result = (from t in db.Schedulers orderby t.SchID descending select t.SchID).First();
            var HallSeatList = db.HallSeats.Select(x => x).Where(x => x.HallID == hallID);
            foreach (HallSeat hallSeat in HallSeatList)
            {
                Seat seat = new Seat();
                seat.Row = hallSeat.Row;
                seat.ColumnArray = hallSeat.seatNumbers;
                seat.SchedulerID = result;
                db.Seats.InsertOnSubmit(seat);
            }
             
        }

        public void UpdateSchedulers(int schID, DateTime date, TimeSpan time, int movieID, int hallID)
        {
            var db = new ConnectToDatabaseDataContext();
            db.Connection.Open();
            db.Transaction = db.Connection.BeginTransaction(IsolationLevel.RepeatableRead);

            Scheduler scheduler = db.Schedulers.Single(x => x.SchID == schID);

            scheduler.Date = date;
            scheduler.Starttime = time;
            scheduler.MovieID = movieID;
            scheduler.HallID = hallID;

            try
            {
                 
                db.Transaction.Commit();
                db.Transaction.Dispose();
                db.Connection.Close();
            }
            catch (Exception e)
            {
                db.Transaction.Rollback();
                Console.WriteLine(e.Message);
                db.Connection.Close();
            }
        }

        public void DeleteSch (int schID)
        {
            var db = new ConnectToDatabaseDataContext();
            Scheduler scheduler = db.Schedulers.Single(x => x.SchID == schID);
            //Scheduler DelScheduler = new Scheduler();
            //DelScheduler.SchID = scheduler.SchID;
            db.Schedulers.DeleteOnSubmit(scheduler);

            try
            {
                 
            }
            catch
            {
                Console.Write("Delete scheduler failed");
            }
        }
    }
}