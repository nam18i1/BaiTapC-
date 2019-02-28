using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    class DoanTau
    {
        String MaDT;
        int SLkhach;
        double tt;
        public void nhapTT()
        {
            Console.WriteLine("Nhap Ma doan tau");
            this.MaDT = Console.ReadLine();
            Console.WriteLine("Nhap so luong khach hang");
            this.SLkhach = Convert.ToInt32(Console.ReadLine());
        }
        public double tongtien()
        {
            if (this.SLkhach < 100)
                tt = (this.SLkhach * 100000);
            else
                tt = (this.SLkhach * 80000);
            return tt;
        }
        public void intt()
        {
            Console.WriteLine("Ma tau {0}\ntong tien la {1}",this.MaDT, this.tongtien());
        }
    }
}
