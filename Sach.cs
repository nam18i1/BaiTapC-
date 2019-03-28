using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTInheritance
{
    class Sach
    {
        String masach;
        String ngaynhap;
        public double dongia;
        public double soluong;
        public Sach()
        {
            this.masach = "MT4021";
            this.ngaynhap = "24/2/2019";
            this.dongia = 12000;
            this.soluong = 2;
        }
        public void nhap()
        {
            Console.WriteLine("Nhap ma sach");
            this.masach = Console.ReadLine();
            Console.WriteLine("Nhap ngay nhap sach");
            this.ngaynhap = Console.ReadLine();
            Console.WriteLine("Nhap don gia");
            this.dongia = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so luong sach");
            this.soluong = double.Parse(Console.ReadLine());
        }
        public void In()
        {
            Console.WriteLine("\tThong tin");
            Console.WriteLine("Ma Sach: {0} || Ngay nhap: {1}\nDon gia: {2} || so luong sach: {3}",this.masach, this.ngaynhap, this.dongia, this.soluong);
        }
    }
    }

