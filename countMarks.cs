using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Threading.Tasks;

namespace GradeCalculator
{
    class countMarks
    {

        int lvl;
        int level6LowestMark;

        int average5;
        int average6;

        public string getModuleAverage(int level)
        {
        
            int overall = 0;
            int totalAssessments = 0;
            lvl = level;

            try
            {

                //Open db connection
                SQLiteConnection m_dbConnection;

                m_dbConnection = new SQLiteConnection("Data Source = GradePredict.sqlite; Version =3;");
                m_dbConnection.Open();

                //int asCount = 0;

                SQLiteCommand query = new SQLiteCommand(m_dbConnection);

                //select all modules in level
                query.CommandText = "SELECT Id FROM Modules WHERE level=" + lvl;
                SQLiteDataReader r = query.ExecuteReader();

                //Get total num of modules
                SQLiteCommand getTotalModules = new SQLiteCommand(m_dbConnection);
                getTotalModules.CommandText = "SELECT COUNT(Id) FROM Modules WHERE level=" + lvl;
                int numOfModules = Convert.ToInt32(getTotalModules.ExecuteScalar());

                

                while (r.Read())
                {

                    //Get assessments one by one
                    SQLiteCommand getM = new SQLiteCommand(m_dbConnection);
                    getM.CommandText = "SELECT Id FROM Assessments WHERE pModule=" + Convert.ToInt32(r["Id"]);
                    SQLiteDataReader r2 = getM.ExecuteReader();

                    //read through all assessments of particular module
                    while (r2.Read())
                    {

                        SQLiteCommand getCredCount = new SQLiteCommand(m_dbConnection);
                        getCredCount.CommandText = "SELECT credits FROM Modules WHERE Id=" + Convert.ToInt32(r["Id"]);
                        int credCount = Convert.ToInt32(getCredCount.ExecuteScalar());

                        //if module credit is 15, do normal calculation
                        if (credCount == 15)
                        {
                            SQLiteCommand getWeight = new SQLiteCommand(m_dbConnection);
                            getWeight.CommandText = "SELECT weight FROM Assessments WHERE Id=" + Convert.ToInt32(r2["Id"]);
                            int weight = (int)getWeight.ExecuteScalar();

                            SQLiteCommand getMark = new SQLiteCommand(m_dbConnection);
                            getMark.CommandText = "SELECT mark FROM Assessments WHERE Id=" + Convert.ToInt32(r2["Id"]);
                            int mark = (int)getMark.ExecuteScalar();

                            //MessageBox.Show("15 cred Mark: "+mark);

                            totalAssessments += mark * weight / 100;
                        }

                        //otherwise, multiply by 2
                        if (credCount == 30)
                        {
                            SQLiteCommand getWeight = new SQLiteCommand(m_dbConnection);
                            getWeight.CommandText = "SELECT weight FROM Assessments WHERE Id=" + Convert.ToInt32(r2["Id"]);
                            int weight = (int)getWeight.ExecuteScalar();

                            SQLiteCommand getMark = new SQLiteCommand(m_dbConnection);
                            getMark.CommandText = "SELECT mark FROM Assessments WHERE Id=" + Convert.ToInt32(r2["Id"]);
                            int mark = (int)getMark.ExecuteScalar();

                            

                            totalAssessments += (mark * weight / 100) * 2;

                            //Increase num of modules
                            
                        }

                    }

                    //Check if module is 30 credits, if yes, update module count
                    SQLiteCommand check = new SQLiteCommand(m_dbConnection);
                    check.CommandText = "SELECT credits FROM Modules WHERE Id=" + Convert.ToInt32(r["Id"]);
                    int credCheck = Convert.ToInt32(check.ExecuteScalar());
                    if (credCheck == 30) { numOfModules ++; }

                }

               

                overall += totalAssessments / numOfModules;

                m_dbConnection.Close();
            }
            catch
            {
           
            }

            return Convert.ToString(overall);
        }

