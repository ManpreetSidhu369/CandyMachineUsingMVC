using Example.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace Example.Controllers
{
    public class CandyController : Controller
    {
        //private List<Candy> candies;
        //public CandyController()
        //{
        //    candies = new List<Candy>
        //    {
        //        new Candy
        //        {
        //            Name = "Gummies",
        //            Weight = 1,
        //            Price = 2,
                 
        //            IsCheck = false

        //        },
        //         new Candy
        //        {
        //            Name = "Pops",
        //            Weight = 1,
        //            Price = 2,
        //            IsCheck=false

        //        },
        //          new Candy
        //        {
        //            Name = "ChewGum",
        //            Weight = 1,
        //            Price = 2,
        //            IsCheck = false

        //        },
        //           new Candy
        //        {
        //            Name = "Smarties",
        //            Weight = 1,
        //            Price = 2,
        //            IsCheck = false

        //        }
        //    };
            


       // }




        public IActionResult Candies()
        {
            List<Candy> cands = new List<Candy>();
            cands.Add(new Candy() { Name = "Gummies", Weight = 1.2, Price = 2, IsCheck = false });
            cands.Add(new Candy() { Name = "Smarties", Weight = 1.3, Price = 2.5, IsCheck = false });
            cands.Add(new Candy() { Name = "Choco", Weight = 1.1, Price = 2.2, IsCheck = false });
            cands.Add(new Candy() { Name = "Pops", Weight = 1.0, Price = 2.0, IsCheck = false });
            CandyList candyList = new CandyList();
            candyList.can = cands;
            return View(candyList);
        }
        [HttpPost]
        public IActionResult Candies(CandyList cl)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in cl.can)
            {
                if (item.IsCheck)
                {
                     sb.Append(item.Name +","); 
                    
                }
                
                
            }
            ViewBag.selectCandy = "Selected candies  to be dispensed is/are " + sb.ToString();
            return View(cl);
        }
        
        
    }
    
}
