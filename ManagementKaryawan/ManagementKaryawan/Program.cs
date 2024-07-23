using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementKaryawan
{
    internal class Program
    {

        static List<IPerson> karyawan = new List<IPerson>();

        static void Main(string[] args)
        {
            int pilih;
            do
            {
                Console.WriteLine("+-------------------------+");
                Console.WriteLine("| Menu:                   |");
                Console.WriteLine("+-------------------------+");
                Console.WriteLine("|  1. Tambah Data         |");
                Console.WriteLine("|  2. Lihat Data          |");
                Console.WriteLine("|  3. Hapus Data          |");
                Console.WriteLine("|  4. Keluar              |");
                Console.WriteLine("+-------------------------+");
                Console.Write("Pilih menu [1-4]: ");
                pilih = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (pilih)
                {
                    case 1:
                        Add();
                        break;
                    case 2:
                        View();
                        break;
                    case 3:
                        Delete();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Pilihan tidak valid. Silakan coba lagi.");
                        break;
                }
            } while (pilih != 4);
        }

        static void Add()
        {
            string lagi;
            do
            {
                Console.Write("Masukkan ID Karyawan : ");
                string id = Console.ReadLine();
                Console.Write("Masukkan Nama        : ");
                string nama = Console.ReadLine();
                Console.Write("Masukkan Usia        : ");
                int umur = int.Parse(Console.ReadLine());
                Console.Write("Masukkan Alamat      : ");
                string alamat = Console.ReadLine();
                Console.Write("Masukkan Jabatan     : ");
                string jabatan = Console.ReadLine();

                karyawan.Add(new Karyawan { KaryawanID = id, Nama = nama, Umur = umur, Alamat = alamat, Jabatan = jabatan });
                Console.WriteLine("Karyawan berhasil ditambahkan.\n");
                Console.Write("Apakah anda ingin menambah data lagi?[Y/n]: ");
                lagi = Console.ReadLine();
            } while (lagi == "y" || lagi == "Y");
            Console.Clear();
        }

        static void View()
        {
            string lagi;
            do
            {
                Console.WriteLine("+-------------+----------------------+------+----------------------+-----------------+");
                Console.WriteLine("| KaryawanID  |         Nama         | Umur |        Alamat        |     Jabatan     |");
                Console.WriteLine("+-------------+----------------------+------+----------------------+-----------------+");
                if (karyawan.Count == 0) { Console.WriteLine("|                                     Data Kosong                                    |"); }
                foreach (Karyawan i in karyawan)
                {
                    i.DisplayInfo();
                }
                Console.WriteLine("+------------------------------------------------------------------------------------+");
                Console.Write("Apakah anda ingin kembali ke menu?[Y/n]: ");
                lagi = Console.ReadLine();
                if (lagi.ToLower() != "y") { Console.Clear(); } else { Console.Clear(); };
            } while (lagi.ToLower() != "y");
        }

        static void Delete()
        {
            string lagi;
            do
            {
                Console.Write("Masukkan ID Karyawan yang ingin dihapus: ");
                string id = Console.ReadLine();

                IPerson DeleteKaryawan = karyawan.Find(kry => (kry as Karyawan)?.KaryawanID == id);
                if (DeleteKaryawan != null)
                {
                    karyawan.Remove(DeleteKaryawan);
                    Console.WriteLine("Karyawan berhasil dihapus.\n");
                }
                else
                {
                    Console.WriteLine("Karyawan tidak ditemukan.\n");
                }
                Console.Write("Apakah anda ingin menghapus data lagi?[Y/n]: ");
                lagi = Console.ReadLine();
                Console.WriteLine();
            } while (lagi.ToLower() == "y"); 
            Console.Clear();
        }
    }
}
