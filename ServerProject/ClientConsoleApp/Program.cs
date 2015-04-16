﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServerProject.DatabaseLayer;
using ServerProject.ControllerLayer;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(String[] arg)
        {
            Program program = new Program();

            program.GetScheduler();

            //program.getHall();
        }

        public void GetScheduler()
        {
            ServerProject.ControllerLayer.CustomerController cusCtr = new CustomerController();
            ServerProject.ControllerLayer.MovieController movCtr = new MovieController();
            ServerProject.DatabaseLayer.DBScheduler schCtr = new ServerProject.DatabaseLayer.DBScheduler();

            Console.WriteLine("ID:" + schCtr.GetScheduler(1).SchID + "\nHall ID: " + schCtr.GetScheduler(1).HallID + "\nDate: " + schCtr.GetScheduler(1).Datetime);

            Console.WriteLine("WELCOME TO THE TEST APP \n");

            foreach (Customer customer in cusCtr.getAllCustomers())
            {
                Console.WriteLine(customer.CusID + ": " + customer.name + "\n");
            }

            Console.WriteLine("****************************** FIND CUSTOMER BY ID ******************************\n");

            Console.WriteLine(cusCtr.findCustomerByID(4).CusID + ": " + cusCtr.findCustomerByID(4).name + "\n");

            Console.WriteLine("****************************** FIND CUSTOMERS WITH NAME ******************************\n");

            foreach (Customer customer in cusCtr.findCustomersByName("Jens"))
            {
                Console.WriteLine(customer.CusID + ": " + customer.name + "\n");
            }

            Console.WriteLine("****************************** FIND MOVIE BY NAME ******************************\n");

            Console.WriteLine(movCtr.findMovieByName("Super-Man").MovieID + ": " + movCtr.findMovieByName("Super-Man").name + ". Playtime: " + movCtr.findMovieByName("Super-Man").Playtime + "\n");

            Console.WriteLine("****************************** FIND MOVIE BY ID ******************************\n");

            Console.WriteLine(movCtr.findMovieByID(3).MovieID + ": " + movCtr.findMovieByID(3).name + ". Playtime: " + movCtr.findMovieByID(3).Playtime + "\n");

            Console.WriteLine("****************************** FIND ALL MOVIES ******************************\n");


            foreach (Movie movie in movCtr.getAllMovies())
            {
                Console.WriteLine(movie.MovieID + ": " + movie.name + ". Playtime: " + movie.Playtime + "\n");
            }

            Console.ReadLine();

        }

        public void getHall()
        {
            Console.WriteLine("WELCOME TO THE TEST APP \n");
        }

    }
}
