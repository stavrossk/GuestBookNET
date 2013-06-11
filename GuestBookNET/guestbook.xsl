<xsl:stylesheet 
  
   xmlns:xsl="http://www.w3.org/1999/XSL/Transform" 
   
   version="1.0">
	
  
    <xsl:template match="/">
		
      
      <table 
        
        border="2" 
        style="border-collapse: collapse" 
        bordercolor="#EBED99" 
        align="center" 
        width="450" 
        height="34">  
			
        
        <tr>
		
          
          <td 
            
            valign="middle" 
            align="center" 
            bgcolor="#dd9900" 
            colspan="2" 
            width="438">
				
            <font 
              
              face="Verdana" 
              size="2"
              
            >
              
              <b>
                
                <u>
                  GuestBook.NET
                </u>
                
              </b> v1.0 alpha
            
            </font>
				
          </td>
          
          
			  </tr>
        
        
        
        
			
        <tr>
          
          <td 
            
            width="438" 
            height="26" 
            align="left" 
            colspan="2">
            
          </td>
        
        </tr>
        
        
        
				<xsl:for-each select="//guest">
				
          <xsl:apply-templates select="name"/>	
				
        </xsl:for-each>
		
        
      </table>
      
      
      
      
    </xsl:template>
  
  
  
  
  
	
  <xsl:template match="name">
	
    <tr>
      
		
      <td 
        
        width="76" 
        height="26" 
        align="left" 
        bgcolor="#dd9900">
			
        
        <font 
          
          face="Verdana" 
          size="2">
          
            Name:
        
        </font>
		
      </td>
      
      
		<td width="356" height="26" valign="middle" align="left" bgcolor="#dd9900">
			<font face="Verdana" size="2"><xsl:value-of select='.'/></font>
		</td>
      
	</tr>
    
    
	<tr>
    
    
		<td 
      
        width="76" 
        height="26" 
        align="left" 
        bgcolor="#dd9900">
      
		      <font 
            
            face="Verdana" 
            size="2"
            
          >
            
            Message: 
          
          </font>
      
		</td>
    
    
    
		<td 
      
      width="356" 
      height="26" 
      valign="middle" 
      align="left" 
      bgcolor="#dd9900"
      
    >
      
      
	      <font 
          face="Verdana" 
          size="2"
        >
          
            <xsl:apply-templates 
            
              select = "../message"
        
            />
          
        </font>
		
    
    </td>
    
    
	</tr>
	
    
  
    
    
	<tr>
    
    
    
		<td 
      
        width="76" 
        height="26" 
        align="left" 
        bgcolor="#dd9900"
        
    >
      
	      <font 
          
          face="Verdana" 
          size="2"
        >
          Creation Date:
        
        </font>
		
    </td>
		
    
    
    <td width="356" height="26" valign="middle" align="left" bgcolor="#dd9900">
			<font face="Verdana" size="2"><xsl:apply-templates select="../date"/></font>
		</td>
		
    
	</tr>
    
    
    
    
    
    
	<tr>
    
    <td width="438" height="26" align="left" colspan="2"></td></tr>
	
  
  </xsl:template>





</xsl:stylesheet>