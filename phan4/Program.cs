
//var numbers = new List<int> { 1,8,0,9,3,2};


////from: lấy data sources
////where: điều kiện lọc filter
////oderby ascending / descending : sắp xếp
//// select: lấy kết quả
//var result = from num in numbers
//             where num % 2 == 0 
//             orderby num ascending
//             select num;    

//foreach (var num in result)
//    Console.WriteLine(num);


//// Method Syntax sử dụng hàm hỗ trợ linq của .net

//var result1 = numbers.Where(x => x % 2 == 0).Select(x => x);

//foreach (var num in result1) Console.WriteLine(num);

////lambda expressions được dùng để tạo ra một function ẩn danh
////productId => productId % 2 == 0 (productId: tham số đầu vào)

//var products = new List<Product>
//{
//    new Product { Id = 1, Name = "Phong"},
//    new Product { Id = 2, Name = "Ha"},
//    new Product { Id = 3, Name = "Ly"},

//};

//var producName = products.Where(x => x.Name == "Phong").Select(x => x.Id);
//foreach (var product in producName)
//    Console.WriteLine(product);

//// tạo ra 1 object mới select

//var studentCreate = products.Where(x => x.Id == 2)
//    .Select(product => new Product { Id =  product.Id, Name = product.Name });

//foreach(var product in studentCreate) Console.WriteLine(product.Name);


//public class Product
//{
//    public int Id { get; set; }
//    public string Name { get; set; }

//}

using System.Linq;
using System.Security.Cryptography.X509Certificates;

var products = new List<Product>
{
    new Product { Id = 1, Name = "My", Color = "red", Mark = 30},
    new Product { Id = 2, Name = "Com", Color = "white", Mark = 50 },
    new Product { Id = 3, Name = "Pho", Color = "yellow", Mark = 10},
    new Product { Id = 4, Name = "Lua", Color = "pink", Mark = 40 },
};


var joinResult = string.Join(" , ", products.Select(p => p.Name));
Console.WriteLine(joinResult);

//var allTest = products.All(x => x.Mark < 35);
//Console.WriteLine(allTest);

//var anyTest = products.Any(x => x.Mark > 55);
//Console.WriteLine(anyTest);

//OrderBy, Join, Contains, Max, Min, Count, Sum, Union, Skip, Take, Group…

// hàm Skip(), SkipLast(), SkipWhile và hàm Take()
// hàm skip(bỏ qua số lượng phần tử) , hàm skipLast(bỏ qua số lượng phần tử cuối)
// hàm take(lấy số lượng phần tử), hàm takeLast(lấy số lượng phần từ cuối)
// hàm Max(), hàm Min()
//var maxResult = products.Max(p => p.Mark);
//Console.WriteLine(maxResult);

//var skipResult1 = products.Skip(3);
//foreach (var product in skipResult1)
//{
//    Console.WriteLine(product.Name);
//}

// hàm count(): đếm
//var countResult = products.Count();
//Console.WriteLine(countResult);

//hàm contains : kiểm tra sự tồn tại

//string name1 = "My";
//var containerResult = products.Contains();
//Console.WriteLine(containerResult);



//var firstTest = products.Where
// sử dụng All, Any : return kiểu bool
// All: kiểm tra xem tất cả các phần tử trong một tập hợp có thỏa mãn một điều kiện nào đó hay không
// Any: kiểm tra xem có ít nhất một phần tử trong tập hợp thỏa mãn một điều kiện nào đó hay không.
// Nó trả về true nếu có ít nhất một phần tử thỏa mãn điều kiện, ngược lại trả về false.
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
    public double Mark { get; set; }
}




