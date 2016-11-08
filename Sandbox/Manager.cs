using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Manager : Employee
    {
        private int monthlyBonus;
        private int timer;

        

        public Manager(String name, int salaryPerMonth) : base(name, salaryPerMonth)
        {
            this.timer = 0;
            this.monthlyBonus = 800;
        }

        public void SetAntalTimer(int timer)
        {
            this.timer = timer;
        }

        public override int GetSalaryPerMonth()
        {
            int sum = 0;

            if (timer > 180)
            {
                sum = GetSalaryPerMonth() + monthlyBonus;
            }
            return GetSalaryPerMonth();

        }
     }
}
