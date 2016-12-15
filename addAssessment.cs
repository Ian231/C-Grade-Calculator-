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
    public partial class addAssessment : Form
    {
        String moduleTitle, moduleCode, courseTitle;
        int numAssessment, mCredits, mlevel;
        String connectionString;
        int firstColumnFirstRow;


        private moduleModel ad;
        public moduleModel AAmoduleModel
        {
            get
            {
                return ad;
            }
            set
            {
                ad = value;
            }
        }

        public addAssessment(String courseName, String mName, String mCode, int numofAssessment, int cred, int lvl)
        {
            InitializeComponent();
            courseTitle = courseName;
            moduleTitle = mName;
            moduleCode = mCode;
            numAssessment = numofAssessment;
            mCredits = cred;
            mlevel = lvl;
            assesmentModuleTitle.Text = "Add Assessments to " + mName;

            //hides by default
            hiddenText();

            switch (numofAssessment)
            {
                case 1:
                    setVisible1();
                    break;
                case 2:
                    setVisible1();
                    setVisible2();
                    break;
                case 3:
                    setVisible1();
                    setVisible2();
                    setVisible3();
                    break;
                case 4:
                    setVisible1();
                    setVisible2();
                    setVisible3();
                    setVisible4();
                    break;
            }

        }


        private void addAssessment_Load(object sender, EventArgs e)
        {

        }

        public void hiddenText()
        {
            as1Label.Visible = false;
            as1TitleText.Visible = false;
            assessmentT1.Visible = false;
            as1WText.Visible = false;
            as1W.Visible = false;
            as1MarkText.Visible = false;
            as1Mark.Visible = false;

            as2Label.Visible = false;
            as2TitleText.Visible = false;
            assessmentT2.Visible = false;
            as2WText.Visible = false;
            as2W.Visible = false;
            as2MarkText.Visible = false;
            as2Mark.Visible = false;

            as3Label.Visible = false;
            as3TitleText.Visible = false;
            assessmentT3.Visible = false;
            as3WText.Visible = false;
            as3W.Visible = false;
            as3MarkText.Visible = false;
            as3Mark.Visible = false;

            as4Label.Visible = false;
            as4TitleText.Visible = false;
            assessmentT4.Visible = false;
            as4WText.Visible = false;
            as4W.Visible = false;
            as4MarkText.Visible = false;
            as4Mark.Visible = false;
        }

        public void setVisible1()
        {
            as1Label.Visible = true;
            as1TitleText.Visible = true;
            assessmentT1.Visible = true;
            as1WText.Visible = true;
            as1W.Visible = true;
            as1MarkText.Visible = true;
            as1Mark.Visible = true;
        }

        public void setVisible2()
        {
            as2Label.Visible = true;
            as2TitleText.Visible = true;
            assessmentT2.Visible = true;
            as2WText.Visible = true;
            as2W.Visible = true;
            as2MarkText.Visible = true;
            as2Mark.Visible = true;
        }

        public void setVisible3()
        {
            as3Label.Visible = true;
            as3TitleText.Visible = true;
            assessmentT3.Visible = true;
            as3WText.Visible = true;
            as3W.Visible = true;
            as3MarkText.Visible = true;
            as3Mark.Visible = true;
        }

        public void setVisible4()
        {
            as4Label.Visible = true;
            as4TitleText.Visible = true;
            assessmentT4.Visible = true;
            as4WText.Visible = true;
            as4W.Visible = true;
            as4MarkText.Visible = true;
            as4Mark.Visible = true;
        }

        
        //If field left empty
        public Boolean assessmentWeightingValid()
        {
            //Total weighting should add up to 100
            if ((AAmoduleModel.assessW + AAmoduleModel.assessW2 + AAmoduleModel.assessW3 + AAmoduleModel.assessW4) == 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //If field left empty
        public Boolean assessmentTitleValid()
        {
            if (this.numAssessment == 1)
            {
                if (assessmentT1.Text.Trim().Length == 0)
                {

                    return false;
                }
                else
                {
                    return true;
                }
            }

            if (this.numAssessment == 2)
            {
                if ((assessmentT1.Text.Trim().Length == 0) || (assessmentT2.Text.Trim().Length == 0))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            if (this.numAssessment == 3)
            {
                if ((assessmentT1.Text.Trim().Length == 0) || (assessmentT2.Text.Trim().Length == 0 || (assessmentT3.Text.Trim().Length == 0)))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            if (this.numAssessment == 4)
            {
                if ((assessmentT1.Text.Trim().Length == 0) || (assessmentT2.Text.Trim().Length == 0) || (assessmentT3.Text.Trim().Length == 0) || (assessmentT4.Text.Trim().Length == 0))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }




        private void submitButton_Click(object sender, EventArgs e)
        {
            if (!assessmentTitleValid())
            {
                MessageBox.Show("Assesment Title Field Left Blank");
            }
            else
            {
                ad = new moduleModel();
               try
                {
                   
                    AAmoduleModel.assessN = assessmentT1.Text;
                }
                catch { }

               try
               {
                   
                   AAmoduleModel.assessN2 = assessmentT2.Text;
               }
               catch { }

               try
               {
                   AAmoduleModel.assessN3 = assessmentT3.Text;
               }
               catch { }

               try
               {
                   AAmoduleModel.assessN4 = assessmentT4.Text;
               }
               catch { }

            
               try
               {
                   AAmoduleModel.assessW = int.Parse(as1W.Text);
               }
               catch
               { }
               try
               {
                   AAmoduleModel.assessW2 = int.Parse(as2W.Text);
               }
               catch { }

               try
               {
                   AAmoduleModel.assessW3 = int.Parse(as3W.Text);
               }
               catch { }

               try
               {
                   AAmoduleModel.assessW4 = int.Parse(as4W.Text);
               }
               catch { }


               if (as1Mark.Text.Trim().Length == 0)
               {
                   AAmoduleModel.assessM = -1;
               }
               else
               {
                   AAmoduleModel.assessM = int.Parse(as1Mark.Text);
               }

               if (as2Mark.Text.Trim().Length == 0)
               {
                   AAmoduleModel.assessM2 = -1;  
               }
               else
               {
                   AAmoduleModel.assessM2 = int.Parse(as2Mark.Text);
               }

               if (as3Mark.Text.Trim().Length == 0)
               {
                   AAmoduleModel.assessM3 = -1;
               }
               else
               {
                   AAmoduleModel.assessM3 = int.Parse(as3Mark.Text);
               }

               if (as4Mark.Text.Trim().Length == 0)
               {
                   AAmoduleModel.assessM4 = -1;
               }
               else
               {
                   AAmoduleModel.assessM4 = int.Parse(as4Mark.Text);
               }
               if ((AAmoduleModel.assessW + AAmoduleModel.assessW2 + AAmoduleModel.assessW3 + AAmoduleModel.assessW4) != 100)
               {
                   MessageBox.Show("Weighting should total 100%.", "Error");
               }
               else
               {
                   try
                   {
                       connectionString = "Data Source = GradePredict.sqlite; Version =3";
                       SQLiteConnection database = new SQLiteConnection(connectionString);
                       database.Open();

                       String sql = "INSERT INTO Modules (modTitle, modCode, credits, assessment, level) values ('" + moduleTitle + "', '" + moduleCode + "', " + mCredits + ", " + numAssessment + ", " + mlevel + ")";
                       SQLiteCommand insertModules = new SQLiteCommand(sql, database);
                       //sql query
                       insertModules.ExecuteNonQuery();

                       //Return first column of first row
                       try
                       {
                           insertModules.CommandText = "SELECT last_insert_rowid()";
                           Int64 firstColumnRow = (Int64)insertModules.ExecuteScalar();
                           firstColumnFirstRow = (int)firstColumnRow;
                       }
                       catch (Exception ex)
                       {
                           MessageBox.Show("Error " + ex);
                       }

                       //If number of assessments is 1
                       if (numAssessment == 1)
                       {
                           sql = "INSERT INTO Assessments (title, weight, pModule, mark, level) values ('" + AAmoduleModel.assessN + "', " + AAmoduleModel.assessW + ", " + firstColumnFirstRow + ", " + AAmoduleModel.assessM + ", " + mlevel + ")";
                           SQLiteCommand insertAssess1 = new SQLiteCommand(sql, database);
                           insertAssess1.ExecuteNonQuery();
                       }
                       if (numAssessment == 2)
                       {
                           sql = "INSERT INTO Assessments (title, weight, pModule, mark, level) values ('" + AAmoduleModel.assessN + "', " + AAmoduleModel.assessW + ", " + firstColumnFirstRow + ", " + AAmoduleModel.assessM + ", " + mlevel + ")";
                           SQLiteCommand insertAssess1 = new SQLiteCommand(sql, database);
                           insertAssess1.ExecuteNonQuery();

                           sql = "INSERT INTO Assessments (title, weight, pModule, mark, level) values ('" + AAmoduleModel.assessN2 + "', " + AAmoduleModel.assessW2 + ", " + firstColumnFirstRow + ", " + AAmoduleModel.assessM2 + ", " + mlevel + ")";
                           SQLiteCommand insertAssess2 = new SQLiteCommand(sql, database);
                           insertAssess2.ExecuteNonQuery();
                       }
                       if (numAssessment == 3)
                       {
                           sql = "INSERT INTO Assessments (title, weight, pModule, mark, level) values ('" + AAmoduleModel.assessN + "', " + AAmoduleModel.assessW + ", " + firstColumnFirstRow + ", " + AAmoduleModel.assessM + ", " + mlevel + ")";
                           SQLiteCommand insertAssess1 = new SQLiteCommand(sql, database);
                           insertAssess1.ExecuteNonQuery();

                           sql = "INSERT INTO Assessments (title, weight, pModule, mark, level) values ('" + AAmoduleModel.assessN2 + "', " + AAmoduleModel.assessW2 + ", " + firstColumnFirstRow + ", " + AAmoduleModel.assessM2 + ", " + mlevel + ")";
                           SQLiteCommand insertAssess2 = new SQLiteCommand(sql, database);
                           insertAssess2.ExecuteNonQuery();

                           sql = "INSERT INTO Assessments (title, weight, pModule, mark, level) values ('" + AAmoduleModel.assessN3 + "', " + AAmoduleModel.assessW3 + ", " + firstColumnFirstRow + ", " + AAmoduleModel.assessM3 + ", " + mlevel + ")";
                           SQLiteCommand insertAssess3 = new SQLiteCommand(sql, database);
                           insertAssess3.ExecuteNonQuery();
                       }
                       if (numAssessment == 4)
                       {
                           sql = "INSERT INTO Assessments (title, weight, pModule, mark, level) values ('" + AAmoduleModel.assessN + "', " + AAmoduleModel.assessW + ", " + firstColumnFirstRow + ", " + AAmoduleModel.assessM + ", " + mlevel + ")";
                           SQLiteCommand insertAssess1 = new SQLiteCommand(sql, database);
                           insertAssess1.ExecuteNonQuery();

                           sql = "INSERT INTO Assessments (title, weight, pModule, mark, level) values ('" + AAmoduleModel.assessN2 + "', " + AAmoduleModel.assessW2 + ", " + firstColumnFirstRow + ", " + AAmoduleModel.assessM2 + ", " + mlevel + ")";
                           SQLiteCommand insertAssess2 = new SQLiteCommand(sql, database);
                           insertAssess2.ExecuteNonQuery();

                           sql = "INSERT INTO Assessments (title, weight, pModule, mark, level) values ('" + AAmoduleModel.assessN3 + "', " + AAmoduleModel.assessW3 + ", " + firstColumnFirstRow + ", " + AAmoduleModel.assessM3 + ", " + mlevel + ")";
                           SQLiteCommand insertAssess3 = new SQLiteCommand(sql, database);
                           insertAssess3.ExecuteNonQuery();

                           sql = "INSERT INTO Assessments (title, weight, pModule, mark, level) values ('" + AAmoduleModel.assessN4 + "', " + AAmoduleModel.assessW4 + ", " + firstColumnFirstRow + ", " + AAmoduleModel.assessM4 + ", " + mlevel + ")";
                           SQLiteCommand insertAssess4 = new SQLiteCommand(sql, database);
                           insertAssess4.ExecuteNonQuery();
                       }

                       database.Close();




                       MessageBox.Show("Module " + moduleTitle + " and its " + numAssessment + " assessment(s) successfully added to Level " + mlevel);
                       this.Dispose();
                   }


                   catch (Exception ex)
                   {
                       Console.WriteLine(ex);
                   }
               }
            }


        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
     
    }
}
