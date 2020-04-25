using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekzamen
{
    class Plane
    {
        public int id;
        public string Model;
        public int Max;
        public int Speed;
        public Plane()
        {

        }
        public Plane(int id)
        {
            string st = WorkFile.ReadLine(id);
            string[] ss = st.Split(';');
            id = Convert.ToInt32(ss[0]);
            Model = ss[1];
            Max = Convert.ToInt32(ss[2]);
            Speed = Convert.ToInt32(ss[3]);
        }
        public void Save()
        {
            WorkFile.AddUpdate(id, Model, Max, Speed);
        }

    }
}
