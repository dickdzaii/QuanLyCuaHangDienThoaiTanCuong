using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace QuanLyCuaHangDienThoaiTanCuong
{
    
    class HoaDonBan
    {
        private string mahoadon;
        private DateTime ngaylap;
       // dtmua dtm = new dtmua();
        private string tdt;
        private int soluong;
        private double dongia;
        ///////QLDTM ql = new QLDTM();
        private int[] a;
        KhachHang kh = new KhachHang();
        private double thanhtien;
        private string nguoilap;
        private string ngay,tien;
        DT dt = new DT();
        DienThoai dt1 = new DienThoai();


        public string Mahoadon
        {
            get
            {
                return mahoadon;
            }

            set
            {
                mahoadon = value;
            }
        }

        public DateTime Ngaylap
        {
            get
            {
                return ngaylap;
            }

            set
            {
                ngaylap = value;
            }
        }

       
        internal KhachHang Kh
        {
            get
            {
                return kh;
            }

            set
            {
                kh = value;
            }
        }

        public double Thanhtien
        {
            get
            {
                return thanhtien;
            }

            set
            {
                thanhtien = value;
            }
        }

        public string Nguoilap
        {
            get
            {
                return nguoilap;
            }

            set
            {
                nguoilap = value;
            }
        }

        public string Ngay
        {
            get
            {
                return ngay;
            }

            set
            {
                ngay = value;
            }
        }

        public string Tien
        {
            get
            {
                return tien;
            }

            set
            {
                tien = value;
            }
        }

        public int[] A
        {
            get
            {
                return a;
            }

            set
            {
                a = value;
            }
        }

        public string Tdt
        {
            get
            {
                return tdt;
            }

            set
            {
                tdt = value;
            }
        }

        public int Soluong
        {
            get
            {
                return soluong;
            }

            set
            {
                soluong = value;
            }
        }

        public double Dongia
        {
            get
            {
                return dongia;
            }

            set
            {
                dongia = value;
            }
        }

        public HoaDonBan()
        {
            mahoadon = "";
            a = new int[3];
            ngaylap = new DateTime();
            ngay = "";
            tdt = "";
            soluong = 0;
            dongia = 0;
            thanhtien = 0;
            nguoilap = "";
            tien = "";
         
            
            
        }
        public HoaDonBan(HoaDonBan hdb)
        {
            a = new int[3];
            this.mahoadon = hdb.mahoadon;
            this.ngaylap = hdb.ngaylap;
            this.ngay = hdb.ngay;
            this.ngay = this.ngaylap.ToString("yyyyMMdd-HHMMss");
            this.thanhtien = hdb.thanhtien;
            this.nguoilap = hdb.nguoilap;
            this.tdt = hdb.tdt;
            this.soluong = hdb.soluong;
            this.tien = hdb.tien;
            this.tien = this.thanhtien.ToString();
           
        }
        public HoaDonBan(string hoadonban)
        {
            
            string[] tmp = hoadonban.Split('|');
            this.mahoadon = tmp[0];
            ngaylap = DateTime.Parse(tmp[1]);
            kh.Tenkh = tmp[2];
            kh.Cmt = tmp[3];
            Kh.Ns = int.Parse(tmp[4]);
            kh.Gioitinh = tmp[5];
            kh.Diachi = tmp[6];
            kh.Sodt = tmp[7];
            this.tdt = tmp[8];
           this.soluong = int.Parse(tmp[9]);
            this.dongia = double.Parse(tmp[10]);
            this.thanhtien = double.Parse(tmp[11]);
            //this.tien=tmp[8];
            this.nguoilap = tmp[12];
            
        }
       
            public void nhap()
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("nhập mã hóa đơn: ");
                mahoadon = Console.ReadLine().Trim();
            } while (mahoadon == "");
            kh.nhap();
            ngaylap = DateTime.Now;
            ngay = ngaylap.ToString();
            dt1 = dt.TimKiemTen(tdt);


            do
            {
            tt:
                {
                    Console.Write("nhập tên điện thoại khách đặt:");
                    tdt = Console.ReadLine().Trim();
                }
                dt.ReadFile("dienthoai.txt");
                dt1 = dt.TimKiemTen(tdt);
                if (dt1 == null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("điện thoại vừa nhập không tồn tại trong kho.");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("nhấn phím bất kỳ để nhập lại");
                    Console.ReadKey();
                    Console.WriteLine();
                    goto tt;
                }

                
            } while (tdt == "");
            {
                bool hl = true;
                do
                {
                    try
                    {
                    dia:
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("nhập số lượng mua:");
                            soluong = int.Parse(Console.ReadLine());
                        }
                        if (soluong > dt1.Soluong)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("số lượng trong kho không đủ,bấm phím bất kỳ để nhập lại");
                            Console.ReadKey();
                            goto dia;
                        }
                       
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("bạn vừa nhập giá trị không hợp lệ");
                        hl = false;
                    } while (hl == false) ;
                } while (soluong <= 0);



            }
            bool hl2=true;
            try
            {
                do
                {
                    Console.WriteLine("nhap gia ban:");
                    dongia = double.Parse(Console.ReadLine());
                } while (dongia <= 0);
            }catch(Exception)
            {
                hl2 = false;
                Console.WriteLine("gia tri khong hop le");
            }while (hl2 == false) ;

            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("người lập hóa đơn:");
                nguoilap = Console.ReadLine().Trim();
            } while (nguoilap == "");
        }
        public void update()
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            ConsoleKeyInfo kt;
        chon:
            {
                Console.WriteLine("F1: cập nhật mã hóa đơn");
                Console.WriteLine("F2: cập nhật ngày lập");
                Console.WriteLine("F3: cập nhật thông tin khách hàng");
                Console.WriteLine("F4: cập nhật thông tin điện thoại khách hàng mua");
                Console.WriteLine("F5: cập nhật tên người lập hóa đơn");
                Console.WriteLine("F6: thoát");
                Console.Write("Mời bạn chọn chức năng");
                kt = Console.ReadKey();
                Console.WriteLine();
            }
            switch (kt.Key)
            {
                case ConsoleKey.F1:
                    {
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("nhập mã hóa đơn: ");
                            mahoadon = Console.ReadLine().Trim();
                        } while (mahoadon == "");
                        Console.WriteLine("thông tin đã được cập nhật"); break;
                    }
                case ConsoleKey.F2:
                    {
                        do
                        {
                            Console.Write("nhập ngày lập:");
                            a[0] = int.Parse(Console.ReadLine());
                        } while (a[0] < 0 && a[0] > 31);
                        do
                        {
                            Console.Write("nhập tháng lập:");
                            a[1] = int.Parse(Console.ReadLine());
                        } while (a[0] < 0 && a[0] > 12);
                        do
                        {
                            Console.Write("nhập năm lập:");
                            a[2] = int.Parse(Console.ReadLine());
                        } while (a[0] < 0 && a[0] > 2018);
                        ngaylap = new DateTime(a[2], a[1], a[0]);
                        Console.WriteLine("thông tin đã được cập nhật"); break;
                    }
                case ConsoleKey.F3:
                    {
                        kh.update();
                        break;
                    }
                case ConsoleKey.F4:
                    {
                        ConsoleKeyInfo ktt;
                    ttt:
                        {
                            Console.WriteLine("F1:cập nhật tên điện thoại.");
                            Console.WriteLine("F2:cập nhật số lượng mua.");
                            Console.WriteLine("F3:cập nhật giá bán.");
                            Console.WriteLine("F4:thoát.");
                            Console.Write("Mời bạn chọn chức năng");
                            ktt = Console.ReadKey();
                        }
                        switch (ktt.Key)
                        {

                            case ConsoleKey.F1:
                                {
                                    dt1 = dt.TimKiemTen(tdt);


                                    do
                                    {
                                    tt:
                                        {
                                            Console.Write("nhập tên điện thoại khách hàng đặt: ");
                                            tdt = Console.ReadLine().Trim();
                                        }
                                        dt.ReadFile("dienthoai.txt");
                                        dt1 = dt.TimKiemTen(tdt);

                                        if (dt1 == null)
                                        {
                                            Console.WriteLine("điện thoại vừa nhập không tồn tại trong kho.");
                                            Console.Write("nhấn phím bất kỳ để nhập lại");
                                            Console.ReadKey();
                                            Console.WriteLine();
                                            goto tt;
                                        }

                                     
                                    } while (tdt == "");
                                    Console.WriteLine("thông tin đã được cập nhật"); break;
                                }
                            case ConsoleKey.F2:
                                {
                                    
                                    dt.WriteFile("dienthoai.txt");
                                    bool hl = true;
                                    do
                                    {
                                        try
                                        {
                                            Console.Write("nhập số lượng mua:");
                                            soluong = int.Parse(Console.ReadLine());
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("bạn vừa nhập giá trị không hợp lệ");
                                            hl = false;
                                        } while (hl == false) ;
                                    } while (soluong < 0);
                                   
                                    dt.WriteFile("dienthoai.txt");
                                    Console.WriteLine("thông tin đã được cập nhật"); break;
                                }
                            case ConsoleKey.F3:
                                {
                                    do
                                    {
                                        Console.WriteLine("nhập giá bán:");
                                        dongia = double.Parse(Console.ReadLine());
                                    } while (dongia <= 0);
                                    break;
                                }
                            case ConsoleKey.F4: break;
                            default:
                                Console.WriteLine("chức năng bạn chọn không hợp lệ, vui lòng chọn lại."); Console.ReadKey();
                                Console.Clear(); goto ttt;
                        }
                        break;
                    }
                case ConsoleKey.F5:
                    {
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("người lập hóa đơn:");
                            nguoilap = Console.ReadLine().Trim();
                        } while (nguoilap == "");
                        Console.WriteLine("thông tin đã được cập nhật"); break;
                    }
                case ConsoleKey.F6: break;
                default: Console.WriteLine("chức năng bạn chọn không hợp lệ, vui lòng chọn lại."); Console.ReadKey(); Console.Clear(); goto chon;
            }

        }
       public void cnsl()
        {
            dt1.updateslhdb(soluong);
            
            dt.additionalmethod();
            dt.writefile("dienthoai.txt", dt1);

        }
        public double tinhtien()
        {
            thanhtien = soluong * dongia;
            return thanhtien;
        }
        public void hien()
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            //int i = 1;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("           CỬA HÀNG ĐIỆN THOẠI TÂN CƯỜNG");
            Console.WriteLine("           HÓA ĐƠN XUẤT HÀNG ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("mã hóa đơn: {0,5}\nngày lập:{1}", mahoadon, ngaylap);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("+thông tin khách hàng:");
            Console.ForegroundColor = ConsoleColor.White;

            kh.hien();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("+thông tin mặt hàng:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("{0,-30} {1,8} {2,8} {3,8} ", "ten dien thoai", "so luong", "don gia", "thanh tien");
            Console.ForegroundColor = ConsoleColor.Cyan;
            tinhtien();
            Console.Write("{0,-30} {1,8} {2,8} {3,8} ", tdt, soluong, dongia, soluong*dongia);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("người lập \n{0}",nguoilap);
        }
        public string tostring()
        {
            tinhtien();
            return (mahoadon + "|" + ngaylap + "|" + kh.Tenkh.Trim() + "|" + kh.Cmt.Trim() + "|" + Kh.Ns + "|" + Kh.Gioitinh.Trim() + "|" + kh.Diachi.Trim() + "|" + kh.Sodt.Trim() + "|"+tdt +"|"+soluong +"|"+dongia +"|"+thanhtien +"|"+ nguoilap);
            
        }
        
    }
    class QLHDB
    {
        private List<HoaDonBan> hoadonban;
        public QLHDB()
        {
            hoadonban = new List<HoaDonBan>();
        }
        public void WriteFile(string filename)
        {
            StreamWriter sw = new StreamWriter(filename);
            foreach (HoaDonBan dt in hoadonban)
            {
                sw.WriteLine(dt.tostring());
            }
            sw.Close();
        }
        public void writefile(string filename, HoaDonBan dt)
        {
            StreamWriter sw = new StreamWriter(filename, true);

            sw.WriteLine(dt.tostring());

            sw.Close();
        }
        public void ReadFile(string filename)
        {

            hoadonban = new List<HoaDonBan>();
            StreamReader sr = new StreamReader(filename);
            String tmp;
            HoaDonBan dt;
            while (sr.EndOfStream == false)
            {
                tmp = sr.ReadLine().Trim();
                if (tmp == "") continue;
                dt = new HoaDonBan(tmp);
                hoadonban.Add(dt);
            }
            sr.Close();
        }
        public HoaDonBan timkiemhoadon(String mhd)
        {

            foreach (HoaDonBan hdb in hoadonban)
            {
                if (hdb.Mahoadon.Equals(mhd))
                    return hdb;

            }
            return null;
        }
        public void Them(HoaDonBan hdb)
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            if (timkiemhoadon(hdb.Mahoadon) != null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("mã hóa đơn đã bị trùng,không thể thêm");
            }
            else
            {
                hoadonban.Add(hdb);
                writefile("hoadonban.txt", hdb);
                hdb.cnsl();
               
            }
        }
        public void Nhap()
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            HoaDonBan dt;
                dt = new HoaDonBan();
                dt.nhap();
                Them(dt);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("bấm Enter để hoàn tất");
            Console.Read();
        
        }
        public void update()
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            string mhd;
            string tt;
        tt:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("nhập mã hoá đơn bạn muốn cập nhật:");
            mhd = Console.ReadLine();
            ReadFile("hoadonban.txt");
            HoaDonBan dt = timkiemhoadon(mhd);

            if (dt == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("mã hóa đơn bạn vừa nhập không tồn tại,bấm phím bất kỳ để nhập lại:");
                Console.ReadKey();
                goto tt;
            }
            else
            {
                dt.update();
                WriteFile("hoadonban.txt");
            }
        }
        public void TimKiemTheoma()
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("nhập mã hóa đơn muốn tìm: ");
            string tendt = Console.ReadLine().Trim();
            int f = 0;
            ReadFile("hoadonban.txt");
            foreach (HoaDonBan dt in hoadonban)
            {

                if (dt.Mahoadon.ToLower().Trim().Equals(tendt.ToLower().Trim()))
                {
                    f = f + 1;
                    Console.WriteLine("kết quả thứ {0}:", f);
                    dt.hien();

                }
            }

            if (f == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("không có hóa đơn bán có mã {0}!", tendt);
            }
        }
        public void TimKiemTheotdt()
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("nhập tên điện thoại muốn tìm: ");
            string tendt = Console.ReadLine().Trim();
            int f = 0;
            ReadFile("hoadonban.txt");
            foreach (HoaDonBan dt in hoadonban)
            {

                if (dt.Mahoadon.ToLower().Trim().Equals(tendt.ToLower().Trim()))
                {
                    f = f + 1;
                    Console.WriteLine("kết quả thứ {0}:", f);
                    dt.hien();

                }
            }

            if (f == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("không có hóa đơn bán loại điện thoại {0}!", tendt);
            }
        }
        public void hien()
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            int i=1;
           ReadFile("hoadonban.txt");
            //ReadFile("dtmua.txt");
            foreach(HoaDonBan hd in hoadonban)
            {
                Console.WriteLine("hóa đơn thứ {0}",i);
                hd.hien();
                i++;
                Console.ReadKey();
            }
        }
        public void thkedt()
        {
            int thang,nam;
            int f = 0;
            do {
                Console.Write("nhập tháng:");
                thang = int.Parse(Console.ReadLine()); } while (thang < 1 || thang > 12);
           
            do
            {
                Console.Write("nhập năm:");
                nam = int.Parse(Console.ReadLine());
            } while (nam < 2015 );
            ReadFile("hoadonban.txt");
            Console.WriteLine("{0,3} {1,-25} {2,10} {3,10}", "STT", "tên điện thoại", "số lượng", "thành tiền");
            foreach (HoaDonBan hdb in hoadonban)
            {
                if (hdb.Ngaylap.Month == thang && hdb.Ngaylap.Year == nam)
                {
                    f = f + 1;
                    Console.Clear();
                    Console.WriteLine("{0,3} {1,-25} {2,10} {3,10}",f,hdb.Tdt,hdb.Soluong,hdb.Soluong*hdb.Dongia);
                }
            }
            if (f == 0) {
                Console.Clear();
                Console.Write("có {0} loại điện thoại được bán trong tháng {1} năm {2}", f, thang, nam);
            }
        }
        public void doanhthuthang(int thang, int nam)
        {
            double doanhthu = 0;
            ReadFile("hoadonban.txt");
            foreach (HoaDonBan hdn in hoadonban)
            {
                if (hdn.Ngaylap.Year == nam && hdn.Ngaylap.Month == thang)
                {
                    doanhthu = doanhthu + hdn.Thanhtien;
                }

            }
            Console.WriteLine("tổng doanh thu của tháng {0} năm {1} là {2}đồng", thang, nam, doanhthu);
        }
        public void doanhthunam(int nam)
        {
            double doanhthu = 0;
            ReadFile("hoadonban.txt");
            foreach (HoaDonBan hdn in hoadonban)
            {
                if (hdn.Ngaylap.Year == nam)
                {
                    doanhthu = doanhthu + hdn.Thanhtien;
                }

            }
            Console.WriteLine("tổng doanh thu của năm {0} là {1}đồng", nam, doanhthu);
        }
    }

}
