using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementKaryawan
{
    internal class Karyawan : Person
    {
        public string KaryawanID { get; set; }
        public string Jabatan { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"| {KaryawanID,-11} | {Nama,-20} | {Umur,-4} | {Alamat,-20} | {Jabatan,-15} |");
        }
    }
}

