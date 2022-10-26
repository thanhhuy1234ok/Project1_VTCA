using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class NVSanXuat : NhanVien
    {
        private int soSP;

        public int SoSP { get => soSP; set => soSP = value; }

        public NVSanXuat() : base()
        {
            this.SoSP = 0;
        }

        public NVSanXuat(string hoten, int namVL, int soSP)
            : base(hoten, namVL)
        {
            this.SoSP = soSP;
        }

        public new void NhapTT()
        {
            // gọi phương thức NhapTT() của lớp NhanVien
            // để nhập hoten và namVL
            base.NhapTT();
            // nhập thêm thông tin riêng của nhân viên sản phẩm : bao gồm số sản phẩm
            Console.WriteLine("So san pham lam duoc: ");
            this.SoSP = int.Parse(Console.ReadLine());
        }

        public new void XuatTT()
        {
            base.XuatTT();
            Console.WriteLine(" - {0}n", this.SoSP);
        }

        public double TinhLuong()
        {
            return NhanVien.LCB + this.SoSP * 2000;
        }
    }
}
