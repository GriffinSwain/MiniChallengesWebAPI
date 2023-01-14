//Griffin Parker
//January 13, 2023
//All For One Sprint - endpoints code
//This program is half of the code for the All For One Sprint. It contains the code uploaded to an azure 
//website that will be called upon by the other half of the code.

/* How to call the different programs cheatsheet
https://griffinminichapi.azurewebsites.net/minichallenge/SayHello/{name}
https://griffinminichapi.azurewebsites.net/minichallenge/AddingNumbers/{num1}/{num2}
https://griffinminichapi.azurewebsites.net/minichallenge/AskingQuestions/{name}/{time}
https://griffinminichapi.azurewebsites.net/minichallenge/GreaterOrLess/{num1}/{num2}
https://griffinminichapi.azurewebsites.net/minichallenge/MadLibs/{exclamation}/{name}/{adjest}/{animal}/{bodypart}/{verb}/{character}/{adjective}/{noise}/{verbs}
https://griffinminichapi.azurewebsites.net/minichallenge/OddOrEven/{number}
https://griffinminichapi.azurewebsites.net/minichallenge/ReverseIt/{string}
https://griffinminichapi.azurewebsites.net/minichallenge/RestaurantPicker/{"good", "bad" or "decent"}
https://griffinminichapi.azurewebsites.net/minichallenge/Magic8Ball
*/
using Microsoft.AspNetCore.Mvc;

namespace MiniChallengesWebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class MiniChallengeController : ControllerBase
{
    [HttpGet]
    [Route("SayHello/{name}")]
    public string SayHello(string name)
    {
        return $"Welcome {name}...";
    }

    [HttpGet]
    [Route("AddingNumbers/{number1}/{number2}")]
    public int Add2Numbers(int number1, int number2)
    {
        return number1 + number2;
    } 

    [HttpGet]
    [Route("AskingQuestions/{nombre}/{time}")]
    public string Questions(string nombre, string time)
    {
        return $"You are {nombre} and you woke up at {time}!";
    }

    [HttpGet]
    [Route("GreaterOrLess/{num1}/{num2}")]
    public string GreaterLess(int num1, int num2)
    {
    if (num1 > num2) return (num1 + " is greater than "+ num2);
    if (num1 < num2) return (num1 + " is lesser than " + num2);
    if (num1 == num2) return (num1 + " is equal to " + num2);
    return "Cool";
    }

    [HttpGet]
    [Route("MadLibs/{exclamation}/{name}/{adjest}/{animal}/{bodypart}/{verb}/{character}/{adjective}/{noise}/{verbs}")]
    public string MadLibs(string exclamation, string name, string adjest, string animal, string bodypart, string verb, string character, string adjective, string noise, string verbs)
    {
        return $"{exclamation}!! You've been sent to the principal's office!! You've never seen them yourself, but your best friend {name} says that they're the {adjest} principal in the whole world!! You didn't think that dropping a live {animal} into Billy Hinger's pants was going to cause all this trouble... how would you have known that it was going to bite clean through his {bodypart}? On your way through the halls, you stop at the bathroom, {verb} some cold water on your face and say a quick prayer to {character} to help you get through this trying time... You've arrived at the principals office and the office lady is staring at you with a {adjective} look on her face the whole time you're waiting. Finally, the door swings open seemingly on its own, and a {noise} {verbs} out at you from the inky blackness beyond. You tremulously take a few steps in to the black void of the office when the lights flicker on. You can't believe your eyes... {character} is behind the desk! They kick their feet up, chuckle to themselves, and look at you with a grin on their face 'So what's all this I hear about a {animal} and Billy Hinger's {bodypart}?'";
    }

    [HttpGet]
    [Route("OddOrEven/{number}")]
    public string OddOrEven(int number)
    {
    if(number % 2 == 0)
    {return $"{number} is an even number";
    }else return $"{number} is an odd number";
    }

    [HttpGet]
    [Route("ReverseIt/{input}")]
    public string ReverseIt(string input)
    {
    string reverse = ""; 
    for(int i = input.Length - 1; i >= 0; i--) reverse = reverse + input[i];
    return $"A voice answers back '{reverse}'";
    }

    [HttpGet]
    [Route("RestaurantPicker/{restaurant}")]

    public string RestaurantPicker(string restaurant)
    {
        string picked = "";
        restaurant = restaurant.ToLower();
    string [] badRestaurants = {"Applebees", "Olive Garden", "McDonalds", "Burger King", "Del Taco", "Domino's", "Subway", "Your Nearest Greasy Chinese Restaurant", "Denny's", "Mimi's Cafe"};
    string [] decentRestaurants = {"In-n-Out", "Wendy's", "Five Guys", "Rubio's", "Your Local Taco Truck", "Taco Bell", "Old Spaghetti Factory", "PizzaHut", "Togo's", "Papa John's"};
    string [] goodRestaurants = {"Shadowbrook", "Smack Pie", "Market Tavern", "Papapavlo's", "The Creamery", "Fenton's", "The Dancing Fox", "Michael David Winery", "Prime Table Steakhouse", "Misaki Sushi"};
        Random rndNum = new Random();
        int num = rndNum.Next(0, 9);
        if (restaurant == "good") picked = goodRestaurants[num];
        if (restaurant == "decent") picked = decentRestaurants[num];
        if (restaurant == "bad") picked = badRestaurants[num];
        return $"You should eat at {picked}";
    }

    [HttpGet]
    [Route("Magic8Ball")]

    public string Magic8Ball()
    {
        Random rndNum = new Random();
        int num = rndNum.Next(0, 9);
        switch (num)
        {
            case 0:
            return "YEP!";
            break;
            case 1:
            return "This is undoubtedly true.";
            break;
            case 2:
            return "Signs point to yes.";
            break;
            case 3:
            return "Absolutely not!";
            break;
            case 4:
            return "Nope.";
            break;
            case 5:
            return "Nu-uh";
            break;
            case 6:
            return "Try again later";
            break;
            case 7:
            return "It remains undecided";
            break;
            case 8:
            return "????";
            break;
            case 9:
            return "You will die today";
            break;
            default:
            return "this shouldn't be possible to reach...";
            break;
        }
        return "Two lines?";
    }
    }
