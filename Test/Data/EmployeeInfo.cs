using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Data
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

        public EmployeeInfo() { }

        public EmployeeInfo(int _id, string _firstName, string _surName,
            string _patronymic, DateTime _dateOfBirth, string _docSeries,
            string _docNumber, string _position)
        {
            ID = _id;
            FirstName = _firstName;
            SurName = _surName;
            Patronymic = _patronymic;
            DateOfBirth = _dateOfBirth;
            DocSeries = _docSeries;
            DocNumber = _docNumber;
            Position = _position;
        }

        public EmployeeInfo Clone()
        {
            return new EmployeeInfo()
            {
                ID = this.ID,
                FirstName = this.FirstName,
                SurName = this.SurName,
                Patronymic = this.Patronymic,
                DateOfBirth = this.DateOfBirth,
                DocSeries = this.DocSeries,
                DocNumber = this.DocNumber,
                Position = this.Position,
            };
        }

        public bool Equals(EmployeeInfo employeeInfo)
        {
            return(this.FirstName == employeeInfo.FirstName
                && this.SurName == employeeInfo.SurName
                && this.Patronymic == employeeInfo.Patronymic
                && this.DateOfBirth == employeeInfo.DateOfBirth
                && this.DocSeries == employeeInfo.DocSeries
                && this.DocNumber == employeeInfo.DocNumber
                && this.Position == employeeInfo.Position);

        }

        public void Copy(EmployeeInfo _employeeInfo)
        {
            ID = _employeeInfo.ID;
            FirstName = _employeeInfo.FirstName;
            SurName = _employeeInfo.SurName;
            Patronymic = _employeeInfo.Patronymic;
            DateOfBirth = _employeeInfo.DateOfBirth;
            DocSeries = _employeeInfo.DocSeries;
            DocNumber = _employeeInfo.DocNumber;
            Position = _employeeInfo.Position;
        }
    }
}
