using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeCalculator
{
    public partial class Main : Form
    {

        String connectionString, cName;
        int modLevel;
        public Main()
        {
            InitializeComponent();


            warningMessage.Visible = false;
           
            connectionString = "Data Source = GradePredict.sqlite; Version =3";
            
            SQLiteConnection database = new SQLiteConnection(connectionString);
            database.Open();

            SQLiteCommand command = new SQLiteCommand("SELECT * FROM Courses", database);
            SQLiteDataReader getdata = command.ExecuteReader();

            while (getdata.Read())
            {
                comboBox1.Items.Add(getdata["courseName"]);
            }

            database.Close();
        }

        private void Go_Button_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Trim().Length == 0)
            {
                warningMessage.Visible = true;

            }
            else
            {
                Form1 form1 = new Form1(comboBox1.Text);
                form1.Activate();
                form1.Show();

                this.Visible = false;
            }
        }
    }
}
