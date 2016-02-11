using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomaDataModel
{
    class Choice
    {
        // Primary Key
        public int ChoiceID { get; set; }

        // Foreign Key
        public int YearTermID { get; set; }

        // Student A00... Number
        // Max Length 9 Characters
        public string StudentID { get; set; }

        // Max Length 40 Characters
        public string StudentFirstName { get; set; }

        // Max Length 40 Characters
        public string StudentLastName { get; set; }

        // Foreign Key
        public int FirstChoiceOptionID { get; set; }

        // Foreign Key
        public int SecondChoiceOptionID { get; set; }

        // Foreign Key
        public int ThirdChoiceOptionID { get; set; }

        // Foreign Key
        public int FourthChoiceOptionID { get; set; }

        // Always the current Date-Time
        public DateTime SelectionDate { get; set; }
    }
}
