using System;


namespace GuestBookNET
{


    public partial class GuestbookSignPage : System.Web.UI.Page
    {



        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void SubmitButtonClick(object sender, EventArgs e)
        {


            GuestbookEntryGenerator entryGenerator
                = new GuestbookEntryGenerator();

            entryGenerator.GenerateGuestbookEntry
                (NameTextBox.Text, MessageTextBox.Text);


            Response.Redirect("GuestbookViewerForm.aspx");


        }





        protected void ViewGuestbookButton_Click(object sender, EventArgs e)
        {



        }


        protected void ViewGuestbookButtonClick(object sender, EventArgs e)
        {


            GuestbookViewer guestbookViewer = new GuestbookViewer();

            Response.Redirect("GuestbookViewerForm.aspx");

        
        
        }





    }



}
