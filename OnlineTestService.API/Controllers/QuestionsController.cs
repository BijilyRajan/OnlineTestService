using Microsoft.AspNetCore.Mvc;
using OnlineTestService.API.Models;

namespace OnlineTestService.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuestionsController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<QuestionsController> _logger;

        public QuestionsController(ILogger<QuestionsController> logger)
        {
            _logger = logger;
        }

        //[HttpGet(Name = "GetQuestion")]
        //public IEnumerable<Question> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new Question
        //    {
        //        id = index,
        //        Description = "Question " + index,
        //        Answer = "Answer " + index
        //    })
        //    .ToArray();
        //}

        //[HttpGet(Name = "GetQuestions")]
        //public JsonResult GetQuestions()
        //{
        //    return new JsonResult(
        //        new List<object> { 
        //            new { id = 1, name = "Test 1" },
        //            new { id = 2, name = "Test 2" }
        //        });
        //}


        [HttpGet(Name = "GetQuestions")]
        public JsonResult GetQuestions()
        {
            return new JsonResult(QuestionDataStore.Current);
        }


    }
}