using System.IO;
using System.Web.UI;
using System.Xml;
using System.Xml.Xsl;

namespace GuestBookNET
{


    public class GuestbookViewer : Page
    {



        private void Page_Load(object sender, System.EventArgs e)
        {
            

            //Load the XML file   

            var doc = new XmlDocument( );   

            doc.Load( Server.MapPath("guestbook.xml") );   

   


            //Load the XSL file   

            var xslt = new XslCompiledTransform();   

            xslt.Load( Server.MapPath("guestbook.xsl") );   

   

             const string xmlQuery = "//guestbook";


            if (doc.DocumentElement != null)
            {

                XmlNodeList nodeList 
                    = doc.DocumentElement.SelectNodes(xmlQuery);

            }



            var memStream = new MemoryStream();   

            
             xslt.Transform( doc, null, memStream );   

             memStream.Seek( 0, SeekOrigin.Begin );   

   

             var sr = new StreamReader(memStream);   

   

    //Print out the result   

    Response.Write(sr.ReadToEnd());   





        }


    }




}