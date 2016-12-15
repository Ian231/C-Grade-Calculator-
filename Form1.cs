using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        addModule moduleAdd;
        addAssessment assessmentAdd;
        String courseT, cName;
        String connectionString;
        int modLevel;
        int selectedLevel = 0;
        ArrayList moduleTLabel = new ArrayList();
        ArrayList moduleTLabel1 = new ArrayList();
        ArrayList moduleTLabel2 = new ArrayList();

        ArrayList moduleCLabel = new ArrayList();
        ArrayList moduleCLabel1 = new ArrayList();
        ArrayList moduleCLabel2 = new ArrayList();

        ArrayList assessmentInfo = new ArrayList();
        ArrayList assessmentInfo1 = new ArrayList();
        ArrayList assessmentInfo2 = new ArrayList();

        public Form1(String courseName)
        {
            
            InitializeComponent();
            courseTitle.Text = courseName;
            courseT = courseName;
            selectLevel4Details();
            selectLevel5Details();
            selectLevel6Details();
        
            moduleAdd = new addModule(modLevel, cName);

            editButton.Visible = false;

        }

      
       

        private void addModule_Click(object sender, EventArgs e)
        {
         
        }


        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private void addlevel4Module_Click(object sender, EventArgs e)
        {
            addModule addMod4 = new addModule(4, courseT);
            addMod4.Show();
            this.Close();

        }

        private void addlevel5Module_Click(object sender, EventArgs e)
        {
            addModule addMod5 = new addModule(5, courseT);
            addMod5.Show();
            this.Close();
        }

        private void addlevel6Module_Click(object sender, EventArgs e)
        {
            addModule addMod6 = new addModule(6, courseT);
            addMod6.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application Saved ");
            Application.Exit();
        }

        //Level 4 tab page information 

        public void selectLevel4Details()
        {
            connectionString = "Data Source = GradePredict.sqlite; Version =3";
            SQLiteConnection database = new SQLiteConnection(connectionString);
           
            database.Open();
            SQLiteCommand cmd = new SQLiteCommand(database);
            int level4Mod = 0;
            cmd.CommandText = "SELECT COUNT(Id) FROM Modules WHERE level=4";
            level4Mod = Convert.ToInt32(cmd.ExecuteScalar());

            for (int i = 0; i < level4Mod; i++)
            {
                int ii = 0, k = 0;
                cmd.CommandText = "SELECT Id FROM Modules WHERE level=4";
                SQLiteDataReader sqlDataReader = cmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    ArrayList title = new ArrayList();
                    ArrayList weight = new ArrayList();
                    ArrayList mark = new ArrayList();

                    // Module Title from database into label(programmatically added)
                    Label modTitle = new Label();
                    modTitle.Location = new Point(20, 60 + i * 120);
                    modTitle.Height = 20;
                    modTitle.Width = 300;
                    this.moduleTLabel.Add(modTitle);

                    SQLiteCommand sql_cmd = new SQLiteCommand(database);
                    sql_cmd.CommandText = "SELECT modTitle FROM Modules WHERE Id=" + Convert.ToInt32(sqlDataReader["Id"]);
                    String moduleName = (String)sql_cmd.ExecuteScalar();
                    (moduleTLabel[i] as Label).Text = moduleName;

                    this.tabPage2.Controls.Add(moduleTLabel[i] as Label);

                    //Module Credits from database to label 
                    Label modCred = new Label();
                    modCred.Location = new Point(20, 80 + i * 120);
                    modCred.Height = 20;
                    modCred.Width = 300;
                    this.moduleCLabel.Add(modCred);
                        

                    SQLiteCommand sqlcmd1 = new SQLiteCommand(database);
                    sqlcmd1.CommandText = "SELECT credits FROM Modules WHERE Id=" + Convert.ToInt32(sqlDataReader["Id"]);
                    String moduleCredits = Convert.ToString(sqlcmd1.ExecuteScalar());
                        
                    SQLiteCommand sqlcmd2 = new SQLiteCommand(database);
                    sqlcmd2.CommandText = "SELECT modCode FROM Modules WHERE Id=" + Convert.ToInt32(sqlDataReader["Id"]);
                    String moduleCode = Convert.ToString(sqlcmd2.ExecuteScalar());

                    (moduleCLabel[i] as Label).Text = @"" + moduleCredits + " credits - " + " Module Code: " + moduleCode;
                    this.tabPage2.Controls.Add(moduleCLabel[i] as Label);

                    SQLiteCommand assesMod = new SQLiteCommand(database);
                    assesMod.CommandText = "SELECT COUNT(Id) FROM Assessments WHERE pModule=" + Convert.ToInt32(sqlDataReader["Id"]);
                    int asMod = Convert.ToInt32(assesMod.ExecuteScalar());


                    SQLiteCommand sqlcmd3 = new SQLiteCommand(database);
                    sqlcmd3.CommandText = "SELECT title FROM Assessments WHERE pModule=" + Convert.ToInt32(sqlDataReader["Id"]);
                    SQLiteDataReader sqlDataReader1 = sqlcmd3.ExecuteReader();

                    while (sqlDataReader1.Read())
                    {
                        title.Add(sqlDataReader1["title"]);

                    }
                    SQLiteCommand sqlcmd4 = new SQLiteCommand(database);
                    sqlcmd4.CommandText = "SELECT weight FROM Assessments WHERE pModule=" + Convert.ToInt32(sqlDataReader["Id"]);
                    SQLiteDataReader sqlDataReader2 = sqlcmd4.ExecuteReader();

                    while (sqlDataReader2.Read())
                    {
                        weight.Add(sqlDataReader2["weight"]);
                    }

                    SQLiteCommand sqlcmd5 = new SQLiteCommand(database);
                    sqlcmd5.CommandText = "SELECT mark FROM Assessments WHERE pModule =" + Convert.ToInt32(sqlDataReader["Id"]);
                    SQLiteDataReader sqlDataReader3 = sqlcmd5.ExecuteReader();

                    while (sqlDataReader3.Read())
                    {
                        mark.Add(sqlDataReader3["mark"]);
                    }

                    for (int j = 0; j < title.Count; j++)
                    {
                        Label assessmentT = new Label();
                        assessmentT.Location = new Point(20, 100 + (j * 20) + k);
                        assessmentT.Height = 20;
                        assessmentT.Width = 300;
                        this.assessmentInfo.Add(assessmentT);

                        (assessmentInfo[ii] as Label).Text = @"" + title[j] + " (" + weight[j] + "%): " + mark[j];
                        this.tabPage2.Controls.Add((assessmentInfo[ii] as Label));
                        ii++;
                    }
                    k = k + 120;
                    i++;
                }

            }
            database.Close();
        }

        //Level 5 tab Module information
        public void selectLevel5Details()
        {
            connectionString = "Data Source = GradePredict.sqlite; Version =3";
            SQLiteConnection database = new SQLiteConnection(connectionString);

            database.Open();
            SQLiteCommand cmd = new SQLiteCommand(database);
            int level5Mod = 0;
            cmd.CommandText = "SELECT COUNT(Id) FROM Modules WHERE level=5";
            level5Mod = Convert.ToInt32(cmd.ExecuteScalar());

            for (int i = 0; i < level5Mod; i++)
            {
                int ii = 0, k = 0;
                cmd.CommandText = "SELECT Id FROM Modules WHERE level=5";
                SQLiteDataReader sqlDataReader = cmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    ArrayList title = new ArrayList();
                    ArrayList weight = new ArrayList();
                    ArrayList mark = new ArrayList();

                    Label modTitle = new Label();
                    modTitle.Location = new Point(20, 60 + i * 120);
                    modTitle.Height = 20;
                    modTitle.Width = 300;
                    this.moduleTLabel1.Add(modTitle);

                    SQLiteCommand sql_cmd = new SQLiteCommand(database);
                    sql_cmd.CommandText = "SELECT modTitle FROM Modules WHERE Id=" + Convert.ToInt32(sqlDataReader["Id"]);
                    String moduleName = (String)sql_cmd.ExecuteScalar();
                    (moduleTLabel1[i] as Label).Text = moduleName;

                    this.tabPage3.Controls.Add(moduleTLabel1[i] as Label);

                    //Module Credits from database to label 
                    Label modCred = new Label();
                    modCred.Location = new Point(20, 80 + i * 120);
                    modCred.Height = 20;
                    modCred.Width = 300;
                    this.moduleCLabel1.Add(modCred);


                    SQLiteCommand sqlcmd1 = new SQLiteCommand(database);
                    sqlcmd1.CommandText = "SELECT credits FROM Modules WHERE Id=" + Convert.ToInt32(sqlDataReader["Id"]);
                    String moduleCredits = Convert.ToString(sqlcmd1.ExecuteScalar());

                    SQLiteCommand sqlcmd2 = new SQLiteCommand(database);
                    sqlcmd2.CommandText = "SELECT modCode FROM Modules WHERE Id=" + Convert.ToInt32(sqlDataReader["Id"]);
                    String moduleCode = Convert.ToString(sqlcmd2.ExecuteScalar());

                    (moduleCLabel1[i] as Label).Text = @"" + moduleCredits + " credits - " + " Module Code: " + moduleCode;
                    this.tabPage3.Controls.Add(moduleCLabel1[i] as Label);

                    SQLiteCommand assesMod = new SQLiteCommand(database);
                    assesMod.CommandText = "SELECT COUNT(Id) FROM Assessments WHERE pModule=" + Convert.ToInt32(sqlDataReader["Id"]);
                    int asMod = Convert.ToInt32(assesMod.ExecuteScalar());


                    SQLiteCommand sqlcmd3 = new SQLiteCommand(database);
                    sqlcmd3.CommandText = "SELECT title FROM Assessments WHERE pModule=" + Convert.ToInt32(sqlDataReader["Id"]);
                    SQLiteDataReader sqlDataReader1 = sqlcmd3.ExecuteReader();

                    while (sqlDataReader1.Read())
                    {
                        title.Add(sqlDataReader1["title"]);

                    }
                    SQLiteCommand sqlcmd4 = new SQLiteCommand(database);
                    sqlcmd4.CommandText = "SELECT weight FROM Assessments WHERE pModule=" + Convert.ToInt32(sqlDataReader["Id"]);
                    SQLiteDataReader sqlDataReader2 = sqlcmd4.ExecuteReader();

                    while (sqlDataReader2.Read())
                    {
                        weight.Add(sqlDataReader2["weight"]);
                    }

                    SQLiteCommand sqlcmd5 = new SQLiteCommand(database);
                    sqlcmd5.CommandText = "SELECT mark FROM Assessments WHERE pModule =" + Convert.ToInt32(sqlDataReader["Id"]);
                    SQLiteDataReader sqlDataReader3 = sqlcmd5.ExecuteReader();

                    while (sqlDataReader3.Read())
                    {
                        mark.Add(sqlDataReader3["mark"]);
                    }

                    for (int j = 0; j < title.Count; j++)
                    {
                        Label assessmentTitle = new Label();
                        assessmentTitle.Location = new Point(20, 100 + (j * 20) + k);
                        assessmentTitle.Height = 20;
                        assessmentTitle.Width = 300;
                        this.assessmentInfo1.Add(assessmentTitle);

                        (assessmentInfo1[ii] as Label).Text = @"" + title[j] + "(" + weight[j] + "%): " + mark[j];
                        this.tabPage3.Controls.Add((assessmentInfo1[ii] as Label));
                        ii++;
                    }
                    k = k + 120;
                    i++;
                }
                database.Close();

            }


        }

        //Level 6 tab information 
        public void selectLevel6Details()
        {
            connectionString = "Data Source = GradePredict.sqlite; Version =3";
            SQLiteConnection database = new SQLiteConnection(connectionString);

            database.Open();
            SQLiteCommand cmd = new SQLiteCommand(database);
            int level6Mod = 0;
            cmd.CommandText = "SELECT COUNT(id) FROM Modules WHERE level=6";
            level6Mod = Convert.ToInt32(cmd.ExecuteScalar());

            for (int i = 0; i < level6Mod; i++)
            {
                int ii = 0, k = 0;
                cmd.CommandText = "SELECT Id FROM Modules WHERE level=6";
                SQLiteDataReader sqlDataReader = cmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    ArrayList title = new ArrayList();
                    ArrayList weight = new ArrayList();
                    ArrayList mark = new ArrayList();

                    Label modTitle = new Label();
                    modTitle.Location = new Point(20, 60 + i * 120);
                    modTitle.Height = 20;
                    modTitle.Width = 300;
                    this.moduleTLabel2.Add(modTitle);

                    SQLiteCommand sql_cmd = new SQLiteCommand(database);
                    sql_cmd.CommandText = "SELECT modTitle FROM Modules WHERE Id=" + Convert.ToInt32(sqlDataReader["Id"]);
                    String moduleName = (String)sql_cmd.ExecuteScalar();
                    (moduleTLabel2[i] as Label).Text = moduleName;

                    this.tabPage4.Controls.Add(moduleTLabel2[i] as Label);

                    Label modCred = new Label();
                    modCred.Location = new Point(20, 80 + i * 120);
                    modCred.Height = 20;
                    modCred.Width = 300;
                    this.moduleCLabel2.Add(modCred);


                    SQLiteCommand sqlcmd1 = new SQLiteCommand(database);
                    sqlcmd1.CommandText = "SELECT credits FROM Modules WHERE Id=" + Convert.ToInt32(sqlDataReader["Id"]);
                    String moduleCredits = Convert.ToString(sqlcmd1.ExecuteScalar());

                    SQLiteCommand sqlcmd2 = new SQLiteCommand(database);
                    sqlcmd2.CommandText = "SELECT modCode FROM Modules WHERE Id=" + Convert.ToInt32(sqlDataReader["Id"]);
                    String moduleCode = Convert.ToString(sqlcmd2.ExecuteScalar());

                    (moduleCLabel2[i] as Label).Text = @"" + moduleCredits + " credits - " + " Module Code: " + moduleCode;
                    this.tabPage4.Controls.Add(moduleCLabel2[i] as Label);

                    SQLiteCommand assesMod = new SQLiteCommand(database);
                    assesMod.CommandText = "SELECT COUNT(Id) FROM Assessments WHERE pModule=" + Convert.ToInt32(sqlDataReader["Id"]);
                    int asMod = Convert.ToInt32(assesMod.ExecuteScalar());


                    SQLiteCommand sqlcmd3 = new SQLiteCommand(database);
                    sqlcmd3.CommandText = "SELECT title FROM Assessments WHERE pModule=" + Convert.ToInt32(sqlDataReader["Id"]);
                    SQLiteDataReader sqlDataReader1 = sqlcmd3.ExecuteReader();

                    while (sqlDataReader1.Read())
                    {
                        title.Add(sqlDataReader1["title"]);

                    }
                    SQLiteCommand sqlcmd4 = new SQLiteCommand(database);
                    sqlcmd4.CommandText = "SELECT weight FROM Assessments WHERE pModule=" + Convert.ToInt32(sqlDataReader["Id"]);
                    SQLiteDataReader sqlDataReader2 = sqlcmd4.ExecuteReader();

                    while (sqlDataReader2.Read())
                    {
                        weight.Add(sqlDataReader2["weight"]);
                    }

                    SQLiteCommand sqlcmd5 = new SQLiteCommand(database);
                    sqlcmd5.CommandText = "SELECT mark FROM Assessments WHERE pModule =" + Convert.ToInt32(sqlDataReader["Id"]);
                    SQLiteDataReader sqlDataReader3 = sqlcmd5.ExecuteReader();

                    while (sqlDataReader3.Read())
                    {
                        mark.Add(sqlDataReader3["mark"]);
                    }

                    for (int j = 0; j < title.Count; j++)
                    {
                        Label assessmentT = new Label();
                        assessmentT.Location = new Point(20, 100 + (j * 20) + k);
                        assessmentT.Height = 20;
                        assessmentT.Width = 300;
                        this.assessmentInfo2.Add(assessmentT);

                        (assessmentInfo2[ii] as Label).Text = @"" + title[j] + "(" + weight[j] + "%): " + mark[j];
                        this.tabPage4.Controls.Add((assessmentInfo2[ii] as Label));
                        ii++;
                    }
                    k = k + 120;
                    i++;

                }
                database.Close();

            }

        }
     
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void editButton_Click(object sender, EventArgs e)
        {
            selectEditModule sem = new selectEditModule(selectedLevel, courseT);
            sem.Show();
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"])
            {
                editButton.Visible = false;
               
               
            }

            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"])
            {
                selectedLevel = 4;
                editButton.Visible = true;
                

               

            }

            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage3"])
            {
                selectedLevel = 5;
                editButton.Visible = true;
          

              

            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage4"])
            {
                selectedLevel = 6;
                editButton.Visible = true;
               

        
            }

            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage5"])
            {
                countMarks total4 = new countMarks();
                countMarks total5 = new countMarks();
                countMarks total6 = new countMarks();

                //Get get average for levels
                this.summaryL4.Text = total4.getModuleAverage(4);
                this.summaryL5.Text = total5.getModuleAverage(5);
                this.summaryL6.Text = total6.getModuleAverage(6);

                countMarks getTotal = new countMarks();
                countMarks getBest56 = new countMarks();

                //get best modules
                best6.Text = getTotal.getBest6();
                best56.Text = getTotal.getBest56();

                countMarks overall = new countMarks();

                //Calculate predicted average
                String predicted = getTotal.averageAllYears();
                predictedGrade.Text = predicted;

                //Assign styles
                if (predicted.StartsWith("1st Class Degree"))
                {
                    predictedGrade.ForeColor = Color.FromArgb(0, 165, 255);
                }

                if (predicted.StartsWith("Upper Second Degree"))
                {
                    predictedGrade.ForeColor = Color.FromArgb(0, 211, 0);
                }

                if (predicted.StartsWith("Lower Second Degree"))
                {
                    predictedGrade.ForeColor = Color.FromArgb(0, 211, 0);
                }

                if (predicted.StartsWith("Third Class Degree"))
                {
                    predictedGrade.ForeColor = Color.FromArgb(0, 211, 0);
                }

                if (predicted.StartsWith("Ordinary Pass"))
                {
                    predictedGrade.ForeColor = Color.FromArgb(0, 211, 0);
                }

                if (predicted.StartsWith("Fail"))
                {
                    predictedGrade.ForeColor = Color.FromArgb(215, 0, 0);
                }

          
                
            }

            

            }

        private void reCalculate_Click(object sender, EventArgs e)
        {

            try
            {
                //Get Level 5 and 6 averages from boxes
                int level5Average = Convert.ToInt32(summaryL5.Text);
                int level6Average = Convert.ToInt32(summaryL6.Text);

                if (level5Average > 100 || level6Average > 100)
                {
                    MessageBox.Show("You put incorrect data.");
                }
                else
                {
                    //pass to countMarks
                    countMarks cm = new countMarks();
                    string predicted = cm.recalculate(level5Average, level6Average);
                    predictedGrade.Text = predicted;

                    if (predicted.StartsWith("1st Class Degree"))
                    {
                        predictedGrade.ForeColor = Color.FromArgb(0, 165, 255);
                    }

                    if (predicted.StartsWith("Upper Second Degree"))
                    {
                        predictedGrade.ForeColor = Color.FromArgb(0, 211, 0);
                    }

                    if (predicted.StartsWith("Lower Second Degree"))
                    {
                        predictedGrade.ForeColor = Color.FromArgb(0, 211, 0);
                    }

                    if (predicted.StartsWith("Third Class Degree"))
                    {
                        predictedGrade.ForeColor = Color.FromArgb(0, 211, 0);
                    }

                    if (predicted.StartsWith("Ordinary Pass"))
                    {
                        predictedGrade.ForeColor = Color.FromArgb(0, 211, 0);
                    }

                    if (predicted.StartsWith("Fail"))
                    {
                        predictedGrade.ForeColor = Color.FromArgb(215, 0, 0);
                    }

                }

            }
            catch
            {
                MessageBox.Show("You put incorrect data.");
            }



        }


        

      

    


    }
}
