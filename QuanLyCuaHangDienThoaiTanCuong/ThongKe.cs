using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangDienThoaiTanCuong
{
    class ThongKe
    {
        QLHDN n = new QLHDN();
        QLHDB b = new QLHDB();
        public static void tkedt()
        {
            QLHDN n = new QLHDN();
            QLHDB b = new QLHDB();
            b.thkedt();
        }
        public static void thang()
        {
            QLHDN n = new QLHDN();
            QLHDB b = new QLHDB();
            int thang, nam;
            int f = 0;
            do
            {
                Console.Write("nhập tháng:");
                thang = int.Parse(Console.ReadLine());
            } while (thang < 1 || thang > 12);

            do
            {
                Console.Write("nhập năm:");
                nam = int.Parse(Console.ReadLine());
            } while (nam < 2015);
            b.doanhthuthang(thang, nam);
            n.doanhthuthang(thang, nam);
        }
        public static void nam()
        {
            
            QLHDN n = new QLHDN();
            QLHDB b = new QLHDB();
            int nam;
            int f = 0;
            
            do
            {
                Console.Write("nhập năm:");
                nam = int.Parse(Console.ReadLine());
            } while (nam < 2015);
            b.doanhthunam(nam);
            n.doanhthunam(nam);
        }
        
    }
}
