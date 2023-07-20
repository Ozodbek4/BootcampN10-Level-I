using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N6_issue1
{
    internal class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDay { get; set; }
        public int Payment { get; set; }
        public string EduType { get; set; }
        public int PaymentAmount { get; set; }
        public bool IsPayment { get; set; }

        public int GetAge() => DateTime.Now.Year - BirthDay.Year;
        public string GetPayment()
        {
            decimal amount = Payment - PaymentAmount;
            if (amount < 0) return $"{-amount} haqdor";
            else return $"{amount} qarzdor";
        }
    }
}
