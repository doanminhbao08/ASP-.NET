using Microsoft.AspNetCore.Mvc;
using MyApp.Models;

namespace MyApp.Controllers
{
    public class ItemsssController : Controller
    {
        public IActionResult Overview(){
            var item2 = new Item1() { Name = "keyboard" };
            var item4 = new Item1() { Name = "laptop" };
            return View(item4);
        }

        public ContentResult Overview1() {
            return Content("Hello this is Overview1");
        }

        public IActionResult Edit(int Itemid){
            return Content("id=" + Itemid); // Trả ra text
        } // Để ra được content này thì cần Itemsss/Edit/2 (chỉ work nếu tên var là id)
          // or Itemsss/Edit?Itemid=2
    }

    public class BaoController : Controller{
        public IActionResult Ankem()
        {
            var item5 = new Item1() { Name = "Bingchiling" };
            return View(item5);
        }
    }
}

// Đây là controller sẽ tạo các hàm để xử lý rồi đưa ra view

// Cái hàm là Overview và return View, thì ở Views phải có một file là Overview để nó display
// IActionResult trả ra view của cái item

// View của Overview sẽ nằm trong một file ở thu mục Views và có tên file trùng tên hàm

// Điều tiên điều sang Cotroller qua URL bằng tên Controller: Itemsss (Toàn bộ phần
// đứng trước chữ Controller)

// Để tạo View thì cần tạo 1 folder cùng tên với controller và sau đó tạo file view trùng
// tên với hàm trong controller đó.