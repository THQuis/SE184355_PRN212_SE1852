using System.Text;
using System.Threading.Channels;
using DemoMyStoreLINQ2SQL;

Console.OutputEncoding = Encoding.UTF8;

string connectionString = "Server=localhost;database=MyStore;uid=sa;pwd=12345";

MyStoreDataContext context = new MyStoreDataContext(connectionString);

// Cau1 : Dungf LINQ2SQL ddeer laays toan bo danh muc
var categories = context.Categories;
foreach (var cate in categories)
{
    Console.WriteLine(cate.CategoryID + "\t" + cate.CategoryName);
}

//Caau 2
//timf chi tiet danh muc khi biet CategoryId
int cateId = 5;

Category category = context.Categories.FirstOrDefault(c => c.CategoryID == cateId);
if (category == null)
{
    Console.WriteLine("ko tìm thấy danh mục có mã.");
}
else
{
    Console.WriteLine($"Tìm thấy danh mục có mã = {cateId}, chi tiết.");
    Console.WriteLine(category.CategoryID + "\t" + category.CategoryName);
}

////Câu 3 hteem mới 1 danh mục
//Category cnew = new Category();
//cnew.CategoryName = "hách nôi";
//context.Categories.InsertOnSubmit(cnew);
//context.SubmitChanges();

//// Câu 4 thêm mới nhiều danh mục
//List<Category> dsdm_new = new List<Category>();
//dsdm_new.Add(new Category() { CategoryName = "laptop" });
//dsdm_new.Add(new Category() { CategoryName = "TV" });
//dsdm_new.Add(new Category() { CategoryName = "Phụ kiện" });
//context.Categories.InsertAllOnSubmit(dsdm_new);
//context.SubmitChanges();

//Câu 5 sửa tên danh mục
//Nguyene tắc: Phải tìm truocws =>  tìm thấy mới sửa

Category c = (from x in context.Categories
              where x.CategoryID == 10
              select x).FirstOrDefault();

Category c2 = context.Categories.FirstOrDefault(x => x.CategoryID == 10);
if (c2 != null)
{
    c2.CategoryName = "Hôi nách";
    context.SubmitChanges();
}

//Câu 6 : tìm thấy danh mục rùi xóa

Category c3 = context.Categories.FirstOrDefault(x => x.CategoryID == 13);
if (c3 != null)
{
    context.Categories.DeleteOnSubmit(c3);
    context.SubmitChanges();
}

// Caua 7: xóa tất cả doanh mục mà không chứa bất kì sản phẩm nào

var c4 = context.Categories.Where(x => !x.Products.Any()).ToList();

if (c4 != null)
{
    context.Categories.DeleteAllOnSubmit(c4);
    context.SubmitChanges();
    Console.WriteLine($"Đã xóa {c4.Count} danh mục không có sản phẩm.");
}
else
{
    Console.WriteLine("Không có danh mục nào để xóa.");
}