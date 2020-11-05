using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangDienThoaiTanCuong
{
    class KhachHang
    {
        
        private string cmt, tenkh,gioitinh,diachi;
        private int ns;
        
        private string namsinh, sodt;

        public string Cmt
        {
            get
            {
                return cmt;
            }

            set
            {
                if(value!="")
                cmt = value;
            }
        }

        public string Diachi
        {
            get
            {
                return diachi;
            }

            set
            {
                if (value != "")
                    diachi = value;
            }
        }

        public string Gioitinh
        {
            get
            {
                return gioitinh;
            }

            set
            {
                if (value != "")
                    gioitinh = value;
            }
        }

        public int Ns
        {
            get
            {
                return ns;
            }

            set
            {
                if (value != 0)
                    ns = value;
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
                if (value != "")
                    tenkh = value;
            }
        }

        public string Namsinh
        {
            get
            {
                return namsinh;
            }

            set
            {
                if (value != "")
                    namsinh = value;
            }
        }

        public string Sodt
        {
            get
            {
                
                    return sodt;
            }

            set
            {
                if (value != "")
                    sodt = value;
            }
        }

        public KhachHang()
        {
            cmt = "";
            tenkh = "";
            gioitinh = "";
            diachi = "";
            ns = 0;
            sodt = "";
        }
        public KhachHang(KhachHang kh)
        {
            this.cmt = kh.cmt;
            this.tenkh = kh.tenkh;
            this.ns = kh.ns;
            this.diachi = kh.diachi;
            this.gioitinh = kh.gioitinh;
            this.namsinh = this.ns.ToString();
            
        }
        public KhachHang(string khachhang)
        {
            string []tmp = khachhang.Split('|');
            tenkh = tmp[0];
            cmt = tmp[1];
            namsinh = tmp[2];
            gioitinh = tmp[3];
            diachi = tmp[4];
            sodt = tmp[5];
        }
        public void nhap()
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("nhập tên khách hàng:");
                tenkh = Console.ReadLine().Trim();
            } while (tenkh == "");
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("nhập so chứng minh thư/thẻ căn cước:");
                cmt = Console.ReadLine().Trim();
            } while (cmt.Length!=9 & cmt.Length!=12);
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.Write("nhập năm sinh:");
                ns = int.Parse(Console.ReadLine());
            } while (ns<1920 && ns>2018);
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("nhập giới tính:");
                gioitinh = Console.ReadLine().Trim();
            } while (gioitinh != "nam" && gioitinh!="nu");
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("nhập địa chỉ:");
                diachi = Console.ReadLine().Trim();
            } while (diachi == "");
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("nhập số điện thoại:");
                sodt = Console.ReadLine().Trim();
            } while (sodt.Length!=11&&sodt.Length!=10);
        }
        public void update()
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("           CHƯƠNG TRÌNH QUẢN LÝ CỬA HÀNG ĐIỆN THOẠI TÂN CƯỜNG");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("     ******************************************************************");
            Console.WriteLine("     *                                 MENU                           *");
            Console.WriteLine("     *                 1: cập nhật tên khách hàng.                    *");
            Console.WriteLine("     *                                                                *");
            Console.WriteLine("     *                 2: cập nhật số chứng minh thư/thẻ căn cước.    *");
            Console.WriteLine("     *                                                                *");
            Console.WriteLine("     *                 3: cập nhật năm sinh.                          *");
            Console.WriteLine("     *                                                                *");
            Console.WriteLine("     *                 4: cập nhật giới tính.                         *");
            Console.WriteLine("     *                                                                *");
            Console.WriteLine("     *                 5: cập nhật địa chỉ.                           *");
            Console.WriteLine("     *                                                                *");
            Console.WriteLine("     *                 6: cập nhật so điện thoại.                     *");
            Console.WriteLine("     *                                                                *");
            Console.WriteLine("     *                 Backspace:quay lại                             *");
            Console.WriteLine("     *                                                                *");
            Console.WriteLine("     *                 Mời bạn chọn chức năng                         *");
            Console.WriteLine("     *                                                                *");
            Console.WriteLine("     ******************************************************************");
