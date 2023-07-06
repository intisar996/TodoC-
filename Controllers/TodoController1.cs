using Microsoft.AspNetCore.Mvc;
using TodoL.Data;
using TodoL.Models;


namespace TodoL.Controllers
{
    public class TodoController : Controller
    {

        private readonly ApplicationDbContent _db;
        public TodoController(ApplicationDbContent db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<TodoList> todosobj = _db.TodoLists.ToList();

            return View(todosobj);

        }

   
        [HttpPost]
        public IActionResult Index(TodoList obj)
        {
            _db.TodoLists.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult Update(int Id)
        {

            var todoobj = _db.TodoLists.FirstOrDefault(b => b.Id == Id);
            return View(todoobj);
        }
        [HttpPost]
        public IActionResult Update(TodoList obj)
        {

            _db.TodoLists.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int Id)
        {
            var todoobj = _db.TodoLists.FirstOrDefault(b => b.Id == Id);
            _db.TodoLists.Remove(todoobj);
            _db.SaveChanges();

            return RedirectToAction("Index");

        }

        
    }
}
