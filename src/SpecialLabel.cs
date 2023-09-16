using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSU_Fall_2023_Hackathon
{
    public class SpecialLabel : Label
    {
        public static int count = 0;
        private string name;
        public int id;

        public SpecialLabel(string name)
        {
            this.name = name;
            Font = new Font("Segoe", 24);
            id = count;
            Location = new Point(300, (id * 100 + 10));
            count++;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
