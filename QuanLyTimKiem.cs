using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static _21880159.Entities;


namespace _21880159
{
    class QuanLyTimKiem
    {
        public static void TimKiem(List<MatHang> mhs, List<LoaiHang> loaiHangs, int choice)
        {
            switch (choice)
            {
                //tim kiem theo ma hang
                case 1:
                    Console.Clear();
                    string maMH;
                    do
                    {
                        Console.WriteLine("Nhap ma mat hang: ");
                        maMH = Console.ReadLine().Trim();
                        if (maMH.Length == 0)
                        {
                            Console.WriteLine("Khong duoc de trong!");
                            continue;
                        }
                        break;
                    } while (true);
                    Console.WriteLine("Ket qua tim kiem theo ma hang: ");
                    Console.WriteLine($"{"Ma hang",-15}{"Ten hang",-15}{"Han dung",-15}{"Cty SX",-15}{"Nam SX",-15}{"Ma LH",-15}");
                    for (int i = 0; i < mhs.Count; i++)
                    {
                        if (mhs[i].maHang.Equals(maMH))
                        {
                            Console.WriteLine(mhs[i].ToString());
                        }
                    }
                    break;
                case 2:
                    Console.Clear();
                    string tenMH;
                    do
                    {
                        Console.WriteLine("Nhap ten mat hang: ");
                        tenMH = Console.ReadLine().Trim().ToLower();
                        if (tenMH.Length == 0)
                        {
                            Console.WriteLine("Khong duoc de trong!");
                            continue;
                        }
                        break;
                    } while (true);
                    Console.WriteLine("Ket qua tim kiem theo ten hang: ");
                    Console.WriteLine($"{"Ma hang",-15}{"Ten hang",-15}{"Han dung",-15}{"Cty SX",-15}{"Nam SX",-15}{"Ma LH",-15}");
                    for (int i = 0; i < mhs.Count; i++)
                    {
                        if (mhs[i].tenHang.ToLower().Contains(tenMH))
                        {
                            Console.WriteLine(mhs[i].ToString());
                        }
                    }
                    break;
                case 3:
                    Console.Clear();
                    string tenCty;
                    do
                    {
                        Console.WriteLine("Nhap ten cong ty san xuat mat hang: ");
                        tenCty = Console.ReadLine().Trim().ToLower();
                        if (tenCty.Length == 0)
                        {
                            Console.WriteLine("Khong duoc de trong!");
                            continue;
                        }
                        break;
                    } while (true);
                    Console.WriteLine("Ket qua tim kiem theo ten cong ty san xuat mat hang: ");
                    Console.WriteLine($"{"Ma hang",-15}{"Ten hang",-15}{"Han dung",-15}{"Cty SX",-15}{"Nam SX",-15}{"Ma LH",-15}");
                    for (int i = 0; i < mhs.Count; i++)
                    {
                        if (mhs[i].congTySanXuat.ToLower().Contains(tenCty))
                        {
                            Console.WriteLine(mhs[i].ToString());
                        }
                    }
                    break;
                case 4:
                    Console.Clear();
                    string maLH;
                    do
                    {
                        Console.WriteLine("Nhap ma loai hang: ");
                        maLH = Console.ReadLine().Trim().ToLower();
                        if (maLH.Length == 0)
                        {
                            Console.WriteLine("Khong duoc de trong!");
                            continue;
                        }
                        break;
                    } while (true);
                    Console.WriteLine("Ket qua tim kiem mat hang theo ma loai hang: ");
                    Console.WriteLine($"{"Ma hang",-15}{"Ten hang",-15}{"Han dung",-15}{"Cty SX",-15}{"Nam SX",-15}{"Ma LH",-15}");
                    for (int i = 0; i < mhs.Count; i++)
                    {
                        if (mhs[i].maLoaiHang.ToLower().Equals(maLH))
                        {
                            Console.WriteLine(mhs[i].ToString());
                        }
                    }
                    break;
                case 5:
                    Console.Clear();
                    string tenLH;
                    do
                    {
                        Console.WriteLine("Nhap ten loai hang: ");
                        tenLH = Console.ReadLine().Trim().ToLower();
                        if (tenLH.Length == 0)
                        {
                            Console.WriteLine("Khong duoc de trong!");
                            continue;
                        }
                        break;
                    } while (true);
                    Console.WriteLine("Ket qua tim kiem mat hang theo ten loai hang: ");
                    Console.WriteLine($"{"Ma hang",-15}{"Ten hang",-15}{"Han dung",-15}{"Cty SX",-15}{"Nam SX",-15}{"Ma LH",-15}");
                    for (int i = 0; i < loaiHangs.Count; i++)
                    {
                        if (loaiHangs[i].tenLoaiHang.ToLower().Contains(tenLH))
                        {
                            for (int j = 0; j < mhs.Count; j++)
                            {
                                if (mhs[j].maLoaiHang.Equals(loaiHangs[i].maLoaiHang))
                                {
                                    Console.WriteLine(mhs[j].ToString());
                                }
                            }
                        }
                    }
                    break;
                case 6:
                    Console.Clear();
                    string maLoaiHang;
                    do
                    {
                        Console.WriteLine("Nhap ma loai hang: ");
                        maLoaiHang = Console.ReadLine().Trim().ToLower();
                        if (maLoaiHang.Length == 0)
                        {
                            Console.WriteLine("Khong duoc de trong!");
                            continue;
                        }
                        break;
                    } while (true);
                    Console.WriteLine("Ket qua tim kiem loai hang theo ma loai hang: ");
                    Console.WriteLine($"{"Ma loai hang",-15}{"Ten loai hang",-15}");
                    for (int i = 0; i < loaiHangs.Count; i++)
                    {
                        if (loaiHangs[i].maLoaiHang.ToLower().Equals(maLoaiHang))
                        {
                            Console.WriteLine(loaiHangs[i].ToString());
                        }
                    }
                    break;
                case 7:
                    Console.Clear();
                    string tenLoaiHang;
                    do
                    {
                        Console.WriteLine("Nhap ten loai hang: ");
                        tenLoaiHang = Console.ReadLine().Trim().ToLower();
                        if (tenLoaiHang.Length == 0)
                        {
                            Console.WriteLine("Khong duoc de trong!");
                            continue;
                        }
                        break;
                    } while (true);
                    Console.WriteLine("Ket qua tim kiem loai hang theo ten loai hang: ");
                    Console.WriteLine($"{"Ma loai hang",-15}{"Ten loai hang",-15}");
                    for (int i = 0; i < loaiHangs.Count; i++)
                    {
                        if (loaiHangs[i].tenLoaiHang.ToLower().Contains(tenLoaiHang))
                        {
                            Console.WriteLine(loaiHangs[i].ToString());
                        }
                    }
                    break;
            }
        }
    }
}
