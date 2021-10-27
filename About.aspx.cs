using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Speech.Synthesis;
using System.Speech.Recognition;

public partial class About : System.Web.UI.Page
{
    SpeechSynthesizer a = new SpeechSynthesizer();
    Choices list = new Choices();
    SpeechRecognitionEngine s = new SpeechRecognitionEngine();
    protected void Page_Load(object sender, EventArgs e)
    {
        list.Add(new String[] { "hello", "what is your name" });
        Grammar gr = new Grammar(new GrammarBuilder(list));
        
        try
        {
            s.RequestRecognizerUpdate();
            s.LoadGrammar(gr);
            s.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(s_SpeechRecognized);
            s.SetInputToDefaultAudioDevice();
            s.RecognizeAsync(RecognizeMode.Multiple);
        }


        catch
        {
            return;
        }
    }
    public void say(String h)
    {
        a.Speak(h);
    }
    void s_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
    {
        String r = e.Result.Text;
        if (r == "hello")
        {
            say("hi");
        }
        if (r == "what is your name")
        {
            say("i am jarvis");
        }
    }
}