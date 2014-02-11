<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output indent="yes"/>
  <xsl:strip-space elements="*"/>


  <xsl:template match="@* | node()">
    <xsl:copy>
      <xsl:apply-templates select="@* | node()"/>
    </xsl:copy>
  </xsl:template>

  <xsl:template match="room">
    <room>
      <xsl:attribute name="name">
        <xsl:value-of select="name"/>
      </xsl:attribute>
    </room>
  </xsl:template>


  <xsl:template match="device">
    <device>
      <xsl:attribute name="name">
        <xsl:value-of select="name"/>
      </xsl:attribute>
      <xsl:attribute name="state">
        <xsl:value-of select="state"/>
      </xsl:attribute>
    </device>
  </xsl:template>
  
</xsl:stylesheet>