        //Get best 7 modules, level 6
        public string getBest6()
        {
            int totalAssessments = 0;

            List<int> allModuleMarks = new List<int>();
            //ArrayList allModuleMarks = new ArrayList();
            ArrayList allLevelMarks = new ArrayList();

            //Open db connection
            SQLiteConnection m_dbConnection;

            m_dbConnection = new SQLiteConnection("Data Source = GradePredict.sqlite; Version =3;");
            m_dbConnection.Open();

            //int asCount = 0;

            SQLiteCommand query = new SQLiteCommand(m_dbConnection);

            query.CommandText = "SELECT Id FROM Modules WHERE level=6";
            SQLiteDataReader r = query.ExecuteReader();

            //Get total num of modules
            SQLiteCommand getTotalModules = new SQLiteCommand(m_dbConnection);
            getTotalModules.CommandText = "SELECT COUNT(Id) FROM Modules WHERE level=6";
            int numOfModules = Convert.ToInt32(getTotalModules.ExecuteScalar());

            while (r.Read())
            {
                //SQLiteCommand query_1 = new SQLiteCommand(m_dbConnection);
                //query_1.CommandText = "SELECT asnum FROM Modules WHERE id=" + Convert.ToInt32(r["id"]);
                //int asnum = (int)query_1.ExecuteScalar();

                SQLiteCommand getM = new SQLiteCommand(m_dbConnection);
                getM.CommandText = "SELECT Id FROM Assessments WHERE pModule=" + Convert.ToInt32(r["Id"]);
                SQLiteDataReader r2 = getM.ExecuteReader();

                int globalMarkCount = 0;

                //read through all assessments of particular module
                while (r2.Read())
                {
                    int markToCount = 0;

                    SQLiteCommand getCredCount = new SQLiteCommand(m_dbConnection);
                    getCredCount.CommandText = "SELECT credits FROM Modules WHERE id=" + Convert.ToInt32(r["Id"]);
                    int credCount = Convert.ToInt32(getCredCount.ExecuteScalar());

                    //if module credit is 15, do normal calculation
                    if (credCount == 15)
                    {
                        SQLiteCommand getWeight = new SQLiteCommand(m_dbConnection);
                        getWeight.CommandText = "SELECT weight FROM Assessments WHERE id=" + Convert.ToInt32(r2["Id"]);
                        int weight = (int)getWeight.ExecuteScalar();

                        SQLiteCommand getMark = new SQLiteCommand(m_dbConnection);
                        getMark.CommandText = "SELECT mark FROM Assessments WHERE Id=" + Convert.ToInt32(r2["Id"]);
                        int mark = (int)getMark.ExecuteScalar();

                        markToCount += mark;
                        globalMarkCount = markToCount;
                        //MessageBox.Show("15 cred Mark: "+mark);

                        totalAssessments += mark * weight / 100;
                    }

                    //otherwise, multiply by 2
                    if (credCount == 30)
                    {
                        SQLiteCommand getWeight = new SQLiteCommand(m_dbConnection);
                        getWeight.CommandText = "SELECT weight FROM Assessments WHERE Id=" + Convert.ToInt32(r2["Id"]);
                        int weight = (int)getWeight.ExecuteScalar();

                        SQLiteCommand getMark = new SQLiteCommand(m_dbConnection);
                        getMark.CommandText = "SELECT mark FROM Assessments WHERE Id=" + Convert.ToInt32(r2["Id"]);
                        int mark = (int)getMark.ExecuteScalar();

                        markToCount += mark*2;
                        globalMarkCount = markToCount;

                        totalAssessments += (mark * weight / 100) * 2;

                        
                    }

                    

                }

                //Check if module is 30 credits, if yes, update module count
                SQLiteCommand check = new SQLiteCommand(m_dbConnection);
                check.CommandText = "SELECT credits FROM Modules WHERE Id=" + Convert.ToInt32(r["Id"]);
                int credCheck = Convert.ToInt32(check.ExecuteScalar());
                if (credCheck == 30) { numOfModules++; }

                //Add to the list each markToCount is the average of one module
                allModuleMarks.Add(globalMarkCount);
                
            }



            //Get lowest mark, by parsing through list.
            int min = 100; int minIndex = 0;
            for (int i = 1; i < allModuleMarks.Count; ++i)
            {
                if (allModuleMarks[i] < min)
                {
                    min = allModuleMarks[i]; //this is the mark
                    minIndex = i; //and its index
                }
            }

            level6LowestMark=min; //assigning to the global var, need it for the second part

            int best7Marks=0;

            for (int i = 0; i < allModuleMarks.Count; i++)
            {
                if (i != minIndex)
                {
                    best7Marks += allModuleMarks[i];
                }

            }

            average5 = best7Marks/7;

            return Convert.ToString(average5);

        }

