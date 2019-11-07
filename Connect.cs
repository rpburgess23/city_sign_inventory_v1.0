using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace connectcs
{
 public partial class Form1 : Form
 {
  public Form1()
  {
   InitializeComponent();
  }

  private void button1_Click(object sender, EventArgs e)
  {
   string connetionString;
   SqlConnection con;
   connetionString = @"Data Source=cleanearthsoftware.com ;Initial Catalog=4236paulgarlandclean_cims;User ID=cims_user;Password=CSC4610-01";
   con = new SqlConnection(connetionString);
   con.Open();
   MessageBox.Show("Connected!");
   con.Close();
  }
 }
}