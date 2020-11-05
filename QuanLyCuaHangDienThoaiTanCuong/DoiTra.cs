using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangDienThoaiTanCuong
{
    class DoiTra
    {
        private string madoitra, tenkh, tendt,  ngaydoi,loaidoi;        
        public string Madoitra
        {
            get
            {
                return madoitra;
            }

            set
            {
                madoitra = value;
            }
        }

        public string Ngaydoi
        {
            get
            {
                return ngaydoi;
            }

            set
            {
                ngaydoi = value;
            }
        }

        public string Tendt
        {
            get
            {
                return tendt;
            }

            set
            {
                tendt = value;
            }
        }

        public string Tenkh
        {
            get
            {
                return tenkh;
            }

            set
            {
                tenkh = value;
            }
        }

        
        public DoiTra()
        {
            madoitra = "";
            tenkh = "";
            tendt = "";
            ngaydoi = "";
          
        }
        public DoiTra (DoiTra doi)
        {
            this.madoitra = doi.madoitra;
            this.tendt = doi.tendt;
            this.tendt = doi.tendt;
            this.ngaydoi = doi.ngaydoi;
       
        }
        public DoiTra(string doitra)
        {
            string[] tmp = doitra.Split('|');
            this.madoitra = tmp[0];
            this.tenkh = tmp[1];
            this.tendt = tmp[2];
          
            this.ngaydoi = tmp[3];
        }
        public void nhap()
        {
            do
            {
                Console.Write("nhập ma doi tra: ");
                madoitra = Console.ReadLine().Trim();
            } while (madoitra == "");
            do
            {
                Console.Write("nhập tên khách hàng: ");
                tenkh = Console.ReadLine().Trim();
            } while (tenkh == "");
            do
            {
                Console.Write("nhập tên điện thoại khách hàng yêu cầu đổi: ");
                tendt = Console.ReadLine().Trim();
            } while (tendt == "");
            ConsoleKeyInfo loai;
            
            do
            {
                Console.Write("nhập ngày đổi: ");
                ngaydoi = Console.ReadLine().Trim();
            } while (ngaydoi == "");
        }
        public string tostring()
        {
            return madoitra + "|" + tenkh + "|" + tendt + "|"+ngaydoi;
            
        }
    }
    class QLDT
    {
        private List<DoiTra> doitra;
        public QLDT()
        {
            doitra = new List<DoiTra>();
        }
        public void WriteFile(string filename)
        {
            StreamWriter sw = new StreamWriter(filename);
            foreach (DoiTra dt in doitra)
            {
                sw.WriteLine(dt.tostring());
            }
            sw.Close();
        }
        public void writefile(string filename, DoiTra dt)
        {
            StreamWriter sw = new StreamWriter(filename, true);

            sw.WriteLine(dt.tostring());

            sw.Close();
        }
        public void ReadFile(string filename)
        {

            doitra = new List<DoiTra>();
            StreamReader sr = new StreamReader(filename);
            String tmp;
            DoiTra dt;
            while (sr.EndOfStream == false)
            {
                tmp = sr.ReadLine().Trim();
                if (tmp == "") continue;
                dt = new DoiTra(tmp);
                doitra.Add(dt);
            }
            sr.Close();
        }
        public DoiTra TimKiemTheoMa(String madt)
        {

            foreach (DoiTra dt in doitra)
            {
                ReadFile("doitra.txt");
                if (dt.Madoitra.Trim().Equals(madt.Trim()))
                    return dt;

            }
            return null;
        }
        public void them(DoiTra dt)
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            ReadFile("doitra.txt");
            if (TimKiemTheoMa(dt.Madoitra.Trim()) != null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("thêm thất bại, mã đổi trả đã tồn tại");
            }
            else
            {
                doitra.Add(dt);
                writefile("doitra.txt", dt);
            }
        }
        public void nhap()
        {
            DoiTra dt = new DoiTra();
            dt.nhap();
            them(dt);
            Console.ReadKey();
        }
        public void hien()
        {
            int i = 1;
            ReadFile("doitra.txt");
            foreach(DoiTra dt in doitra)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("{0,3} {1,10} {2,-20} {3,-20} {4,10}","STT","mã đổi trả","tên khách hàng","tên điện thoại đổi","ngày đổi");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("{0,3} {1,10} {2,-20} {3,-20} {4,10}", i, dt.Madoitra, dt.Tenkh, dt.Tendt, dt.Ngaydoi);
                i = i + 1;

            }
        }
    }
}
