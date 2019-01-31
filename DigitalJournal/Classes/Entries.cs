﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using DigitalJournal.Pages;
using DigitalJournal.Classes;

namespace DigitalJournal.Classes
{
    class Entries
    {
        
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        public Array Entryvals { get; set; }
        //TableColumns column = new TableColumns();

        public void CreateEntry()
        {
            // my database connection
            con = new SqlConnection("Data Source = DESKTOP-FH9J9JB\\SQLEXPRESS; Initial Catalog = Journal Entries; Integrated Security = True");
            con.Open();
            cmd = new SqlCommand("Insert Into Entry2(EntryName, Entry, Date, Userid) Values (@EntryName, @Entry, @Date, @UserID)", con);
            cmd.Parameters.AddWithValue("@EntryName", Entryvals.GetValue(0).ToString());
            cmd.Parameters.AddWithValue("@Entry", Entryvals.GetValue(1).ToString());
            cmd.Parameters.AddWithValue("@Date", DateTime.Now);
            cmd.Parameters.AddWithValue("@UserID", 1);
            cmd.ExecuteNonQuery();
        }
        //public void AssignUserID()
        //{
        //    con = new SqlConnection("Data Source = DESKTOP-FH9J9JB\\SQLEXPRESS; Initial Catalog = Journal Entries; Integrated Security = True");
        //    con.Open();
        //    cmd = new SqlCommand("Insert Into Associate(EntryName, Entry, DateCreated) Values (@EntryName, @Entry, @DateCreated)", con);
        //}
    }
}
