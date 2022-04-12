using OnlineTestService.API.Models;

namespace OnlineTestService.API
{
    public class QuestionDataStore
    {
        //replace with DI later
        public static QuestionDataStore Current { get; } = new QuestionDataStore();
        public QuestionDataStore()
        {
            QuestionName = "handsetCards";
            questions =  new List<Question>(){  

            new Question() { title = "Question 1", content = "Which of the following is the correct ways to set a value 3.14 in a variable pi such that it cannot be modified?", choices = new List<string> { "pi = 3.14F", "const float pi", "float pi = 3.14F" } , cols = 1, rows = 1  },
            new Question() { title = "Question 1", content = "Which is a software language", choices = new List<string> { "Agile", "C++", "Eclipse" } , cols = 1, rows = 1  }

            };
        }

        public List<Question> questions { get; set; }

        public string QuestionName { get; set; }

    }
}
