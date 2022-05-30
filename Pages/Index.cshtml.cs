using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Armandt_Sieberhagen_SEESA_APP.Pages
{
    public class IndexModel : PageModel
    {
        public string[] CollectionOfWords = new string[100];
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            
            for (int i = 1; i < 101; i++)
            {
                //creates a small function that takes in a multiple and returns a bool
                bool isImultipleOf(int multiple) => i % multiple == 0  ? true : false;
                bool multpleOfFive = isImultipleOf(5);
                bool multpleOfThree = isImultipleOf(3);
                CollectionOfWords[i-1] = ConvertNumIntoFizzBuzz(i, multpleOfFive, multpleOfThree);
            }
        }

        //logic behind converting the i into a FizzBuzz Value
        string ConvertNumIntoFizzBuzz(int num,bool multpleOfFive, bool multpleOfThree)
        {
            string returnedValue = "";
            if (multpleOfFive && multpleOfThree) returnedValue = "FizzBuzz";
            else if (multpleOfThree) returnedValue = "Fizz";
            else if (multpleOfFive ) returnedValue = "Buzz";
            else returnedValue = num.ToString();
            return returnedValue;
        }
    }
}