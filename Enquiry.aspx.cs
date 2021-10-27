using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SpeechLib;
using System.Diagnostics;

public partial class Enquiry : System.Web.UI.Page
{
    SpVoice a = new SpVoice();



    protected void Page_Load(object sender, EventArgs e)
    {

        Label1.Text = ("<br>The system can provide information about different types of courses, duration, fees, demand of a \n" +
  " course and eligibiliy criteria for taking admission.</br><br>Please enter your query within the textbox and press enter :</br>");
        Label2.Text = "";
        Label3.Text = "";
        Label4.Text = "";
    }
    
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        
        //fees
        if ((TextBox1.Text.ToLower().Contains("fee")) == true)
        {
            Label2.Text = "The total fees of each course is given below ::";
            a.Speak(Label2.Text);

            Label3.Text = "<br>1) The total fee of BSc (Maths, Physics, Chemistry, IT, Biology) is RS.15000 per year.</br><br>2) The total fee of BCA is RS.15000 per year.</br><br>3) The total fee of MSc ( Maths, Physics, Chemistry, IT, Biology) is RS.30000 per year.</br><br>4) The total fee of MCA is RS.35000 per year. </br><br>5) The total fee of BA is RS.15000 per year. </br><br>6) The total fee of MA is RS.25000 per year. </br><br>7) The total fee of B.Com is RS.15000 per year. </br><br>8) The total fee of M.Com is RS.35000 per year. </br> ";
            TextBox1.Text = "";

        }

        //course
        else if ((TextBox1.Text.ToLower().Contains("open app")) == true)
        {
            a.Speak("OK, sir.");
            Process.Start("C:/Users/Rajendra/Documents/Visual Studio 2010/WebSites/AI/aiSpRecog/aiSpRecog.sln");

        }
        else if ((TextBox1.Text.ToLower().Contains("all") & TextBox1.Text.ToLower().Contains("course") || TextBox1.Text.ToLower().Contains("every") & TextBox1.Text.ToLower().Contains("course")) == true)
        {
            Label2.Text = "The following is the list of all available courses in the university :: ";
            a.Speak(Label2.Text);

            Label3.Text = "<br>1) BSc (Maths, Physics, Chemistry, IT, Biology)</br><br>2) BCA </br><br>3) BA</br><br>4) B.Com </br><br>5) MSc ( Maths, Physics, Chemistry, IT, Biology)</br><br>6) Master of Computer Applications </br><br>7) Master of Arts</br><br>8) Master of Commerce </br> ";
            TextBox1.Text = "";

        }

        else if ((TextBox1.Text.ToLower().Contains("post graduat") & TextBox1.Text.ToLower().Contains("course")
                   || TextBox1.Text.ToLower().Contains("pg") & TextBox1.Text.ToLower().Contains("course") ||
                    TextBox1.Text.ToLower().Contains("post graduat") & TextBox1.Text.ToLower().Contains("program")
                   || TextBox1.Text.ToLower().Contains("pg") & TextBox1.Text.ToLower().Contains("program")) == true)
        {
            Label2.Text = "The following is the list of courses available for post graduation :: ";
            a.Speak(Label2.Text);

            Label3.Text = "<br>1) MSc ( Maths, Physics, Chemistry, IT, Biology)</br><br>2) Master of Computer Applications </br><br>3) Master of Arts</br><br>4) Master of Commerce </br> ";
            TextBox1.Text = "";

        }
        else if ((TextBox1.Text.ToLower().Contains("graduat") & TextBox1.Text.ToLower().Contains("course")
            || TextBox1.Text.ToLower().Contains("ug") & TextBox1.Text.ToLower().Contains("course") ||
             TextBox1.Text.ToLower().Contains("graduat") & TextBox1.Text.ToLower().Contains("program")
            || TextBox1.Text.ToLower().Contains("ug") & TextBox1.Text.ToLower().Contains("program")) == true)
        {
            Label2.Text = "The following is the list of courses available for graduation :: ";
            a.Speak(Label2.Text);

            Label3.Text = "<br>1) BSc (Maths, Physics, Chemistry, IT, Biology)</br><br>2) BCA </br><br>3) BA</br><br>4) B.Com </br> ";
            TextBox1.Text = "";

        }

        
        else if (TextBox1.Text.Contains("science") & TextBox1.Text.Contains("course") ||
            TextBox1.Text.Contains("science") & TextBox1.Text.Contains("program") == true)
        {
            Label2.Text = "The following is the list of courses available under Science :: ";
            a.Speak(Label2.Text);

            Label3.Text = "<br>1) BSc (Maths, Physics, Chemistry, IT, Biology)</br><br>2) BCA </br><br>3) MSc ( Maths, Physics, Chemistry, IT, Biology)</br><br>4) MCA </br> ";
            TextBox1.Text = "";

        }

