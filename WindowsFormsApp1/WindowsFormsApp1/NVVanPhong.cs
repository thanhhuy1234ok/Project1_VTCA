using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
     public class NVVanPhong : NhanVien
    {
        private int songayLV;
        private int trocap;

        public int SongayLV { get => songayLV; set => songayLV = value; }
        public int Trocap { get => trocap; set => trocap = value; }

        public NVVanPhong() : base()
        {
            this.SongayLV = 20;
            this.Trocap = 1000000;
        }

        public NVVanPhong(string hoten, int namVL, int songayLV, int trocap)
            : base(hoten, namVL)
        {
            this.SongayLV = songayLV;
            this.Trocap = trocap;
        }

        public new void NhapTT()
        {
            // gọi phương thức NhapTT() của lớp NhanVien
            // để nhập hoten và namVL
            base.NhapTT();
            // nhập thêm thông tin riêng của nhân viên văn phòng
            Console.WriteLine("So ngay lam viec: ");
            this.SongayLV = int.Parse(Console.ReadLine());
            Console.WriteLine("Tro cap: ");
            this.Trocap = int.Parse(Console.ReadLine());
        }

        public new void XuatTT()
        {
            base.XuatTT();
            Console.WriteLine(" - {0} - {1}", this.SongayLV, this.Trocap);
        }

        public double TinhLuong()
        {
            return NhanVien.LCB + this.SongayLV * 100000 + this.Trocap;
        }
    }
}
