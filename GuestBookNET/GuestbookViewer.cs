using System.IO;

using System.Web.UI;

using System.Xml;

using System.Xml.XPath;

using System.Xml.Xsl;





namespace GuestBookNET
{




    public class GuestbookViewer : Page
    {





        private void Page_Load()
        {


            XslCompiledTransform guestbookXslt;
            
            
            var guestbookXml 
                = LoadGuestbookXmlAndXslt
                (out guestbookXslt);



            GenerateAndWriteXsltOutput
                (guestbookXml, guestbookXslt);
        
        
        }





        private void GenerateAndWriteXsltOutput
            (IXPathNavigable guestbookXml, 
            XslCompiledTransform guestbookXslt)
        {


            var xsltTransformStreamReader
                = GenerateXsltTransformStreamReader
                    (guestbookXslt, guestbookXml);


            //Print out the result   

            Response.Write
                (xsltTransformStreamReader.ReadToEnd());

        
        }





        private XmlDocument 
            LoadGuestbookXmlAndXslt
            (out XslCompiledTransform guestbookXslt)
        {


            var guestbookXml = LoadGuestbookXml();


            guestbookXslt = LoadGuestbookXslt();
        
            
            return guestbookXml;
        
        
        }






        private static StreamReader 
            GenerateXsltTransformStreamReader
            (XslCompiledTransform xslt,
            IXPathNavigable guestbookXml)
        {


            var xsltTransformMemStream 
                = new MemoryStream();


            xslt.Transform
                (guestbookXml, null,
                xsltTransformMemStream);


            xsltTransformMemStream.Seek
                (0, SeekOrigin.Begin);


            var xsltTransformStreamReader
                = new StreamReader
                    (xsltTransformMemStream);
        
            
            return xsltTransformStreamReader;
        
        }






        private XslCompiledTransform LoadGuestbookXslt()
        {

            //Load the XSL file   

            var xslt = new XslCompiledTransform();

            xslt.Load
                (Server.MapPath
                ("guestbook.xsl"));
        
            return xslt;
        
        
        }




        private XmlDocument LoadGuestbookXml()
        {

            //Load the XML file   

            var doc = new XmlDocument();

            doc.Load(Server.MapPath("guestbook.xml"));
            
            
            return doc;


        }




    }




}