        //Get best 7 modules, level 6,5
        public string getBest56()
        {
            
            int totalAssessments = 0;

            List<int> allModuleMarks = new List<int>();
            //ArrayList allModuleMarks = new ArrayList();
            ArrayList allLevelMarks = new ArrayList();

            //Open db connection
            SQLiteConnection m_dbConnection;

            m_dbConnection = new SQLiteConnection("Data Source = GradePredict.sqlite; Version =3;");
            m_dbConnection.Open();

            //int asCount = 0;

            SQLiteCommand query = new SQLiteCommand(m_dbConnection);

            query.CommandText = "SELECT Id FROM Modules WHERE level=5";
            SQLiteDataReader r = query.ExecuteReader();

            //Get total num of modules
            SQLiteCommand getTotalModules = new SQLiteCommand(m_dbConnection);
            getTotalModules.CommandText = "SELECT COUNT(Id) FROM Modules WHERE level=5";
            int numOfModules = Convert.ToInt32(getTotalModules.ExecuteScalar());

            while (r.Read())
            {
                //SQLiteCommand query_1 = new SQLiteCommand(m_dbConnection);
                //query_1.CommandText = "SELECT asnum FROM Modules WHERE id=" + Convert.ToInt32(r["id"]);
                //int asnum = (int)query_1.ExecuteScalar();

                SQLiteCommand getM = new SQLiteCommand(m_dbConnection);
                getM.CommandText = "SELECT Id FROM Assessments WHERE pModule=" + Convert.ToInt32(r["Id"]);
                SQLiteDataReader r2 = getM.ExecuteReader();

                int globalMarkCount = 0;

                //read through all assessments of particular module
                while (r2.Read())
                {
                    int markToCount = 0;

                    SQLiteCommand getCredCount = new SQLiteCommand(m_dbConnection);
                    getCredCount.CommandText = "SELECT credits FROM Modules WHERE Id=" + Convert.ToInt32(r["Id"]);
                    int credCount = Convert.ToInt32(getCredCount.ExecuteScalar());

                    //if module credit is 15, do normal calculation
                    if (credCount == 15)
                    {
                        SQLiteCommand getWeight = new SQLiteCommand(m_dbConnection);
                        getWeight.CommandText = "SELECT weight FROM Assessments WHERE Id=" + Convert.ToInt32(r2["Id"]);
                        int weight = (int)getWeight.ExecuteScalar();

                        SQLiteCommand getMark = new SQLiteCommand(m_dbConnection);
                        getMark.CommandText = "SELECT mark FROM Assessments WHERE Id=" + Convert.ToInt32(r2["Id"]);
                        int mark = (int)getMark.ExecuteScalar();

                        markToCount += mark;
                        globalMarkCount = markToCount;
                      

                        totalAssessments += mark * weight / 100;
                    }

                    //otherwise, multiply by 2
                    if (credCount == 30)
                    {
                        SQLiteCommand getWeight = new SQLiteCommand(m_dbConnection);
                        getWeight.CommandText = "SELECT weight FROM Assessments WHERE Id=" + Convert.ToInt32(r2["Id"]);
                        int weight = (int)getWeight.ExecuteScalar();

                        SQLiteCommand getMark = new SQLiteCommand(m_dbConnection);
                        getMark.CommandText = "SELECT mark FROM Assessments WHERE Id=" + Convert.ToInt32(r2["Id"]);
                        int mark = (int)getMark.ExecuteScalar();

                        markToCount += mark * 2;
                        globalMarkCount = markToCount;
                        //MessageBox.Show("15 cred Mark: " + mark);

                        totalAssessments += (mark * weight / 100) * 2;

                        
                    }


                }

                //Check if module is 30 credits, if yes, update module count
                SQLiteCommand check = new SQLiteCommand(m_dbConnection);
                check.CommandText = "SELECT credits FROM Modules WHERE Id=" + Convert.ToInt32(r["Id"]);
                int credCheck = Convert.ToInt32(check.ExecuteScalar());
                if (credCheck == 30) { numOfModules++; }

                //Add to the list each markToCount is the average of one module
                allModuleMarks.Add(globalMarkCount);

            }

            //ADD LOWEST MARK FROM LEVEL 6
            allModuleMarks.Add(level6LowestMark);

            //Get lowest mark, by parsing through list.
            int min = 100; int aftermin = 100; int minIndex = 0; int afterMinIndex = 0;
            for (int i = 1; i < allModuleMarks.Count; ++i)
            {
                if (allModuleMarks[i] < min)
                {
                    min = allModuleMarks[i]; //this is the mark
                    minIndex = i; //and its index
                }
            }

            //Get SECOND lowest mark, by parsing through list.
            for (int i = 1; i < allModuleMarks.Count; ++i)
            {
                if (i!=min)
                {
                    if (allModuleMarks[i] < aftermin)
                    {
                        aftermin = allModuleMarks[i]; //this is the mark
                        afterMinIndex = i; //and its index
                    }
                }
            }

            int best7Marks = 0;

            for (int i = 0; i < allModuleMarks.Count; i++)
            {
                if (i != minIndex || i != afterMinIndex)
                {
                    best7Marks += allModuleMarks[i];
                }

            }

            average6 = best7Marks/7;
            return Convert.ToString(average6);

        }

