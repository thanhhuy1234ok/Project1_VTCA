using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class NhanVien
    {
        protected string hoten;
        protected int namVL;
        protected static int LCB = 200000;

        protected string Hoten { get => hoten; set => hoten = value; }
        protected int NamVL { get => namVL; set => namVL = value; }

        public NhanVien()
        {
            this.Hoten = "";
            this.namVL = 0;
        }
        public NhanVien(string hoten, int namVL)
        {
            this.hoten = hoten;
            this.namVL = namVL;
        }

        public void NhapTT()
        {
            Console.WriteLine("Ho ten: ");
            this.hoten = Console.ReadLine();
            Console.WriteLine("Nam vao lam: ");
            this.namVL = int.Parse(Console.ReadLine());
        }

        public void XuatTT()
        {
            Console.Write("{0} - {1}", this.hoten, this.namVL);
        }
    }
}
