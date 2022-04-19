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

            new Question() { title = "Question 1", content = "Which of the following is the correct ways to set a value 3.14 in a variable pi such that it cannot be modified?", choices = new List<string> { "float pi = 3.14F", "const float pi = 3.14F", "const float pi; pi = 3.14F", "pi = 3.14F" } , cols = 1, rows = 1  },
            new Question() { title = "Question 2", content = "Which is a software language", choices = new List<string> { "Agile", "C++", "Eclipse", "Azure" } , cols = 1, rows = 1  },
            new Question() { title = "Question 3", content = "Which is not a feature of OOP in general definitions", choices = new List<string> { "Efficient Code", "Code reusability", "Modularity", "Redundant data" } , cols = 1, rows = 1  },
            new Question() { title = "Question 4", content = "Which among the following is correct?", choices = new List<string> { "void test(int x=0, int y, int z=0)", "void test(int x=0, int=0)", "void test(int x, int y=0)", "void test(int x=’c, int y)" } , cols = 1, rows = 1  },
            new Question() { title = "Question 5", content = "In C# String is a value type", choices = new List<string> { "True", "False" } , cols = 1, rows = 1  }

            };
        }

        public List<Question> questions { get; set; }

        public string QuestionName { get; set; }

    }
}
