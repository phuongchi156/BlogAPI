using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Linq.Expressions;

namespace ConsoleApp1.BaiTapQuanLySanPham;

public class Bai2
{
    public List<SanPham> products = new List<SanPham>();
    public void Main()
    {

        Console.WriteLine("1: Thêm sản phẩm\n 2: tìm sản phẩm\n 3: Xóa sản phẩm\n4: cập nhật giá sản phẩm\n5:In danh sách sản phẩm");
        int a = int.Parse(Console.ReadLine());
        switch (a)
        {
            case 1:
                CreatePro(products);
                // code block
                break;
            case 2:
                int ma = 0;
                Console.WriteLine("Ban muon tim theo ten(1) hay theo ma (2)?");
                int f = int.Parse(Console.ReadLine());
                if (f == 1)
                {
                    Console.WriteLine("Moi nhap ten");
                    string name = Console.ReadLine();
                    TimKiem(0, name);
                }
                else
                {
                    Console.WriteLine("Moi nhap ma");
                    ma = int.Parse(Console.ReadLine());
                    TimKiem(ma, "");
                }
                break;
            case 3:
                break;
            case 4:
                break;
            default:
                // code block
                break;
        }


    }

    public void CreatePro(List<SanPham> product)
    {
        Console.WriteLine("Nhap so san pham ban muon them");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var sanpham = new SanPham();
            Console.WriteLine("Nhap ma sp");
            sanpham.Ma = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ten sp");
            sanpham.Name = Console.ReadLine();
            Console.WriteLine("Nhap gia");
            sanpham.Price = double.Parse(Console.ReadLine());
            product.Add(sanpham);
        }
    }

    public SanPham TimKiem(int ma, string name)
    {
        if (ma != 0)
        {
            return products.Where(a => a.Ma == ma).First();
        }

        return products.Where(a => a.Name == name).First();
    }
}