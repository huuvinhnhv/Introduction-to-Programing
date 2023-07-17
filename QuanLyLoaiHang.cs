using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static _21880159.Entities;


namespace _21880159
{
    class QuanLyLoaiHang
    {
        public static LoaiHang ThemLoaiHang(string maLH)
        {
            LoaiHang lh = new LoaiHang();
            lh.maLoaiHang = maLH;
            do
            {
                Console.WriteLine("Nhap ten loai hang: ");
                lh.tenLoaiHang = Console.ReadLine().Trim();
                if (lh.tenLoaiHang.Length == 0)
                {
                    Console.WriteLine("Khong duoc de trong!");
                    continue;
                }
                break;
            } while (true);

            return lh;
        }
        public static string XoaLoaiHang(List<MatHang> matHangs, List<LoaiHang> loaiHangs, string maLH)
        {
            for (int i = 0; i < loaiHangs.Count; i++)
            {
                if (loaiHangs[i].maLoaiHang.Equals(maLH))
                {
                    loaiHangs.Remove(loaiHangs[i]);
                    for (int j = 0; j < matHangs.Count; j++)
                    {
                        if (matHangs[j].maLoaiHang.Equals(maLH))
                        {
                            matHangs.Remove(matHangs[j]);
                        }
                    }
                    return $"Da xoa loai hang {maLH} và cac mat hang co ma loai hang tuong ung.";
                }
            }
            return $"Khong ton tai loai hang {maLH}";
        }
        public static string SuaLoaiHang(List<MatHang> matHangs, List<LoaiHang> loaiHangs, string maLH)
        {
            string chose = "";
            for (int i = 0; i < loaiHangs.Count; i++)
            {
                if (loaiHangs[i].maLoaiHang.Equals(maLH))
                {
                    LoaiHang lh = new LoaiHang();
                    Console.WriteLine("Ban co muon sua ma loai hang ko? (Y/N)");
                    chose = Console.ReadLine().Trim();
                    if (chose[0] == 'y' || chose[0] == 'Y')
                    {
                        bool check = false;
                        do
                        {
                            do
                            {
                                Console.WriteLine("Nhap ma loai hang moi: ");
                                lh.maLoaiHang = Console.ReadLine().Trim();
                                if (lh.maLoaiHang.Length == 0)
                                {
                                    Console.WriteLine("Khong duoc de trong!");
                                    continue;
                                }
                                break;
                            } while (true);

                            foreach (var item in loaiHangs)
                            {
                                if (item.maLoaiHang.Equals(lh.maLoaiHang))
                                {
                                    Console.WriteLine("Ma loai hang da ton tai!");
                                    check = true;
                                    break;
                                }
                            }
                        } while (check);
                        do
                        {
                            Console.WriteLine("Nhap ten loai hang moi: ");
                            lh.tenLoaiHang = Console.ReadLine().Trim();
                            if (lh.tenLoaiHang.Length == 0)
                            {
                                Console.WriteLine("Khong duoc de trong!");
                                continue;
                            }
                            break;
                        } while (true);

                        loaiHangs[i] = lh;
                        for (int j = 0; j < matHangs.Count; j++)
                        {
                            if (matHangs[j].maLoaiHang.Equals(maLH))
                            {
                                MatHang mh = new MatHang();
                                mh = matHangs[j];
                                mh.maLoaiHang = lh.maLoaiHang;
                                matHangs[j] = mh;
                            }
                        }
                        return $"Da sua loai hang {maLH} thanh {loaiHangs[i].maLoaiHang} và cac mat hang co ma loai hang tuong ung.";
                    }
                    lh.maLoaiHang = maLH;
                    do
                    {
                        Console.WriteLine("Nhap ten loai hang moi: ");
                        lh.tenLoaiHang = Console.ReadLine().Trim();
                        if (lh.tenLoaiHang.Length == 0)
                        {
                            Console.WriteLine("Khong duoc de trong!");
                            continue;
                        }
                        break;
                    } while (true);
                    loaiHangs[i] = lh;
                    return $"Da sua loai hang {maLH}.";
                }
            }
            return $"Khong ton tai loai hang {maLH}";
        }
        public static string TimKiemLoaiHang(List<LoaiHang> loaiHangs)
        {
            Console.WriteLine("Nhap ma loai hang: ");
            string maLoaiHang = Console.ReadLine().Trim();
            for (int i = 0; i < loaiHangs.Count; i++)
            {
                if (loaiHangs[i].maLoaiHang.Equals(maLoaiHang))
                {
                    return loaiHangs[i].ToString();
                }
            }
            return $"Khong ton tai ma hang {maLoaiHang}";
        }
        public static void InDanhSachLoaiHang(List<LoaiHang> loaiHangs)
        {
            Console.Clear();
            Console.WriteLine("Danh sach loai hang: ");
            Console.WriteLine($"{"Ma loai hang",-15}{"Ten loai hang",-15}");
            foreach (var item in loaiHangs)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("An Enter de tiep tuc!");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
