using ClassLibrary.Core.Utilities.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Business.Concrete
{
    public class BookManager
    {
        public string Add()
        {
            if (BusinessRules.Run(CheckIfBookExists(),CheckIfBookNameLower3()))
            {
                return "Fail.";
            }
            return "The book added to db.";
        }

        //Business Rules
        private bool CheckIfBookExists()
        {
            return false;//The book does not exist in db.
        }
        private bool CheckIfBookNameLower3()
        {
            return false;//The book name longer than 3.
        }

    }
}
