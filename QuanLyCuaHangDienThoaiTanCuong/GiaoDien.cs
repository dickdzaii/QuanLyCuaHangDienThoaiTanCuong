using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangDienThoaiTanCuong
{
    class GiaoDien
    {
        public static void MainOfThisProgram()
        {
            Console.InputEncoding = UnicodeEncoding.UTF8;
            Console.OutputEncoding = UnicodeEncoding.UTF8;
            ConsoleKeyInfo taylorswift;
        IU:
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("           CHƯƠNG TRÌNH QUẢN LÝ CỬA HÀNG ĐIỆN THOẠI TÂN CƯỜNG");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("     ******************************************************************");
                Console.WriteLine("     *                                 MENU                           *");
                Console.WriteLine("     *                                                                *");
                Console.WriteLine("     *                 F1:quản lý kho hàng                            *");
                Console.WriteLine("     *                                                                *");
                Console.WriteLine("     *                 F2:quản lý nhập hàng                           *");
                Console.WriteLine("     *                                                                *");
                Console.WriteLine("     *                 F3:quản lý bán hàng                            *");
                Console.WriteLine("     *                                                                *");
                Console.WriteLine("     *                 F4:quản lý đổi trả                             *");
                Console.WriteLine("     *                                                                *");
                Console.WriteLine("     *                 F5:Thống kê, báo cáo                           *");
                Console.WriteLine("     *                                                                *");
                Console.WriteLine("     *                 ESC:thoát khỏi chương trình                    *");
                Console.WriteLine("     *                                                                *");
                Console.WriteLine("     *                 Mời bạn chọn chức năng                         *");
                Console.WriteLine("     *                                                                *");
                Console.WriteLine("     ******************************************************************");
                taylorswift = Console.ReadKey();
            }
            switch (taylorswift.Key)
            {
                case ConsoleKey.F1:
                    {
                        {
                            DT dt = new DT();
                            ConsoleKeyInfo kt1;
                        ung:
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("           CHƯƠNG TRÌNH QUẢN LÝ CỬA HÀNG ĐIỆN THOẠI TÂN CƯỜNG");
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("     ******************************************************************");
                                Console.WriteLine("     *                           QUẢN LÝ KHO HÀNG                     *");
                                Console.WriteLine("     *                                                                *");
                                Console.WriteLine("     *                 F1:thêm điện thoại mới                         *");
                                Console.WriteLine("     *                                                                *");
                                Console.WriteLine("     *                 F2:cập nhật điện thoại                         *");
                                Console.WriteLine("     *                                                                *");
                                Console.WriteLine("     *                 F3:xóa điện thoại                              *");
                                Console.WriteLine("     *                                                                *");
                                Console.WriteLine("     *                 F4:tìm kiếm thông tin                          *");
                                Console.WriteLine("     *                                                                *");
                                Console.WriteLine("     *                 F5:hiển thị thông tin                          *");
                                Console.WriteLine("     *                                                                *");
                                Console.WriteLine("     *                 Backspace:quay lại                             *");
                                Console.WriteLine("     *                                                                *");
                                Console.WriteLine("     *                 Mời bạn chọn chức năng                         *");
                                Console.WriteLine("     *                                                                *");
                                Console.WriteLine("     ******************************************************************");
                                kt1 = Console.ReadKey();
                            }
                            Console.Clear();
                            switch (kt1.Key)
                            {
                                case ConsoleKey.F1:
                                    {
                                        dt.Nhap();
                                        Console.ForegroundColor = ConsoleColor.Magenta;
                                        Console.ReadKey();
                                        goto ung;
                                    }
                                case ConsoleKey.F2:
                                    {
                                        dt.UpdateDienThoai();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("nhấn phím bất kỳ để quay lại");
                                        Console.ReadKey();
                                        goto ung;
                                    }
                                case ConsoleKey.F3:
                                    {
                                        dt.xoadienthoai();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        //Console.WriteLine("nhấn phím bất kỳ để quay lại");
                                        //Console.ReadKey();
                                        goto ung;
                                    }
                                case ConsoleKey.F4:
                                    {
                                        ConsoleKeyInfo k;
                                    xD:
                                        {

                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("           CHƯƠNG TRÌNH QUẢN LÝ CỬA HÀNG ĐIỆN THOẠI TÂN CƯỜNG");
                                            Console.WriteLine();
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine("     ******************************************************************");
                                            Console.WriteLine("     *                      TÌM KIẾM ĐIỆN THOẠI                       *");
                                            Console.WriteLine("     *                                                                *");
                                            Console.WriteLine("     *                 F1:Tìm kiếm theo tên                           *");
                                            Console.WriteLine("     *                                                                *");
                                            Console.WriteLine("     *                 F2:Tìm kiếm theo màn hình                      *");
                                            Console.WriteLine("     *                                                                *");
                                            Console.WriteLine("     *                 F3:Tìm kiếm theo hệ điều hành                  *");
                                            Console.WriteLine("     *                                                                *");
                                            Console.WriteLine("     *                 F4:Tìm kiếm theo RAM                           *");
                                            Console.WriteLine("     *                                                                *");
                                            Console.WriteLine("     *                 F5:Tìm kiếm theo bộ nhớ                        *");
                                            Console.WriteLine("     *                                                                *");
                                            Console.WriteLine("     *                 F6:Tìm kiếm theo camera                        *");
                                            Console.WriteLine("     *                                                                *");
                                            Console.WriteLine("     *                 F7:Tìm kiếm theo pin                           *");
                                            Console.WriteLine("     *                                                                *");
                                            Console.WriteLine("     *                 F8:Tìm kiếm theo giá bán                       *");
                                            Console.WriteLine("     *                                                                *");
                                            Console.WriteLine("     *                 Backspace:quay lại                             *");
                                            Console.WriteLine("     *                                                                *");
                                            Console.WriteLine("     *                 Mời bạn chọn chức năng                         *");
                                            Console.WriteLine("     *                                                                *");
                                            Console.WriteLine("     ******************************************************************");
                                            k = Console.ReadKey();
                                        }
                                        Console.Clear();
                                        switch (k.Key)
                                        {
                                            case ConsoleKey.F1:
                                                {
                                                    dt.TimKiemTheoTen();
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.Write("nhấn phím bất kỳ để quay lại");
                                                    Console.ReadKey();
                                                    goto xD;
                                                }
                                            case ConsoleKey.F2:
                                                {
                                                    dt.TimKiemmanhinh();
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.Write("nhấn phím bất kỳ để quay lại");
                                                    Console.ReadKey();
                                                    goto xD;
                                                }
                                            case ConsoleKey.F3:
                                                {
                                                    dt.timkiemhedieuhanh();
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.Write("nhấn phím bất kỳ để quay lại");
                                                    Console.ReadKey();
                                                    goto xD;
                                                }
                                            case ConsoleKey.F4:
                                                {
                                                    dt.TimKiemtheoRAM();
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.Write("nhấn phím bất kỳ để quay lại");
                                                    Console.ReadKey();
                                                    goto xD;
                                                }
                                            case ConsoleKey.F5:
                                                {
                                                    dt.timkiembonho();
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.Write("nhấn phím bất kỳ để quay lại");
                                                    Console.ReadKey();
                                                    goto xD;
                                                }
                                            case ConsoleKey.F6:
                                                {
                                                    dt.TimKiemtheocamera();
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.Write("nhấn phím bất kỳ để quay lại");
                                                    Console.ReadKey();
                                                    goto xD;
                                                }
                                            case ConsoleKey.F7:
                                                {
                                                    dt.TimKiempin();
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.Write("nhấn phím bất kỳ để quay lại");
                                                    Console.ReadKey();
                                                    goto xD;
                                                }
                                            case ConsoleKey.F8:
                                                {
                                                    dt.TimKiemgiaban();
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.Write("nhấn phím bất kỳ để quay lại");
                                                    Console.ReadKey();
                                                    goto xD;
                                                }
                                            case ConsoleKey.Backspace:
                                                {
                                                    goto ung;

                                                }
                                            default: Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("ban vua chon không đúng, vui long nhấn phím bất kỳ để chọn lại."); goto xD;
                                        }
                                    }
                                case ConsoleKey.F5:
                                    {
                                        dt.demkho();
                                        dt.Hienthi();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write("nhấn phím bất kỳ để quay lại"); Console.ReadKey(); goto ung;
                                    }
                                case ConsoleKey.Backspace: goto IU;

                                default: Console.ForegroundColor = ConsoleColor.Red; Console.Write("chức năng bạn chọn không hợp lệ, vui long nhấn phím bất kỳ để chọn lại:"); Console.ReadKey(); goto ung;
                            }

                        }

                    }
                case ConsoleKey.F2:
                    {
                        ConsoleKeyInfo kt2;
                        QLHDN qlhdn = new QLHDN();
                    bbibbi:
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("           CHƯƠNG TRÌNH QUẢN LÝ CỬA HÀNG ĐIỆN THOẠI TÂN CƯỜNG");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("     ******************************************************************");
                            Console.WriteLine("     *                                 MENU                           *");
                            Console.WriteLine("     *                 F1:nhập một hoá đơn nhập hang                  *");
                            Console.WriteLine("     *                                                                *");
                            Console.WriteLine("     *                 F2:cập nhật một hóa đơn                        *");
                            Console.WriteLine("     *                                                                *");
                            Console.WriteLine("     *                 F3:tìm kiếm theo mã                            *");
                            Console.WriteLine("     *                                                                *");
                            Console.WriteLine("     *                 F4:hiển thị thông tin                          *");
                            Console.WriteLine("     *                                                                *");
                            Console.WriteLine("     *                 Backspace:quay lại                             *");
                            Console.WriteLine("     *                                                                *");
                            Console.WriteLine("     *                 Mời bạn chọn chức năng                         *");
                            Console.WriteLine("     *                                                                *");
                            Console.WriteLine("     ******************************************************************");
                        }
                        kt2 = Console.ReadKey();
                        Console.Clear();
                        switch (kt2.Key)
                        {
                            case ConsoleKey.F1:
                                {
                                    qlhdn.Nhap();
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine("hoan tat viec nhap.");
                                    Console.ReadKey();
                                    goto bbibbi;

                                }
                            case ConsoleKey.F2:
                                {
                                    qlhdn.update();
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("nhấn phím bất kỳ để quay lại");
                                    Console.ReadKey();
                                    goto bbibbi;
                                }
                            case ConsoleKey.F3:
                                {
                                    qlhdn.TimKiemTheoma();
                                    Console.ReadKey();
                                    goto bbibbi;
                                }
                            case ConsoleKey.F4:
                                {
                                    qlhdn.hien();
                                    goto bbibbi;
                                }
                            case ConsoleKey.Backspace: goto IU;
                            default: Console.ForegroundColor = ConsoleColor.Red; Console.Write("chức năng bạn chọn không hợp lệ, vui long nhấn phím bất kỳ để chọn lại:"); Console.ReadKey(); goto bbibbi;
                        }
                        //break;
                    }
                case ConsoleKey.F3:
                    {
                        ConsoleKeyInfo kt3;
                        QLHDB qlhdb = new QLHDB();
                    LeeJiUhn:
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("           CHƯƠNG TRÌNH QUẢN LÝ CỬA HÀNG ĐIỆN THOẠI TÂN CƯỜNG");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("     ******************************************************************");
                            Console.WriteLine("     *                                 MENU                           *");
                            Console.WriteLine("     *                                                                *");
                            Console.WriteLine("     *                 F1:nhập một hóa đơn bán                        *");
                            Console.WriteLine("     *                                                                *");
                            Console.WriteLine("     *                 F2:cập nhật một hóa đơn                        *");
                            Console.WriteLine("     *                                                                *");
                            Console.WriteLine("     *                 F3:tìm kiếm theo mã                            *");
                            Console.WriteLine("     *                                                                *");
                            Console.WriteLine("     *                 F4:hiển thị thông tin                          *");
                            Console.WriteLine("     *                                                                *");
                            Console.WriteLine("     *                 Backspace:quay lại                             *");
                            Console.WriteLine("     *                                                                *");
                            Console.WriteLine("     *                 Mời bạn chọn chức năng                         *");
                            Console.WriteLine("     *                                                                *");
                            Console.WriteLine("     ******************************************************************");
                        }
                        kt3 = Console.ReadKey();
                        Console.Clear();
                        switch (kt3.Key)
                        {
                            case ConsoleKey.F1:
                                {
                                    qlhdb.Nhap();
                                    goto LeeJiUhn;
                                }
                            case ConsoleKey.F2:
                                {
                                    
                                    qlhdb.update();
                                    goto LeeJiUhn;
                                }
                            case ConsoleKey.F3:
                                {
                                    qlhdb.TimKiemTheoma();
                                    Console.ReadKey();
                                    goto LeeJiUhn;
                                }
                            case ConsoleKey.F4:
                                {
                                    qlhdb.hien();
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("nhấn phím bất kỳ để quay lại");
                                    Console.ReadKey();
                                    goto LeeJiUhn;
                                }
                            case ConsoleKey.Backspace: goto IU;
                            default: Console.ForegroundColor = ConsoleColor.Red; Console.Write("chức năng bạn chọn không hợp lệ, vui long nhấn phím bất kỳ để chọn lại:"); Console.ReadKey(); goto LeeJiUhn;

                        }
                        break;
                    }
                case ConsoleKey.F4:
                    {
                        ConsoleKeyInfo dt;
                        QLDT qldt = new QLDT();
                    red:
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("           CHƯƠNG TRÌNH QUẢN LÝ CỬA HÀNG ĐIỆN THOẠI TÂN CƯỜNG");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine();
                            Console.WriteLine("     ******************************************************************");
                            Console.WriteLine("     *                                 MENU                           *");
                            Console.WriteLine("     *                 F1:nhập một thông tin đổi trả                  *");
                            Console.WriteLine("     *                                                                *");
                            Console.WriteLine("     *                 F2:hiển thị thông tin                          *");
                            Console.WriteLine("     *                                                                *");
                            Console.WriteLine("     *                 Backspace:quay lại                             *");
                            Console.WriteLine("     *                                                                *");
                            Console.WriteLine("     *                 Mời bạn chọn chức năng                         *");
                            Console.WriteLine("     *                                                                *");
                            Console.WriteLine("     ******************************************************************");
                            dt = Console.ReadKey();
                        }
                        Console.Clear();
                        switch (dt.Key)
                        {
                            case ConsoleKey.F1:
                                {
                                    qldt.nhap();
                                    goto red;
                                }
                            case ConsoleKey.F2:
                                {
                                    qldt.hien();
                                    Console.ReadKey();
                                    goto red;
                                }
                            case ConsoleKey.Backspace:goto IU;
                            default:goto red;
                        }
                        break;
                    }
                case ConsoleKey.F5:
                    {
                        ConsoleKeyInfo thke;
                    tke:
                        {
                            Console.Clear();
                            Console.WriteLine("     ******************************************************************");
                            Console.WriteLine("     *                                 MENU                           *");
                            Console.WriteLine("     *                 F1:thống kê các loại điện thoại đã bán 1 tháng *");
                            Console.WriteLine("     *                                                                *");
                            Console.WriteLine("     *                 F2:thống kê doanh thu theo tháng               *");
                            Console.WriteLine("     *                                                                *");
                            Console.WriteLine("     *                 F3:thống kê doanh thu theo năm                 *");
                            Console.WriteLine("     *                                                                *"); ;
                            Console.WriteLine("     *                 Backspace:quay lại                             *");
                            Console.WriteLine("     *                                                                *");
                            Console.WriteLine("     *                 Mời bạn chọn chức năng                         *");
                            Console.WriteLine("     *                                                                *");
                            Console.WriteLine("     ******************************************************************");
                            thke = Console.ReadKey();
                        }
                        Console.Clear();
                        switch (thke.Key)
                        {
                            case ConsoleKey.F1:
                                {
                                    ThongKe.tkedt();
                                    Console.ReadKey();
                                    goto tke;
                                }
                            case ConsoleKey.F2:
                                {
                                    ThongKe.thang();
                                    Console.ReadKey();
                                    goto tke;
                                }
                            case ConsoleKey.F3:
                                {
                                    ThongKe.nam();
                                    Console.ReadKey();
                                    goto tke;
                                }
                            case ConsoleKey.Backspace:goto IU;
                            default:goto tke;
                        }
                       // goto IU;
                    }
                case ConsoleKey.Escape: break;
                default:Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("chức năng bạn chọn không hợp lệ, vui lòng bấm phím bất kỳ để chọn lại");
                    Console.ReadKey(); goto IU;
            }
        }
    }
}
