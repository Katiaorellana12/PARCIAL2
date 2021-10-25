using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PARCIAL2
{
  public class Account
    {
        Connection conn = new Connection();
        crud crud = new crud();

        public static int _CODUSER { get; set; }
        public  string _PRIMER_NOMBRE { get; set; }
        public  string _NOMBRE_DE_USUARIO { get; set; }

        public string _PRIMER_APELLIDO { get; set; }
        public  string  _CORREO { get; set; }
        public  string _FECHA_DE_REGISTRO { get; set; }
  
        public string _CONTRASEÑA { get; set; }
        public  int _CODLOG { get; set; }


        public MySqlDataReader getAll()
        {
            string query = "SELECT * FROM account WHERE CODUSER <> 1 ";
           

            return crud.select(query);
        }

        public Boolean REGISTRARCUENTA()
        {
            string query = "INSERT INTO account(CODUSER, PRIMER_NOMBRE, PRIMER_APELLIDO, CORREO, FECHA_DE_REGISTRO, NOMBRE_DE_USUARIO, CONTRASEÑA)" +
                "VALUES ('" + _CODUSER + "','" + _PRIMER_NOMBRE + "', '" + _PRIMER_APELLIDO + "', '" + _CORREO + "', '" + _FECHA_DE_REGISTRO + "', '" + _NOMBRE_DE_USUARIO + "', '" + _CONTRASEÑA + "')";
            crud.executeQuery(query);
            return true;

        }


        public Boolean login()
        {
            string query = "SELECT * FROM account WHERE NOMBRE_DE_USUARIO='" + _NOMBRE_DE_USUARIO+"' AND CONTRASEÑA='" + _CONTRASEÑA+"'";
            if (crud.select(query).HasRows)
            {
                return true;
            }
            return false;
        }
        public MySqlDataReader getAllLOG()
        {
            string query = "SELECT * FROM userlog WHERE CODLOG <> 0 ";


            return crud.select(query);
        }
        public void Insertarlog()
        {
            string Insertarlog = "INSERT INTO userlog( CODLOG, NOMBRE_DE_USUARIO, TIMELOGGEDIN) VALUES('" + _CODLOG + "','" + _NOMBRE_DE_USUARIO + "', '" + _FECHA_DE_REGISTRO + DateTime.Now.ToString("dddd, dd MMM yyy HH:mm:ss") + "')";
            crud.executeQuery(Insertarlog);
        }
        public MySqlDataReader getbyID()
        {
            string query = "SELECT * FROM account  WHERE NOMBRE_DE_USUARIO='" + _NOMBRE_DE_USUARIO + "' ";
            return crud.select(query);
        }
        public MySqlDataReader getLog()
        {
            string query = " SELECT * FROM userlog";

            return crud.select(query);
        }
        public MySqlDataReader getLogWithoutAdmin()
        {
            string query = "SELECT * FROM userlog WHERE NOMBRE_DE_USUARIO <> 'admin' ";
            return crud.select(query);
        }
        public MySqlDataReader getAlldatos()
        {
            string query = "SELECT PRIMER_NOMBRE, PRIMER_APELLIDO,CORREO, FECHA_DE_REGISTRO, NOMBRE_DE_USUARIO, CONTRASEÑA FROM account ";


            return crud.select(query);
        }
        public MySqlDataReader LogWithoutAdmin()
        {
            string query = "SELECT * FROM account  WHERE NOMBRE_DE_USUARIO <> 'admin' ";
            {
                return crud.select(query);
            }
        }
        public Boolean perfil()
        {
            string query = "SELECT * FROM account WHERE NOMBRE_DE_USUARIO <> 'admin' +  AND CONTRASEÑA  <> 'admin' ";
            if (crud.select(query).HasRows)
            {
                return true;
            }
            return false;
        }
    }
    }
