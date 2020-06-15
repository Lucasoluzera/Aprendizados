using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Farmacia_Toledo
{
    public class Connection 
    {
        //TODO CONFIGURAR A LINHA DE CONEXAO 
        public string stringConnection = "Persist Security Info=False;server=localhost;database=farmacia;uid=root;password=root";
        protected MySqlConnection strConn = null;

        public void openConnection()
        {
            try
            {
                strConn = new MySqlConnection(stringConnection);
                strConn.Open();
             
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }

        public void closeConnection()
        {
            try
            {
                strConn = new MySqlConnection(stringConnection);
                strConn.Close();
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }
            
    }
}
