using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementKaryawan
{
    internal abstract class Person : IPerson
    {
        public string Nama { get; set; }
        public int Umur { get; set; }
        public string Alamat { get; set; }

        public abstract void DisplayInfo();
    }
}
                                                           

