using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Class
{
    public class EmployeeInfo
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Patronymic { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string DocSeries { get; set; }
        public string DocNumber { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }

        public EmployeeInfo(){}

        public EmployeeInfo(int _id, string _firstName, string _surName,
            string _patronymic, DateTime _dateOfBirth, string _docSeries,
            string _docNumber, string _position, string _department)
        {
            ID = _id;
            FirstName = _firstName;
            SurName = _surName;
            Patronymic = _patronymic;
            DateOfBirth = _dateOfBirth;
            DocSeries = _docSeries;
            DocNumber = _docNumber;
            Position = _position;
            Department = _department;
        }
    }
}
