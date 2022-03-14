
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


namespace baitap14322
{
        class Phanso
        {
            private int tu, mau;
            public Phanso()
            {
                tu = 0;
                mau = 1;
            }
            public Phanso(int t, int m)
            {
                tu = t;
                mau = m;
            }
            public void XuatPhanSo()
            {
                Console.WriteLine("{0}/{1}", tu, mau);
            }
            public Phanso CongPS(Phanso ps10)
            {
                int ts = tu * ps10.mau + mau * ps10.tu;
                int ms = mau * ps10.mau;
                Phanso ketqua = new Phanso(ts, ms);
                return (ketqua);
            }

            public Phanso TruPS(Phanso ps1)
            {
                int ts = tu * ps1.mau - mau * ps1.tu;
                int ms = mau * ps1.mau;
                Phanso ketqua = new Phanso(ts, ms);
                return (ketqua);
            }
            public Phanso NhanPS(Phanso ps1)
            {
                int ts = tu * ps1.tu;
                int ms = mau * ps1.mau;
                Phanso ketqua = new Phanso(ts, ms);
                return (ketqua);
            }
            public Phanso ChiaPS(Phanso ps1)
            {
                int ts = tu * ps1.mau;
                int ms = mau * ps1.tu;
                Phanso ketqua = new Phanso(ts, ms);
                return (ketqua);
            }
            public Phanso RutGon()
            {
                int ts = tu;
                int ms = mau;
                while (tu != mau)
                    if (tu > mau) tu = tu - mau;
                    else mau = mau - tu;
                ts = ts / tu; ms = ms / tu;
                Phanso ketqua = new Phanso(ts, ms);
                return (ketqua);
            }
        }
        class Program
        {
            static void Main(string[] args)
            {

                Phanso ps = new Phanso();
                Phanso ps1 = new Phanso(6, 2);
                Phanso ps2 = new Phanso(1, 2);
                Console.Write("Phan so thu nhat = "); ps1.XuatPhanSo();
                Console.Write("Phan so thu hai = "); ps2.XuatPhanSo();



                ps = ps1.CongPS(ps2);

                Console.Write("Tong cua hai phan so : ");
                ps.RutGon();
                ps.XuatPhanSo();

                ps = ps1.TruPS(ps2);
                Console.Write("Hieu cua hai phan so :");
                ps.XuatPhanSo();


                ps = ps1.NhanPS(ps2);
                Console.Write("Tich cua hai phan so :");
                ps.XuatPhanSo();

                ps = ps1.ChiaPS(ps2);
                Console.Write("Thuong cua hai phan so :");
                ps.XuatPhanSo();

                Console.WriteLine();
                Console.Write("Phan so can rut gon: ");
                ps1.XuatPhanSo();
                ps = ps1.RutGon();
                Console.Write("Phan so sau khi rut gon: ");
                ps.XuatPhanSo();
            }
        }
    }