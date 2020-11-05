using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace QuanLyCuaHangDienThoaiTanCuong
{

    class HoaDonNhap
    {
        private string mahoadon;
        private DateTime ngaylap;
        // dtmua dtm = new dtmua();
        private string tdt;
        private int soluong;
        private double dongia;
        ///////QLDTM ql = new QLDTM();
        private int[] a;
        private double thanhtien;
        private string nguoilap;
        private string ngay, tien;
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

        public HoaDonNhap()
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
        public HoaDonNhap(HoaDonNhap hdb)
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
        public HoaDonNhap(string HoaDonNhap)
        {

            string[] tmp = HoaDonNhap.Split('|');
            this.mahoadon = tmp[0];
            ngaylap = DateTime.Parse(tmp[1]);    
            this.tdt = tmp[2];
            this.soluong = int.Parse(tmp[3]);
            this.dongia = double.Parse(tmp[4]);
            this.thanhtien = double.Parse(tmp[5]);
            //this.tien=tmp[8];
            this.nguoilap = tmp[6];

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
           
            ngaylap = DateTime.Now;
            ngay = ngaylap.ToString();
            dt1 = dt.TimKiemTen(tdt);


            do
            {
            tt:
                {
                    Console.Write("nhập tên điện thoại nhập:");
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

                //else dongia = dt1.Giaban;
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
                            Console.Write("nhập số lượng nhập:");
                            soluong = int.Parse(Console.ReadLine());
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("bạn vừa nhập giá trị không hợp lệ");
                        hl = false;
                    } while (hl == false) ;
                } while (soluong < 0);



            }
            do
            {
                Console.Write("nhap gia nhap:");
                dongia = double.Parse(Console.ReadLine());
            } while (dongia <= 0);

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
                Console.WriteLine("F3: cập nhật thông tin điện thoại nhập");
                Console.WriteLine("F4: cập nhật tên người lập hóa đơn");
                Console.WriteLine("F5: thoát");
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
                        ConsoleKeyInfo ktt;
                    ttt:
                        {
                            Console.WriteLine("F1:cập nhật tên điện thoại.");
                            Console.WriteLine("F2:cập nhật số lượng mua.");
                            Console.WriteLine("F2:cập nhật giá nhập.");
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
                                            Console.Write("nhập tên điện thoại nhâp;: ");
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

                                        else dt1.Giaban = dongia;
                                    } while (tdt == "");
                                    Console.WriteLine("thông tin đã được cập nhật"); break;
                                }
                            case ConsoleKey.F2:
                                {
                                    dt1.updateslhdn(soluong);
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
                                    dt1.updateslhdb(soluong);
                                    dt.WriteFile("dienthoai.txt");
                                    Console.WriteLine("thông tin đã được cập nhật"); break;
                                }
                                do
                                {
                                    Console.Write("nhap gia nhap:");
                                    dongia = double.Parse(Console.ReadLine());
                                } while (dongia <= 0);
                            case ConsoleKey.F4: break;
                            default:
                                Console.WriteLine("chức năng bạn chọn không hợp lệ, vui lòng chọn lại."); Console.ReadKey();
                                Console.Clear(); goto ttt;
                        }
                        break;
                    }
                case ConsoleKey.F4:
                    {
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("người lập hóa đơn:");
                            nguoilap = Console.ReadLine().Trim();
                        } while (nguoilap == "");
                        Console.WriteLine("thông tin đã được cập nhật"); break;
                    }
                case ConsoleKey.F5: break;
                default: Console.WriteLine("chức năng bạn chọn không hợp lệ, vui lòng chọn lại."); Console.ReadKey(); Console.Clear(); goto chon;
            }

        }
        public void cnsl()
        {
            dt1.updateslhdn(soluong);
            dt.additionalmethod();
            dt.writefile("dienthoai.txt",dt1);
            
            
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
            Console.WriteLine("           HÓA ĐƠN NHẬP HÀNG ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("mã hóa đơn: {0,5}\nngày lập:{1}", mahoadon, ngaylap);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("+thông tin mặt hàng:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("{0,-30} {1,8} {2,8} {3,8} ", "tên điện thoại", "số lượng", "đơn giá", "thành tiền");
            Console.ForegroundColor = ConsoleColor.Cyan;
            tinhtien();
            Console.Write("{0,-30} {1,8} {2,8} {3,8} ", tdt, soluong, dongia, soluong * dongia);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("người lập \n{0}", nguoilap);
        }
        public string tostring()
        {
            tinhtien();
            return (mahoadon + "|" + ngaylap + "|" + tdt + "|" + soluong + "|" + dongia + "|" + thanhtien + "|" + nguoilap);

        }

    }
    class QLHDN
    {
        private List<HoaDonNhap> HoaDonNhap;
        public QLHDN()
        {
            HoaDonNhap = new List<HoaDonNhap>();
        }
        public void WriteFile(string filename)
        {
            StreamWriter sw = new StreamWriter(filename);
            foreach (HoaDonNhap dt in HoaDonNhap)
            {
                sw.WriteLine(dt.tostring());
            }
            sw.Close();
        }
        public void writefile(string filename, HoaDonNhap dt)
        {
            StreamWriter sw = new StreamWriter(filename, true);

            sw.WriteLine(dt.tostring());

            sw.Close();
        }
        public void ReadFile(string filename)
        {

            HoaDonNhap = new List<HoaDonNhap>();
            StreamReader sr = new StreamReader(filename);
            String tmp;
            HoaDonNhap dt;
            while (sr.EndOfStream == false)
            {
                tmp = sr.ReadLine().Trim();
                if (tmp == "") continue;
                dt = new HoaDonNhap(tmp);
                HoaDonNhap.Add(dt);
            }
            sr.Close();
        }
        public HoaDonNhap timkiemhoadon(String mhd)
        {

            foreach (HoaDonNhap hdb in HoaDonNhap)
            {
                if (hdb.Mahoadon.Equals(mhd))
                    return hdb;

            }
            return null;
        }
        public void Them(HoaDonNhap hdb)
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
                HoaDonNhap.Add(hdb);
                writefile("HoaDonNhap.txt", hdb);
                hdb.cnsl();
                
            }
        }
        public void Nhap()
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            HoaDonNhap dt;
            dt = new HoaDonNhap();
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
            ReadFile("HoaDonNhap.txt");
            HoaDonNhap dt = timkiemhoadon(mhd);

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
                WriteFile("HoaDonNhap.txt");
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
            ReadFile("HoaDonNhap.txt");
            foreach (HoaDonNhap dt in HoaDonNhap)
            {

                if (dt.Tdt.ToLower().Trim().Equals(tendt.ToLower().Trim()))
                {
                    f = f + 1;
                    Console.WriteLine("kết quả thứ {0}:", f);
                    dt.hien();

                }
            }

            if (f == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("không có hóa đơn nhập điện thoại có tên {0}!", tendt);
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
            ReadFile("HoaDonNhap.txt");
            foreach (HoaDonNhap dt in HoaDonNhap)
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
                Console.WriteLine("không có hóa đơn nhập có mã {0}!", tendt);
            }
        }
        public void hien()
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            int i = 1;
            ReadFile("HoaDonNhap.txt");
            //ReadFile("dtmua.txt");
            foreach (HoaDonNhap hd in HoaDonNhap)
            {
                Console.WriteLine("hóa đơn thứ {0}", i);
                hd.hien();
                i++;
                Console.ReadKey();
            }
        }
        public void doanhthuthang(int thang, int nam)
        {
            double doanhthu = 0;
            ReadFile("HoaDonNhap.txt");
            foreach (HoaDonNhap hdn in HoaDonNhap)
            {
                if (hdn.Ngaylap.Year == nam && hdn.Ngaylap.Month == thang)
                {
                    doanhthu = doanhthu + hdn.Thanhtien;
                }

            }
            Console.WriteLine("tổng chi phí tháng {0} năm {1} là {2}đồng", thang, nam, doanhthu);
        }
        public void doanhthunam(int nam)
        {
            double doanhthu = 0;
            ReadFile("HoaDonNhap.txt");
            foreach (HoaDonNhap hdn in HoaDonNhap)
            {
                if (hdn.Ngaylap.Year == nam )
                {
                    doanhthu = doanhthu + hdn.Thanhtien;
                }

            }
            Console.WriteLine("tổng chi phí của năm {0} là {1}đồng", nam, doanhthu);
        }
    }
}
