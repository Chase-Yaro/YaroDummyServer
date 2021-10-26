using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnrealServer.Data;

[Route("results")]
public class SpeechResultsController : ControllerBase {
    private readonly UnrealContext _ctx;

    public SpeechResultsController(UnrealContext ctx)
    {
        _ctx = ctx;
    }

    [Route("add")]
    [HttpPost]
    public async Task<IActionResult> PostPin(string resultText) {
        var result = new SpeechResult {ResultText = resultText.ToLower(), TimeStamp = System.DateTime.Now};
        _ctx.Add(result);
        await _ctx.SaveChangesAsync();

        string returnText = "";

        if (result.ResultText == "hello")
        {
            returnText = "Hi, how are you?";
        }
        else if (result.ResultText == "good") {
            returnText = "Thats great to hear! Did you eat breakfast today?";
        }
        else if (result.ResultText == "yes") {
            returnText = "Fantastic, breakfast is a crucial component for a healthy routine";
        }

        return new ObjectResult(new {returnText = returnText});
    }
}