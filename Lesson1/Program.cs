using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            var pb = new PhoneBook();
            //Random r = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    pb.Add(new Contact($"A{i}", $"A{i}yan", $"A{i}@mail.ru", $"{r.Next(100000000, 999999999)}"));
            //}

            pb.Clear();
        }
    }
}