;
            int lc = int.Parse(Console.ReadLine());
            switch (lc)
            {
                case 1:
                    {
                        do
                        {
                            Console.Write("nhập tên khách hàng:");
                            tenkh = Console.ReadLine().Trim();
                        } while (tenkh == "");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("thông tin đã được cập nhật."); break;
                    }
                case 2:
                    {
                        do
                        {
                            Console.Write("nhập số chứng minh thư/thẻ căn cước:");
                            cmt = Console.ReadLine().Trim();
                        } while (cmt == ""); Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("thông tin đã được cập nhật."); break;
                    }
                case 3:
                    {
                        do
                        {
                            Console.Write("nhập năm sinh:");
                            ns = int.Parse(Console.ReadLine());
                        } while (ns < 1920); Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("thông tin đã được cập nhật."); break;
                    }
                case 4:
                    {
                        do
                        {
                            Console.Write("nhập giới tính:");
                            tenkh = Console.ReadLine().Trim();
                        } while (tenkh != "nam" || tenkh != "nu"); Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("thông tin đã được cập nhật."); break;
                    }
                case 5:
                    {
                        do
                        {
                            Console.Write("nhập địa chỉ:");
                            diachi = Console.ReadLine().Trim();
                        } while (diachi == ""); Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("thông tin đã được cập nhật."); break;
                    }
                case 6:
                    {
                        do
                        {
                            Console.Write("nhập số điện thoại:");
                            sodt = Console.ReadLine().Trim();
                        } while (sodt.Length>11); Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("thông tin đã được cập nhật."); break;
                    }
                case 0: break;
            }
        }
        public void hien()
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("{0,-20} {1,-12}  {2,4}  {3,5} {4,-20} {5,-11}", "tên khách hàng", "cmt/căn cước", "ns", " gt", "địa chỉ", "sđt");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0,-20} {1,-12}  {2,4}  {3,5} {4,-20} {5,-11}", tenkh,cmt,ns,gioitinh,diachi,sodt);
        }
        public String tostring()
        {
            return tenkh.Trim() +"|"+ cmt.Trim() + "|" + ns.ToString().Trim() + "|" + gioitinh.Trim() + "|" + diachi.Trim() + "|" + sodt.Trim();
        }
    }
    class QLKH
    {
        private List<KhachHang> khachhang;
        public QLKH()
        {
            khachhang = new List<KhachHang>();
        }
            public void WriteFile(string filename)
        {
            StreamWriter sw = new StreamWriter(filename);
            foreach (KhachHang kh in khachhang)
            {
                sw.WriteLine(kh.tostring());
            }
            sw.Close();
        }
        public void writefile(string filename, KhachHang kh)
        {
            StreamWriter sw = new StreamWriter(filename, true);

            sw.WriteLine(kh.tostring());

            sw.Close();
        }
        public void ReadFile(string filename)
        {

            khachhang = new List<KhachHang>();
            StreamReader sr = new StreamReader(filename);
            String tmp;
            KhachHang kh;
            while (sr.EndOfStream == false)
            {
                tmp = sr.ReadLine().Trim();
                if (tmp == "") continue;
                kh = new KhachHang(tmp);
                khachhang.Add(kh);
            }
            sr.Close();
        }
        public void hienthi()
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            int i = 1;
            foreach(KhachHang kh in khachhang)
            {
                ReadFile("khachhang.txt");
                Console.ForegroundColor = ConsoleColor.White; 
                Console.WriteLine("{0,-3} {1,-16} {2,-12}  {3,-4}  {4,-5} {5,-20} {6,-11}","STT","tên khách hàng","cmt/căn cước","ns","gt","địa chỉ","sđt");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("{0,-3} {1,-16} {2,-12}  {3,-4}  {4,-5} {5,-20} {6,-11}", i, kh.Tenkh, kh.Cmt, kh.Namsinh, kh.Gioitinh, kh.Diachi, kh.Sodt);
                i = i + 1;
            }
        }
        public KhachHang timkiemtheocmt(string cmt)
        {


            foreach (KhachHang kh in khachhang)
            {
                if (kh.Cmt.Equals(cmt))
                    return kh;
            }
            return null;
        }
        public void them(KhachHang kh)
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            if (timkiemtheocmt(kh.Cmt) != null)
            {
                Console.WriteLine(" khách hàng đã tồn tại trong he thong");
                khachhang.Remove(kh);
            }
            else
            {
                khachhang.Add(kh);
                writefile("khachhang.txt", kh);
            }
        }
        public void Nhap()
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            int Tiep;
            KhachHang kh;
            string tt, t;
        tt:
            {
                kh = new KhachHang();
                kh.nhap();
                them(kh);
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("ban có muốn nhap them khong?");
            Console.Write("1:co/0:khong: ");
        t:
            Tiep = int.Parse(Console.ReadLine());
            if (Tiep == 1) goto tt;
            else if (Tiep != 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("lựa chọn không đúng, vui lòng chọn lại: ");
                goto t;
            }

        }
        public void UpdatKH()
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            string cmt;
            string tt;
        tt:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("nhập ma điện thoại ban muốn cập nhật:");
            cmt = Console.ReadLine();
            KhachHang kh = timkiemtheocmt(cmt);

            if (kh == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ma điện thoại ban vừa nhập không tồn tại,bấm phím bất kỳ để nhập lại:");
                Console.ReadKey();
                goto tt;
            }
            else
            {
                kh.update();
                WriteFile("khachhang.txt");
            }
        }
        public void xoakhachhang()
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("nhập so cmt/thẻ căn cước cua khách hàng muốn xoa:");
            string cmt = Console.ReadLine();
            int nl = 0;

            foreach (KhachHang kh in khachhang)
            {
                if (kh.Cmt.ToLower().Equals(cmt.ToLower()))
                {
                    nl = 1;
                    khachhang.Remove(kh);
                    WriteFile("khachhang.txt");
                    break;
                }
            }
            if (nl == 0)
            {
                Console.WriteLine("khách hàng có so cmt/thẻ căn cước vừa nhập không tồn tại hoac da bi xoa");
            }
        }
        public void timkiemcmt()
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("nhập so cmt/thẻ căn cước cua khách hàng can tim:");
            string cmt = Console.ReadLine();
            int f = 0;
            foreach (KhachHang kh in khachhang)
            {
                if (kh.Cmt.ToLower().Equals(cmt.ToLower()))
                {
                    f = 1;
                    kh.hien();
                }
            }
            if (f == 0)
                Console.WriteLine("không có điện thoại nao có ma {0}", cmt);
        }
        public void timkiemtheoten()
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("nhập tên khách hàng can tim:");
            string tenkh = Console.ReadLine();
            int f = 0;
            foreach (KhachHang kh in khachhang)
            {
                if (kh.Tenkh.ToLower().Trim().Equals(tenkh.ToLower().Trim()))
                {
                    f = 1;
                    kh.hien();
                }
            }
            if (f == 0)
                Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("không có khách hàng nao có ten {0}", tenkh);
        }
        public void timkiemdiachi()
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("nhập địa chỉ cua khách hàng can tim:");
            string dc = Console.ReadLine();
            int f = 0;
            foreach (KhachHang kh in khachhang)
            {
                if (kh.Diachi.ToLower().Equals(dc.ToLower()))
                {
                    f = 1;
                    kh.hien();
                }
            }
            if (f == 0)
                Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("không có khách hàng nao o {0}", dc);
        }
    }
    
}
