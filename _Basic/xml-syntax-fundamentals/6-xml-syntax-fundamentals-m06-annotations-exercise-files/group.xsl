<xsl:stylesheet 
  xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
  version="1.0">

<xsl:output indent="yes"/>

<xsl:template match="words">
  <sorted-words>
   <xsl:for-each select="word">
     <xsl:sort/>
     <xsl:copy-of select="."/>
   </xsl:for-each>
  </sorted-words>
</xsl:template>

</xsl:stylesheet>