using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SpeechLib;
public partial class Result : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        SpVoice a = new SpVoice();
        string b;
        b = TextBox1.Text;
        switch (b)
        {
            case "101":
                Label2.Text = "Congratulations! You have successfully passed.";
                a.Speak(Label2.Text);
                break;
            case "102":
                Label2.Text = "Congratulations! You have successfully passed.";
                a.Speak(Label2.Text);
                break;
            case "103":
                Label2.Text = "Congratulations! You have successfully passed.";
                a.Speak(Label2.Text);
                break;
            case "104":
                Label2.Text = "Congratulations! You have successfully passed.";
                a.Speak(Label2.Text);
                break;
            case "105":
                Label2.Text = "Congratulations! You have successfully passed.";
                a.Speak(Label2.Text);
                break;
            case "106":
                Label2.Text = "Sorry, you have failed.";
                a.Speak(Label2.Text);
                break;
            case "107":
                Label2.Text = "Sorry, you have failed.";
                a.Speak(Label2.Text);
                break;
            case "108":
                Label2.Text = "Sorry, you have failed.";
                a.Speak(Label2.Text);
                break;
            case "109":
                Label2.Text = "Sorry, you have failed.";
                a.Speak(Label2.Text);
                break;
            case "110":
                Label2.Text = "Sorry, you have failed.";
                a.Speak(Label2.Text);
                break;
            default:
                Label2.Text = "Please enter the correct seat number.";
                a.Speak(Label2.Text);
                break;
        }

    }
}