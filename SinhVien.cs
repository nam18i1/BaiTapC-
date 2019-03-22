using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THConStructor
{
    class SinhVien
    {
        public String masv;
        float toan;
        float ly;
        float hoa;
        public SinhVien()
        {
            this.masv = "01";
            this.toan = (float)7.5;
            this.ly = (float)8.5;
            this.hoa = (float)6.0;
        }
        public SinhVien(String ma, float toan, float ly, float hoa)
        {
            this.masv = ma;
            this.toan = toan;
            this.ly = ly;
            this.hoa =hoa;
        }
        public void nhap()
        {
            Console.WriteLine("Nhap Masv:");
            this.masv = Console.ReadLine();
            Console.WriteLine("Nhap diem mon toan");
            this.toan = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem mon ly");
            this.ly = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem mon hoan");
            this.hoa = float.Parse(Console.ReadLine());
        }
        public float TB()
        {
            float tb = (this.toan + this.ly + this.hoa) / 3;
            return tb;
        }
        public void IN()
        {
            Console.WriteLine("MaSV {0}, Toan: {1}, Ly: {2}, Hoa: {3}", this.masv, this.toan, this.ly, this.hoa);
            Console.WriteLine("Diem TB la: {0}", this.TB());
        }
    }
}
