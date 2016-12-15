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
    public partial class selectEditModule : Form
    {
        List<Button> moduleButton = new List<Button>();
        int Level;
        String Course; String connectionString;

        public selectEditModule(int lvl, String coursename)
        {
            InitializeComponent();
            Level = lvl;
            Course = coursename;
            showModulesToEdit();
        }

        public void showModulesToEdit()
        {
            connectionString = "Data Source = GradePredict.sqlite; Version =3";
            SQLiteConnection database = new SQLiteConnection(connectionString);
            database.Open();
            SQLiteCommand cmd = new SQLiteCommand(database);

            cmd.CommandText = "SELECT Id FROM Modules WHERE level=" + Level;
            SQLiteDataReader SQLDataReader = cmd.ExecuteReader();

            int i = 0;

            while (SQLDataReader.Read())
            {
                Button button = new Button();
                button.Location = new Point(243, 20 + i * 40);
                button.Size = new Size(160, 30);
                button.Name = ""+Convert.ToInt32(SQLDataReader["Id"]);

                this.moduleButton.Add(button);

                SQLiteCommand sql_cmd = new SQLiteCommand(database);
                sql_cmd.CommandText = "SELECT modTitle FROM Modules WHERE Id=" + Convert.ToInt32(SQLDataReader["Id"]);
                string moduleName = (string)sql_cmd.ExecuteScalar();


                (moduleButton[i] as Button).Text = moduleName;
                this.modulePanel.Controls.Add((moduleButton[i] as Button));

                //Event handle for button
                button.Click += editMod;

                i++;

            }

            database.Close();
        }





        private void editMod(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            editModule editMod = new editModule(Convert.ToInt32(btn.Name), Level, Course);
            editMod.Show();
            this.Dispose();

        }

      
       

    }
}
