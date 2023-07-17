using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21880159
{
    public class Entities
    {
        public struct MatHang
        {
            public string maHang { get; set; }
            public string tenHang { get; set; }
            public int hanDung { get; set; }
            public string congTySanXuat { get; set; }
            public DateTime namSanXuat { get; set; }
            public string maLoaiHang { get; set; }

            public MatHang(string maHang, string tenHang, int hanDung, string congTySanXuat, DateTime namSanXuat, string maLoaiHang)
            {
                this.maHang = maHang;
                this.tenHang = tenHang;
                this.hanDung = hanDung;
                this.congTySanXuat = congTySanXuat;
                this.namSanXuat = namSanXuat;
                this.maLoaiHang = maLoaiHang;
            }
            public override string ToString()
            {
                return $"{maHang,-15}{tenHang,-15}{hanDung,-15}{congTySanXuat,-15}{namSanXuat.Day,-2}/{namSanXuat.Month,-2}/{namSanXuat.Year,-9}{maLoaiHang,-15}";
            }
        }
        public struct LoaiHang
        {
            public string maLoaiHang { get; set; }
            public string tenLoaiHang { get; set; }

            public LoaiHang(string maLoaiHang, string tenLoaiHang)
            {
                this.maLoaiHang = maLoaiHang;
                this.tenLoaiHang = tenLoaiHang;
            }

            public override string ToString()
            {
                return $"{maLoaiHang,-15}{tenLoaiHang,-15}";
            }
        }
    }
}
