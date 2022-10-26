using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class NVQuanLy:NhanVien
    {
        private double hesoCV;
        private int thuong;

        public NVQuanLy() : base()
        {
            this.hesoCV = 1;
            this.thuong = 0;
        }

        public NVQuanLy(string hoten, int namVL, double hesoCV, int thuong)
            : base(hoten, namVL)
        {
            this.hesoCV = hesoCV;
            this.thuong = thuong;
        }

        public new void NhapTT()
        {
            base.NhapTT();
            Console.WriteLine("He so chuc vu:: ");
            this.hesoCV = double.Parse(Console.ReadLine());
            Console.WriteLine("Thuong: ");
            this.thuong = int.Parse(Console.ReadLine());
        }

        public new void XuatTT()
        {
            base.XuatTT();
            Console.WriteLine(" - {0} - {1}", this.hesoCV, this.thuong);
        }

        public double TinhLuong()
        {
            return NhanVien.LCB * this.hesoCV + this.thuong;
        }
    }
}
