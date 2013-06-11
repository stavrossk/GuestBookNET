using System;
using System.Globalization;
using System.Web.UI;
using System.Xml;




namespace GuestBookNET
{



    public class GuestbookEntryGenerator : Page
    {




        internal void GenerateGuestbookEntry
            (string userName, string userMessage)
        {


            // Load the xml file  

            var xmldoc = new XmlDocument();

            xmldoc.Load( Server.MapPath("guestbook.xml"));



            //Create a new guest element and add it to the root node  

            XmlElement parentNode = xmldoc.CreateElement("guest");


            if (xmldoc.DocumentElement != null) 
                xmldoc.DocumentElement.PrependChild(parentNode);




            // Create the required nodes  

            XmlElement nameNode = xmldoc.CreateElement("name");

            XmlElement messageNode = xmldoc.CreateElement("message");

            XmlElement dateNode = xmldoc.CreateElement("date");



            // retrieve the text   


            
            XmlText userNameText = xmldoc.CreateTextNode(userName);


            XmlText userMessageText = xmldoc.CreateTextNode(userMessage);


            XmlText messageDateText 
                = xmldoc.CreateTextNode
                (DateTime.Now.ToString
                (CultureInfo.InvariantCulture));





            // append the nodes to the parentNode without the value  

            parentNode.AppendChild(nameNode);

            parentNode.AppendChild(messageNode);

            parentNode.AppendChild(dateNode);



            // save the value of the fields into the nodes  

            nameNode.AppendChild(userNameText);

            messageNode.AppendChild(userMessageText);

            dateNode.AppendChild(messageDateText);



            // Save to the XML file  

            xmldoc.Save(Server.MapPath("guestbook.xml"));



        }  




    }




}