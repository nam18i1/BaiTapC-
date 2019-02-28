using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
    class CauA
    {
        int i;
        int n;
        double a, b, c;
        public void nhapN()
        {
            Console.WriteLine("Nhap n");
            this.n = Convert.ToInt32(Console.ReadLine());
        }
        public double TinhCauA()
        {
            for (i = 1; i <= n; i++)
            
                if (i % 2 == 0)
                
                    a -= i;
                
                else
                
                    a += i;
                
            
            return a;
        }
        public double TinhCauB(){
            for(i=1; i<=n; i++)
                {
                b+=1/(float)i;
                }
            return b;
             }
        public double TinhCauC()
         {
           for(i=1; i<=n; i++){
              c+=i;
            }
           return c;
         }
        public void InTong()
        {
            Console.WriteLine("Ket qua cua cauA ={0}\n CauB = {1}\n CauC = {2}",this.TinhCauA(), this.TinhCauB(), this.TinhCauC());
            
          }
    }
}
