using AnalyzeText.Lib;
using Microsoft.AspNetCore.Mvc;

namespace AnalyzeTextWebApp.Controllers
{
    public class TextController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EmotionTest()
        {
            string text = Request.Form["usertext"];
            Emotion emotionText = new Emotion();
            ViewBag.usertext = emotionText.IsEmotion(text);

            return View();
        }
    }
}
