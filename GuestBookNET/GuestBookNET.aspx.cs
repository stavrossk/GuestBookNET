using System;


namespace GuestBookNET
{


    public partial class GuestbookSignPage : System.Web.UI.Page
    {




        protected void SubmitButtonClick(object sender, EventArgs e)
        {


            var entryGenerator
                = new GuestbookEntryGenerator();

            entryGenerator.GenerateGuestbookEntry
                (NameTextBox.Text, MessageTextBox.Text);


            Response.Redirect("GuestbookViewerForm.aspx");


        }




        protected void ViewGuestbookButtonClick
            (object sender, EventArgs e)
        {


            Response.Redirect("GuestbookViewerForm.aspx");

               
        }





    }



}
