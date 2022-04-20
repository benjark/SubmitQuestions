using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FinalPractice.Models;

namespace FinalPractice.Controllers
{
    public class HomeController : Controller
    {
        private QuestionContext context { get; set; }

        public HomeController(QuestionContext temp)
        {
            context = temp;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
       
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(StudentQuestion sq)
        {
            context.Add(sq);
            context.SaveChanges();

            return RedirectToAction("QuestionList");
        }
        [HttpGet]
        public IActionResult QuestionList (StudentQuestion sq)
        {
            var questions = context.Questions
            .OrderBy(x => x.StudentFirstName)
            .ToList();
            return View(questions);
        }
        [HttpGet]
        public IActionResult Edit (int questionid)
        {
            var question = context.Questions.Single(q => q.QuestionID == questionid);
            return View("Add", question);
        }
        [HttpPost]
        public IActionResult Edit (StudentQuestion sq)
        {
            context.Update(sq);
            context.SaveChanges();
            return RedirectToAction("QuestionList");
        }
        [HttpGet]
        public IActionResult Delete (int questionid)
        {
            var question = context.Questions.Single(q => q.QuestionID == questionid);
            return View(question);
        }
        [HttpPost]
        public IActionResult Delete(StudentQuestion s)
        {
            context.Questions.Remove(s);
            context.SaveChanges();
            return RedirectToAction("QuestionList");
        }
    }
}
