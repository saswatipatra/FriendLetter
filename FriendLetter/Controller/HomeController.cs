using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }

    [Route("/")]
    public ActionResult Letter()
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = "Lina";
      myLetterVariable.Sender = "Jasmine";
      myLetterVariable.Destination = "Denamark";
      myLetterVariable.Location = "Singapore";
      myLetterVariable.Present = "necklace";
      myLetterVariable.Gift= "snack";

      return View(myLetterVariable);
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/postcard")]
    public ActionResult Postcard(string recipient, string sender, string destination, string location, string present, string gift)
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = recipient;
      myLetterVariable.Sender = sender;
      myLetterVariable.Destination = destination;
      myLetterVariable.Location = location;
      myLetterVariable.Present = present;
      myLetterVariable.Gift = gift;
      return View(myLetterVariable);
    }
  }
}
