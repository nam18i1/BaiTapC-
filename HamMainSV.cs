using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THConStructor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap so SV:");
            n = Int32.Parse(Console.ReadLine());
            SinhVien[] sv = new SinhVien[n];
            for(int i = 0; i < n; i++)
            {
                sv[i] = new SinhVien();
                sv[i].nhap();
                sv[i].IN();
            }
            float min = sv[0].TB();
            for(int i = 1; i < n; i++)
            {
                if (sv[i].TB() < min)
                    min = sv[i].TB();
             }
            Console.WriteLine("Sinh vien co diem TB thap nhat la: {0}", min);
            for(int i =0; i < n; i++)
            {
                if (sv[i].masv.Contains("IT"))
                    Console.WriteLine("Ma sv {0} co diem TB la: {1}", sv[i].masv, sv[i].TB());
            }
            for(int i = 0; i < n; i++)
            {
                for(int j=i+1; j< n;j++)
                {
                    if(sv[j].TB() < sv[i].TB())
                   {       
                       SinhVien t =  new SinhVien();
                        t = sv[i];
                        sv[i] = sv[j];
                        sv[j] = t;
                    }
                }
             }
            Console.WriteLine("Diem TB sap xep theo thu tu tang dan:");
            for(int i = 0; i  < n; i++)
                Console.WriteLine("MaSv: {0} DiemTB: {1}",sv[i].masv,sv[i].TB());
            Console.ReadLine();
        }
    }
}


