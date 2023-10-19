<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:template match="/">
		<html>
			<body>
				<h2>Order Details:</h2>
				<h3>
					<xsl:value-of select="Order/CustomerName"></xsl:value-of>
				</h3>
				<h3>
					<xsl:value-of select="Order/@id"></xsl:value-of>
				</h3>
				<table border="1">
					<tr bgcolor="blue">
						<th>Item id</th>
						<th>Item Name</th>
						<th>Price</th>
						<th>Quantity</th>
					</tr>
					<xsl:for-each select="Order/Item">
						<tr>
							<td>
								<xsl:value-of select="ItemId"></xsl:value-of>
							</td>
							<td>
								<xsl:value-of select="ItemName"></xsl:value-of>
							</td>
							<td>
								<xsl:value-of select="Price"></xsl:value-of>
							</td>
							<td>
								<xsl:value-of select="Quantity"></xsl:value-of>
							</td>
						</tr>
					</xsl:for-each>
				</table>

			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>