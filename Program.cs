using System;
using System.Collections.Generic;

using static _21880159.Entities;

namespace _21880159
{
    class Program
    {
        public static List<MatHang> matHangs = new List<MatHang>();
        public static List<LoaiHang> loaiHangs = new List<LoaiHang>();

        static void Main(string[] args)
        {
            int choice = 0;
            do
            {
                MatHang mh = new MatHang();
                LoaiHang lh = new LoaiHang();
                menu();
                choice = choiceValidation();
                string selection = "";
                string maHang = "";
                string maLoaiHang = "";
                switch (choice)
                {
                    //them mat hang
                    case 1:
                        do
                        {
                            if (loaiHangs.Count == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Danh sach loai hang rong xin tao loai hang truoc");
                                Console.WriteLine("An phim bat ky de tiep tuc!");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Clear();
                                while (true)
                                {
                                    Console.WriteLine("Nhap ma mat hang: ");
                                    maHang = Console.ReadLine().Trim();
                                    if (maHang.Length == 0)
                                    {
                                        Console.WriteLine("Khong duoc de trong!");
                                        continue;
                                    }
                                    if (!kiemTraMaHang(maHang))
                                    {
                                        break;
                                    }
                                    Console.WriteLine("Ma hang da ton tai!");
                                }
                                mh = QuanLyMatHang.ThemSP(maHang);
                                if (kiemTraMaLoaiHang(mh.maLoaiHang))
                                {
                                    matHangs.Add(mh);
                                }
                                else
                                {
                                    Console.WriteLine("Ma loai hang khong ton tai vui long tao moi.");
                                }
                                Console.WriteLine("Ban co tiep tuc them mat hang ko? (Y/N)");
                                selection = Console.ReadLine().Trim();
                            }
                        } while (selection.Length != 0 && selection[0] != 'n' && selection[0] != 'N');
                        break;
                    //xoa mat hang
                    case 2:
                        do
                        {
                            Console.Clear();
                            if (kiemTraDanhSachMatHang())
                            {
                                Console.WriteLine("Danh sach rong!");
                                Console.WriteLine("An phim bat ky de tiep tuc!");
                                Console.ReadKey();
                                break;
                            }
                            while (true)
                            {
                                Console.WriteLine("Nhap ma mat hang muon xoa: ");
                                maHang = Console.ReadLine().Trim();
                                if (maHang.Length == 0)
                                {
                                    Console.WriteLine("Khong duoc de trong!");
                                    continue;
                                }
                                break;
                            }
                            string kq = QuanLyMatHang.XoaSP(matHangs, maHang);
                            Console.WriteLine(kq);
                            Console.WriteLine("Ban co tiep tuc sua mat hang ko? (Y/N)");
                            selection = Console.ReadLine().Trim();
                        } while (selection.Length != 0 && selection[0] != 'n' && selection[0] != 'N');
                        break;
                    //sua mat hang
                    case 3:
                        do
                        {
                            Console.Clear();
                            if (kiemTraDanhSachMatHang())
                            {
                                Console.WriteLine("Danh sach rong!");
                                Console.WriteLine("An phim bat ky de tiep tuc!");
                                Console.ReadKey();
                                break;
                            }

                            while (true)
                            {
                                Console.WriteLine("Nhap ma mat hang muon sua: ");
                                maHang = Console.ReadLine().Trim();
                                if (maHang.Length == 0)
                                {
                                    Console.WriteLine("Khong duoc de trong!");
                                    continue;
                                }
                                break;
                            }
                            string kq = QuanLyMatHang.SuaSP(matHangs, maHang);
                            Console.WriteLine(kq);
                            Console.WriteLine("Ban co tiep tuc sua mat hang ko? (Y/N)");
                            selection = Console.ReadLine().Trim();
                        } while (selection.Length != 0 && selection[0] != 'n' && selection[0] != 'N');
                        break;
                    //In danh sach mat hang
                    case 4:
                        Console.Clear();
                        if (kiemTraDanhSachLoaiHang())
                        {
                            Console.WriteLine("Danh sach rong!");
                            Console.WriteLine("An phim bat ky de tiep tuc!");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            QuanLyMatHang.InDanhSachMatHang(matHangs);
                        }
                        break;
                    //----------Loai Hang---------//
                    //them loai hang
                    case 5:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Them ma loai hang: ");
                            while (true)
                            {
                                Console.WriteLine("Nhap ma loai hang: ");
                                maLoaiHang = Console.ReadLine().Trim();
                                if (maLoaiHang.Length == 0)
                                {
                                    Console.WriteLine("Khong duoc de trong!");
                                    continue;
                                }
                                if (!kiemTraMaLoaiHang(maLoaiHang))
                                {
                                    break;
                                }
                                Console.WriteLine("Ma loai hang da ton tai!");
                                Console.WriteLine("An phim bat ky de tiep tuc!");
                                Console.ReadKey();
                            }

                            lh = QuanLyLoaiHang.ThemLoaiHang(maLoaiHang);
                            loaiHangs.Add(lh);
                            Console.WriteLine("Ban co tiep tuc them loai hang ko? (Y/N)");
                            selection = Console.ReadLine().Trim();
                        } while (selection.Length != 0 && selection[0] != 'n' && selection[0] != 'N');
                        break;
                    //xoa loai hang
                    case 6:
                        do
                        {
                            Console.Clear();
                            if (kiemTraDanhSachLoaiHang())
                            {
                                Console.WriteLine("Danh sach rong!");
                                Console.WriteLine("An phim bat ky de tiep tuc!");
                                Console.ReadKey();
                                break;
                            }

                            while (true)
                            {
                                Console.WriteLine("Nhap ma loai hang muon xoa: ");
                                maLoaiHang = Console.ReadLine().Trim();
                                if (maLoaiHang.Length == 0)
                                {
                                    Console.WriteLine("Khong duoc de trong!");
                                    continue;
                                }
                                break;
                            }
                            string kq = QuanLyLoaiHang.XoaLoaiHang(matHangs, loaiHangs, maLoaiHang);
                            Console.WriteLine(kq);
                            Console.WriteLine("Ban co tiep tuc sua loai hang ko? (Y/N)");
                            selection = Console.ReadLine().Trim();
                        } while (selection.Length != 0 && selection[0] != 'n' && selection[0] != 'N');
                        break;
                    //sua loai hang
                    case 7:
                        do
                        {
                            Console.Clear();
                            if (kiemTraDanhSachLoaiHang())
                            {
                                Console.WriteLine("Danh sach rong!");
                                Console.WriteLine("An phim bat ky de tiep tuc!");
                                Console.ReadKey();
                                break;
                            }
                            while (true)
                            {
                                Console.WriteLine("Nhap ma loai hang muon sua: ");
                                maLoaiHang = Console.ReadLine().Trim();
                                if (maLoaiHang.Length == 0)
                                {
                                    Console.WriteLine("Khong duoc de trong!");
                                    continue;
                                }
                                break;
                            }
                            string kq = QuanLyLoaiHang.SuaLoaiHang(matHangs, loaiHangs, maLoaiHang);
                            Console.WriteLine(kq);
                            Console.WriteLine("Ban co tiep tuc sua loai hang ko? (Y/N)");
                            selection = Console.ReadLine().Trim();
                        } while (selection.Length != 0 && selection[0] != 'n' && selection[0] != 'N');
                        break;
                    case 8:
                        Console.Clear();
                        if (kiemTraDanhSachLoaiHang())
                        {
                            Console.WriteLine("Danh sach rong!");
                            Console.WriteLine("An phim bat ky de tiep tuc!");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            QuanLyLoaiHang.InDanhSachLoaiHang(loaiHangs);
                        }
                        break;
                    case 9:
                        Console.Clear();
                        int searchChoice = 0;
                        do
                        {
                            Console.Clear();
                            menuTimKiem();
                            searchChoice = choiceValidation();
                            if (searchChoice == 0)
                            {
                                Console.Clear();
                                break;
                            }
                            if (searchChoice < 0 || searchChoice > 7)
                            {
                                Console.Clear();
                                Console.WriteLine("Nhap sai lua chon!");
                                Console.WriteLine("An phim bat ky de tiep tuc!");
                                Console.ReadKey();
                            }
                            else
                            {
                                do
                                {
                                    if (kiemTraDanhSachMatHang() || kiemTraDanhSachLoaiHang())
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Danh sach rong!");
                                        Console.WriteLine("An phim bat ky de tiep tuc!");
                                        Console.ReadKey();
                                        break;
                                    }
                                    QuanLyTimKiem.TimKiem(matHangs, loaiHangs, searchChoice);
                                    Console.WriteLine("Ban co tiep tuc ko? (Y/N)");
                                    selection = Console.ReadLine().Trim();
                                } while (selection.Length != 0 && selection[0] != 'n' && selection[0] != 'N');
                            }
                        } while (searchChoice != 0);
                        break;
                    case 10:
                        matHangs.Clear();
                        loaiHangs.Clear();
                        Console.Clear();
                        matHangs.Add(new MatHang("001", "Cafe", 12, "vina cf", DateTime.Parse("02/03/2022"), "MLH01"));
                        matHangs.Add(new MatHang("002", "Tra sua", 12, "vina ts", DateTime.Parse("12/02/2021"), "MLH02"));
                        matHangs.Add(new MatHang("003", "Sua tuoi", 12, "sua VN", DateTime.Parse("01/07/2021"), "MLH03"));
                        matHangs.Add(new MatHang("004", "Sting", 12, "pepsi", DateTime.Parse("08/05/2022"), "MLH04"));
                        matHangs.Add(new MatHang("005", "Coca", 12, "cocacola", DateTime.Parse("11/06/2022"), "MLH04"));
                        loaiHangs.Add(new LoaiHang("MLH01", "Cafe"));
                        loaiHangs.Add(new LoaiHang("MLH02", "Sua"));
                        loaiHangs.Add(new LoaiHang("MLH03", "Tra"));
                        loaiHangs.Add(new LoaiHang("MLH04", "Nuoc ngot"));
                        Console.WriteLine("Da tao thanh cong!\nAn Enter de tiep tuc!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        choice = 0;
                        break;
                }
            } while (choice != 0);
        }

