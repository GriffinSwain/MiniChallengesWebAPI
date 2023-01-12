using Microsoft.AspNetCore.Mvc;
using StudentDirectoryApi.Models;

namespace StudentDirectoryApi.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentDirectoryController : ControllerBase
{
    public List<StudentListModel> studentsList = new List<StudentListModel>()
    {
        new StudentListModel(){
            firstName = "Harrison",
            lastName = "Busby",
            slackName = "Harrison Busby",
            email = "hbusby@codestack.co",
            hobbies = "Piano"
        },
        new StudentListModel(){
            firstName = "Brandon",
            lastName = "Le",
            slackName = "Brandon Le",
            email = "ble@codestack.co",
            hobbies = "Eating & Sleeping"
        },
        new StudentListModel(){
            firstName = "Jessie",
            lastName = "Lamzon",
            slackName = "Jessie Lamzon",
            email = "jlamzon@codestack.co",
            hobbies = "Eating & Traveling"
        },
        new StudentListModel(){
            firstName = "Andrea",
            lastName = "Burr",
            slackName = "Andrea Burr",
            email = "aburr@codestack.co",
            hobbies = "Horse Riding"
        },
        new StudentListModel(){
            firstName = "Daniel",
            lastName = "Decoito",
            slackName = "Daniel Decoito",
            email = "ddecoito@codestack.co",
            hobbies = "Bears, Beets, Battlestar Galactica"
        },
        new StudentListModel(){
            firstName = "Pedro",
            lastName = "Castaneda",
            slackName = "Pedro Castaneda",
            email = "pcastaneda@codestack.co",
            hobbies = "Hiking & Traveling"
        },
        new StudentListModel(){
            firstName = "Jeremy",
            lastName = "Lapham",
            slackName = "Muscle Baby",
            email = "jlapham@codestack.co",
            hobbies = "Body Building, Powerlifting, Wrestling"
        },
        new StudentListModel(){
            firstName = "Jacob",
            lastName = "Dekok",
            slackName = "Jacob Dekok",
            email = "jdekok@codestack.co",
            hobbies = "Copying Jeremy, Body Building, Powerlifting, Wrestling"
        },
        new StudentListModel(){
            firstName = "Kenneth",
            lastName = "Fujimura",
            slackName = "Kenneth Fujimura",
            email = "kfujimura@codestack.co",
            hobbies = "Games, Sports, Model Kits, Anima, Naps, Culinary Tourism"
        },
        new StudentListModel(){
            firstName = "Fernando",
            lastName = "Aguilar",
            slackName = "Freddy Aguilar",
            email = "faguilar@codestack.co",
            hobbies = "Playing Video Games, Reading, Writing"
        },
        new StudentListModel(){
            firstName = "Jovann",
            lastName = "Contreras",
            slackName = "Jovann Contresras",
            email = "jcontreras@codestack.co",
            hobbies = "Declined To Answer"
        },
        new StudentListModel(){
            firstName = "Andrew",
            lastName = "Nilsson",
            slackName = "Drew Nillson",
            email = "anilsson@codestack.co",
            hobbies = "Playing Video Games"
        },
        new StudentListModel(){
            firstName = "Lerissa",
            lastName = "Lazar",
            slackName = "Lerissa Lazar",
            email = "llazar@codestack.co",
            hobbies = "Drawing & Watching Anime"
        },
        new StudentListModel(){
            firstName = "N. Harrison",
            lastName = "Wilkins",
            slackName = "Harrison Wilkins",
            email = "nwilkins@codestack.co",
            hobbies = "Declined To Answer"
        },
        new StudentListModel(){
            firstName = "Madeline",
            lastName = "Gowan",
            slackName = "Maddie Gowan",
            email = "mgowan@codestack.co",
            hobbies = "Rodents"
        },
        new StudentListModel(){
            firstName = "Manuel",
            lastName = "Leyva",
            slackName = "Manuel Leyva",
            email = "mleyva@codestack.co",
            hobbies = "Photography"
        },
        new StudentListModel(){
            firstName = "Elizar",
            lastName = "Garcia",
            slackName = "Elizar Garcia",
            email = "egarcia@codestack.co",
            hobbies = "Bowling & Sleeping"
        },
        new StudentListModel(){
            firstName = "Mark",
            lastName = "Ramirez",
            slackName = "Mark Ramirez",
            email = "mramirez@codestack.co",
            hobbies = "Games & Drinking Way Too Much Water"
        },
        new StudentListModel(){
            firstName = "Chris",
            lastName = "Martinez",
            slackName = "Chris Martinez",
            email = "cmartinez@codestack.co",
            hobbies = "Declined To Answer"
        },
        new StudentListModel(){
            firstName = "Samuel",
            lastName = "Laguna",
            slackName = "Samuel Laguna",
            email = "slaguna@codestack.co",
            hobbies = "Declined To Answer"
        },
        new StudentListModel(){
            firstName = "Isaiah",
            lastName = "Ferguson",
            slackName = "Isaiah Ferguson",
            email = "iferguson@codestack.co",
            hobbies = "Declined To Answer"
        },
        new StudentListModel(){
            firstName = "John",
            lastName = "Magpantay",
            slackName = "John Magpantay",
            email = "jmagpantay@codestack.co",
            hobbies = "FPS Games"
        },
        new StudentListModel(){
            firstName = "Reed",
            lastName = "Goodwin",
            slackName = "Reed Goodwin",
            email = "rgoodwin@codestack.co",
            hobbies = "Declined To Answer"
        },
        new StudentListModel(){
            firstName = "Amar",
            lastName = "Mann",
            slackName = "Amar Mann",
            email = "amann@codestack.co",
            hobbies = "Kicking Rocks"
        },
        new StudentListModel(){
            firstName = "Marcel",
            lastName = "Rodriguez",
            slackName = "Marcel Rodriguez",
            email = "mrodriguez@codestack.co",
            hobbies = "Declined To Answer"
        },
        new StudentListModel(){
            firstName = "Richard",
            lastName = "Johnson",
            slackName = "Richard Johnson",
            email = "rjohnson@codestack.co",
            hobbies = "Watching Youtube, Sketching, Playing Video Games"
        },
        new StudentListModel(){
            firstName = "Ulises",
            lastName = "Ortega",
            slackName = "Ulises Ortega",
            email = "uortega@codestack.co",
            hobbies = "Video Games, Rollerblading, Board Games"
        },
        new StudentListModel(){
            firstName = "Caroline",
            lastName = "Hana",
            slackName = "Caroline Hana",
            email = "chana@codestack.co",
            hobbies = "Video Games, Anime, Hanging Out With Friends"
        },
        new StudentListModel(){
            firstName = "Aisha",
            lastName = "Mashrah",
            slackName = "Aisha Mashrah",
            email = "amashrah@codestack.co",
            hobbies = "Painting"
        },
        new StudentListModel(){
            firstName = "Shaun",
            lastName = "Aguirre-Reyes",
            slackName = "Saguirre-Reyes",
            email = "saguirre-reyes@codestack.co",
            hobbies = "Writing, Listening To Music"
        },
        new StudentListModel(){
            firstName = "Griffin",
            lastName = "Parker",
            slackName = "Griffin Parker",
            email = "gparker@codestack.co",
            hobbies = "Singing"
        }
    };

    [HttpGet]
    [Route("GetStudentByFirstName/{studentFirstName}")]
    public StudentListModel GetStudentByFirstName(string studentFirstName)
    {
        StudentListModel result = new StudentListModel()
        {
            firstName = "N/A",
            lastName = "N/A",
            slackName = "N/A",
            email = "N/A",
            hobbies = "N/A"
        };
        for (int i = 0; i < studentsList.Count; i++)
        {
            //Checking the studentsList firstName to our variable firstName

            if (studentsList[i].firstName == studentFirstName)
            {
                result = studentsList[i];
                break;
            }
            else
            {
                result.firstName = "N/A";
                result.lastName = "N/A";
                result.slackName = "N/A";
                result.email = "N/A";
                result.hobbies = "N/A";
            }
        }
        return result;
    }


}
