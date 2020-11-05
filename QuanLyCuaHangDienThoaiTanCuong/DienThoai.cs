using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangDienThoaiTanCuong
{
    class DienThoai
    {
        private string madt;
        private string tendt;
        private string manhinh;
        private string hedieuhanh;
        private string RAM;
        private string bonho;
        private string pin;
        private string camera;
        private int soluong;
        private double gianhap;
        private double giaban;
        //biến dùng để chuyển các dữ liệu kiểu số sang xâu
        private string sl, gn, gb;
        public DienThoai()
        {
            madt = "";
            tendt = "";
            manhinh = "";
            hedieuhanh = "";
            RAM = "";
            bonho = "";
            pin = "";
            camera = "";
            soluong = 0;
            gianhap = 0;
            giaban = 0;
            sl = soluong.ToString();
            gn = gianhap.ToString();;
            gb = giaban.ToString();
        }
        public DienThoai(DienThoai dt)
        {
            this.madt = dt.madt;
            this.tendt = dt.tendt;
            this.manhinh = dt.manhinh;
            this.hedieuhanh = dt.hedieuhanh;
            this.RAM = dt.RAM;
            this.bonho = dt.bonho;
            this.pin = dt.pin;
            this.camera = dt.camera;
            this.soluong = dt.soluong;
            this.gianhap = dt.gianhap;
            this.giaban = dt.giaban;
            this.sl = dt.sl;
            this.gn = dt.gn;
            this.gb = dt.gb;
            this.sl = this.soluong.ToString();
            this.gn = this.gianhap.ToString();
            this.gb = this.giaban.ToString();
        }
        public string Madt 
        {
            get
            {
                return madt;
            }

            set
            {
                if (value != "")
                    madt = value;
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
                if (value != "")
                    tendt = value;
            }
        }

        public string Manhinh
        {
            get
            {
                return manhinh;
            }

            set
            {
                if (value != "")
                    manhinh = value;
            }
        }

        public string Hedieuhanh
        {
            get
            {
                return hedieuhanh;
            }

            set
            {
                if (value != "")
                    hedieuhanh = value;
            }
        }
        public string Ram
        {
            get
            {
                return RAM;
            }
            set
            {
                if (value != "")
                    RAM = value;
            }
        }
        public string Bonho
        {
            get
            {
                return bonho;
            }

            set
            {
                if (value != "")
                    bonho = value;
            }
        }

        public string Pin
        {
            get
            {
                return pin;
            }

            set
            {
                if (value != "")
                    pin = value;
            }
        }

        public string Camera
        {
            get
            {

                return camera;
            }

            set
            {
                if (value != "")
                    camera = value;
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
                if (value > 0)
                    soluong = value;
            }
        }
        public double Gianhap
        {
            get
            {
                return gianhap;
            }

            set
            {
                if (value > 0)
                    gianhap = value;
            }
        }

        public double Giaban
        {
            get
            {
                return giaban;
            }

            set
            {
                if (value > 0)
                    giaban = value;
            }
        }

        
        public DienThoai (string dienthoai)
        {
            string[] tmp = dienthoai.Split('|');
            this.madt = tmp[0];
            this.tendt = tmp[1];
            this.manhinh = tmp[2];
            this.hedieuhanh = tmp[3];
            this.RAM = tmp[4];
            this.bonho = tmp[5];
            this.pin = tmp[6];
            this.camera = tmp[7];
            this.soluong = int.Parse(tmp[8]);
        }
        public void nhap()
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("nhập thông tin cho điện thoại:");
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("nhập mã điện thoại: ");
                madt = Console.ReadLine().Trim();
            } while (madt == "");
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("nhập tên điện thoại: ");
                tendt = Console.ReadLine().Trim();
            } while (tendt == "");
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("nhập màn hinh: ");
                manhinh = Console.ReadLine().Trim();
            } while (manhinh == "");
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("nhập hệ điều hành: ");
                hedieuhanh = Console.ReadLine().Trim();
            } while (hedieuhanh == "");
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("nhập RAM: ");
                RAM = Console.ReadLine().Trim();
            } while (RAM == "");
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("nhập bộ nhớ trong: ");
                bonho = Console.ReadLine().Trim();
            } while (bonho == "");
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("nhập độ phân giải camera: ");
                camera = Console.ReadLine().Trim();
            } while (camera == "");
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("nhập dung lượng pin: ");
                pin = Console.ReadLine().Trim();
            } while (pin == "");
           
            /*try
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("nhập số lượng: ");
                    soluong = int.Parse(Console.ReadLine());
                    hl = true;
                } while (soluong < 0);
            }
            catch (Exception)
            {
                Console.WriteLine("gia tri khong hop le");
                hl = false;

            }while (hl == false);
            */
            soluong = 0;
           
        }    
        public void hienthi()
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0,3}  {2,-25} {3,9} {4,8} {5,8}", "*", madt, tendt,soluong,gianhap,giaban);
            Console.ForegroundColor = ConsoleColor.Green;
            
        }
       public void hienthithongso()
        {
           // Console.WriteLine("bấm Enter để hiển thị thông số");
            //Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{1,-8} {0,-20} {1,-7} {2,-14} {3,5} {4,6} {5,7} {6,6}", tendt, manhinh, hedieuhanh, RAM, bonho, pin, camera);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("bấm phím bất kỳ để tiếp tục");
            Console.ReadKey();
        }
        public void update()
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            ConsoleKeyInfo ki;
            Console.ForegroundColor = ConsoleColor.Cyan;
                              Console.WriteLine("           CHƯƠNG TRÌNH QUẢN LÝ CỬA HÀNG ĐIỆN THOẠI TÂN CƯỜNG");
                              Console.WriteLine("     ******************************************************************");
                                            Console.WriteLine("     *                                 MENU                           *");
                                            Console.WriteLine("     *                 F1:cập nhật tên                                *");
                                            Console.WriteLine("     *                                                                *");
                                            Console.WriteLine("     *                 F2:cập nhật màn hình                           *");
                                            Console.WriteLine("     *                                                                *");
                                            Console.WriteLine("     *                 F3:cập nhật hệ điều hành                       *");
                                            Console.WriteLine("     *                                                                *");
                                            Console.WriteLine("     *                 F4:cập nhật RAM                                *");
                                            Console.WriteLine("     *                                                                *");
                                            Console.WriteLine("     *                 F5:cập nhật bộ nhớ                             *");
                                            Console.WriteLine("     *                                                                *");
                                            Console.WriteLine("     *                 F6:cập nhật camera                             *");
            Console.WriteLine("     *                                                                *");
            Console.WriteLine("     *                 F6:cập nhật pin                                *");
                                            Console.WriteLine("     *                                                                *");
                                            Console.WriteLine("     *                 F8:cập nhật số lượng                           *");
                                            Console.WriteLine("     *                                                                *");
                                            Console.WriteLine("     *                 Backspace:quay lại                             *");
                                            Console.WriteLine("     *                                                                *");
                                            Console.WriteLine("     *                 Mời bạn chọn chức năng                         *");
                                            Console.WriteLine("     *                                                                *");
                                            Console.WriteLine("     ******************************************************************");
        tt:
            {
                ki = Console.ReadKey();
            }
            Console.Clear();
         

            switch (ki.Key)
            {
                case ConsoleKey.F1:
                    {
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("nhập tên điện thoại: ");
                            tendt = Console.ReadLine().Trim();
                        } while (tendt == "");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("thông tin đã được cập nhật"); break;
                    }
                case ConsoleKey.F2:
                    {
                        do

                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("nhập màn hình: ");
                            manhinh = Console.ReadLine().Trim();
                        } while (manhinh == "");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("thông tin đã được cập nhật"); break;
                    }
                case ConsoleKey.F3:
                    {
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("nhập hệ điều hành: ");
                            hedieuhanh = Console.ReadLine().Trim();
                        } while (hedieuhanh == "");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("thông tin đã được cập nhật"); break;
                    }
                case ConsoleKey.F4:
                    {
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("nhập RAM: ");
                            RAM = Console.ReadLine().Trim();
                        } while (RAM == "");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("thông tin đã được cập nhật"); break;
                    }
                case ConsoleKey.F5:
                    {
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("nhập bộ nhớ trong: ");
                            bonho = Console.ReadLine().Trim();
                        } while (bonho == "");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("thông tin đã được cập nhật"); break;
                    }
                case ConsoleKey.F6:
                    {
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("nhập độ phân giải camera: ");
                            camera = Console.ReadLine().Trim();
                        } while (camera == "");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("thông tin đã được cập nhật"); break;
                    }
                case ConsoleKey.F7:
                    {
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("nhập dung lượng pin: ");
                            pin = Console.ReadLine().Trim();
                        } while (pin == "");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("thông tin đã được cập nhật"); break;
                    }
                case ConsoleKey.F8:
                    {
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("nhập số lượng: ");
                            soluong = int.Parse(Console.ReadLine());
                        } while (soluong < 0);
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("thông tin đã được cập nhật"); break;
                    }
               
                case ConsoleKey.Backspace: break;
                default: Console.WriteLine("chức năng bạn chọn không hợp lệ, vui lòng chọn lại"); goto tt;
            }
        }
        public int updateslhdb(int sol)
        {
            soluong =soluong - sol;
            return soluong;
        }
        public int updateslhdn(int sol)
        {
            soluong = soluong + sol;
            return soluong;
        }
        public String tostring()
        {
            return madt.Trim() + "|" + tendt.Trim() + "|" + manhinh.Trim() + "|" + hedieuhanh.Trim() + "|" + RAM.Trim() + "|" + bonho.Trim() + "|" + pin.Trim() + "|" + camera.Trim() + "|"+soluong;
        }
    }
    class DT
    {
        //tạo danh sách điện thoại dienthoai
        private List<DienThoai> dienthoai;
        public DT()
        {
            dienthoai = new List<DienThoai>();
        }
        public void WriteFile(string filename)
        {
            StreamWriter sw = new StreamWriter(filename);
            foreach (DienThoai dt in dienthoai)
            {
                sw.WriteLine(dt.tostring());
            }
            sw.Close();
        }
        public void writefile(string filename, DienThoai dt)
        {
            StreamWriter sw = new StreamWriter(filename, true);

            sw.WriteLine(dt.tostring());
          
            sw.Close();
        }
        public void ReadFile(string filename)
        {

            dienthoai = new List<DienThoai>();
            StreamReader sr = new StreamReader(filename);
            String tmp;
            DienThoai dt;
            while (sr.EndOfStream == false)
            {
                tmp = sr.ReadLine().Trim();
                if (tmp == "") continue;
                dt = new DienThoai(tmp);
                dienthoai.Add(dt);
            }
            sr.Close();
        }
        public void timkiemma()
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("nhập ma điện thoại can tim:");
            string madt = Console.ReadLine();
            int f = 0;
            foreach (DienThoai dt in dienthoai)
            {
                ReadFile("dienthoai.txt");
                if (dt.Madt.ToLower().Equals(madt.ToLower()))
                {
                    f = f + 1;
                    Console.WriteLine("kết quả thứ {0}:", f);
                    dt.hienthi();
                    dt.hienthithongso();
                }
            }
            if (f == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("không có điện thoại nao có ma {0}", madt);
            }
        }
        public void additionalmethod()
        {
            dienthoai.RemoveAt(dienthoai.ToArray().Length-1);
            WriteFile("dienthoai.txt");
        }
        public void TimKiemTheoTen()
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("nhập tên điện thoại muốn tìm: ");
            string tendt = Console.ReadLine().Trim();
            int f = 0;
            ReadFile("dienthoai.txt");
            foreach (DienThoai dt in dienthoai)
            {
                
                if (dt.Tendt.ToLower().Trim().Equals(tendt.ToLower().Trim()))
                {
                    f = f + 1;
                    Console.WriteLine("kết quả thứ {0}:", f);
                    dt.hienthi();
                    dt.hienthithongso();
                }  
            }

            if (f == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("không có điện thoại có ten {0}!", tendt);
            }

        }
        public DienThoai TimKiemTen(String tendt)
        {

            foreach (DienThoai dt in dienthoai)
            {
                ReadFile("dienthoai.txt");
                if (dt.Tendt.ToLower().Trim().Equals(tendt.ToLower().Trim()))
                    return dt;

            }
            return null;
        }
        public DienThoai TimKiemTheoMa(String madt)
        {
            
            foreach (DienThoai dt in dienthoai)
            {
                ReadFile("dienthoai.txt");
                if (dt.Madt.Trim().Equals(madt.Trim()))
                    return dt;
                
            }
            return null;
        }
        public void TimKiemtheoRAM()
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("nhập RAM yêu cầu: ");
            string RAM = Console.ReadLine();
            int f = 0;
            ReadFile("dienthoai.txt");
            foreach (DienThoai dt in dienthoai)
            {
                
                if (dt.Ram.ToLower().Equals(RAM.ToLower()))
                {
                    f=f+1;
                    Console.WriteLine("kết quả thứ {0}:", f);
                    dt.hienthi();
                    dt.hienthithongso();
                }
                
            }
            if (f ==0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("không có điện thoại có RAM {0}", RAM);
            }
        }
        public void TimKiemgiaban()
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("nhập giá bán yêu cầu: ");
            double giaban = double.Parse(Console.ReadLine());
            int f = 0;
            ReadFile("dienthoai.txt");
            foreach (DienThoai dt in dienthoai)
            {
                
                if (dt.Giaban <= giaban)
                {
                    f=f+1;
                    Console.WriteLine("kết quả thứ {0}:", f);
                    dt.hienthi();
                    dt.hienthithongso();
                }
                
            }
            if (f == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("không có điện thoại có giá nhỏ hơn {0}!", giaban);
            }

        }
        public void TimKiemmanhinh()
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("nhập màn hinh yêu cầu: ");
            string manhinh = Console.ReadLine();
            int f = 0;
            ReadFile("dienthoai.txt");
            foreach (DienThoai dt in dienthoai)
            {
                
                if (dt.Manhinh.ToLower().Equals(manhinh.ToLower()))
                {
                    f=f+1;
                    Console.WriteLine("kết quả thứ {0}:", f);
                    dt.hienthi();
                    dt.hienthithongso();
                }
                
            }
            if (f == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("không có điện thoại có màn hinh yêu cầu!");
            }

        }
        public void TimKiempin()
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("nhập dung lượng pin yêu cầu: ");
            string pin = Console.ReadLine();
            int f = 0;
            ReadFile("dienthoai.txt");
            foreach (DienThoai dt in dienthoai)
            {
                
                if (dt.Pin.ToLower().Equals(pin.ToLower()))
                {
                    f=f+1;
                    Console.WriteLine("kết quả thứ {0}:", f);
                    dt.hienthi();
                    dt.hienthithongso();
                }
                
            }
            if (f == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("không có điện thoại có dung lượng pin yêu cầu!");
            }

        }
        public void timkiembonho()
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("nhập độ lớn bộ nhớ trong yêu cầu: ");
            string bonho = Console.ReadLine().Trim();
            int f = 0;
            ReadFile("dienthoai.txt");
            foreach (DienThoai dt in dienthoai)
            {
                
                if (dt.Bonho.ToLower().Equals(bonho.ToLower()))
                {
                    f=f+1;
                    Console.WriteLine("kết quả thứ {0}:", f);
                    dt.hienthi();
                    dt.hienthithongso();
                }

            }
            if (f == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("không có điện thoại có bộ nhớ yêu cầu!");
            }

        }


        public void timkiemhedieuhanh()
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("nhập hệ điều hành yêu cầu: ");
            string hdt = Console.ReadLine().Trim();
            int f = 0;
            ReadFile("dienthoai.txt");
            foreach (DienThoai dt in dienthoai)
            {
                
                if (dt.Hedieuhanh.ToLower().Trim().Equals(hdt.ToLower().Trim()))
                {
                    f = f + 1;
                    Console.WriteLine("kết quả thứ {0}:", f);
                    dt.hienthi();
                    dt.hienthithongso();
                }

            }
            if (f == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("không có điện thoại có hệ điều hành yêu cầu!");
            }
        }
        public void TimKiemtheocamera()
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("nhập camera yêu cầu: ");
            string camera  = Console.ReadLine();
            int f = 0;
             ReadFile("dienthoai.txt");
            foreach (DienThoai dt in dienthoai)
            {
               
                if (dt.Camera.ToLower().Equals(camera.ToLower()))
                {
                    f=f+1;
                    Console.WriteLine("kết quả thứ {0}:", f);
                    dt.hienthi();
                    dt.hienthithongso();
                }
                
            }
            if (f == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("không có điện thoại có camera yêu cầu!");
            }
           


        }
        public void Them(DienThoai dt)
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            ReadFile("dienthoai.txt");
            if (TimKiemTheoMa(dt.Madt.Trim()) != null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("thêm thất bại, loại điện thoại cần thêm đã tồn tại trong hệ thống");
            }
            else
            {
                dienthoai.Add(dt);
                writefile("dienthoai.txt", dt);
            }
        }

        public void Nhap()
        {
            
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            
            int Tiep;
            DienThoai dt;
            string tt,t;
       tt:
            {
                Console.Clear();
                dt = new DienThoai();
                dt.nhap();
                Them(dt); }
            
                Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("thêm điện thoại thành công");
                Console.WriteLine("ban có muốn nhập thêm không?");
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
        public void UpdateDienThoai()
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            string madt;
            string tt;
            Console.Clear();
        tt:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("nhập tên điện thoại bạn muốn cập nhật:");
            madt = Console.ReadLine().Trim();
            ReadFile("dienthoai.txt");
            DienThoai dt = TimKiemTen(madt);
            
            if (dt == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("tên điện thoại ban vừa nhập không tồn tại,bấm phím bất kỳ để nhập lại:");
                Console.ReadKey();
                goto tt;
            }
            else
            {
                dt.update();
                WriteFile("dienthoai.txt");
            }
        }
        public void xoadienthoai()
        {
            ReadFile("dienthoai.txt");
            Hienthi();

            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            //Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("nhập tên điện thoại muốn xóa:");
            string tendienthoai = Console.ReadLine().Trim();
            int nl = 0;
            ReadFile("dienthoai.txt");
            foreach (DienThoai dt in dienthoai)
            {
                if (dt.Tendt.Trim().ToLower().Equals(tendienthoai.Trim().ToLower()))
                {
                    nl = nl+1;
                    dienthoai.Remove(dt);
                    WriteFile("dienthoai.txt");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("đã xóa điện thoại");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("nhấn phím bất kỳ để quay lại ");
                    Console.ReadKey();
                    break;


                }
                
                
            }
            if (nl == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ten điện thoại vừa nhập không tồn tại hoặc đã bị xóa");
            }

        }
        public void demkho()
        {
            Console.Clear();
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            ReadFile("dienthoai.txt");
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("có tất cả {0} loại điện thoại trong kho", dienthoai.Count);
           
           
        }

        public  void Hienthi()
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            ReadFile("dienthoai.txt");
            //Console.ForegroundColor = ConsoleColor.Magenta;
            demkho();
            int j = 1;
            //Console.WriteLine("bấm phím bất kỳ để hiển thị thông số");
            //Console.ReadKey();
           // Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("{0,3} {1,14} {2,-20} {3,-8} {4,-14} {5,5} {6,6} {7,7} {8,6} {9,10}", "STT","mã điện thoại","tên điện thoại","màn hình","hệ điều hành","RAM","bộ nhớ","pin","camera","so luong");                
            foreach (DienThoai dt in dienthoai)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("{0,3} {1,14} {2,-20} {3,-8} {4,-14} {5,5} {6,6} {7,7} {8,6} {9,10}", j,dt.Madt, dt.Tendt, dt.Manhinh, dt.Hedieuhanh, dt.Ram, dt.Bonho, dt.Pin, dt.Camera,dt.Soluong);
                j = j + 1;
            }
        }
    }
}
