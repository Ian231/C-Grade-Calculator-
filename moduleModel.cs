using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalculator
{
   public class moduleModel
    {
        String moduleName = " ", moduleCode = " ";
        int moduleAssessment = 0, moduleCredit = 0, moduleLevel = 0;


        String assessmentTitle = "", assessmentTitle2 = "", assessmentTitle3 = "", assessmentTitle4 = "";
        int assessmentWeight = 0, assessmentWeight2 = 0, assessmentWeight3 = 0, assessmentWeight4 = 0;
        int assessmentMark = 0, assessmentMark2 = 0, assessmentMark3 = 0, assessmentMark4 = 0; 
        int assessmentLevel = 0;

        public String modName
        {
            get { return moduleName; }
            set { moduleName = value; }
 
        }

        public String modCode
        {
            get { return moduleCode; }
            set { moduleCode = value; }
        }

        public int modAssess
        {
            get { return moduleAssessment; }
            set { moduleAssessment = value; }
        }

        public int modCred
        {
            get { return moduleCredit; }
            set { moduleCredit = value; }
        }

        public int modLevel
        {
            get { return moduleLevel; }
            set { moduleLevel = value; }
        }


        public String assessN
        {
            get { return assessmentTitle; }
            set { assessmentTitle = value; }
        }


        public String assessN2
        {
            get { return assessmentTitle2; }
            set { assessmentTitle2 = value; }
        }


        public String assessN3
        {
            get { return assessmentTitle3; }
            set { assessmentTitle3 = value; }
        }


        public String assessN4
        {
            get { return assessmentTitle4; }
            set { assessmentTitle4 = value; }
        }

        public int assessW
        {
            get { return assessmentWeight; }
            set { assessmentWeight = value; }
        }

        public int assessW2
        {
            get { return assessmentWeight2; }
            set { assessmentWeight2 = value; }
        }

        public int assessW3
        {
            get { return assessmentWeight3; }
            set { assessmentWeight3 = value; }
        }

        public int assessW4
        {
            get { return assessmentWeight4; }
            set { assessmentWeight4 = value; }
        }

        public int assessM
        {
            get { return assessmentMark; }
            set { assessmentMark = value; }
        }

        public int assessM2
        {
            get { return assessmentMark2; }
            set { assessmentMark2 = value; }
        }

        public int assessM3
        {
            get { return assessmentMark3; }
            set { assessmentMark3 = value; }
        }

        public int assessM4
        {
            get { return assessmentMark4; }
            set { assessmentMark4 = value; }
        }

        public int assessL
        {
            get { return assessmentLevel; }
            set { assessmentLevel = value; }
        }

    }


}