        public string averageAllYears(){
            //Average everything by calculating percentages
            int averageAll = (average5 * 40 / 100) + (average6 * 60 / 100);
            string result="";

            if (averageAll >= 70)
            {
                result = "1st Class Degree, " + averageAll + "%";
            }

            if (averageAll < 69 && averageAll > 60)
            {
                result = "Upper Second Degree, " + averageAll + "%";
            }

            if (averageAll < 59 && averageAll > 50)
            {
                result = "Lower Second Degree, " + averageAll + "%";
            }

            if (averageAll < 49 && averageAll > 45)
            {
                result = "Third Class Degree, " + averageAll + "%";
            }

            if (averageAll < 44 && averageAll > 40)
            {
                result = "Ordinary Pass, " + averageAll + "%";
            }

            if (averageAll < 40)
            {
                result = "Fail";
            }

            

            return result;
        }

        //Recalculate with user details
        public string recalculate(int level5Av, int level6Av)
        {
            //Average everything by calculating percentages
            int averageAll = (level5Av * 40 / 100) + (level6Av * 60 / 100);
            string result = "";

            if (averageAll >= 70)
            {
                result = "1st Class Degree, " + averageAll+"%";
            }

            if (averageAll <= 69 && averageAll >= 60)
            {
                result = "Upper Second Degree, " + averageAll + "%";
            }

            if (averageAll <= 59 && averageAll >= 50)
            {
                result = "Lower Second Degree, " + averageAll + "%";
            }

            if (averageAll <= 49 && averageAll >= 45)
            {
                result = "Third Class Degree, " + averageAll + "%";
            }

            if (averageAll <= 44 && averageAll >= 40)
            {
                result = "Ordinary Pass, " + averageAll + "%";
            }

            if (averageAll < 40)
            {
                result = "Fail, " + averageAll + "%";
            }



            return result;
        }

    }
}
