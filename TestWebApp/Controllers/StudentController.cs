using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using TestWebApp.DBContexts;
using System.Data.Entity.Migrations;

namespace TestWebApp.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            using (TestDatabaseDBContext db = new TestDatabaseDBContext())
            {               
                List<Student> students = db.Students.ToList();
                return View(students);
            }
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            using (TestDatabaseDBContext db = new TestDatabaseDBContext())
            {
                Student student = db.Students.FirstOrDefault(x => x.Id == id);
                return View(student);
            }
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            Student student = new Student();
            return View(student);
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(Student student)
        {
            try
            {
                using (TestDatabaseDBContext db = new TestDatabaseDBContext())
                {
                    student = db.Students.Add(student);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            using (TestDatabaseDBContext db = new TestDatabaseDBContext())
            {
                Student student = db.Students.FirstOrDefault(x => x.Id == id);
                return View(student);
            }
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Student student)
        {
            try
            {
                // TODO: Add update logic here
                using (TestDatabaseDBContext db = new TestDatabaseDBContext())
                {
                    db.Students.AddOrUpdate(student);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            using (TestDatabaseDBContext db = new TestDatabaseDBContext())
            {
                Student student = db.Students.FirstOrDefault(x => x.Id == id);
                return View(student);
            }
        }

        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Student student)
        {
            try
            {
                using (TestDatabaseDBContext db = new TestDatabaseDBContext())
                {
                    db.Students.Remove(db.Students.FirstOrDefault(x => x.Id == id));
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
