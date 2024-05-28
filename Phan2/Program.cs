/*
 OOP? hướng đối tượng, lấy objet làm trung tâm
 */

/*
 Class : bản thiết kế cho các đối tượng(định nghĩa phương thức và hành động)
 Object: là thể hiện cụ thể của class, có trạng thái và hành vi riêng
 Property: mô tả trạng thái và đặc điểm của đối tượng
 Methods: mô tả hành vi đối tượng.
 Hàm khởi tạo: khởi tạo đối tượng của lớp, trùng với tên của lớp, có thể có hoặc kh có tham số truyền vào.
 get: trả về giá trị / set: gán giá trị.
 4 tính chất OOP: kế thừa, đóng gói, đa hình, trừu tượng
   - đóng gói : thể hiện qua access Modifiers cho lớp và thuộc tính (public, private, internal, protected).
   - kế thừa: các lớp con kế thừa thuộc tính và pthuc class cha -> tránh lặp lại code
   - đa hình:  các lớp khác nhau có thể hiểu cùng 1 thông điệp theo những cách kahcs nhau(override và overload)
   - trừu tượng: tập trung vào mức độ chung nhất mà không quan tâm đến chi tiết, thể hiện qua abstract class và interface
     (Lớp Shape đại diện cho các loại hình dạng khác nhau như tròn, vuông,..., kh chỉ rõ chi tiết từng hình dạng,
      chỉ định thuộc tính và pthuc chung ví dụ như tính chu vi, diện tích,... )
   - Sự khác nhau giữa abstract class và interface
      abstract class: lớp chung cho các lớp khác kế thừa / có thể chứa pthuc ảo và pthuc bth / chỉ có thể kế thừa 1 abstract class
      interface: định nghĩa các pthuc, không có thực thi bên trong nó/ tất cả đều là abstract / khi implement thì nó sẽ implement các pthuc đã định nghĩa trong interface
      ví dụ: xây dựng tính năng, chức năng của đối tượng(thêm, sửa, xóa,...) -> interface
             xây dựng 1 lớp có tính năng chung cho các đối tượng khác nhau -> có thể có pthuc bth và có pthuc abstract
   - sự khác nhau giữa override và overload:
            + override: xra 2 lớp kế thừa nhau, cùng tham số, dữ liệu trả về, xra lúc runtime
            + overload: xra cùng 1 lớp, khác tham số, số lượng và kiểu dữ liệu trả về, xra lúc compile time
        
 */

// lớp Animal


//Dog dog = new Dog();

//Animal dog = new Dog();
//Animal cat = new Cat();
//dog.Speak();
//cat.Speak();



// sử dụng interface
//public interface IAnimal
//{
//    public void Run();
//}
//public abstract class Animal : IAnimal
//{
//    //properties
//    public string Name { get; set; }

//    // sử dụng private -> lớp con không thể truy cập thuộc tính này
//    private int Age { get; set; }
//    public string Color { get; set; }

//    // constructor khởi tạo đối tượng
//    public Animal()
//    {

//    }

//    // phương thức
//    // sử dụng virtual
//    public virtual void Speak()
//    {
//        Console.WriteLine("Animal is speaking....");
//    }

//    public void Run()
//    {
//        throw new NotImplementedException();
//    }
//}


//// class Dog kế thừa class cha là animal
//public class Dog : Animal
//{
//    public Dog()
//    {

//    }

//    // sử dụng override
//    public override void Speak()
//    {
//        Console.WriteLine("Dog is speaking...");
//    }
//}

////class Cat kế thừa class cha là animal
//public class Cat : Animal
//{
//    public Cat()
//    {

//    }

//    public override void Speak()
//    {
//        Console.WriteLine("Cat is speaking...");
//    }
//}


//Rectangle rtg = new Rectangle(3, 4);
//public abstract class Shape
//{
//    public abstract double CalculateArea();

//}

//public interface IDrawable
//{
//    void Draw();
//}

//public class Rectangle : Shape, IDrawable
//{
//    private double width { get;set; }
//    private double height { get;set; }
        
//    public Rectangle( double _width, double _height)
//    {
//        _width = width;
//        _height = height;   
//    }
//    public override double CalculateArea()
//    {
//        return width * height;
//    }

//    public void Draw()
//    {
//        Console.WriteLine("Drawing a rectangle");
//    }
//}