using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cs390914_SD_3.Models;
using System.Data.Entity;

namespace Cs390914_SD_3.DAL.MIS4200Context
{
    public class MIS4200Context : DbContext 
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {


        }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<WorkoutDetails> WorkoutDetails { get; set; }
        public DbSet<Trainers> Trainers { get; set; }


    }
}