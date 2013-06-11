

<%@ Page  

    Title="" 
    
    Language="C#" 
    
    MasterPageFile="~/Site.master" 
    
    AutoEventWireup="true"
    
    CodeBehind="GuestBookNET.aspx.cs" 
    
    Inherits="GuestBookNET.GuestbookSignPage" 
    
%>



<asp:Content 

    ID="HeaderContent" 
    
    runat="server" 
    
    ContentPlaceHolderID="HeadContent"

>
    

</asp:Content>



<asp:Content 

    ID="Content1" 
    
    runat="server" 
    
    contentplaceholderid="MainContent"
    
>
    
    

<p>
    
    &nbsp;&nbsp;&nbsp; <strong>Please enter your name:</strong>
    
    <asp:TextBox 
        
        ID="NameTextBox" 
        
        runat="server" 
        
        style=
            
            "margin-left: 25px; 
             margin-top: 21px" 
             Width="204px" Height="36px"
        
    ></asp:TextBox>
    
    
    
    

    <asp:RequiredFieldValidator 
    
        id = "nameRequired" 
        
        runat = "server"  

        ControlToValidate = "NameTextBox"  

        ErrorMessage = " You must type your name! "  

        Display = "dynamic" style="font-weight: 700; font-style: italic; text-align: center"
        
    >
            
        Please enter your name!  
            

    </asp:RequiredFieldValidator> 
    
    

</p>






<p>
    

    <strong>
        
        &nbsp;&nbsp;&nbsp; Please enter your message:
    
    </strong>
    

    <asp:TextBox 
    
        ID="MessageTextBox" 
        
        runat="server" 
        
        style="margin-left: 15px; margin-top: 19px;" Height="55px" 
        
        TextMode="MultiLine" Width="200px"></asp:TextBox>
    
    
    
    
    
    

    <strong>
        
    
    
    
    
    

    <asp:RequiredFieldValidator 
    
        id = "RequiredFieldValidator" 
        
        runat = "server"  

        ControlToValidate = "MessageTextBox"  

        ErrorMessage = " You must type a message! "  

        Display = "dynamic" style="text-align: center"
        
    >
            
        Please type a message!  
            

    </asp:RequiredFieldValidator> 
    
    

    </strong>
    


</p>





<p>
    
    

    <asp:Button 
    
        ID="SubmitButton" 
        
        runat="server" 
        
        style="margin-left: 61px; margin-top: 44px;" 
        
        Text="Submit Message" 
        
        Width="135px" 
        
        onclick="SubmitButtonClick" 
        
    />
    

    <asp:Button 
    
        ID="ViewGuestbookButton" 
        
        runat="server" 
        
        style="margin-left: 32px" 
        
        Text="View GuestBook" 
        
        Width="140px" 
        
        onclick="ViewGuestbookButtonClick" 
        
    />
        
        

</p>



</asp:Content>