        else if ((TextBox1.Text.ToLower().Contains("art") &
            (TextBox1.Text.ToLower().Contains("course") ||
            TextBox1.Text.Contains("art") & TextBox1.Text.Contains("program"))) == true)
        {
            Label2.Text = "Bachelor of Arts and Master of Arts are the only available courses under Arts in the University.";
            a.Speak(Label2.Text);
            TextBox1.Text = "";

        }
        else if ((TextBox1.Text.ToLower().Contains("commerce") &
             TextBox1.Text.ToLower().Contains("course") ||
            TextBox1.Text.ToLower().Contains("commerce") &
            TextBox1.Text.ToLower().Contains("program")) == true)
        {
            Label2.Text = "Bachelor of Commerce and Master of Commerce are the only available courses under Commerce in the University.";
            a.Speak(Label2.Text);
            TextBox1.Text = "";

        }
        //duration
        else if ((TextBox1.Text.ToLower().Contains("duration")) == true)
        {
            Label2.Text = "The duration of each course is given below ::";
            a.Speak(Label2.Text);

            Label3.Text = "<br>1) Duration of BSc (Maths, Physics, Chemistry, IT, Biology) is 3 years.</br><br>2) Duration of BCA is 3 years.</br><br>3) Duration of MSc ( Maths, Physics, Chemistry, IT, Biology) is 2 years.</br><br>4) Duration of MCA is 3 years. </br><br>5) Duration of BA is 3 years. </br><br>6) Duration of MA is 2 years. </br><br>7) Duration of B.Com is 3 years. </br><br>8) Duration of M. Com is 2 years. </br> ";
            TextBox1.Text = "";

        }

//elibility
        else if ((TextBox1.Text.ToLower().Contains("eligi") &
       TextBox1.Text.ToLower().Contains("bca") ||
           TextBox1.Text.ToLower().Contains("eligi") & TextBox1.Text.ToLower().Contains("bscit") ||
            TextBox1.Text.ToLower().Contains("eligi") & TextBox1.Text.ToLower().Contains("bsc it") ||
            TextBox1.Text.ToLower().Contains("eligi") & TextBox1.Text.ToLower().Contains("ba") ||
            TextBox1.Text.ToLower().Contains("eligi") & TextBox1.Text.ToLower().Contains("bcom")) == true)
        {
            Label2.Text = "A student will be eligible for the mentioned course or program if he or she has secured atleast 50 percent in SSC as well as HSC or CBSC board examinations.   ";
            a.Speak(Label2.Text);
            TextBox1.Text = "";
        }
        else if ((
   TextBox1.Text.ToLower().Contains("eligi") & TextBox1.Text.ToLower().Contains("mca") ||
        TextBox1.Text.ToLower().Contains("eligi") & TextBox1.Text.ToLower().Contains("mscit") ||
        TextBox1.Text.ToLower().Contains("eligi") & TextBox1.Text.ToLower().Contains("msc it") ||
        TextBox1.Text.ToLower().Contains("eligi") & TextBox1.Text.ToLower().Contains("ma") ||
        TextBox1.Text.ToLower().Contains("eligi") & TextBox1.Text.ToLower().Contains("mcom")) == true)
        {
            Label2.Text = "A student will be eligible for the mentioned course or program if he or she has secured atleast 50 percent in SSC as well as HSC or CBSC board examinations.<br> The student should also have cleared the graduation program with atleast aggrgate of 50 percent.  ";
            a.Speak(Label2.Text);
            TextBox1.Text = "";
        }

//result
        else if ((TextBox1.Text.ToLower().Contains("result")) == true)
        {
            Label2.Text = "Please check the university's official website for deatils about the result.";
            a.Speak(Label2.Text);
            Label3.Text = "Only BSc IT results have been declared. Click on the given link.";
            HyperLink1.Text = "Results of B.Sc IT";
            a.Speak(Label3.Text);
            TextBox1.Text = "";

        }
        
        //admission details
        else if ((TextBox1.Text.ToLower().Contains("admission")) == true)
        {
            Label3.Text = "Admissions will start from June or July. Dates will be uploaded on the website shortly.";
            a.Speak(Label3.Text);
            TextBox1.Text = "";
        }

        else
        {

            Label4.Text = "Sorry, I Did not understand your query. Please try again.";
            Label4.ForeColor = System.Drawing.Color.Red;
            a.Speak(Label4.Text);
        }
    }

}