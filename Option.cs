using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomaDataModel
{
    class Option
    {
        // Primary Key
        public int OptionID { get; set; }

        // Max length: 50 characters
        public string Title { get; set; }

        public bool isActive { get; set; }
    }
}
