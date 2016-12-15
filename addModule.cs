using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace GradeCalculator
{
    public partial class addModule : Form
    {
       
        List<TextBox> textboxModule = new List<TextBox>();
        List<TextBox> textCode = new List<TextBox>();
        List<ComboBox> combobox = new List<ComboBox>();
        List<ComboBox> combobox1 = new List<ComboBox>();
        //ArrayList assessmentCombo = new ArrayList();
        List<Label> labels = new List<Label>();
        List<Label> labels1 = new List<Label>();
        List<Label> labels2 = new List<Label>();
        List<Label> labels3 = new List<Label>();
        //List<Button> button = new List<Button>();
        List<String> importedData = new List<String>();
        int credit;
        String courseTitle;
        int level;

        String connectionString;

        private moduleModel md;
        public moduleModel AMmoduleModel
        {
            get
            {
                return md;
            }
            set
            {
                md = value;
            }
        }

        public addModule(int modLevel, String courseN)
        {
            InitializeComponent();
            addModuleTitle.Text = "Level " + modLevel + " Modules ";
            level = modLevel;
            courseTitle = courseN;

            //initial minimum and maximum
            numericUpDownNumComp.Minimum = 1;
            numericUpDownNumComp.Maximum = 8;
            //sets buttons to be hidden intially
            assessmentButton.Visible = false;
            assessmentButton2.Visible = false;
            assesmentButton3.Visible = false;
            assessmentButton4.Visible = false;
            assessmentButton5.Visible = false;
            assesmentButton6.Visible = false;
            assessmentButton7.Visible = false;
            assesmentButton8.Visible = false;


        }


        private void addButton_Click(object sender, EventArgs e)
        {

            int length = (int)this.numericUpDownNumComp.Value;
            for (int i = 0; i < length; i++)
            {
                //instantiate and configure the text boxes
                textboxModule.Add(new TextBox());
                System.Drawing.Point p = new System.Drawing.Point(69, 200 + i * 25);
                //to evoke an object in an ArrayList we use the 'as' keyword
                (textboxModule[i] as TextBox).Location = p;
                (textboxModule[i] as TextBox).Size = new System.Drawing.Size(183, 20);
                //use 'as' again here to add the control to the controls Collection
                this.Controls.Add(textboxModule[i] as TextBox);

                //instantiate and configure the labels
                this.labels.Add(new Label());
                System.Drawing.Point pLabel = new System.Drawing.Point(13, 200 + i * 25);
                (labels[i] as Label).Location = pLabel;
                (labels[i] as Label).Size = new System.Drawing.Size(80, 13);
                (labels[i] as Label).Text = @"Module " + (i + 1).ToString() + ": ";
                this.Controls.Add(labels[i] as Label);

                //instantiate and configure the text boxes
                textCode.Add(new TextBox());
                System.Drawing.Point p2 = new System.Drawing.Point(339, 200 + i * 25);
                //to evoke an object in an ArrayList we use the 'as' keyword
                (textCode[i] as TextBox).Location = p2;
                (textCode[i] as TextBox).Size = new System.Drawing.Size(73, 20);
                //use 'as' again here to add the control to the controls Collection
                this.Controls.Add(textCode[i] as TextBox);

                //instantiate and configure the labels
                this.labels1.Add(new Label());

                System.Drawing.Point pLabel1 = new System.Drawing.Point(263, 200 + i * 25);
                (labels1[i] as Label).Location = pLabel1;
                (labels1[i] as Label).Size = new System.Drawing.Size(80, 13);
                (labels1[i] as Label).Text = @"Module Code: ";
                this.Controls.Add(labels1[i] as Label);

                combobox.Add(new ComboBox());
                System.Drawing.Point pCombo = new System.Drawing.Point(475, 200 + i * 25);
                (combobox[i] as ComboBox).Location = pCombo;
                (combobox[i] as ComboBox).Size = new System.Drawing.Size(40, 20);
                (combobox[i] as ComboBox).Items.AddRange(new object[] {"15",
                    "30",
                    "45"
                });
                this.Controls.Add(combobox[i] as ComboBox);

                this.labels2.Add(new Label());
                System.Drawing.Point pLabel2 = new System.Drawing.Point(427, 200 + i * 25);
                (labels2[i] as Label).Location = pLabel2;
                (labels2[i] as Label).Size = new System.Drawing.Size(80, 13);
                (labels2[i] as Label).Text = @"Credits: ";
                this.Controls.Add(labels2[i] as Label);

                combobox1.Add(new ComboBox());
                System.Drawing.Point pCombo1 = new System.Drawing.Point(612, 200 + i * 25);
                (combobox1[i] as ComboBox).Location = new System.Drawing.Point(612, 200 + i * 25);
                (combobox1[i] as ComboBox).Size = new System.Drawing.Size(40, 20);
                (combobox1[i] as ComboBox).Items.AddRange(new object[] {"1",
                    "2",
                    "3",
                    "4"
                });

                this.Controls.Add(combobox1[i] as ComboBox);




                this.labels3.Add(new Label());
                System.Drawing.Point pLabel3 = new System.Drawing.Point(536, 200 + i * 25);
                (labels3[i] as Label).Location = pLabel3;
                (labels3[i] as Label).Size = new System.Drawing.Size(80, 13);
                (labels3[i] as Label).Text = @"Assessments: ";
                this.Controls.Add(labels3[i] as Label);

            }



            if (numericUpDownNumComp.Value == 1)
            {
                assessmentButton.Visible = true;
            }
            else if (numericUpDownNumComp.Value == 2)
            {
                assessmentButton.Visible = true;
                assessmentButton2.Visible = true;
            }
            else if (numericUpDownNumComp.Value == 3)
            {
                assessmentButton.Visible = true;
                assessmentButton2.Visible = true;
                assesmentButton3.Visible = true;
            }
            else if (numericUpDownNumComp.Value == 4)
            {
                assessmentButton.Visible = true;
                assessmentButton2.Visible = true;
                assesmentButton3.Visible = true;
                assessmentButton4.Visible = true;
            }
            else if (numericUpDownNumComp.Value == 5)
            {
                assessmentButton.Visible = true;
                assessmentButton2.Visible = true;
                assesmentButton3.Visible = true;
                assessmentButton4.Visible = true;
                assessmentButton5.Visible = true;
            }
            else if (numericUpDownNumComp.Value == 6)
            {
                assessmentButton.Visible = true;
                assessmentButton2.Visible = true;
                assesmentButton3.Visible = true;
                assessmentButton4.Visible = true;
                assessmentButton5.Visible = true;
                assesmentButton6.Visible = true;
            }
            else if (numericUpDownNumComp.Value == 7)
            {
                assessmentButton.Visible = true;
                assessmentButton2.Visible = true;
                assesmentButton3.Visible = true;
                assessmentButton4.Visible = true;
                assessmentButton5.Visible = true;
                assesmentButton6.Visible = true;
                assessmentButton7.Visible = true;
            }
            else if (numericUpDownNumComp.Value == 8)
            {
                assessmentButton.Visible = true;
                assessmentButton2.Visible = true;
                assesmentButton3.Visible = true;
                assessmentButton4.Visible = true;
                assessmentButton5.Visible = true;
                assesmentButton6.Visible = true;
                assessmentButton7.Visible = true;
                assesmentButton8.Visible = true;
            }

        }


        private void clearButton_Click(object sender, EventArgs e)
        {
            numericUpDownNumComp.Value = 1;
            //Removes everything after button is clicked

            foreach (TextBox txt in textboxModule)
            {
                this.Controls.Remove(txt);
            }
            foreach (Label lbl in labels)
            {
                this.Controls.Remove(lbl);
            }
            foreach (Label lbl1 in labels1)
            {
                this.Controls.Remove(lbl1);
            }
            foreach (TextBox txtb in textCode)
            {
                this.Controls.Remove(txtb);
            }
            foreach (Label lbl2 in labels2)
            {
                this.Controls.Remove(lbl2);
            }
            foreach (ComboBox comb in combobox)
            {
                this.Controls.Remove(comb);
            }
            foreach (ComboBox comb1 in combobox1)
            {
                this.Controls.Remove(comb1);
            }
            foreach (Label lbl3 in labels3)
            {
                this.Controls.Remove(lbl3);
            }

            assessmentButton.Dispose();
            assessmentButton2.Dispose();
            assesmentButton3.Dispose();
            assessmentButton4.Dispose();
            assessmentButton5.Dispose();
            assesmentButton6.Dispose();
            assessmentButton7.Dispose();
            assesmentButton8.Dispose();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(courseTitle);
            form.Activate();
            form.Show();
            this.Dispose();

        }


        public bool totalCredits()
        {
            int totalCount = 0;
            credit = Int32.Parse(combobox[0].GetItemText(this.combobox[0].SelectedItem));
            credit = Int32.Parse(combobox[1].GetItemText(this.combobox[1].SelectedItem));
            credit = Int32.Parse(combobox[2].GetItemText(this.combobox[2].SelectedItem));
            credit = Int32.Parse(combobox[3].GetItemText(this.combobox[3].SelectedItem));
            credit = Int32.Parse(combobox[4].GetItemText(this.combobox[4].SelectedItem));
            credit = Int32.Parse(combobox[5].GetItemText(this.combobox[5].SelectedItem));
            credit = Int32.Parse(combobox[6].GetItemText(this.combobox[6].SelectedItem));
            credit = Int32.Parse(combobox[7].GetItemText(this.combobox[7].SelectedItem));
            try
            {
                connectionString = "Data Source = GradePredict.sqlite; Version =3";
                SQLiteConnection database = new SQLiteConnection(connectionString);
                using (database)
                {
                    database.Open();
                    using (SQLiteCommand cmd = database.CreateCommand())
                    {
                        cmd.CommandText = @"SELECT credits FROM Modules where level=" + level;
                        cmd.CommandType = CommandType.Text;
                        SQLiteDataReader sqlReader = cmd.ExecuteReader();

                        while (sqlReader.Read())
                        {
                            importedData.Add(Convert.ToString(sqlReader["credits"]));
                        }
                    }
                }
                for (int i = 0; i < importedData.Count; i++)
                {
                    totalCount += int.Parse(importedData[i]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("Error during counting credits");
            }
            if (totalCount == 120 || ((credit + totalCount) > 120))
            {
                return true;
            }

            return false;
        }


        private void assessmentButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textboxModule[0].Text) || string.IsNullOrEmpty(textCode[0].Text) || string.IsNullOrEmpty(combobox[0].Text) || string.IsNullOrEmpty(combobox1[0].Text))
            {
                MessageBox.Show("Fill in all Fields ");
            }
            else
            {
                md = new moduleModel();
                AMmoduleModel.modName = textboxModule[0].Text;
                AMmoduleModel.modCode = textCode[0].Text;
                AMmoduleModel.modAssess = Int32.Parse(combobox1[0].GetItemText(this.combobox1[0].SelectedItem));
                AMmoduleModel.modCred = Int32.Parse(combobox[0].GetItemText(this.combobox[0].SelectedItem));
                addAssessment assessment = new addAssessment(courseTitle, AMmoduleModel.modName, AMmoduleModel.modCode, AMmoduleModel.modAssess, AMmoduleModel.modCred, level);
                assessment.Activate();
                assessment.ShowDialog();
            }
        }

        private void assessmentButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textboxModule[1].Text) || string.IsNullOrEmpty(textCode[1].Text) || string.IsNullOrEmpty(combobox[1].Text) || string.IsNullOrEmpty(combobox1[1].Text))
            {
                MessageBox.Show("Fill in all Fields");
            }
            else
            {
                md = new moduleModel();
                AMmoduleModel.modName = textboxModule[1].Text;
                AMmoduleModel.modCode = textCode[1].Text;
                AMmoduleModel.modAssess = Int32.Parse(combobox1[1].GetItemText(this.combobox1[1].SelectedItem));
                AMmoduleModel.modCred = Int32.Parse(combobox[1].GetItemText(this.combobox[1].SelectedItem));
                addAssessment assessment1 = new addAssessment(courseTitle, AMmoduleModel.modName, AMmoduleModel.modCode, AMmoduleModel.modAssess, AMmoduleModel.modCred, level); 
                assessment1.Activate();
                assessment1.ShowDialog();
            }
        }

        private void assesmentButton3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textboxModule[2].Text) || string.IsNullOrEmpty(textCode[2].Text) || string.IsNullOrEmpty(combobox[2].Text) || string.IsNullOrEmpty(combobox1[2].Text))
            {
                MessageBox.Show("Fill in all Fields");
            }
            else
            {
                md = new moduleModel();
                AMmoduleModel.modName = textboxModule[2].Text;
                AMmoduleModel.modCode = textCode[2].Text;
                AMmoduleModel.modAssess = Int32.Parse(combobox1[2].GetItemText(this.combobox1[2].SelectedItem));
                AMmoduleModel.modCred = Int32.Parse(combobox[2].GetItemText(this.combobox[2].SelectedItem));
                addAssessment assessment2 = new addAssessment(courseTitle, AMmoduleModel.modName, AMmoduleModel.modCode, AMmoduleModel.modAssess, AMmoduleModel.modCred, level); 
                assessment2.Activate();
                assessment2.ShowDialog();
            }

        }

        private void assessmentButton4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textboxModule[3].Text) || string.IsNullOrEmpty(textCode[3].Text) || string.IsNullOrEmpty(combobox[3].Text) || string.IsNullOrEmpty(combobox1[3].Text))
            {
                MessageBox.Show("Fill in all Fields");
            }
            else
            {
                md = new moduleModel();
                AMmoduleModel.modName = textboxModule[3].Text;
                AMmoduleModel.modCode = textCode[3].Text;
                AMmoduleModel.modAssess = Int32.Parse(combobox1[3].GetItemText(this.combobox1[3].SelectedItem));
                AMmoduleModel.modCred = Int32.Parse(combobox[3].GetItemText(this.combobox[3].SelectedItem));
                addAssessment assessment3 = new addAssessment(courseTitle, AMmoduleModel.modName, AMmoduleModel.modCode, AMmoduleModel.modAssess, AMmoduleModel.modCred, level); 
                assessment3.Activate();
                assessment3.ShowDialog();
            }
        }

        private void assessmentButton5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textboxModule[4].Text) || string.IsNullOrEmpty(textCode[4].Text) || string.IsNullOrEmpty(combobox[4].Text) || string.IsNullOrEmpty(combobox1[4].Text))
            {
                MessageBox.Show("Fill in all Fields");
            }
            else
            {
                md = new moduleModel();
                AMmoduleModel.modName = textboxModule[4].Text;
                AMmoduleModel.modCode = textCode[4].Text;
                AMmoduleModel.modAssess = Int32.Parse(combobox1[4].GetItemText(this.combobox1[4].SelectedItem));
                AMmoduleModel.modCred = Int32.Parse(combobox[4].GetItemText(this.combobox[4].SelectedItem));
                addAssessment assessment4 = new addAssessment(courseTitle, AMmoduleModel.modName, AMmoduleModel.modCode, AMmoduleModel.modAssess, AMmoduleModel.modCred, level); 
                assessment4.Activate();
                assessment4.ShowDialog();
                this.Dispose();
            }
        }

        private void assesmentButton6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textboxModule[5].Text) || string.IsNullOrEmpty(textCode[5].Text) || string.IsNullOrEmpty(combobox[5].Text) || string.IsNullOrEmpty(combobox1[5].Text))
            {
                MessageBox.Show("Fill in all Fields");
            }
            else
            {
                md = new moduleModel();
                AMmoduleModel.modName = textboxModule[5].Text;
                AMmoduleModel.modCode = textCode[5].Text;
                AMmoduleModel.modAssess = Int32.Parse(combobox1[5].GetItemText(this.combobox1[5].SelectedItem));
                AMmoduleModel.modCred = Int32.Parse(combobox[5].GetItemText(this.combobox[5].SelectedItem));
                addAssessment assessment5 = new addAssessment(courseTitle, AMmoduleModel.modName, AMmoduleModel.modCode, AMmoduleModel.modAssess, AMmoduleModel.modCred, level); 
                assessment5.Activate();
                assessment5.ShowDialog();
            }
        }

        private void assessmentButton7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textboxModule[6].Text) || string.IsNullOrEmpty(textCode[6].Text) || string.IsNullOrEmpty(combobox[6].Text) || string.IsNullOrEmpty(combobox1[6].Text))
            {
                MessageBox.Show("Fill in all Fields");
            }
            else
            {
                md = new moduleModel();
                AMmoduleModel.modName = textboxModule[6].Text;
                AMmoduleModel.modCode = textCode[6].Text;
                AMmoduleModel.modAssess = Int32.Parse(combobox1[6].GetItemText(this.combobox1[6].SelectedItem));
                AMmoduleModel.modCred = Int32.Parse(combobox[6].GetItemText(this.combobox[6].SelectedItem));
                addAssessment assessment6 = new addAssessment(courseTitle, AMmoduleModel.modName, AMmoduleModel.modCode, AMmoduleModel.modAssess, AMmoduleModel.modCred, level); 
                assessment6.Activate();
                assessment6.ShowDialog();
            }
        }

        private void assesmentButton8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textboxModule[7].Text) || string.IsNullOrEmpty(textCode[7].Text) || string.IsNullOrEmpty(combobox[7].Text) || string.IsNullOrEmpty(combobox1[7].Text))
            {
                MessageBox.Show("Fill in all Fields");
            }
            else
            {
                md = new moduleModel();
                AMmoduleModel.modName = textboxModule[7].Text;
                AMmoduleModel.modCode = textCode[7].Text;
                AMmoduleModel.modAssess = Int32.Parse(combobox1[7].GetItemText(this.combobox1[7].SelectedItem));
                AMmoduleModel.modCred = Int32.Parse(combobox[7].GetItemText(this.combobox[7].SelectedItem));
                addAssessment assessment7 = new addAssessment(courseTitle, AMmoduleModel.modName, AMmoduleModel.modCode, AMmoduleModel.modAssess, AMmoduleModel.modCred, level);
                assessment7.Activate();
                assessment7.ShowDialog();
            }
        }
         

    }

}
