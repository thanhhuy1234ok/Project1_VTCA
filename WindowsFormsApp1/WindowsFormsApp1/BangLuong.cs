using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class BangLuong
    {
        private string MaSo;
        private DateTime NgayTinhLuong = DateTime.Now;


        public string MaSo1 { get => MaSo; set => MaSo = value; }
        public DateTime NgayTinhLuong1 { get => NgayTinhLuong; set => NgayTinhLuong = value; }

        public BangLuong(string MaSo, DateTime NgayTinhLuong)
        {
            this.MaSo1 = MaSo;
            this.NgayTinhLuong1 = NgayTinhLuong;
        }

        public void ThemNV()
        {

        }

        public void XoaNV()
        {

        }
        
    }
}
