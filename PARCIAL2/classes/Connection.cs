using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace PARCIAL2
{
    class Connection
    { 
        private MySqlConnection conn =
            new MySqlConnection("Server=localhost;Database=parcial2;Uid=root;" +
                "Pwd=usbw;SSL Mode=None");
    public MySqlCommand command;


    public MySqlConnection openConnection()
    {
        if (conn.State == ConnectionState.Closed)
        {
            conn.Open();
        }
        return conn;
    }

  
    public MySqlConnection closeConnection()
    {
        if (conn.State == ConnectionState.Open)
        {
            conn.Close();
        }
        return conn;
    }

}
}
