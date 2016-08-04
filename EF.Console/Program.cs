using EF.DataAccess.Contexts;
using EF.DataAccess.MigrationsBaga;
using EF.DataAccess.Models.Baga;
using System;
using System.Data.Entity;
using System.Linq;

namespace EF.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Poets.Load();
           Poets.DeleteOp();
            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadLine();
        }


    }
}
