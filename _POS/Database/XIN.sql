USE [XIN]
GO
/****** Object:  Table [dbo].[XINUsers]    Script Date: 12/26/2012 12:14:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[XINUsers](
	[EmployeeNo] [varchar](10) NOT NULL,
	[EmployeeName] [nvarchar](20) NOT NULL,
	[PasswordCode] [varchar](10) NOT NULL,
 CONSTRAINT [PK_XINUsers] PRIMARY KEY CLUSTERED 
(
	[EmployeeNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Transfer]    Script Date: 12/26/2012 12:14:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Transfer](
	[TransferID] [varchar](10) NOT NULL,
	[TransferDate] [date] NOT NULL,
	[TransferType] [char](1) NOT NULL,
	[Description] [nvarchar](20) NULL,
	[Amount] [int] NOT NULL,
	[Comment] [ntext] NULL,
 CONSTRAINT [PK_Transfer] PRIMARY KEY CLUSTERED 
(
	[TransferID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 12/26/2012 12:14:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Supplier](
	[SupplierID] [varchar](8) NOT NULL,
	[AttribName] [nvarchar](10) NULL,
	[CompanyName] [nvarchar](50) NULL,
	[EarNo] [varchar](8) NULL,
	[JoinMan] [nvarchar](20) NULL,
	[Tel1] [varchar](20) NULL,
	[Tel2] [varchar](20) NULL,
	[Fax] [varchar](20) NULL,
	[MobilePhone] [varchar](10) NULL,
	[CompanyAddress] [nvarchar](50) NULL,
	[DeliveryAddress] [nvarchar](50) NULL,
	[LastReceiptDate] [date] NULL,
	[Comment] [ntext] NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Programs]    Script Date: 12/26/2012 12:14:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Programs](
	[ProgramID] [varchar](30) NOT NULL,
	[ProgramName] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Programs] PRIMARY KEY CLUSTERED 
(
	[ProgramID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Product]    Script Date: 12/26/2012 12:14:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [varchar](10) NOT NULL,
	[ProductName] [nvarchar](50) NULL,
	[Unit] [nvarchar](4) NULL,
	[LastReceiptDate] [date] NULL,
	[LastDeliveryDate] [date] NULL,
	[StopSales] [bit] NULL,
	[Price] [int] NULL,
	[Stock] [int] NULL,
	[Picture] [image] NULL,
	[Comment] [ntext] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 12/26/2012 12:14:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerID] [varchar](8) NOT NULL,
	[AttribName] [nvarchar](10) NULL,
	[CompanyName] [nvarchar](50) NULL,
	[EarNo] [varchar](8) NULL,
	[JoinMan] [nvarchar](20) NULL,
	[Tel1] [varchar](20) NULL,
	[Tel2] [varchar](20) NULL,
	[Fax] [varchar](20) NULL,
	[MobilePhone] [varchar](10) NULL,
	[CompanyAddress] [nvarchar](50) NULL,
	[DeliveryAddress] [nvarchar](50) NULL,
	[LastDeliveryDate] [date] NULL,
	[Comment] [ntext] NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Delivery]    Script Date: 12/26/2012 12:14:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Delivery](
	[DeliveryID] [varchar](10) NOT NULL,
	[DeliveryDate] [date] NOT NULL,
	[CustomerID] [varchar](8) NOT NULL,
	[JoinMan] [nvarchar](20) NULL,
	[DeliveryType] [char](1) NOT NULL,
	[InvoiceNo] [varchar](10) NULL,
	[SubTotal] [int] NOT NULL,
	[ValueAddTax] [int] NOT NULL,
	[Amount] [int] NOT NULL,
	[ShipAddress] [nvarchar](50) NULL,
	[Comment] [ntext] NULL,
 CONSTRAINT [PK_Delivery] PRIMARY KEY CLUSTERED 
(
	[DeliveryID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Receipt]    Script Date: 12/26/2012 12:14:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Receipt](
	[ReceiptID] [varchar](10) NOT NULL,
	[ReceiptDate] [date] NOT NULL,
	[SupplierID] [varchar](8) NOT NULL,
	[ReceiptType] [char](1) NOT NULL,
	[InvoiceNo] [varchar](10) NULL,
	[SubTotal] [int] NOT NULL,
	[ValueAddTax] [int] NOT NULL,
	[Amount] [int] NOT NULL,
	[ShipAddress] [nvarchar](50) NULL,
	[Comment] [ntext] NULL,
 CONSTRAINT [PK_Receipt] PRIMARY KEY CLUSTERED 
(
	[ReceiptID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserAuthority]    Script Date: 12/26/2012 12:14:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserAuthority](
	[EmployeeNo] [varchar](10) NOT NULL,
	[ProgramID] [varchar](30) NOT NULL,
	[Run] [bit] NOT NULL,
	[Append] [bit] NOT NULL,
	[Edit] [bit] NOT NULL,
	[Report] [bit] NOT NULL,
 CONSTRAINT [PK_UserAuthority] PRIMARY KEY CLUSTERED 
(
	[EmployeeNo] ASC,
	[ProgramID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TransferDetails]    Script Date: 12/26/2012 12:14:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TransferDetails](
	[TransferID] [varchar](10) NOT NULL,
	[Seq] [tinyint] NOT NULL,
	[ProductID] [varchar](10) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Amount] [int] NOT NULL,
 CONSTRAINT [PK_TransferDetails] PRIMARY KEY CLUSTERED 
(
	[TransferID] ASC,
	[Seq] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[SalesByCustomer]    Script Date: 12/26/2012 12:14:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SalesByCustomer]
	@BeginDate AS DATE,
	@EndDate AS DATE
AS
SELECT R.CustomerID, R.CompanyName, 
SUM(M.Amount) AS Amount
FROM Customer R INNER JOIN Delivery M 
ON R.CustomerID = M.CustomerID 
WHERE M.DeliveryDate >= @BeginDate 
AND M.DeliveryDate <= @EndDate
GROUP BY R.CustomerID, R.CompanyName
ORDER BY SUM(M.Amount) DESC
RETURN
GO
/****** Object:  Table [dbo].[ReceiptDetails]    Script Date: 12/26/2012 12:14:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ReceiptDetails](
	[ReceiptID] [varchar](10) NOT NULL,
	[ReceiptSeq] [tinyint] NOT NULL,
	[ProductID] [varchar](10) NOT NULL,
	[Quantity] [int] NOT NULL,
	[UnitPrice] [int] NOT NULL,
	[Amount] [int] NOT NULL,
 CONSTRAINT [PK_ReceiptDetails] PRIMARY KEY CLUSTERED 
(
	[ReceiptID] ASC,
	[ReceiptSeq] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DeliveryDetails]    Script Date: 12/26/2012 12:14:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DeliveryDetails](
	[DeliveryID] [varchar](10) NOT NULL,
	[DeliverySeq] [tinyint] NOT NULL,
	[ProductID] [varchar](10) NOT NULL,
	[Quantity] [int] NOT NULL,
	[UnitPrice] [int] NOT NULL,
	[Amount] [int] NOT NULL,
 CONSTRAINT [PK_DeliveryDetails] PRIMARY KEY CLUSTERED 
(
	[DeliveryID] ASC,
	[DeliverySeq] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[SalesReport]    Script Date: 12/26/2012 12:14:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SalesReport]
	@BeginDate AS DATE,
	@EndDate AS DATE
AS

SELECT M.DeliveryDate, SUM(M.Amount) AS Amount
FROM Delivery M 
WHERE M.DeliveryDate >= @BeginDate 
AND M.DeliveryDate <= @EndDate
GROUP BY M.DeliveryDate
ORDER BY M.DeliveryDate

SELECT R.CustomerID, R.CompanyName, 
SUM(M.Amount) AS Amount
FROM Customer R INNER JOIN Delivery M 
ON R.CustomerID = M.CustomerID 
WHERE M.DeliveryDate >= @BeginDate 
AND M.DeliveryDate <= @EndDate
GROUP BY R.CustomerID, R.CompanyName
ORDER BY R.CustomerID

SELECT P.ProductID, P.ProductName, 
SUM(D.Amount) AS Amount
FROM Delivery M INNER JOIN DeliveryDetails D 
ON M.DeliveryID = D.DeliveryID
INNER JOIN Product P ON D.ProductID = P.ProductID
WHERE M.DeliveryDate >= @BeginDate 
AND M.DeliveryDate <= @EndDate
GROUP BY P.ProductID, P.ProductName
ORDER BY P.ProductID

RETURN
GO
/****** Object:  StoredProcedure [dbo].[DeliveryDetailsOfProduct]    Script Date: 12/26/2012 12:14:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeliveryDetailsOfProduct] @ProductID VarChar(10)
AS
BEGIN
	SELECT P.ProductID, P.ProductName, D.DeliveryID, D.Quantity, D.UnitPrice, 
           D.Amount
	FROM Product P INNER JOIN DeliveryDetails D ON
    P.ProductID = D.ProductID
	WHERE P.ProductID = @ProductID
END
GO
/****** Object:  Default [DF_Delivery_SubTotal]    Script Date: 12/26/2012 12:14:28 ******/
ALTER TABLE [dbo].[Delivery] ADD  CONSTRAINT [DF_Delivery_SubTotal]  DEFAULT ((0)) FOR [SubTotal]
GO
/****** Object:  Default [DF_Delivery_ValueAddTax]    Script Date: 12/26/2012 12:14:28 ******/
ALTER TABLE [dbo].[Delivery] ADD  CONSTRAINT [DF_Delivery_ValueAddTax]  DEFAULT ((0)) FOR [ValueAddTax]
GO
/****** Object:  Default [DF_Delivery_Amount]    Script Date: 12/26/2012 12:14:28 ******/
ALTER TABLE [dbo].[Delivery] ADD  CONSTRAINT [DF_Delivery_Amount]  DEFAULT ((0)) FOR [Amount]
GO
/****** Object:  Default [DF_Product_StopSales]    Script Date: 12/26/2012 12:14:28 ******/
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_StopSales]  DEFAULT ((0)) FOR [StopSales]
GO
/****** Object:  Default [DF_Product_Price]    Script Date: 12/26/2012 12:14:28 ******/
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_Price]  DEFAULT ((0)) FOR [Price]
GO
/****** Object:  Default [DF_Product_Stock]    Script Date: 12/26/2012 12:14:28 ******/
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_Stock]  DEFAULT ((0)) FOR [Stock]
GO
/****** Object:  Default [DF_Receipt_SubTotal]    Script Date: 12/26/2012 12:14:28 ******/
ALTER TABLE [dbo].[Receipt] ADD  CONSTRAINT [DF_Receipt_SubTotal]  DEFAULT ((0)) FOR [SubTotal]
GO
/****** Object:  Default [DF_Receipt_ValueAddTax]    Script Date: 12/26/2012 12:14:28 ******/
ALTER TABLE [dbo].[Receipt] ADD  CONSTRAINT [DF_Receipt_ValueAddTax]  DEFAULT ((0)) FOR [ValueAddTax]
GO
/****** Object:  Default [DF_Receipt_Amount]    Script Date: 12/26/2012 12:14:28 ******/
ALTER TABLE [dbo].[Receipt] ADD  CONSTRAINT [DF_Receipt_Amount]  DEFAULT ((0)) FOR [Amount]
GO
/****** Object:  Default [DF_ReceiptDetails_Quantity]    Script Date: 12/26/2012 12:14:28 ******/
ALTER TABLE [dbo].[ReceiptDetails] ADD  CONSTRAINT [DF_ReceiptDetails_Quantity]  DEFAULT ((0)) FOR [Quantity]
GO
/****** Object:  Default [DF_ReceiptDetails_UnitPrice]    Script Date: 12/26/2012 12:14:28 ******/
ALTER TABLE [dbo].[ReceiptDetails] ADD  CONSTRAINT [DF_ReceiptDetails_UnitPrice]  DEFAULT ((0)) FOR [UnitPrice]
GO
/****** Object:  Default [DF_ReceiptDetails_Amount]    Script Date: 12/26/2012 12:14:28 ******/
ALTER TABLE [dbo].[ReceiptDetails] ADD  CONSTRAINT [DF_ReceiptDetails_Amount]  DEFAULT ((0)) FOR [Amount]
GO
/****** Object:  Default [DF_Transfer_Amount]    Script Date: 12/26/2012 12:14:28 ******/
ALTER TABLE [dbo].[Transfer] ADD  CONSTRAINT [DF_Transfer_Amount]  DEFAULT ((0)) FOR [Amount]
GO
/****** Object:  Default [DF_TransferDetails_Quantity]    Script Date: 12/26/2012 12:14:28 ******/
ALTER TABLE [dbo].[TransferDetails] ADD  CONSTRAINT [DF_TransferDetails_Quantity]  DEFAULT ((0)) FOR [Quantity]
GO
/****** Object:  Default [DF_TransferDetails_Amount]    Script Date: 12/26/2012 12:14:28 ******/
ALTER TABLE [dbo].[TransferDetails] ADD  CONSTRAINT [DF_TransferDetails_Amount]  DEFAULT ((0)) FOR [Amount]
GO
/****** Object:  Default [DF_UserAuthority_Run]    Script Date: 12/26/2012 12:14:28 ******/
ALTER TABLE [dbo].[UserAuthority] ADD  CONSTRAINT [DF_UserAuthority_Run]  DEFAULT ((1)) FOR [Run]
GO
/****** Object:  Default [DF_UserAuthority_Append]    Script Date: 12/26/2012 12:14:28 ******/
ALTER TABLE [dbo].[UserAuthority] ADD  CONSTRAINT [DF_UserAuthority_Append]  DEFAULT ((1)) FOR [Append]
GO
/****** Object:  Default [DF_UserAuthority_Edit]    Script Date: 12/26/2012 12:14:28 ******/
ALTER TABLE [dbo].[UserAuthority] ADD  CONSTRAINT [DF_UserAuthority_Edit]  DEFAULT ((1)) FOR [Edit]
GO
/****** Object:  Default [DF_UserAuthority_Report]    Script Date: 12/26/2012 12:14:28 ******/
ALTER TABLE [dbo].[UserAuthority] ADD  CONSTRAINT [DF_UserAuthority_Report]  DEFAULT ((1)) FOR [Report]
GO
/****** Object:  Default [DF_XINUsers_PasswordCode]    Script Date: 12/26/2012 12:14:28 ******/
ALTER TABLE [dbo].[XINUsers] ADD  CONSTRAINT [DF_XINUsers_PasswordCode]  DEFAULT ((111)) FOR [PasswordCode]
GO
/****** Object:  ForeignKey [FK_Delivery_Customer]    Script Date: 12/26/2012 12:14:28 ******/
ALTER TABLE [dbo].[Delivery]  WITH CHECK ADD  CONSTRAINT [FK_Delivery_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[Delivery] CHECK CONSTRAINT [FK_Delivery_Customer]
GO
/****** Object:  ForeignKey [FK_DeliveryDetails_Delivery]    Script Date: 12/26/2012 12:14:28 ******/
ALTER TABLE [dbo].[DeliveryDetails]  WITH CHECK ADD  CONSTRAINT [FK_DeliveryDetails_Delivery] FOREIGN KEY([DeliveryID])
REFERENCES [dbo].[Delivery] ([DeliveryID])
GO
ALTER TABLE [dbo].[DeliveryDetails] CHECK CONSTRAINT [FK_DeliveryDetails_Delivery]
GO
/****** Object:  ForeignKey [FK_DeliveryDetails_Product]    Script Date: 12/26/2012 12:14:28 ******/
ALTER TABLE [dbo].[DeliveryDetails]  WITH CHECK ADD  CONSTRAINT [FK_DeliveryDetails_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[DeliveryDetails] CHECK CONSTRAINT [FK_DeliveryDetails_Product]
GO
/****** Object:  ForeignKey [FK_Receipt_Supplier]    Script Date: 12/26/2012 12:14:28 ******/
ALTER TABLE [dbo].[Receipt]  WITH CHECK ADD  CONSTRAINT [FK_Receipt_Supplier] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Supplier] ([SupplierID])
GO
ALTER TABLE [dbo].[Receipt] CHECK CONSTRAINT [FK_Receipt_Supplier]
GO
/****** Object:  ForeignKey [FK_ReceiptDetails_Product]    Script Date: 12/26/2012 12:14:28 ******/
ALTER TABLE [dbo].[ReceiptDetails]  WITH CHECK ADD  CONSTRAINT [FK_ReceiptDetails_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[ReceiptDetails] CHECK CONSTRAINT [FK_ReceiptDetails_Product]
GO
/****** Object:  ForeignKey [FK_ReceiptDetails_Receipt]    Script Date: 12/26/2012 12:14:28 ******/
ALTER TABLE [dbo].[ReceiptDetails]  WITH CHECK ADD  CONSTRAINT [FK_ReceiptDetails_Receipt] FOREIGN KEY([ReceiptID])
REFERENCES [dbo].[Receipt] ([ReceiptID])
GO
ALTER TABLE [dbo].[ReceiptDetails] CHECK CONSTRAINT [FK_ReceiptDetails_Receipt]
GO
/****** Object:  ForeignKey [FK_TransferDetails_Product]    Script Date: 12/26/2012 12:14:28 ******/
ALTER TABLE [dbo].[TransferDetails]  WITH CHECK ADD  CONSTRAINT [FK_TransferDetails_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[TransferDetails] CHECK CONSTRAINT [FK_TransferDetails_Product]
GO
/****** Object:  ForeignKey [FK_TransferDetails_Transfer]    Script Date: 12/26/2012 12:14:28 ******/
ALTER TABLE [dbo].[TransferDetails]  WITH CHECK ADD  CONSTRAINT [FK_TransferDetails_Transfer] FOREIGN KEY([TransferID])
REFERENCES [dbo].[Transfer] ([TransferID])
GO
ALTER TABLE [dbo].[TransferDetails] CHECK CONSTRAINT [FK_TransferDetails_Transfer]
GO
/****** Object:  ForeignKey [FK_UserAuthority_Programs]    Script Date: 12/26/2012 12:14:28 ******/
ALTER TABLE [dbo].[UserAuthority]  WITH CHECK ADD  CONSTRAINT [FK_UserAuthority_Programs] FOREIGN KEY([ProgramID])
REFERENCES [dbo].[Programs] ([ProgramID])
GO
ALTER TABLE [dbo].[UserAuthority] CHECK CONSTRAINT [FK_UserAuthority_Programs]
GO
/****** Object:  ForeignKey [FK_UserAuthority_XINUsers]    Script Date: 12/26/2012 12:14:28 ******/
ALTER TABLE [dbo].[UserAuthority]  WITH CHECK ADD  CONSTRAINT [FK_UserAuthority_XINUsers] FOREIGN KEY([EmployeeNo])
REFERENCES [dbo].[XINUsers] ([EmployeeNo])
GO
ALTER TABLE [dbo].[UserAuthority] CHECK CONSTRAINT [FK_UserAuthority_XINUsers]
GO
