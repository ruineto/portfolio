<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
  <xsl:output indent="yes"/>
  <xsl:strip-space elements="*"/>

  <xsl:template match="@* | node()">
    <xsl:copy>
      <xsl:apply-templates select="@* | node()"/>
    </xsl:copy>
  </xsl:template>
  
  <xsl:variable name="ston" select="'on'"/>
  
    <xsl:template match="state">
    <state>
      <xsl:choose>
        <xsl:when test="self::node()[text()='off']">
          false
        </xsl:when>
        <xsl:otherwise>
          true
        </xsl:otherwise>
      </xsl:choose>
    </state>
  </xsl:template>

</xsl:stylesheet>
