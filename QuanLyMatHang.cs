using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static _21880159.Entities;

namespace _21880159
{
    public class QuanLyMatHang
    {

        public static List<MatHang> DSMH = new List<MatHang>();

        public static MatHang ThemSP(string maHang)
        {
            MatHang mh = new MatHang();
            mh.maHang = maHang;
            do
            {
                Console.WriteLine("Nhap ten mat hang: ");
                mh.tenHang = Console.ReadLine().Trim();
                if (mh.tenHang.Length == 0)
                {
                    Console.WriteLine("Khong duoc de trong!");
                    continue;
                }
                break;
            } while (true);
            do
            {
                try
                {
                    Console.WriteLine("Nhap han dung (thang): ");
                    mh.hanDung = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Vui long nhap so thang!");
                }
            } while (true);

            do
            {
                Console.WriteLine("Nhap cty san xuat: ");
                mh.congTySanXuat = Console.ReadLine().Trim();
                if (mh.congTySanXuat.Length == 0)
                {
                    Console.WriteLine("Khong duoc de trong!");
                    continue;
                }
                break;
            } while (true);

            do
            {
                try
                {
                    Console.WriteLine("Nhap nam san xuat (MM/dd/YYYY): ");

                    DateTime namSanXuat = Convert.ToDateTime(Console.ReadLine().Trim());
                    if (!(namSanXuat.Year > DateTime.Now.Year))
                    {
                        if (!(namSanXuat.Month > DateTime.Now.Month))
                        {
                            if (!(namSanXuat.Day > DateTime.Now.Day))
                            {
                                mh.namSanXuat = namSanXuat;
                                break;
                            }
                        }
                    }
                    Console.WriteLine("Nam san xuat ko the lon hon nam hien tai!");
                    continue;
                }
                catch (Exception)
                {
                    Console.WriteLine("Sai dinh dang ngay!");
                }
            } while (true);

            do
            {
                Console.WriteLine("Nhap ma loai hang: ");
                mh.maLoaiHang = Console.ReadLine().Trim();
                if (mh.maLoaiHang.Length == 0)
                {
                    Console.WriteLine("Khong duoc de trong!");
                    continue;
                }
                break;
            } while (true);
            return mh;
        }

        public static string SuaSP(List<MatHang> mhs, string maMH)
        {
            for (int i = 0; i < mhs.Count; i++)
            {
                if (mhs[i].maHang.Equals(maMH))
                {
                    mhs[i].ToString();
                    MatHang mh = mhs[i];
                    Console.WriteLine("Sua mat hang: ");
                    do
                    {
                        Console.WriteLine("Nhap ten mat hang: ");
                        mh.tenHang = Console.ReadLine().Trim();
                        if (mh.tenHang.Length == 0)
                        {
                            Console.WriteLine("Khong duoc de trong!");
                            continue;
                        }
                        break;
                    } while (true);
                    do
                    {
                        try
                        {
                            Console.WriteLine("Nhat han dung (thang): ");
                            mh.hanDung = int.Parse(Console.ReadLine());
                            break;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Vui long nhap so thang!");
                        }
                    } while (true);

                    do
                    {
                        Console.WriteLine("Nhap cty san xuat: ");
                        mh.congTySanXuat = Console.ReadLine().Trim();
                        if (mh.congTySanXuat.Length == 0)
                        {
                            Console.WriteLine("Khong duoc de trong!");
                            continue;
                        }
                        break;
                    } while (true);

                    do
                    {
                        try
                        {
                            Console.WriteLine("Nhap nam san xuat (MM/dd/YYYY): ");

                            DateTime namSanXuat = Convert.ToDateTime(Console.ReadLine().Trim());
                            if (namSanXuat.Year > DateTime.Now.Year)
                            {
                                if (namSanXuat.Month > DateTime.Now.Month)
                                {
                                    if (namSanXuat.Day > DateTime.Now.Day)
                                    {
                                        mh.namSanXuat = namSanXuat;
                                        break;
                                    }
                                }
                            }
                            Console.WriteLine("Nam san xuat ko the lon hon nam hien tai!");
                            continue;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Sai dinh dang ngay!");
                        }
                    } while (true);

                    do
                    {
                        Console.WriteLine("Nhap ma loai hang: ");
                        mh.maLoaiHang = Console.ReadLine().Trim();
                        if (mh.maLoaiHang.Length == 0)
                        {
                            Console.WriteLine("Khong duoc de trong!");
                            continue;
                        }
                        break;
                    } while (true);
                    return "Sua thanh cong!";
                }
            }
            return $"Khong ton tai ma hang {maMH}";
        }

        public static string XoaSP(List<MatHang> mhs, string maMH)
        {
            for (int i = 0; i < mhs.Count; i++)
            {
                if (mhs[i].maHang.Equals(maMH))
                {
                    mhs.Remove(mhs[i]);
                    return $"Da xoa mat hang {maMH}";
                }
            }
            return $"Khong ton tai mat hang {maMH}";
        }
        public static void InDanhSachMatHang(List<MatHang> matHangs)
        {
            Console.Clear();
            Console.WriteLine("Danh sach mat hang: ");
            Console.WriteLine($"{"Ma hang",-15}{"Ten hang",-15}{"Han dung",-15}{"Cty SX",-15}{"Nam SX",-15}{"Ma LH",-15}");
            foreach (var item in matHangs)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("An Enter de tiep tuc!");
            Console.ReadKey();
        }
    }
}