        public static int choiceValidation()
        {
            int choice = 0;
            while (true)
            {
                try
                {
                    choice = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.Write("\nNhap sai vui long nhap lai lua chon: ");
                }
            }
            return choice;
        }
        public static void menu()
        {
            Console.WriteLine("-------MENU------\n");
            Console.WriteLine(
                "----QUAN LY MAT HANG----" +
                "\n1. Them mot mat hang." +
                "\n2. Xoa mot mat hang." +
                "\n3. Sua mot mat hang." +
                "\n4. Danh sach mat hang hien co." +
                "\n----QUAN LY LOAI HANG----" +
                "\n5. Them mot loai hang." +
                "\n6. Xoa mot loai hang." +
                "\n7. Sua mot loai hang." +
                "\n8. Danh sach loai hang hien co." +
                "\n----QUAN LY TIM KIEM----" +
                "\n9. Menu tim kiem" +
                "\n----TAO DU LIEU MAU----" +
                "\n10. Tao du lieu mau." +
                "\n0. Thoat chuong trinh.");
            Console.Write("Vui long lua chon: ");

        }
        public static void menuTimKiem()
        {
            Console.WriteLine("-------MENU TIM KIEM-----\n");
            Console.WriteLine("----TIM KIEM MAT HANG----" +
                "\n1. Theo MA HANG." +
                "\n2. Theo TEN HANG." +
                "\n3. Theo CONG TY SAN XUAT." +
                "\n4. Theo MA LOAI HANG." +
                "\n5. Theo TEN LOAI HANG.\n" +
                "\n----TIM KIEM LOAI HANG----" +
                "\n6. Theo MA LOAI HANG." +
                "\n7. Theo TEN LOAI HANG." +
                "\n0. Thoat tim kiem.");
            Console.Write("Vui long lua chon: ");
        }
        public static bool kiemTraMaHang(string maHang)
        {
            foreach (var item in matHangs)
            {
                if (item.maHang.Equals(maHang))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool kiemTraMaLoaiHang(string maHang)
        {
            foreach (var item in loaiHangs)
            {
                if (item.maLoaiHang.Equals(maHang))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool kiemTraDanhSachMatHang()
        {
            return matHangs.Count == 0;
        }
        public static bool kiemTraDanhSachLoaiHang()
        {
            return loaiHangs.Count == 0;
        }
    }
}
