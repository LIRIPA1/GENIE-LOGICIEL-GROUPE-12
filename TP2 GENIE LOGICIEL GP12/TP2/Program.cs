﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2.Abstract;
using System.Data.SqlClient;
using TP2.Connection;
using System.Data;
using MySql.Data.MySqlClient;

namespace TP2
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("ABSTRACT CLASS");
            Console.WriteLine("===============\n");
            Teacher t1 = new Teacher("LISA", "SIHERYA", "22LIAGELJ600020");
            Teacher t2 = new Teacher("longa", "clement", "20IGGJ008842");
            Student s1 = new Student("LIRIPA" , "KPAKI", "22LSILJ670206");
            Student s2 = new Student("KYAKIMWA" , "IRENE", "23LIAGELJ1070467");
            t1.Add(2);
            t2.Add(1);
            s1.Add(2);
            s2.Add(2);

            t1.show(1,2);
            Console.WriteLine("\n===============\n");
            s1.show(1,2);

            Console.WriteLine("\n===============\n");


            Console.WriteLine("INTERFACE ");
            Console.WriteLine("===============\n");

            Interfaces.Teacher t3 = new Interfaces.Teacher("michek", "saba", "lkji");
            Interfaces.Student s3 = new Interfaces.Student("mola", "mali", "22lsi65774");

            t2.Add(2);
            s2.Add(2);

            t2.show(2,2);
            Console.WriteLine("\n===============\n");
            s2.show(2,2);

            Console.WriteLine("\n===============\n");



            Console.ReadLine();

        }
    }
}
