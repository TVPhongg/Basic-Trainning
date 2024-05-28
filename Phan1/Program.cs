
// C# là ngôn ngữ OOP, phất triển bởi MS

/* Kiểu dữ liệu trong c#
 * Tham trị : chứa trực tiếp giá trị của nó(bool, double, float, int, long, short, decimal)
 * Tham chiếu : lưu trữ địa chỉ nơi chứa giá trị của nó(class, interface, array, delegate)
*/



/* Const và Read-Only
 - Giống: kh thể thay đổi giá trị sau khi gán, ngăn chặn sự thay đổi giá trị sau khi đã được thiết lập
 - Khác:  
  + const: Giá trị phải được gán tại thời điểm khai báo và không thể thay đổi sau đó(complie - time)(int, float,.. )
  + read-only: Giá trị có thể được gán khi khai báo hoặc trong constructor của lớp(run-time)(kiểu dữ liệu phức tạp và đối tượng)
 */


//public const double Pi = 3.14159;
//private readonly IProduct _product;

/* 
 * Phương thức để chuyển đổi kiểu dữ liệu
 - Giống: đều chuyển đổi kiểu dữ liệu chuỗi sang kiểu dữ liệu cơ bản như int, double, float,..
 * Parse(): chuyển đổi và ném exception nếu chuỗi kh hợp lệ
 * TryParse(): chuyển đổi và trả kết quả true/false
 * Convert(): chuyển đổi kiểu dữ liệu
 
 - Khác: Parse phát sinh ngoại lệ / Convert: kh phát sinh ngoại lệ mà trả về giá trị mặc định nếu kh thể chuyển đổi 
 */

//string str = "10";
//int valueNum = Convert.ToInt32(str);
//Console.WriteLine(valueNum);

//int valueNum1 = int.Parse(str);
//Console.WriteLine(valueNum1.GetType());


/*
 Biến toàn cục và biến cục bộ
- biến toàn cục: được truy cập ở bất cứ đâu, 
- biến cục bộ: khai báo trong 1 phương thức hoặc khối mã
 */

//class MyClass
//{
//    public static int GlobalVariable = 10;

//    static void Main(string[] args)
//    {
//        Console.WriteLine(GlobalVariable); // In ra giá trị của biến toàn cục
//    }
//}

//class MyClass1
//{
//    static void Main(string[] args)
//    {
//        int localVariable = 20; // Biến cục bộ khai báo trong phương thức Main
//        Console.WriteLine(localVariable); // In ra giá trị của biến cục bộ
//    }
//}


/* Có 2 cách truyền tham số vào 1 phương thức??
 Kiểu tham trị và kiểu tham chiếu(Từ khóa ref và out)
 - kiểu tham chiếu: tham chiếu đến vùng nhớ của biến truyền vào phương thức. Các thay đổi ảnh hưởng đến giá trị gốc
 - kiểu tham trị: copy giá trị ban đầu vào để truyền vào phương thức. Giá trị ban đầu không thay đổ(int, float, double,..)
 - Ref : biến phải được khởi tạo trước khi truyền vào phương thức
 - Out: kh cần khởi tạo trước
 */

// ví dụ kiểu tham trị
//class Program
//{
//    static void ChangeValue(int x)
//    {
//        x = 20;
//    }

//    static void Main(string[] args)
//    {
//        int number = 10;
//        Console.WriteLine("Before method call: " + number); // Output: 10
//        ChangeValue(number);
//        Console.WriteLine("After method call: " + number); // Output: 10 (giá trị không thay đổi)
//    }
//}

//// ví dụ kiểu tham chiếu

//class Program1
//{
//    static void GetValue(out int x)
//    {
//        x = 20;
//    }

//    static void Main(string[] args)
//    {
//        int number;
//        GetValue(out number);
//        Console.WriteLine("Value assigned inside method: " + number); // Output: 20
//    }
//}

//class Program2
//{
//    static void ChangeValue(ref int x)
//    {
//        x = 20;
//    }

//    static void Main(string[] args)
//    {
//        int number = 10;
//        Console.WriteLine("Before method call: " + number); // Output: 10
//        ChangeValue(ref number);
//        Console.WriteLine("After method call: " + number); // Output: 20 (giá trị thay đổi)
//    }
//}

/* Vòng lặp for và foreach
 * for: lặp khối mã với điều kiện lặp, số lần nhất định / sử dụng khi bạn cần lặp qua một dãy có kích thước biết trước.
 * foreach: lặp qua các phần tử của 1 mảng / cần lặp qua tất cả các phần tử trong một tập hợp mà không quan tâm đến chỉ mục của từng phần tử.
 */

//int[] numbers = { 1, 2, 3, 4, 5 };

//for(int i = 0; i < numbers.Length; i++)
//    Console.WriteLine(i);

//foreach(int i in numbers)
//    Console.WriteLine(i);

/* Một số kiểu dữ liệu cơ bản:
 * Array : lưu trữ tập hợp các DL cùng kiểu DL , làm việc theo chỉ mục, kích thước mảng cố định
 * List : cho phép lưu trữ một tập hợp các phần tử cùng kiểu dữ liệu, có thể mở rộng
 * String: lưu trữ các ký tự Unicode
 * Nullable:+ có thể lưu trữ giá trị như int, float,..  hoặc giá trị null / int? address
            + một giá trị có thể trống hoặc không xác định, như trong các trường hợp khi lấy dữ liệu từ cơ sở dữ liệu mà giá trị có thể là null.
 * Stack:
 * Queue:
 * LinkedList:
 * 
 
 */
