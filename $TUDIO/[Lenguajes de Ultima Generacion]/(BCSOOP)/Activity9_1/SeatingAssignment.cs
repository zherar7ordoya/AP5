using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity9_1
{
    public class SeatingAssignment
    {
        int _row;
        int _seat;
        string _student;
        public int Row
        {
            get { return _row; }
            set { _row = value; }
        }
        public int Seat
        {
            get { return _seat; }
            set { _seat = value; }
        }
        public string Student
        {
            get { return _student; }
            set { _student = value; }
        }
        public SeatingAssignment(int row, int seat, string student)
        {
            this.Row = row;
            this.Seat = seat;
            this.Student = student;
        }
    }
}
