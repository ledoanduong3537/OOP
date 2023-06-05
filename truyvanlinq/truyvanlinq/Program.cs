using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace truyvanlinq
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var brands = new List<Brand>() {
                new Brand{ID = 1, Name = "Công ty AAA"},
                new Brand{ID = 2, Name = "Công ty BBB"},
                new Brand{ID = 4, Name = "Công ty CCC"},
                };
            var products = new List<Product>()
            {
                new Product(1, "Bàn trà",    400, new string[] {"Xám", "Xanh"},         2),
                new Product(2, "Tranh treo", 400, new string[] {"Vàng", "Xanh"},        1),
                new Product(3, "Đèn trùm",   500, new string[] {"Trắng"},               3),
                new Product(4, "Bàn học",    200, new string[] {"Trắng", "Xanh"},       1),
                new Product(5, "Túi da",     300, new string[] {"Đỏ", "Đen", "Vàng"},   2),
                new Product(6, "Giường ngủ", 500, new string[] {"Trắng"},               2),
                new Product(7, "Tủ áo",      600, new string[] {"Trắng"},               3),
            };


            /*
                HƯỚNG DẪN TRUY VẤN DỮ LIỆU LINQ
                b1: xác định nguồn dữ liệu : from tenphantu in IEnumerables (array, list, ....) .... where, orderby .... 
                b2: lấy dữ liệu: select, group by, ...
             */








            // lấy sản phẩm có giá 400
            //var query = from p in products 
            //            where p.Price == 400 
            //            select p;
            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //}



            // 1. SELECT 
            //var kq=  products.Select(
            //        (p) =>
            //        {
            //            return new
            //            {
            //                ten = p.Name,
            //                gia = p.Price
            //            };
            //        }
            //    );
            //foreach (var item in kq)
            //{
            //    Console.Write(item);
            //}


            // 2. WHERE
            //var kq = products.Where(
            //    (p) => {
            //        //return p.Name.Contains("tr");\
            //        //return p.Brand == 2;
            //        return p.Price >= 300 && p.Price <= 400;
            //    } 
            //    );
            //foreach (var item in kq)
            //{
            //    Console.WriteLine(item);
            //}


            // 3.SELECTMANY
            //var kq = products.SelectMany(
            //    (p) =>
            //    {
            //        return p.Colors;
            //    }
            //    );
            //foreach (var item in kq)
            //{
            //    Console.WriteLine(item);
            //}


            //4. Min, Max, sum, arverage
            //var kq = products.Where(p=>p.Price > 0).Max(p=>p.Price);
            //var kq = products.Where(p => p.Price % 2 == 0).Average(p=> p.Price);
            //Console.WriteLine((float)kq);
            //var kq= products.Sum(p=> p.Price);
            //Console.WriteLine(kq);

            // 5.JOIN;
            //cách 1:
            //var kq = products.Join(brands, p => p.Brand, b => b.ID, (p, b) =>
            //{
            //    return new
            //    {
            //        ten = p.Name,
            //    thuonghieu = b.Name
            //    };
            //}
            //);
            //foreach (var item in kq)
            //{
            //    Console.WriteLine(item);   
            //}

            // cách 2: 
            //var kq1 = from pr in products
            //          join br in brands
            //          on pr.Brand equals br.ID
            //          select new {
            //                name = pr.Name,
            //                thuonghieu = br.Name
            //    };
            //foreach (var item in kq1)
            //{
            //    Console.WriteLine(item);
            //}


            //6. group join
            //var grjoin = brands.GroupJoin(products,
            //    br => br.ID, 
            //    pr => pr.Brand,
            //    (br, pr) =>  
            //    {
            //        return new
            //        {
            //            thuonghieu = br.Name,
            //           sanpham = pr
            //        };
            //    }
            //    );
            //foreach (var item in grjoin)
            //{
            //    Console.WriteLine(item.thuonghieu);
            //    foreach (var item1 in item.sanpham)
            //    {
            //        Console.WriteLine(item1);
            //    }
            //}


            //7. TAKE
            //products.Take(4).ToList().ForEach(p => Console.WriteLine(p));


            // 8.SKIP
            //products.Skip(2).ToList().ForEach((p) => Console.WriteLine(p));


            // 9. orderby / orderby descending
            //products.OrderByDescending(p=>p.Price).ToList().ForEach(p=> Console.WriteLine(p));

            //10.groupby
            //var kq =  products.GroupBy(p => p.Brand);
            // foreach (var item in kq)
            // {
            //     Console.WriteLine(item.Key);
            //     foreach (var p in item)
            //     {
            //         Console.WriteLine(p);
            //     }
            // }

            // 11. distinct
            //products.SelectMany(p=> p.Colors).Distinct().ToList().ForEach(mau => Console.WriteLine(mau));

            //12. singe
            //var p1 = products.Single(p => p.Price == 400);
            //Console.WriteLine(p1);

            // 13. ANY, ALL
            //var m = products.Any(p => p.Price == 600);
            //Console.WriteLine(m);   
            //var m1 = products.All(p=> p.Price >= 200);
            //Console.WriteLine(m1);

            // 14. COUNT
            //var m = products.Count(p=>p.Price>400);
            //Console.WriteLine(m);

            // vidu 1: in ra tên sản phẩm, tên thương hiệu có giá từ 300 ~ 400, sắp xếp giảm dần
            //var m = products.Where(p => p.Price >= 300 && p.Price <= 400)
            //    .OrderByDescending(p => p.Price)
            //    .Join(brands, p => p.Brand, b => b.ID, (sp, th) =>
            //    {
            //        return new
            //        {
            //            tensp = sp.Name,
            //            thuonghieu = th.Name,
            //            gia = sp.Price
            //        };
            //    });
            //foreach (var item in m)
            //{
            //    Console.WriteLine($"{item.tensp, 15} {item.thuonghieu, 30} {item.gia, 20}");
            //}

            //vidu2: lấy ra tên sản phẩm và giá: 
            //var qr = from s in products select $"{s.Name} : {s.Price}";
            //foreach (var item in qr)
            //{
            //    Console.WriteLine(item);
            //}


            //vidu3: lấy ra sản phẩm có giá < 500 và màu sắc
            //var qr = from sp in products
            //         from br in sp.Colors
            //         where sp.Price < 500 && br == "Xanh"
            //         orderby sp.Price descending
            //         select new
            //         {
            //             ten  = sp.Name,
            //             gia = sp.Price,
            //             mau = sp.Colors
            //         };
            //qr.ToList().ForEach(
            //    a => {
            //        Console.WriteLine($"{a.ten} - {a.gia} {string.Join(",", a.mau)}");
            //    }
            //    ); 


            //vidu4: nhóm sản phẩm theo giá(<400) tăng dần
            // cách 1:
            //var qr = from p in products
            //         where p.Price < 400
            //         orderby p.Price
            //         group p by p.Price;
            // cách 2:
            //var qr = from p in products
            //         where p.Price < 400
            //         group p by p.Price into gr
            //         orderby gr.Key
            //         select gr;
            //         
            //foreach (var item in qr)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine(item1);
            //    }
            //}

            // vidu5: truy vấn trả về các đối tượng
            //var qr = from p in products
            //         where p.Price < 500
            //         group p by p.Price into gr
            //         orderby gr.Key
            //         let sl = "Số lượng là: "+ gr.Count()
            //         select new
            //         {
            //             gia = gr.Key,
            //             cacsanpham = gr.ToList(),
            //             soluong= sl
            //         };
            //foreach (var item in qr)
            //{
            //    Console.WriteLine(item.gia);
            //    Console.WriteLine(item.soluong);
            //    foreach (var item1 in item.cacsanpham)
            //    {
            //        Console.WriteLine(item1);
            //    }
            //}

            //vidu6: liệt kê ra tên sp,hãng sx và giá
            //var qr = from p in products
            //         join b in brands on p.Brand equals b.ID
            //         select new
            //         {
            //             ten = p.Name,
            //             gia = p.Price,
            //             thuonghieu = b.Name
            //         };

            var qr = from p in products
                     join b in brands on p.Brand equals b.ID into m
                     from t in m.DefaultIfEmpty()
                     select new
                     {
                         ten = p.Name,
                         gia = p.Price,
                         thuonghieu =(t!= null) ? t.Name:"không có giá trị"
                     };


            foreach (var item in qr)
            {
                Console.WriteLine($"{item.ten} {item.gia} {item.thuonghieu}");
            }
        }
    }
}
