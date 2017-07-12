<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl">
  
    <xsl:output method="xml" indent="yes"/>

    <xsl:template match="element/text()">
      <xsl:call-template name="recursive" >
        <xsl:with-param name="input" select="."/>
      </xsl:call-template>
    </xsl:template>

  <xsl:template name="recursive">
    <xsl:param name="input"/>
    <xsl:param name="result"/>
    <xsl:param name="iteration" select="0"/>

    <xsl:message>iteration <xsl:value-of select="$iteration"/></xsl:message>
    <xsl:message>input  : <xsl:value-of select="$input"/></xsl:message>
    <xsl:message>result  : <xsl:value-of select="$result"/></xsl:message>
    <xsl:message/>
    
    <xsl:choose>
      <xsl:when test="$input = ''">
        <xsl:value-of select="$result"/>
      </xsl:when>
      <xsl:otherwise>
        <xsl:call-template name="recursive">
          <xsl:with-param name="input" select="substring($input,2)"/>
          <xsl:with-param name="result" select="concat($result,substring($input,1,1))"/>
          <xsl:with-param name="iteration" select="$iteration + 1"/>
        </xsl:call-template>
      </xsl:otherwise>
    </xsl:choose>
  </xsl:template>
</xsl:stylesheet>
