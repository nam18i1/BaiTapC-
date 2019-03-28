using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTInheritance
{
    class SachGiaoKhoa : Sach
    {
        String ttsach;
        
        public SachGiaoKhoa() : base()
        {
           
            this.ttsach = "moi";
         }
        public new void nhap()
        {
            base.nhap();
            Console.WriteLine("Tinh trang sach (moi hay cu)");
            this.ttsach = Console.ReadLine();
        }
        public double tinhtien() 
        {
            
            double tt;
            if (this.ttsach == "moi")
             tt = this.soluong * this.dongia;
            else 
            tt = (this.soluong * this.dongia) * (0.5);
            
            return tt;
            
           
        }
        public new void In()
        {
            base.In();
            Console.WriteLine("Tien Sach la {0}", this.tinhtien());
        }
    }
}
