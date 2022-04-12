namespace OnlineTestService.API.Models
{
    public class Question
    {

        public string title { get; set; }
        public string content { get; set; }
        public List<string> choices { get; set; }
        public int cols { get; set; }
        public int rows { get; set; }


    }

}
