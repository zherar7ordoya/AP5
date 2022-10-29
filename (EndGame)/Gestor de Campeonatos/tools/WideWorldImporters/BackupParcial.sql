USE [WideWorldImporters]
GO
/****** Object:  DatabaseRole [Plains Sales]    Script Date: 22/10/2022 01:21:57 ******/
CREATE ROLE [Plains Sales]
GO
/****** Object:  Schema [Integration]    Script Date: 22/10/2022 01:21:57 ******/
CREATE SCHEMA [Integration]
GO
/****** Object:  Schema [Purchasing]    Script Date: 22/10/2022 01:21:57 ******/
CREATE SCHEMA [Purchasing]
GO
/****** Object:  Schema [Reports]    Script Date: 22/10/2022 01:21:57 ******/
CREATE SCHEMA [Reports]
GO
/****** Object:  Schema [Sales]    Script Date: 22/10/2022 01:21:57 ******/
CREATE SCHEMA [Sales]
GO
/****** Object:  Table [Purchasing].[Suppliers_Archive]    Script Date: 22/10/2022 01:21:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Purchasing].[Suppliers_Archive](
	[SupplierID] [int] NOT NULL,
	[SupplierName] [nvarchar](100) NOT NULL,
	[SupplierCategoryID] [int] NOT NULL,
	[PrimaryContactPersonID] [int] NOT NULL,
	[AlternateContactPersonID] [int] NOT NULL,
	[DeliveryMethodID] [int] NULL,
	[DeliveryCityID] [int] NOT NULL,
	[PostalCityID] [int] NOT NULL,
	[SupplierReference] [nvarchar](20) NULL,
	[BankAccountName] [nvarchar](50) MASKED WITH (FUNCTION = 'default()') NULL,
	[BankAccountBranch] [nvarchar](50) MASKED WITH (FUNCTION = 'default()') NULL,
	[BankAccountCode] [nvarchar](20) MASKED WITH (FUNCTION = 'default()') NULL,
	[BankAccountNumber] [nvarchar](20) MASKED WITH (FUNCTION = 'default()') NULL,
	[BankInternationalCode] [nvarchar](20) MASKED WITH (FUNCTION = 'default()') NULL,
	[PaymentDays] [int] NOT NULL,
	[InternalComments] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](20) NOT NULL,
	[FaxNumber] [nvarchar](20) NOT NULL,
	[WebsiteURL] [nvarchar](256) NOT NULL,
	[DeliveryAddressLine1] [nvarchar](60) NOT NULL,
	[DeliveryAddressLine2] [nvarchar](60) NULL,
	[DeliveryPostalCode] [nvarchar](10) NOT NULL,
	[DeliveryLocation] [geography] NULL,
	[PostalAddressLine1] [nvarchar](60) NOT NULL,
	[PostalAddressLine2] [nvarchar](60) NULL,
	[PostalPostalCode] [nvarchar](10) NOT NULL,
	[LastEditedBy] [int] NOT NULL,
	[ValidFrom] [datetime2](7) NOT NULL,
	[ValidTo] [datetime2](7) NOT NULL
) ON [USERDATA] TEXTIMAGE_ON [USERDATA]
GO
/****** Object:  Table [Purchasing].[Suppliers]    Script Date: 22/10/2022 01:21:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Purchasing].[Suppliers](
	[SupplierID] [int] NOT NULL,
	[SupplierName] [nvarchar](100) NOT NULL,
	[SupplierCategoryID] [int] NOT NULL,
	[PrimaryContactPersonID] [int] NOT NULL,
	[AlternateContactPersonID] [int] NOT NULL,
	[DeliveryMethodID] [int] NULL,
	[DeliveryCityID] [int] NOT NULL,
	[PostalCityID] [int] NOT NULL,
	[SupplierReference] [nvarchar](20) NULL,
	[BankAccountName] [nvarchar](50) MASKED WITH (FUNCTION = 'default()') NULL,
	[BankAccountBranch] [nvarchar](50) MASKED WITH (FUNCTION = 'default()') NULL,
	[BankAccountCode] [nvarchar](20) MASKED WITH (FUNCTION = 'default()') NULL,
	[BankAccountNumber] [nvarchar](20) MASKED WITH (FUNCTION = 'default()') NULL,
	[BankInternationalCode] [nvarchar](20) MASKED WITH (FUNCTION = 'default()') NULL,
	[PaymentDays] [int] NOT NULL,
	[InternalComments] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](20) NOT NULL,
	[FaxNumber] [nvarchar](20) NOT NULL,
	[WebsiteURL] [nvarchar](256) NOT NULL,
	[DeliveryAddressLine1] [nvarchar](60) NOT NULL,
	[DeliveryAddressLine2] [nvarchar](60) NULL,
	[DeliveryPostalCode] [nvarchar](10) NOT NULL,
	[DeliveryLocation] [geography] NULL,
	[PostalAddressLine1] [nvarchar](60) NOT NULL,
	[PostalAddressLine2] [nvarchar](60) NULL,
	[PostalPostalCode] [nvarchar](10) NOT NULL,
	[LastEditedBy] [int] NOT NULL,
	[ValidFrom] [datetime2](7) GENERATED ALWAYS AS ROW START NOT NULL,
	[ValidTo] [datetime2](7) GENERATED ALWAYS AS ROW END NOT NULL,
 CONSTRAINT [PK_Purchasing_Suppliers] PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [USERDATA],
 CONSTRAINT [UQ_Purchasing_Suppliers_SupplierName] UNIQUE NONCLUSTERED 
(
	[SupplierName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [USERDATA],
	PERIOD FOR SYSTEM_TIME ([ValidFrom], [ValidTo])
) ON [USERDATA] TEXTIMAGE_ON [USERDATA]
WITH
(
SYSTEM_VERSIONING = ON (HISTORY_TABLE = [Purchasing].[Suppliers_Archive])
)
GO
/****** Object:  Table [Sales].[Customers_Archive]    Script Date: 22/10/2022 01:21:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Sales].[Customers_Archive](
	[CustomerID] [int] NOT NULL,
	[CustomerName] [nvarchar](100) NOT NULL,
	[BillToCustomerID] [int] NOT NULL,
	[CustomerCategoryID] [int] NOT NULL,
	[BuyingGroupID] [int] NULL,
	[PrimaryContactPersonID] [int] NOT NULL,
	[AlternateContactPersonID] [int] NULL,
	[DeliveryMethodID] [int] NOT NULL,
	[DeliveryCityID] [int] NOT NULL,
	[PostalCityID] [int] NOT NULL,
	[CreditLimit] [decimal](18, 2) NULL,
	[AccountOpenedDate] [date] NOT NULL,
	[StandardDiscountPercentage] [decimal](18, 3) NOT NULL,
	[IsStatementSent] [bit] NOT NULL,
	[IsOnCreditHold] [bit] NOT NULL,
	[PaymentDays] [int] NOT NULL,
	[PhoneNumber] [nvarchar](20) NOT NULL,
	[FaxNumber] [nvarchar](20) NOT NULL,
	[DeliveryRun] [nvarchar](5) NULL,
	[RunPosition] [nvarchar](5) NULL,
	[WebsiteURL] [nvarchar](256) NOT NULL,
	[DeliveryAddressLine1] [nvarchar](60) NOT NULL,
	[DeliveryAddressLine2] [nvarchar](60) NULL,
	[DeliveryPostalCode] [nvarchar](10) NOT NULL,
	[DeliveryLocation] [geography] NULL,
	[PostalAddressLine1] [nvarchar](60) NOT NULL,
	[PostalAddressLine2] [nvarchar](60) NULL,
	[PostalPostalCode] [nvarchar](10) NOT NULL,
	[LastEditedBy] [int] NOT NULL,
	[ValidFrom] [datetime2](7) NOT NULL,
	[ValidTo] [datetime2](7) NOT NULL
) ON [USERDATA] TEXTIMAGE_ON [USERDATA]
GO
/****** Object:  Table [Sales].[Customers]    Script Date: 22/10/2022 01:21:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Sales].[Customers](
	[CustomerID] [int] NOT NULL,
	[CustomerName] [nvarchar](100) NOT NULL,
	[BillToCustomerID] [int] NOT NULL,
	[CustomerCategoryID] [int] NOT NULL,
	[BuyingGroupID] [int] NULL,
	[PrimaryContactPersonID] [int] NOT NULL,
	[AlternateContactPersonID] [int] NULL,
	[DeliveryMethodID] [int] NOT NULL,
	[DeliveryCityID] [int] NOT NULL,
	[PostalCityID] [int] NOT NULL,
	[CreditLimit] [decimal](18, 2) NULL,
	[AccountOpenedDate] [date] NOT NULL,
	[StandardDiscountPercentage] [decimal](18, 3) NOT NULL,
	[IsStatementSent] [bit] NOT NULL,
	[IsOnCreditHold] [bit] NOT NULL,
	[PaymentDays] [int] NOT NULL,
	[PhoneNumber] [nvarchar](20) NOT NULL,
	[FaxNumber] [nvarchar](20) NOT NULL,
	[DeliveryRun] [nvarchar](5) NULL,
	[RunPosition] [nvarchar](5) NULL,
	[WebsiteURL] [nvarchar](256) NOT NULL,
	[DeliveryAddressLine1] [nvarchar](60) NOT NULL,
	[DeliveryAddressLine2] [nvarchar](60) NULL,
	[DeliveryPostalCode] [nvarchar](10) NOT NULL,
	[DeliveryLocation] [geography] NULL,
	[PostalAddressLine1] [nvarchar](60) NOT NULL,
	[PostalAddressLine2] [nvarchar](60) NULL,
	[PostalPostalCode] [nvarchar](10) NOT NULL,
	[LastEditedBy] [int] NOT NULL,
	[ValidFrom] [datetime2](7) GENERATED ALWAYS AS ROW START NOT NULL,
	[ValidTo] [datetime2](7) GENERATED ALWAYS AS ROW END NOT NULL,
 CONSTRAINT [PK_Sales_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [USERDATA],
 CONSTRAINT [UQ_Sales_Customers_CustomerName] UNIQUE NONCLUSTERED 
(
	[CustomerName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [USERDATA],
	PERIOD FOR SYSTEM_TIME ([ValidFrom], [ValidTo])
) ON [USERDATA] TEXTIMAGE_ON [USERDATA]
WITH
(
SYSTEM_VERSIONING = ON (HISTORY_TABLE = [Sales].[Customers_Archive])
)
GO
/****** Object:  Table [Purchasing].[SupplierCategories_Archive]    Script Date: 22/10/2022 01:21:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Purchasing].[SupplierCategories_Archive](
	[SupplierCategoryID] [int] NOT NULL,
	[SupplierCategoryName] [nvarchar](50) NOT NULL,
	[LastEditedBy] [int] NOT NULL,
	[ValidFrom] [datetime2](7) NOT NULL,
	[ValidTo] [datetime2](7) NOT NULL
) ON [USERDATA]
GO
/****** Object:  Table [Purchasing].[SupplierCategories]    Script Date: 22/10/2022 01:21:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Purchasing].[SupplierCategories](
	[SupplierCategoryID] [int] NOT NULL,
	[SupplierCategoryName] [nvarchar](50) NOT NULL,
	[LastEditedBy] [int] NOT NULL,
	[ValidFrom] [datetime2](7) GENERATED ALWAYS AS ROW START NOT NULL,
	[ValidTo] [datetime2](7) GENERATED ALWAYS AS ROW END NOT NULL,
 CONSTRAINT [PK_Purchasing_SupplierCategories] PRIMARY KEY CLUSTERED 
(
	[SupplierCategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [USERDATA],
 CONSTRAINT [UQ_Purchasing_SupplierCategories_SupplierCategoryName] UNIQUE NONCLUSTERED 
(
	[SupplierCategoryName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [USERDATA],
	PERIOD FOR SYSTEM_TIME ([ValidFrom], [ValidTo])
) ON [USERDATA]
WITH
(
SYSTEM_VERSIONING = ON (HISTORY_TABLE = [Purchasing].[SupplierCategories_Archive])
)
GO
/****** Object:  Table [Sales].[BuyingGroups_Archive]    Script Date: 22/10/2022 01:21:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Sales].[BuyingGroups_Archive](
	[BuyingGroupID] [int] NOT NULL,
	[BuyingGroupName] [nvarchar](50) NOT NULL,
	[LastEditedBy] [int] NOT NULL,
	[ValidFrom] [datetime2](7) NOT NULL,
	[ValidTo] [datetime2](7) NOT NULL
) ON [USERDATA]
GO
/****** Object:  Table [Sales].[BuyingGroups]    Script Date: 22/10/2022 01:21:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Sales].[BuyingGroups](
	[BuyingGroupID] [int] NOT NULL,
	[BuyingGroupName] [nvarchar](50) NOT NULL,
	[LastEditedBy] [int] NOT NULL,
	[ValidFrom] [datetime2](7) GENERATED ALWAYS AS ROW START NOT NULL,
	[ValidTo] [datetime2](7) GENERATED ALWAYS AS ROW END NOT NULL,
 CONSTRAINT [PK_Sales_BuyingGroups] PRIMARY KEY CLUSTERED 
(
	[BuyingGroupID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [USERDATA],
 CONSTRAINT [UQ_Sales_BuyingGroups_BuyingGroupName] UNIQUE NONCLUSTERED 
(
	[BuyingGroupName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [USERDATA],
	PERIOD FOR SYSTEM_TIME ([ValidFrom], [ValidTo])
) ON [USERDATA]
WITH
(
SYSTEM_VERSIONING = ON (HISTORY_TABLE = [Sales].[BuyingGroups_Archive])
)
GO
/****** Object:  Table [Sales].[CustomerCategories_Archive]    Script Date: 22/10/2022 01:21:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Sales].[CustomerCategories_Archive](
	[CustomerCategoryID] [int] NOT NULL,
	[CustomerCategoryName] [nvarchar](50) NOT NULL,
	[LastEditedBy] [int] NOT NULL,
	[ValidFrom] [datetime2](7) NOT NULL,
	[ValidTo] [datetime2](7) NOT NULL
) ON [USERDATA]
GO
/****** Object:  Table [Sales].[CustomerCategories]    Script Date: 22/10/2022 01:21:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Sales].[CustomerCategories](
	[CustomerCategoryID] [int] NOT NULL,
	[CustomerCategoryName] [nvarchar](50) NOT NULL,
	[LastEditedBy] [int] NOT NULL,
	[ValidFrom] [datetime2](7) GENERATED ALWAYS AS ROW START NOT NULL,
	[ValidTo] [datetime2](7) GENERATED ALWAYS AS ROW END NOT NULL,
 CONSTRAINT [PK_Sales_CustomerCategories] PRIMARY KEY CLUSTERED 
(
	[CustomerCategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [USERDATA],
 CONSTRAINT [UQ_Sales_CustomerCategories_CustomerCategoryName] UNIQUE NONCLUSTERED 
(
	[CustomerCategoryName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [USERDATA],
	PERIOD FOR SYSTEM_TIME ([ValidFrom], [ValidTo])
) ON [USERDATA]
WITH
(
SYSTEM_VERSIONING = ON (HISTORY_TABLE = [Sales].[CustomerCategories_Archive])
)
GO
/****** Object:  UserDefinedFunction [Application].[DetermineCustomerAccess]    Script Date: 22/10/2022 01:21:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [Application].[DetermineCustomerAccess](@CityID int)
RETURNS TABLE
WITH SCHEMABINDING
AS
RETURN (SELECT 1 AS AccessResult
        WHERE IS_ROLEMEMBER(N'db_owner') <> 0
        OR IS_ROLEMEMBER((SELECT sp.SalesTerritory
                          FROM [Application].Cities AS c
                          INNER JOIN [Application].StateProvinces AS sp
                          ON c.StateProvinceID = sp.StateProvinceID
                          WHERE c.CityID = @CityID) + N' Sales') <> 0
	    OR (ORIGINAL_LOGIN() = N'Website'
		    AND EXISTS (SELECT 1
		                FROM [Application].Cities AS c
				        INNER JOIN [Application].StateProvinces AS sp
				        ON c.StateProvinceID = sp.StateProvinceID
				        WHERE c.CityID = @CityID
				        AND sp.SalesTerritory = SESSION_CONTEXT(N'SalesTerritory'))));
GO
/****** Object:  Table [Purchasing].[PurchaseOrderLines]    Script Date: 22/10/2022 01:21:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Purchasing].[PurchaseOrderLines](
	[PurchaseOrderLineID] [int] NOT NULL,
	[PurchaseOrderID] [int] NOT NULL,
	[StockItemID] [int] NOT NULL,
	[OrderedOuters] [int] NOT NULL,
	[Description] [nvarchar](100) NOT NULL,
	[ReceivedOuters] [int] NOT NULL,
	[PackageTypeID] [int] NOT NULL,
	[ExpectedUnitPricePerOuter] [decimal](18, 2) NULL,
	[LastReceiptDate] [date] NULL,
	[IsOrderLineFinalized] [bit] NOT NULL,
	[LastEditedBy] [int] NOT NULL,
	[LastEditedWhen] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Purchasing_PurchaseOrderLines] PRIMARY KEY CLUSTERED 
(
	[PurchaseOrderLineID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [USERDATA]
) ON [USERDATA]
GO
/****** Object:  Table [Purchasing].[PurchaseOrders]    Script Date: 22/10/2022 01:21:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Purchasing].[PurchaseOrders](
	[PurchaseOrderID] [int] NOT NULL,
	[SupplierID] [int] NOT NULL,
	[OrderDate] [date] NOT NULL,
	[DeliveryMethodID] [int] NOT NULL,
	[ContactPersonID] [int] NOT NULL,
	[ExpectedDeliveryDate] [date] NULL,
	[SupplierReference] [nvarchar](20) NULL,
	[IsOrderFinalized] [bit] NOT NULL,
	[Comments] [nvarchar](max) NULL,
	[InternalComments] [nvarchar](max) NULL,
	[LastEditedBy] [int] NOT NULL,
	[LastEditedWhen] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Purchasing_PurchaseOrders] PRIMARY KEY CLUSTERED 
(
	[PurchaseOrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [USERDATA]
) ON [USERDATA] TEXTIMAGE_ON [USERDATA]
GO
/****** Object:  Table [Purchasing].[SupplierTransactions]    Script Date: 22/10/2022 01:21:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Purchasing].[SupplierTransactions](
	[SupplierTransactionID] [int] NOT NULL,
	[SupplierID] [int] NOT NULL,
	[TransactionTypeID] [int] NOT NULL,
	[PurchaseOrderID] [int] NULL,
	[PaymentMethodID] [int] NULL,
	[SupplierInvoiceNumber] [nvarchar](20) NULL,
	[TransactionDate] [date] NOT NULL,
	[AmountExcludingTax] [decimal](18, 2) NOT NULL,
	[TaxAmount] [decimal](18, 2) NOT NULL,
	[TransactionAmount] [decimal](18, 2) NOT NULL,
	[OutstandingBalance] [decimal](18, 2) NOT NULL,
	[FinalizationDate] [date] NULL,
	[IsFinalized]  AS (case when [FinalizationDate] IS NULL then CONVERT([bit],(0)) else CONVERT([bit],(1)) end) PERSISTED,
	[LastEditedBy] [int] NOT NULL,
	[LastEditedWhen] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Purchasing_SupplierTransactions] PRIMARY KEY CLUSTERED 
(
	[SupplierTransactionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [USERDATA]
) ON [USERDATA]
GO
/****** Object:  Table [Sales].[CustomerTransactions]    Script Date: 22/10/2022 01:21:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Sales].[CustomerTransactions](
	[CustomerTransactionID] [int] NOT NULL,
	[CustomerID] [int] NOT NULL,
	[TransactionTypeID] [int] NOT NULL,
	[InvoiceID] [int] NULL,
	[PaymentMethodID] [int] NULL,
	[TransactionDate] [date] NOT NULL,
	[AmountExcludingTax] [decimal](18, 2) NOT NULL,
	[TaxAmount] [decimal](18, 2) NOT NULL,
	[TransactionAmount] [decimal](18, 2) NOT NULL,
	[OutstandingBalance] [decimal](18, 2) NOT NULL,
	[FinalizationDate] [date] NULL,
	[IsFinalized]  AS (case when [FinalizationDate] IS NULL then CONVERT([bit],(0)) else CONVERT([bit],(1)) end) PERSISTED,
	[LastEditedBy] [int] NOT NULL,
	[LastEditedWhen] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Sales_CustomerTransactions] PRIMARY KEY CLUSTERED 
(
	[CustomerTransactionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [USERDATA]
) ON [USERDATA]
GO
/****** Object:  Table [Sales].[InvoiceLines]    Script Date: 22/10/2022 01:21:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Sales].[InvoiceLines](
	[InvoiceLineID] [int] NOT NULL,
	[InvoiceID] [int] NOT NULL,
	[StockItemID] [int] NOT NULL,
	[Description] [nvarchar](100) NOT NULL,
	[PackageTypeID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[UnitPrice] [decimal](18, 2) NULL,
	[TaxRate] [decimal](18, 3) NOT NULL,
	[TaxAmount] [decimal](18, 2) NOT NULL,
	[LineProfit] [decimal](18, 2) NOT NULL,
	[ExtendedPrice] [decimal](18, 2) NOT NULL,
	[LastEditedBy] [int] NOT NULL,
	[LastEditedWhen] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Sales_InvoiceLines] PRIMARY KEY CLUSTERED 
(
	[InvoiceLineID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [USERDATA]
) ON [USERDATA]
GO
/****** Object:  Table [Sales].[Invoices]    Script Date: 22/10/2022 01:21:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Sales].[Invoices](
	[InvoiceID] [int] NOT NULL,
	[CustomerID] [int] NOT NULL,
	[BillToCustomerID] [int] NOT NULL,
	[OrderID] [int] NULL,
	[DeliveryMethodID] [int] NOT NULL,
	[ContactPersonID] [int] NOT NULL,
	[AccountsPersonID] [int] NOT NULL,
	[SalespersonPersonID] [int] NOT NULL,
	[PackedByPersonID] [int] NOT NULL,
	[InvoiceDate] [date] NOT NULL,
	[CustomerPurchaseOrderNumber] [nvarchar](20) NULL,
	[IsCreditNote] [bit] NOT NULL,
	[CreditNoteReason] [nvarchar](max) NULL,
	[Comments] [nvarchar](max) NULL,
	[DeliveryInstructions] [nvarchar](max) NULL,
	[InternalComments] [nvarchar](max) NULL,
	[TotalDryItems] [int] NOT NULL,
	[TotalChillerItems] [int] NOT NULL,
	[DeliveryRun] [nvarchar](5) NULL,
	[RunPosition] [nvarchar](5) NULL,
	[ReturnedDeliveryData] [nvarchar](max) NULL,
	[ConfirmedDeliveryTime]  AS (TRY_CONVERT([datetime2](7),json_value([ReturnedDeliveryData],N'$.DeliveredWhen'),(126))),
	[ConfirmedReceivedBy]  AS (json_value([ReturnedDeliveryData],N'$.ReceivedBy')),
	[LastEditedBy] [int] NOT NULL,
	[LastEditedWhen] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Sales_Invoices] PRIMARY KEY CLUSTERED 
(
	[InvoiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [USERDATA]
) ON [USERDATA] TEXTIMAGE_ON [USERDATA]
GO
/****** Object:  Table [Sales].[OrderLines]    Script Date: 22/10/2022 01:21:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Sales].[OrderLines](
	[OrderLineID] [int] NOT NULL,
	[OrderID] [int] NOT NULL,
	[StockItemID] [int] NOT NULL,
	[Description] [nvarchar](100) NOT NULL,
	[PackageTypeID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[UnitPrice] [decimal](18, 2) NULL,
	[TaxRate] [decimal](18, 3) NOT NULL,
	[PickedQuantity] [int] NOT NULL,
	[PickingCompletedWhen] [datetime2](7) NULL,
	[LastEditedBy] [int] NOT NULL,
	[LastEditedWhen] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Sales_OrderLines] PRIMARY KEY CLUSTERED 
(
	[OrderLineID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [USERDATA]
) ON [USERDATA]
GO
/****** Object:  Table [Sales].[Orders]    Script Date: 22/10/2022 01:21:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Sales].[Orders](
	[OrderID] [int] NOT NULL,
	[CustomerID] [int] NOT NULL,
	[SalespersonPersonID] [int] NOT NULL,
	[PickedByPersonID] [int] NULL,
	[ContactPersonID] [int] NOT NULL,
	[BackorderOrderID] [int] NULL,
	[OrderDate] [date] NOT NULL,
	[ExpectedDeliveryDate] [date] NOT NULL,
	[CustomerPurchaseOrderNumber] [nvarchar](20) NULL,
	[IsUndersupplyBackordered] [bit] NOT NULL,
	[Comments] [nvarchar](max) NULL,
	[DeliveryInstructions] [nvarchar](max) NULL,
	[InternalComments] [nvarchar](max) NULL,
	[PickingCompletedWhen] [datetime2](7) NULL,
	[LastEditedBy] [int] NOT NULL,
	[LastEditedWhen] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Sales_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [USERDATA]
) ON [USERDATA] TEXTIMAGE_ON [USERDATA]
GO
/****** Object:  Table [Sales].[SpecialDeals]    Script Date: 22/10/2022 01:21:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Sales].[SpecialDeals](
	[SpecialDealID] [int] NOT NULL,
	[StockItemID] [int] NULL,
	[CustomerID] [int] NULL,
	[BuyingGroupID] [int] NULL,
	[CustomerCategoryID] [int] NULL,
	[StockGroupID] [int] NULL,
	[DealDescription] [nvarchar](30) NOT NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NOT NULL,
	[DiscountAmount] [decimal](18, 2) NULL,
	[DiscountPercentage] [decimal](18, 3) NULL,
	[UnitPrice] [decimal](18, 2) NULL,
	[LastEditedBy] [int] NOT NULL,
	[LastEditedWhen] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Sales_SpecialDeals] PRIMARY KEY CLUSTERED 
(
	[SpecialDealID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [USERDATA]
) ON [USERDATA]
GO
ALTER TABLE [Purchasing].[PurchaseOrderLines] ADD  CONSTRAINT [DF_Purchasing_PurchaseOrderLines_PurchaseOrderLineID]  DEFAULT (NEXT VALUE FOR [Sequences].[PurchaseOrderLineID]) FOR [PurchaseOrderLineID]
GO
ALTER TABLE [Purchasing].[PurchaseOrderLines] ADD  CONSTRAINT [DF_Purchasing_PurchaseOrderLines_LastEditedWhen]  DEFAULT (sysdatetime()) FOR [LastEditedWhen]
GO
ALTER TABLE [Purchasing].[PurchaseOrders] ADD  CONSTRAINT [DF_Purchasing_PurchaseOrders_PurchaseOrderID]  DEFAULT (NEXT VALUE FOR [Sequences].[PurchaseOrderID]) FOR [PurchaseOrderID]
GO
ALTER TABLE [Purchasing].[PurchaseOrders] ADD  CONSTRAINT [DF_Purchasing_PurchaseOrders_LastEditedWhen]  DEFAULT (sysdatetime()) FOR [LastEditedWhen]
GO
ALTER TABLE [Purchasing].[SupplierCategories] ADD  CONSTRAINT [DF_Purchasing_SupplierCategories_SupplierCategoryID]  DEFAULT (NEXT VALUE FOR [Sequences].[SupplierCategoryID]) FOR [SupplierCategoryID]
GO
ALTER TABLE [Purchasing].[Suppliers] ADD  CONSTRAINT [DF_Purchasing_Suppliers_SupplierID]  DEFAULT (NEXT VALUE FOR [Sequences].[SupplierID]) FOR [SupplierID]
GO
ALTER TABLE [Purchasing].[SupplierTransactions] ADD  CONSTRAINT [DF_Purchasing_SupplierTransactions_SupplierTransactionID]  DEFAULT (NEXT VALUE FOR [Sequences].[TransactionID]) FOR [SupplierTransactionID]
GO
ALTER TABLE [Purchasing].[SupplierTransactions] ADD  CONSTRAINT [DF_Purchasing_SupplierTransactions_LastEditedWhen]  DEFAULT (sysdatetime()) FOR [LastEditedWhen]
GO
ALTER TABLE [Sales].[BuyingGroups] ADD  CONSTRAINT [DF_Sales_BuyingGroups_BuyingGroupID]  DEFAULT (NEXT VALUE FOR [Sequences].[BuyingGroupID]) FOR [BuyingGroupID]
GO
ALTER TABLE [Sales].[CustomerCategories] ADD  CONSTRAINT [DF_Sales_CustomerCategories_CustomerCategoryID]  DEFAULT (NEXT VALUE FOR [Sequences].[CustomerCategoryID]) FOR [CustomerCategoryID]
GO
ALTER TABLE [Sales].[Customers] ADD  CONSTRAINT [DF_Sales_Customers_CustomerID]  DEFAULT (NEXT VALUE FOR [Sequences].[CustomerID]) FOR [CustomerID]
GO
ALTER TABLE [Sales].[CustomerTransactions] ADD  CONSTRAINT [DF_Sales_CustomerTransactions_CustomerTransactionID]  DEFAULT (NEXT VALUE FOR [Sequences].[TransactionID]) FOR [CustomerTransactionID]
GO
ALTER TABLE [Sales].[CustomerTransactions] ADD  CONSTRAINT [DF_Sales_CustomerTransactions_LastEditedWhen]  DEFAULT (sysdatetime()) FOR [LastEditedWhen]
GO
ALTER TABLE [Sales].[InvoiceLines] ADD  CONSTRAINT [DF_Sales_InvoiceLines_InvoiceLineID]  DEFAULT (NEXT VALUE FOR [Sequences].[InvoiceLineID]) FOR [InvoiceLineID]
GO
ALTER TABLE [Sales].[InvoiceLines] ADD  CONSTRAINT [DF_Sales_InvoiceLines_LastEditedWhen]  DEFAULT (sysdatetime()) FOR [LastEditedWhen]
GO
ALTER TABLE [Sales].[Invoices] ADD  CONSTRAINT [DF_Sales_Invoices_InvoiceID]  DEFAULT (NEXT VALUE FOR [Sequences].[InvoiceID]) FOR [InvoiceID]
GO
ALTER TABLE [Sales].[Invoices] ADD  CONSTRAINT [DF_Sales_Invoices_LastEditedWhen]  DEFAULT (sysdatetime()) FOR [LastEditedWhen]
GO
ALTER TABLE [Sales].[OrderLines] ADD  CONSTRAINT [DF_Sales_OrderLines_OrderLineID]  DEFAULT (NEXT VALUE FOR [Sequences].[OrderLineID]) FOR [OrderLineID]
GO
ALTER TABLE [Sales].[OrderLines] ADD  CONSTRAINT [DF_Sales_OrderLines_LastEditedWhen]  DEFAULT (sysdatetime()) FOR [LastEditedWhen]
GO
ALTER TABLE [Sales].[Orders] ADD  CONSTRAINT [DF_Sales_Orders_OrderID]  DEFAULT (NEXT VALUE FOR [Sequences].[OrderID]) FOR [OrderID]
GO
ALTER TABLE [Sales].[Orders] ADD  CONSTRAINT [DF_Sales_Orders_LastEditedWhen]  DEFAULT (sysdatetime()) FOR [LastEditedWhen]
GO
ALTER TABLE [Sales].[SpecialDeals] ADD  CONSTRAINT [DF_Sales_SpecialDeals_SpecialDealID]  DEFAULT (NEXT VALUE FOR [Sequences].[SpecialDealID]) FOR [SpecialDealID]
GO
ALTER TABLE [Sales].[SpecialDeals] ADD  CONSTRAINT [DF_Sales_SpecialDeals_LastEditedWhen]  DEFAULT (sysdatetime()) FOR [LastEditedWhen]
GO
ALTER TABLE [Purchasing].[PurchaseOrderLines]  WITH CHECK ADD  CONSTRAINT [FK_Purchasing_PurchaseOrderLines_Application_People] FOREIGN KEY([LastEditedBy])
REFERENCES [Application].[People] ([PersonID])
GO
ALTER TABLE [Purchasing].[PurchaseOrderLines] CHECK CONSTRAINT [FK_Purchasing_PurchaseOrderLines_Application_People]
GO
ALTER TABLE [Purchasing].[PurchaseOrderLines]  WITH CHECK ADD  CONSTRAINT [FK_Purchasing_PurchaseOrderLines_PackageTypeID_Warehouse_PackageTypes] FOREIGN KEY([PackageTypeID])
REFERENCES [Warehouse].[PackageTypes] ([PackageTypeID])
GO
ALTER TABLE [Purchasing].[PurchaseOrderLines] CHECK CONSTRAINT [FK_Purchasing_PurchaseOrderLines_PackageTypeID_Warehouse_PackageTypes]
GO
ALTER TABLE [Purchasing].[PurchaseOrderLines]  WITH CHECK ADD  CONSTRAINT [FK_Purchasing_PurchaseOrderLines_PurchaseOrderID_Purchasing_PurchaseOrders] FOREIGN KEY([PurchaseOrderID])
REFERENCES [Purchasing].[PurchaseOrders] ([PurchaseOrderID])
GO
ALTER TABLE [Purchasing].[PurchaseOrderLines] CHECK CONSTRAINT [FK_Purchasing_PurchaseOrderLines_PurchaseOrderID_Purchasing_PurchaseOrders]
GO
ALTER TABLE [Purchasing].[PurchaseOrderLines]  WITH CHECK ADD  CONSTRAINT [FK_Purchasing_PurchaseOrderLines_StockItemID_Warehouse_StockItems] FOREIGN KEY([StockItemID])
REFERENCES [Warehouse].[StockItems] ([StockItemID])
GO
ALTER TABLE [Purchasing].[PurchaseOrderLines] CHECK CONSTRAINT [FK_Purchasing_PurchaseOrderLines_StockItemID_Warehouse_StockItems]
GO
ALTER TABLE [Purchasing].[PurchaseOrders]  WITH CHECK ADD  CONSTRAINT [FK_Purchasing_PurchaseOrders_Application_People] FOREIGN KEY([LastEditedBy])
REFERENCES [Application].[People] ([PersonID])
GO
ALTER TABLE [Purchasing].[PurchaseOrders] CHECK CONSTRAINT [FK_Purchasing_PurchaseOrders_Application_People]
GO
ALTER TABLE [Purchasing].[PurchaseOrders]  WITH CHECK ADD  CONSTRAINT [FK_Purchasing_PurchaseOrders_ContactPersonID_Application_People] FOREIGN KEY([ContactPersonID])
REFERENCES [Application].[People] ([PersonID])
GO
ALTER TABLE [Purchasing].[PurchaseOrders] CHECK CONSTRAINT [FK_Purchasing_PurchaseOrders_ContactPersonID_Application_People]
GO
ALTER TABLE [Purchasing].[PurchaseOrders]  WITH CHECK ADD  CONSTRAINT [FK_Purchasing_PurchaseOrders_DeliveryMethodID_Application_DeliveryMethods] FOREIGN KEY([DeliveryMethodID])
REFERENCES [Application].[DeliveryMethods] ([DeliveryMethodID])
GO
ALTER TABLE [Purchasing].[PurchaseOrders] CHECK CONSTRAINT [FK_Purchasing_PurchaseOrders_DeliveryMethodID_Application_DeliveryMethods]
GO
ALTER TABLE [Purchasing].[PurchaseOrders]  WITH CHECK ADD  CONSTRAINT [FK_Purchasing_PurchaseOrders_SupplierID_Purchasing_Suppliers] FOREIGN KEY([SupplierID])
REFERENCES [Purchasing].[Suppliers] ([SupplierID])
GO
ALTER TABLE [Purchasing].[PurchaseOrders] CHECK CONSTRAINT [FK_Purchasing_PurchaseOrders_SupplierID_Purchasing_Suppliers]
GO
ALTER TABLE [Purchasing].[SupplierCategories]  WITH CHECK ADD  CONSTRAINT [FK_Purchasing_SupplierCategories_Application_People] FOREIGN KEY([LastEditedBy])
REFERENCES [Application].[People] ([PersonID])
GO
ALTER TABLE [Purchasing].[SupplierCategories] CHECK CONSTRAINT [FK_Purchasing_SupplierCategories_Application_People]
GO
ALTER TABLE [Purchasing].[Suppliers]  WITH CHECK ADD  CONSTRAINT [FK_Purchasing_Suppliers_AlternateContactPersonID_Application_People] FOREIGN KEY([AlternateContactPersonID])
REFERENCES [Application].[People] ([PersonID])
GO
ALTER TABLE [Purchasing].[Suppliers] CHECK CONSTRAINT [FK_Purchasing_Suppliers_AlternateContactPersonID_Application_People]
GO
ALTER TABLE [Purchasing].[Suppliers]  WITH CHECK ADD  CONSTRAINT [FK_Purchasing_Suppliers_Application_People] FOREIGN KEY([LastEditedBy])
REFERENCES [Application].[People] ([PersonID])
GO
ALTER TABLE [Purchasing].[Suppliers] CHECK CONSTRAINT [FK_Purchasing_Suppliers_Application_People]
GO
ALTER TABLE [Purchasing].[Suppliers]  WITH CHECK ADD  CONSTRAINT [FK_Purchasing_Suppliers_DeliveryCityID_Application_Cities] FOREIGN KEY([DeliveryCityID])
REFERENCES [Application].[Cities] ([CityID])
GO
ALTER TABLE [Purchasing].[Suppliers] CHECK CONSTRAINT [FK_Purchasing_Suppliers_DeliveryCityID_Application_Cities]
GO
ALTER TABLE [Purchasing].[Suppliers]  WITH CHECK ADD  CONSTRAINT [FK_Purchasing_Suppliers_DeliveryMethodID_Application_DeliveryMethods] FOREIGN KEY([DeliveryMethodID])
REFERENCES [Application].[DeliveryMethods] ([DeliveryMethodID])
GO
ALTER TABLE [Purchasing].[Suppliers] CHECK CONSTRAINT [FK_Purchasing_Suppliers_DeliveryMethodID_Application_DeliveryMethods]
GO
ALTER TABLE [Purchasing].[Suppliers]  WITH CHECK ADD  CONSTRAINT [FK_Purchasing_Suppliers_PostalCityID_Application_Cities] FOREIGN KEY([PostalCityID])
REFERENCES [Application].[Cities] ([CityID])
GO
ALTER TABLE [Purchasing].[Suppliers] CHECK CONSTRAINT [FK_Purchasing_Suppliers_PostalCityID_Application_Cities]
GO
ALTER TABLE [Purchasing].[Suppliers]  WITH CHECK ADD  CONSTRAINT [FK_Purchasing_Suppliers_PrimaryContactPersonID_Application_People] FOREIGN KEY([PrimaryContactPersonID])
REFERENCES [Application].[People] ([PersonID])
GO
ALTER TABLE [Purchasing].[Suppliers] CHECK CONSTRAINT [FK_Purchasing_Suppliers_PrimaryContactPersonID_Application_People]
GO
ALTER TABLE [Purchasing].[Suppliers]  WITH CHECK ADD  CONSTRAINT [FK_Purchasing_Suppliers_SupplierCategoryID_Purchasing_SupplierCategories] FOREIGN KEY([SupplierCategoryID])
REFERENCES [Purchasing].[SupplierCategories] ([SupplierCategoryID])
GO
ALTER TABLE [Purchasing].[Suppliers] CHECK CONSTRAINT [FK_Purchasing_Suppliers_SupplierCategoryID_Purchasing_SupplierCategories]
GO
ALTER TABLE [Purchasing].[SupplierTransactions]  WITH CHECK ADD  CONSTRAINT [FK_Purchasing_SupplierTransactions_Application_People] FOREIGN KEY([LastEditedBy])
REFERENCES [Application].[People] ([PersonID])
GO
ALTER TABLE [Purchasing].[SupplierTransactions] CHECK CONSTRAINT [FK_Purchasing_SupplierTransactions_Application_People]
GO
ALTER TABLE [Purchasing].[SupplierTransactions]  WITH CHECK ADD  CONSTRAINT [FK_Purchasing_SupplierTransactions_PaymentMethodID_Application_PaymentMethods] FOREIGN KEY([PaymentMethodID])
REFERENCES [Application].[PaymentMethods] ([PaymentMethodID])
GO
ALTER TABLE [Purchasing].[SupplierTransactions] CHECK CONSTRAINT [FK_Purchasing_SupplierTransactions_PaymentMethodID_Application_PaymentMethods]
GO
ALTER TABLE [Purchasing].[SupplierTransactions]  WITH CHECK ADD  CONSTRAINT [FK_Purchasing_SupplierTransactions_PurchaseOrderID_Purchasing_PurchaseOrders] FOREIGN KEY([PurchaseOrderID])
REFERENCES [Purchasing].[PurchaseOrders] ([PurchaseOrderID])
GO
ALTER TABLE [Purchasing].[SupplierTransactions] CHECK CONSTRAINT [FK_Purchasing_SupplierTransactions_PurchaseOrderID_Purchasing_PurchaseOrders]
GO
ALTER TABLE [Purchasing].[SupplierTransactions]  WITH CHECK ADD  CONSTRAINT [FK_Purchasing_SupplierTransactions_SupplierID_Purchasing_Suppliers] FOREIGN KEY([SupplierID])
REFERENCES [Purchasing].[Suppliers] ([SupplierID])
GO
ALTER TABLE [Purchasing].[SupplierTransactions] CHECK CONSTRAINT [FK_Purchasing_SupplierTransactions_SupplierID_Purchasing_Suppliers]
GO
ALTER TABLE [Purchasing].[SupplierTransactions]  WITH CHECK ADD  CONSTRAINT [FK_Purchasing_SupplierTransactions_TransactionTypeID_Application_TransactionTypes] FOREIGN KEY([TransactionTypeID])
REFERENCES [Application].[TransactionTypes] ([TransactionTypeID])
GO
ALTER TABLE [Purchasing].[SupplierTransactions] CHECK CONSTRAINT [FK_Purchasing_SupplierTransactions_TransactionTypeID_Application_TransactionTypes]
GO
ALTER TABLE [Sales].[BuyingGroups]  WITH CHECK ADD  CONSTRAINT [FK_Sales_BuyingGroups_Application_People] FOREIGN KEY([LastEditedBy])
REFERENCES [Application].[People] ([PersonID])
GO
ALTER TABLE [Sales].[BuyingGroups] CHECK CONSTRAINT [FK_Sales_BuyingGroups_Application_People]
GO
ALTER TABLE [Sales].[CustomerCategories]  WITH CHECK ADD  CONSTRAINT [FK_Sales_CustomerCategories_Application_People] FOREIGN KEY([LastEditedBy])
REFERENCES [Application].[People] ([PersonID])
GO
ALTER TABLE [Sales].[CustomerCategories] CHECK CONSTRAINT [FK_Sales_CustomerCategories_Application_People]
GO
ALTER TABLE [Sales].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Customers_AlternateContactPersonID_Application_People] FOREIGN KEY([AlternateContactPersonID])
REFERENCES [Application].[People] ([PersonID])
GO
ALTER TABLE [Sales].[Customers] CHECK CONSTRAINT [FK_Sales_Customers_AlternateContactPersonID_Application_People]
GO
ALTER TABLE [Sales].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Customers_Application_People] FOREIGN KEY([LastEditedBy])
REFERENCES [Application].[People] ([PersonID])
GO
ALTER TABLE [Sales].[Customers] CHECK CONSTRAINT [FK_Sales_Customers_Application_People]
GO
ALTER TABLE [Sales].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Customers_BillToCustomerID_Sales_Customers] FOREIGN KEY([BillToCustomerID])
REFERENCES [Sales].[Customers] ([CustomerID])
GO
ALTER TABLE [Sales].[Customers] CHECK CONSTRAINT [FK_Sales_Customers_BillToCustomerID_Sales_Customers]
GO
ALTER TABLE [Sales].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Customers_BuyingGroupID_Sales_BuyingGroups] FOREIGN KEY([BuyingGroupID])
REFERENCES [Sales].[BuyingGroups] ([BuyingGroupID])
GO
ALTER TABLE [Sales].[Customers] CHECK CONSTRAINT [FK_Sales_Customers_BuyingGroupID_Sales_BuyingGroups]
GO
ALTER TABLE [Sales].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Customers_CustomerCategoryID_Sales_CustomerCategories] FOREIGN KEY([CustomerCategoryID])
REFERENCES [Sales].[CustomerCategories] ([CustomerCategoryID])
GO
ALTER TABLE [Sales].[Customers] CHECK CONSTRAINT [FK_Sales_Customers_CustomerCategoryID_Sales_CustomerCategories]
GO
ALTER TABLE [Sales].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Customers_DeliveryCityID_Application_Cities] FOREIGN KEY([DeliveryCityID])
REFERENCES [Application].[Cities] ([CityID])
GO
ALTER TABLE [Sales].[Customers] CHECK CONSTRAINT [FK_Sales_Customers_DeliveryCityID_Application_Cities]
GO
ALTER TABLE [Sales].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Customers_DeliveryMethodID_Application_DeliveryMethods] FOREIGN KEY([DeliveryMethodID])
REFERENCES [Application].[DeliveryMethods] ([DeliveryMethodID])
GO
ALTER TABLE [Sales].[Customers] CHECK CONSTRAINT [FK_Sales_Customers_DeliveryMethodID_Application_DeliveryMethods]
GO
ALTER TABLE [Sales].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Customers_PostalCityID_Application_Cities] FOREIGN KEY([PostalCityID])
REFERENCES [Application].[Cities] ([CityID])
GO
ALTER TABLE [Sales].[Customers] CHECK CONSTRAINT [FK_Sales_Customers_PostalCityID_Application_Cities]
GO
ALTER TABLE [Sales].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Customers_PrimaryContactPersonID_Application_People] FOREIGN KEY([PrimaryContactPersonID])
REFERENCES [Application].[People] ([PersonID])
GO
ALTER TABLE [Sales].[Customers] CHECK CONSTRAINT [FK_Sales_Customers_PrimaryContactPersonID_Application_People]
GO
ALTER TABLE [Sales].[CustomerTransactions]  WITH CHECK ADD  CONSTRAINT [FK_Sales_CustomerTransactions_Application_People] FOREIGN KEY([LastEditedBy])
REFERENCES [Application].[People] ([PersonID])
GO
ALTER TABLE [Sales].[CustomerTransactions] CHECK CONSTRAINT [FK_Sales_CustomerTransactions_Application_People]
GO
ALTER TABLE [Sales].[CustomerTransactions]  WITH CHECK ADD  CONSTRAINT [FK_Sales_CustomerTransactions_CustomerID_Sales_Customers] FOREIGN KEY([CustomerID])
REFERENCES [Sales].[Customers] ([CustomerID])
GO
ALTER TABLE [Sales].[CustomerTransactions] CHECK CONSTRAINT [FK_Sales_CustomerTransactions_CustomerID_Sales_Customers]
GO
ALTER TABLE [Sales].[CustomerTransactions]  WITH CHECK ADD  CONSTRAINT [FK_Sales_CustomerTransactions_InvoiceID_Sales_Invoices] FOREIGN KEY([InvoiceID])
REFERENCES [Sales].[Invoices] ([InvoiceID])
GO
ALTER TABLE [Sales].[CustomerTransactions] CHECK CONSTRAINT [FK_Sales_CustomerTransactions_InvoiceID_Sales_Invoices]
GO
ALTER TABLE [Sales].[CustomerTransactions]  WITH CHECK ADD  CONSTRAINT [FK_Sales_CustomerTransactions_PaymentMethodID_Application_PaymentMethods] FOREIGN KEY([PaymentMethodID])
REFERENCES [Application].[PaymentMethods] ([PaymentMethodID])
GO
ALTER TABLE [Sales].[CustomerTransactions] CHECK CONSTRAINT [FK_Sales_CustomerTransactions_PaymentMethodID_Application_PaymentMethods]
GO
ALTER TABLE [Sales].[CustomerTransactions]  WITH CHECK ADD  CONSTRAINT [FK_Sales_CustomerTransactions_TransactionTypeID_Application_TransactionTypes] FOREIGN KEY([TransactionTypeID])
REFERENCES [Application].[TransactionTypes] ([TransactionTypeID])
GO
ALTER TABLE [Sales].[CustomerTransactions] CHECK CONSTRAINT [FK_Sales_CustomerTransactions_TransactionTypeID_Application_TransactionTypes]
GO
ALTER TABLE [Sales].[InvoiceLines]  WITH CHECK ADD  CONSTRAINT [FK_Sales_InvoiceLines_Application_People] FOREIGN KEY([LastEditedBy])
REFERENCES [Application].[People] ([PersonID])
GO
ALTER TABLE [Sales].[InvoiceLines] CHECK CONSTRAINT [FK_Sales_InvoiceLines_Application_People]
GO
ALTER TABLE [Sales].[InvoiceLines]  WITH CHECK ADD  CONSTRAINT [FK_Sales_InvoiceLines_InvoiceID_Sales_Invoices] FOREIGN KEY([InvoiceID])
REFERENCES [Sales].[Invoices] ([InvoiceID])
GO
ALTER TABLE [Sales].[InvoiceLines] CHECK CONSTRAINT [FK_Sales_InvoiceLines_InvoiceID_Sales_Invoices]
GO
ALTER TABLE [Sales].[InvoiceLines]  WITH CHECK ADD  CONSTRAINT [FK_Sales_InvoiceLines_PackageTypeID_Warehouse_PackageTypes] FOREIGN KEY([PackageTypeID])
REFERENCES [Warehouse].[PackageTypes] ([PackageTypeID])
GO
ALTER TABLE [Sales].[InvoiceLines] CHECK CONSTRAINT [FK_Sales_InvoiceLines_PackageTypeID_Warehouse_PackageTypes]
GO
ALTER TABLE [Sales].[InvoiceLines]  WITH CHECK ADD  CONSTRAINT [FK_Sales_InvoiceLines_StockItemID_Warehouse_StockItems] FOREIGN KEY([StockItemID])
REFERENCES [Warehouse].[StockItems] ([StockItemID])
GO
ALTER TABLE [Sales].[InvoiceLines] CHECK CONSTRAINT [FK_Sales_InvoiceLines_StockItemID_Warehouse_StockItems]
GO
ALTER TABLE [Sales].[Invoices]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Invoices_AccountsPersonID_Application_People] FOREIGN KEY([AccountsPersonID])
REFERENCES [Application].[People] ([PersonID])
GO
ALTER TABLE [Sales].[Invoices] CHECK CONSTRAINT [FK_Sales_Invoices_AccountsPersonID_Application_People]
GO
ALTER TABLE [Sales].[Invoices]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Invoices_Application_People] FOREIGN KEY([LastEditedBy])
REFERENCES [Application].[People] ([PersonID])
GO
ALTER TABLE [Sales].[Invoices] CHECK CONSTRAINT [FK_Sales_Invoices_Application_People]
GO
ALTER TABLE [Sales].[Invoices]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Invoices_BillToCustomerID_Sales_Customers] FOREIGN KEY([BillToCustomerID])
REFERENCES [Sales].[Customers] ([CustomerID])
GO
ALTER TABLE [Sales].[Invoices] CHECK CONSTRAINT [FK_Sales_Invoices_BillToCustomerID_Sales_Customers]
GO
ALTER TABLE [Sales].[Invoices]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Invoices_ContactPersonID_Application_People] FOREIGN KEY([ContactPersonID])
REFERENCES [Application].[People] ([PersonID])
GO
ALTER TABLE [Sales].[Invoices] CHECK CONSTRAINT [FK_Sales_Invoices_ContactPersonID_Application_People]
GO
ALTER TABLE [Sales].[Invoices]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Invoices_CustomerID_Sales_Customers] FOREIGN KEY([CustomerID])
REFERENCES [Sales].[Customers] ([CustomerID])
GO
ALTER TABLE [Sales].[Invoices] CHECK CONSTRAINT [FK_Sales_Invoices_CustomerID_Sales_Customers]
GO
ALTER TABLE [Sales].[Invoices]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Invoices_DeliveryMethodID_Application_DeliveryMethods] FOREIGN KEY([DeliveryMethodID])
REFERENCES [Application].[DeliveryMethods] ([DeliveryMethodID])
GO
ALTER TABLE [Sales].[Invoices] CHECK CONSTRAINT [FK_Sales_Invoices_DeliveryMethodID_Application_DeliveryMethods]
GO
ALTER TABLE [Sales].[Invoices]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Invoices_OrderID_Sales_Orders] FOREIGN KEY([OrderID])
REFERENCES [Sales].[Orders] ([OrderID])
GO
ALTER TABLE [Sales].[Invoices] CHECK CONSTRAINT [FK_Sales_Invoices_OrderID_Sales_Orders]
GO
ALTER TABLE [Sales].[Invoices]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Invoices_PackedByPersonID_Application_People] FOREIGN KEY([PackedByPersonID])
REFERENCES [Application].[People] ([PersonID])
GO
ALTER TABLE [Sales].[Invoices] CHECK CONSTRAINT [FK_Sales_Invoices_PackedByPersonID_Application_People]
GO
ALTER TABLE [Sales].[Invoices]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Invoices_SalespersonPersonID_Application_People] FOREIGN KEY([SalespersonPersonID])
REFERENCES [Application].[People] ([PersonID])
GO
ALTER TABLE [Sales].[Invoices] CHECK CONSTRAINT [FK_Sales_Invoices_SalespersonPersonID_Application_People]
GO
ALTER TABLE [Sales].[OrderLines]  WITH CHECK ADD  CONSTRAINT [FK_Sales_OrderLines_Application_People] FOREIGN KEY([LastEditedBy])
REFERENCES [Application].[People] ([PersonID])
GO
ALTER TABLE [Sales].[OrderLines] CHECK CONSTRAINT [FK_Sales_OrderLines_Application_People]
GO
ALTER TABLE [Sales].[OrderLines]  WITH CHECK ADD  CONSTRAINT [FK_Sales_OrderLines_OrderID_Sales_Orders] FOREIGN KEY([OrderID])
REFERENCES [Sales].[Orders] ([OrderID])
GO
ALTER TABLE [Sales].[OrderLines] CHECK CONSTRAINT [FK_Sales_OrderLines_OrderID_Sales_Orders]
GO
ALTER TABLE [Sales].[OrderLines]  WITH CHECK ADD  CONSTRAINT [FK_Sales_OrderLines_PackageTypeID_Warehouse_PackageTypes] FOREIGN KEY([PackageTypeID])
REFERENCES [Warehouse].[PackageTypes] ([PackageTypeID])
GO
ALTER TABLE [Sales].[OrderLines] CHECK CONSTRAINT [FK_Sales_OrderLines_PackageTypeID_Warehouse_PackageTypes]
GO
ALTER TABLE [Sales].[OrderLines]  WITH CHECK ADD  CONSTRAINT [FK_Sales_OrderLines_StockItemID_Warehouse_StockItems] FOREIGN KEY([StockItemID])
REFERENCES [Warehouse].[StockItems] ([StockItemID])
GO
ALTER TABLE [Sales].[OrderLines] CHECK CONSTRAINT [FK_Sales_OrderLines_StockItemID_Warehouse_StockItems]
GO
ALTER TABLE [Sales].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Orders_Application_People] FOREIGN KEY([LastEditedBy])
REFERENCES [Application].[People] ([PersonID])
GO
ALTER TABLE [Sales].[Orders] CHECK CONSTRAINT [FK_Sales_Orders_Application_People]
GO
ALTER TABLE [Sales].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Orders_BackorderOrderID_Sales_Orders] FOREIGN KEY([BackorderOrderID])
REFERENCES [Sales].[Orders] ([OrderID])
GO
ALTER TABLE [Sales].[Orders] CHECK CONSTRAINT [FK_Sales_Orders_BackorderOrderID_Sales_Orders]
GO
ALTER TABLE [Sales].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Orders_ContactPersonID_Application_People] FOREIGN KEY([ContactPersonID])
REFERENCES [Application].[People] ([PersonID])
GO
ALTER TABLE [Sales].[Orders] CHECK CONSTRAINT [FK_Sales_Orders_ContactPersonID_Application_People]
GO
ALTER TABLE [Sales].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Orders_CustomerID_Sales_Customers] FOREIGN KEY([CustomerID])
REFERENCES [Sales].[Customers] ([CustomerID])
GO
ALTER TABLE [Sales].[Orders] CHECK CONSTRAINT [FK_Sales_Orders_CustomerID_Sales_Customers]
GO
ALTER TABLE [Sales].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Orders_PickedByPersonID_Application_People] FOREIGN KEY([PickedByPersonID])
REFERENCES [Application].[People] ([PersonID])
GO
ALTER TABLE [Sales].[Orders] CHECK CONSTRAINT [FK_Sales_Orders_PickedByPersonID_Application_People]
GO
ALTER TABLE [Sales].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Orders_SalespersonPersonID_Application_People] FOREIGN KEY([SalespersonPersonID])
REFERENCES [Application].[People] ([PersonID])
GO
ALTER TABLE [Sales].[Orders] CHECK CONSTRAINT [FK_Sales_Orders_SalespersonPersonID_Application_People]
GO
ALTER TABLE [Sales].[SpecialDeals]  WITH CHECK ADD  CONSTRAINT [FK_Sales_SpecialDeals_Application_People] FOREIGN KEY([LastEditedBy])
REFERENCES [Application].[People] ([PersonID])
GO
ALTER TABLE [Sales].[SpecialDeals] CHECK CONSTRAINT [FK_Sales_SpecialDeals_Application_People]
GO
ALTER TABLE [Sales].[SpecialDeals]  WITH CHECK ADD  CONSTRAINT [FK_Sales_SpecialDeals_BuyingGroupID_Sales_BuyingGroups] FOREIGN KEY([BuyingGroupID])
REFERENCES [Sales].[BuyingGroups] ([BuyingGroupID])
GO
ALTER TABLE [Sales].[SpecialDeals] CHECK CONSTRAINT [FK_Sales_SpecialDeals_BuyingGroupID_Sales_BuyingGroups]
GO
ALTER TABLE [Sales].[SpecialDeals]  WITH CHECK ADD  CONSTRAINT [FK_Sales_SpecialDeals_CustomerCategoryID_Sales_CustomerCategories] FOREIGN KEY([CustomerCategoryID])
REFERENCES [Sales].[CustomerCategories] ([CustomerCategoryID])
GO
ALTER TABLE [Sales].[SpecialDeals] CHECK CONSTRAINT [FK_Sales_SpecialDeals_CustomerCategoryID_Sales_CustomerCategories]
GO
ALTER TABLE [Sales].[SpecialDeals]  WITH CHECK ADD  CONSTRAINT [FK_Sales_SpecialDeals_CustomerID_Sales_Customers] FOREIGN KEY([CustomerID])
REFERENCES [Sales].[Customers] ([CustomerID])
GO
ALTER TABLE [Sales].[SpecialDeals] CHECK CONSTRAINT [FK_Sales_SpecialDeals_CustomerID_Sales_Customers]
GO
ALTER TABLE [Sales].[SpecialDeals]  WITH CHECK ADD  CONSTRAINT [FK_Sales_SpecialDeals_StockGroupID_Warehouse_StockGroups] FOREIGN KEY([StockGroupID])
REFERENCES [Warehouse].[StockGroups] ([StockGroupID])
GO
ALTER TABLE [Sales].[SpecialDeals] CHECK CONSTRAINT [FK_Sales_SpecialDeals_StockGroupID_Warehouse_StockGroups]
GO
ALTER TABLE [Sales].[SpecialDeals]  WITH CHECK ADD  CONSTRAINT [FK_Sales_SpecialDeals_StockItemID_Warehouse_StockItems] FOREIGN KEY([StockItemID])
REFERENCES [Warehouse].[StockItems] ([StockItemID])
GO
ALTER TABLE [Sales].[SpecialDeals] CHECK CONSTRAINT [FK_Sales_SpecialDeals_StockItemID_Warehouse_StockItems]
GO
ALTER TABLE [Sales].[Invoices]  WITH CHECK ADD  CONSTRAINT [CK_Sales_Invoices_ReturnedDeliveryData_Must_Be_Valid_JSON] CHECK  (([ReturnedDeliveryData] IS NULL OR isjson([ReturnedDeliveryData])<>(0)))
GO
ALTER TABLE [Sales].[Invoices] CHECK CONSTRAINT [CK_Sales_Invoices_ReturnedDeliveryData_Must_Be_Valid_JSON]
GO
ALTER TABLE [Sales].[SpecialDeals]  WITH CHECK ADD  CONSTRAINT [CK_Sales_SpecialDeals_Exactly_One_NOT_NULL_Pricing_Option_Is_Required] CHECK  ((((case when [DiscountAmount] IS NULL then (0) else (1) end+case when [DiscountPercentage] IS NULL then (0) else (1) end)+case when [UnitPrice] IS NULL then (0) else (1) end)=(1)))
GO
ALTER TABLE [Sales].[SpecialDeals] CHECK CONSTRAINT [CK_Sales_SpecialDeals_Exactly_One_NOT_NULL_Pricing_Option_Is_Required]
GO
ALTER TABLE [Sales].[SpecialDeals]  WITH CHECK ADD  CONSTRAINT [CK_Sales_SpecialDeals_Unit_Price_Deal_Requires_Special_StockItem] CHECK  (([StockItemID] IS NOT NULL AND [UnitPrice] IS NOT NULL OR [UnitPrice] IS NULL))
GO
ALTER TABLE [Sales].[SpecialDeals] CHECK CONSTRAINT [CK_Sales_SpecialDeals_Unit_Price_Deal_Requires_Special_StockItem]
GO
/****** Object:  StoredProcedure [Integration].[GetCityUpdates]    Script Date: 22/10/2022 01:21:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Integration].[GetCityUpdates]
@LastCutoff datetime2(7),
@NewCutoff datetime2(7)
WITH EXECUTE AS OWNER
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    DECLARE @EndOfTime datetime2(7) = '99991231 23:59:59.9999999';
    DECLARE @InitialLoadDate date = '20130101';

    CREATE TABLE #CityChanges
    (
        [WWI City ID] int,
        City nvarchar(50),
        [State Province] nvarchar(50),
        Country nvarchar(50),
        Continent nvarchar(30),
        [Sales Territory] nvarchar(50),
        Region nvarchar(30),
        Subregion nvarchar(30),
        [Location] geography,
        [Latest Recorded Population] bigint,
        [Valid From] datetime2(7),
        [Valid To] datetime2(7) NULL
    );

    DECLARE @CountryID int;
    DECLARE @StateProvinceID int;
    DECLARE @CityID int;
    DECLARE @ValidFrom datetime2(7);

    -- first need to find any country changes that have occurred since initial load

    DECLARE CountryChangeList CURSOR FAST_FORWARD READ_ONLY
    FOR
    SELECT co.CountryID,
           co.ValidFrom
    FROM [Application].Countries_Archive AS co
    WHERE co.ValidFrom > @LastCutoff
    AND co.ValidFrom <= @NewCutoff
    AND co.ValidFrom <> @InitialLoadDate
    UNION ALL
    SELECT co.CountryID,
           co.ValidFrom
    FROM [Application].Countries AS co
    WHERE co.ValidFrom > @LastCutoff
    AND co.ValidFrom <= @NewCutoff
    AND co.ValidFrom <> @InitialLoadDate
    ORDER BY ValidFrom;

    OPEN CountryChangeList;
    FETCH NEXT FROM CountryChangeList INTO @CountryID, @ValidFrom;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        INSERT #CityChanges
            ([WWI City ID], City, [State Province], Country, Continent, [Sales Territory], Region, Subregion,
             [Location], [Latest Recorded Population], [Valid From], [Valid To])
        SELECT c.CityID, c.CityName, sp.StateProvinceName, co.CountryName, co.Continent, sp.SalesTerritory, co.Region, co.Subregion,
               c.[Location], COALESCE(c.LatestRecordedPopulation, 0), @ValidFrom, NULL
        FROM [Application].Cities FOR SYSTEM_TIME AS OF @ValidFrom AS c
        INNER JOIN [Application].StateProvinces FOR SYSTEM_TIME AS OF @ValidFrom AS sp
        ON c.StateProvinceID = sp.StateProvinceID
        INNER JOIN [Application].Countries FOR SYSTEM_TIME AS OF @ValidFrom AS co
        ON sp.CountryID = co.CountryID
        WHERE co.CountryID = @CountryID;

        FETCH NEXT FROM CountryChangeList INTO @CountryID, @ValidFrom;
    END;

    CLOSE CountryChangeList;
    DEALLOCATE CountryChangeList;

    -- next need to find any stateprovince changes that have occurred since initial load

    DECLARE StateProvinceChangeList CURSOR FAST_FORWARD READ_ONLY
    FOR
    SELECT sp.StateProvinceID,
           sp.ValidFrom
    FROM [Application].StateProvinces_Archive AS sp
    WHERE sp.ValidFrom > @LastCutoff
    AND sp.ValidFrom <= @NewCutoff
    AND sp.ValidFrom <> @InitialLoadDate
    UNION ALL
    SELECT sp.StateProvinceID,
           sp.ValidFrom
    FROM [Application].StateProvinces AS sp
    WHERE sp.ValidFrom > @LastCutoff
    AND sp.ValidFrom <= @NewCutoff
    AND sp.ValidFrom <> @InitialLoadDate
    ORDER BY ValidFrom;

    OPEN StateProvinceChangeList;
    FETCH NEXT FROM StateProvinceChangeList INTO @StateProvinceID, @ValidFrom;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        INSERT #CityChanges
            ([WWI City ID], City, [State Province], Country, Continent, [Sales Territory], Region, Subregion,
             [Location], [Latest Recorded Population], [Valid From], [Valid To])
        SELECT c.CityID, c.CityName, sp.StateProvinceName, co.CountryName, co.Continent, sp.SalesTerritory, co.Region, co.Subregion,
               c.[Location], COALESCE(c.LatestRecordedPopulation, 0), @ValidFrom, NULL
        FROM [Application].Cities FOR SYSTEM_TIME AS OF @ValidFrom AS c
        INNER JOIN [Application].StateProvinces FOR SYSTEM_TIME AS OF @ValidFrom AS sp
        ON c.StateProvinceID = sp.StateProvinceID
        INNER JOIN [Application].Countries FOR SYSTEM_TIME AS OF @ValidFrom AS co
        ON sp.CountryID = co.CountryID
        WHERE sp.StateProvinceID = @StateProvinceID;

        FETCH NEXT FROM StateProvinceChangeList INTO @StateProvinceID, @ValidFrom;
    END;

    CLOSE StateProvinceChangeList;
    DEALLOCATE StateProvinceChangeList;

    -- finally need to find any city changes that have occurred, including during the initial load

    DECLARE CityChangeList CURSOR FAST_FORWARD READ_ONLY
    FOR
    SELECT c.CityID,
           c.ValidFrom
    FROM [Application].Cities_Archive AS c
    WHERE c.ValidFrom > @LastCutoff
    AND c.ValidFrom <= @NewCutoff
    UNION ALL
    SELECT c.CityID,
           c.ValidFrom
    FROM [Application].Cities AS c
    WHERE c.ValidFrom > @LastCutoff
    AND c.ValidFrom <= @NewCutoff
    ORDER BY ValidFrom;

    OPEN CityChangeList;
    FETCH NEXT FROM CityChangeList INTO @CityID, @ValidFrom;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        INSERT #CityChanges
            ([WWI City ID], City, [State Province], Country, Continent, [Sales Territory], Region, Subregion,
             [Location], [Latest Recorded Population], [Valid From], [Valid To])
        SELECT c.CityID, c.CityName, sp.StateProvinceName, co.CountryName, co.Continent, sp.SalesTerritory, co.Region, co.Subregion,
               c.[Location], COALESCE(c.LatestRecordedPopulation, 0), @ValidFrom, NULL
        FROM [Application].Cities FOR SYSTEM_TIME AS OF @ValidFrom AS c
        INNER JOIN [Application].StateProvinces FOR SYSTEM_TIME AS OF @ValidFrom AS sp
        ON c.StateProvinceID = sp.StateProvinceID
        INNER JOIN [Application].Countries FOR SYSTEM_TIME AS OF @ValidFrom AS co
        ON sp.CountryID = co.CountryID
        WHERE c.CityID = @CityID;

        FETCH NEXT FROM CityChangeList INTO @CityID, @ValidFrom;
    END;

    CLOSE CityChangeList;
    DEALLOCATE CityChangeList;

    -- add an index to make lookups faster

    CREATE INDEX IX_CityChanges ON #CityChanges ([WWI City ID], [Valid From]);

    -- work out the [Valid To] value by taking the [Valid From] of any row that's for the same city but later
    -- otherwise take the end of time

    UPDATE cc
    SET [Valid To] = COALESCE((SELECT MIN([Valid From]) FROM #CityChanges AS cc2
                                                        WHERE cc2.[WWI City ID] = cc.[WWI City ID]
                                                        AND cc2.[Valid From] > cc.[Valid From]), @EndOfTime)
    FROM #CityChanges AS cc;

    SELECT [WWI City ID], City, [State Province], Country, Continent, [Sales Territory],
           Region, Subregion, [Location] geography, [Latest Recorded Population], [Valid From],
           [Valid To]
    FROM #CityChanges
    ORDER BY [Valid From];

    DROP TABLE #CityChanges;

    RETURN 0;
END;
GO
/****** Object:  StoredProcedure [Integration].[GetCustomerUpdates]    Script Date: 22/10/2022 01:21:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Integration].[GetCustomerUpdates]
@LastCutoff datetime2(7),
@NewCutoff datetime2(7)
WITH EXECUTE AS OWNER
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    DECLARE @EndOfTime datetime2(7) = '99991231 23:59:59.9999999';
    DECLARE @InitialLoadDate date = '20130101';

    CREATE TABLE #CustomerChanges
    (
        [WWI Customer ID] int,
        Customer nvarchar(100),
        [Bill To Customer] nvarchar(100),
        Category nvarchar(50),
        [Buying Group] nvarchar(50),
        [Primary Contact] nvarchar(50),
        [Postal Code] nvarchar(10),
        [Valid From] datetime2(7),
        [Valid To] datetime2(7) NULL
    );

    DECLARE @BuyingGroupID int;
    DECLARE @CustomerCategoryID int;
    DECLARE @CustomerID int;
    DECLARE @ValidFrom datetime2(7);

    -- first need to find any buying group changes that have occurred since initial load

    DECLARE BuyingGroupChangeList CURSOR FAST_FORWARD READ_ONLY
    FOR
    SELECT bg.BuyingGroupID,
           bg.ValidFrom
    FROM Sales.BuyingGroups_Archive AS bg
    WHERE bg.ValidFrom > @LastCutoff
    AND bg.ValidFrom <= @NewCutoff
    AND bg.ValidFrom <> @InitialLoadDate
    UNION ALL
    SELECT bg.BuyingGroupID,
           bg.ValidFrom
    FROM Sales.BuyingGroups AS bg
    WHERE bg.ValidFrom > @LastCutoff
    AND bg.ValidFrom <= @NewCutoff
    AND bg.ValidFrom <> @InitialLoadDate
    ORDER BY ValidFrom;

    OPEN BuyingGroupChangeList;
    FETCH NEXT FROM BuyingGroupChangeList INTO @BuyingGroupID, @ValidFrom;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        INSERT #CustomerChanges
            ([WWI Customer ID], Customer, [Bill To Customer], Category,
             [Buying Group], [Primary Contact], [Postal Code],
             [Valid From], [Valid To])
        SELECT c.CustomerID, c.CustomerName, bt.CustomerName, cc.CustomerCategoryName,
               bg.BuyingGroupName, p.FullName, c.DeliveryPostalCode,
               c.ValidFrom, c.ValidTo
        FROM Sales.Customers FOR SYSTEM_TIME AS OF @ValidFrom AS c
        INNER JOIN Sales.BuyingGroups FOR SYSTEM_TIME AS OF @ValidFrom AS bg
        ON c.BuyingGroupID = bg.BuyingGroupID
        INNER JOIN Sales.CustomerCategories FOR SYSTEM_TIME AS OF @ValidFrom AS cc
        ON c.CustomerCategoryID = cc.CustomerCategoryID
        INNER JOIN Sales.Customers FOR SYSTEM_TIME AS OF @ValidFrom AS bt
        ON c.BillToCustomerID = bt.CustomerID
        INNER JOIN [Application].People FOR SYSTEM_TIME AS OF @ValidFrom AS p
        ON c.PrimaryContactPersonID = p.PersonID
        WHERE c.BuyingGroupID = @BuyingGroupID;

        FETCH NEXT FROM BuyingGroupChangeList INTO @BuyingGroupID, @ValidFrom;
    END;

    CLOSE BuyingGroupChangeList;
    DEALLOCATE BuyingGroupChangeList;

    -- next need to find any customer category changes that have occurred since initial load

    DECLARE CustomerCategoryChangeList CURSOR FAST_FORWARD READ_ONLY
    FOR
    SELECT cc.CustomerCategoryID,
           cc.ValidFrom
    FROM Sales.CustomerCategories_Archive AS cc
    WHERE cc.ValidFrom > @LastCutoff
    AND cc.ValidFrom <= @NewCutoff
    AND cc.ValidFrom <> @InitialLoadDate
    UNION ALL
    SELECT cc.CustomerCategoryID,
           cc.ValidFrom
    FROM Sales.CustomerCategories AS cc
    WHERE cc.ValidFrom > @LastCutoff
    AND cc.ValidFrom <= @NewCutoff
    AND cc.ValidFrom <> @InitialLoadDate
    ORDER BY ValidFrom;

    OPEN CustomerCategoryChangeList;
    FETCH NEXT FROM CustomerCategoryChangeList INTO @CustomerCategoryID, @ValidFrom;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        INSERT #CustomerChanges
            ([WWI Customer ID], Customer, [Bill To Customer], Category,
             [Buying Group], [Primary Contact], [Postal Code],
             [Valid From], [Valid To])
        SELECT c.CustomerID, c.CustomerName, bt.CustomerName, cc.CustomerCategoryName,
               bg.BuyingGroupName, p.FullName, c.DeliveryPostalCode,
               c.ValidFrom, c.ValidTo
        FROM Sales.Customers FOR SYSTEM_TIME AS OF @ValidFrom AS c
        INNER JOIN Sales.BuyingGroups FOR SYSTEM_TIME AS OF @ValidFrom AS bg
        ON c.BuyingGroupID = bg.BuyingGroupID
        INNER JOIN Sales.CustomerCategories FOR SYSTEM_TIME AS OF @ValidFrom AS cc
        ON c.CustomerCategoryID = cc.CustomerCategoryID
        INNER JOIN Sales.Customers FOR SYSTEM_TIME AS OF @ValidFrom AS bt
        ON c.BillToCustomerID = bt.CustomerID
        INNER JOIN [Application].People FOR SYSTEM_TIME AS OF @ValidFrom AS p
        ON c.PrimaryContactPersonID = p.PersonID
        WHERE cc.CustomerCategoryID = @CustomerCategoryID;

        FETCH NEXT FROM CustomerCategoryChangeList INTO @CustomerCategoryID, @ValidFrom;
    END;

    CLOSE CustomerCategoryChangeList;
    DEALLOCATE CustomerCategoryChangeList;

    -- finally need to find any customer changes that have occurred, including during the initial load

    DECLARE CustomerChangeList CURSOR FAST_FORWARD READ_ONLY
    FOR
    SELECT c.CustomerID,
           c.ValidFrom
    FROM Sales.Customers_Archive AS c
    WHERE c.ValidFrom > @LastCutoff
    AND c.ValidFrom <= @NewCutoff
    UNION ALL
    SELECT c.CustomerID,
           c.ValidFrom
    FROM Sales.Customers AS c
    WHERE c.ValidFrom > @LastCutoff
    AND c.ValidFrom <= @NewCutoff
    ORDER BY ValidFrom;

    OPEN CustomerChangeList;
    FETCH NEXT FROM CustomerChangeList INTO @CustomerID, @ValidFrom;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        INSERT #CustomerChanges
            ([WWI Customer ID], Customer, [Bill To Customer], Category,
             [Buying Group], [Primary Contact], [Postal Code],
             [Valid From], [Valid To])
        SELECT c.CustomerID, c.CustomerName, bt.CustomerName, cc.CustomerCategoryName,
               bg.BuyingGroupName, p.FullName, c.DeliveryPostalCode,
               c.ValidFrom, c.ValidTo
        FROM Sales.Customers FOR SYSTEM_TIME AS OF @ValidFrom AS c
        INNER JOIN Sales.BuyingGroups FOR SYSTEM_TIME AS OF @ValidFrom AS bg
        ON c.BuyingGroupID = bg.BuyingGroupID
        INNER JOIN Sales.CustomerCategories FOR SYSTEM_TIME AS OF @ValidFrom AS cc
        ON c.CustomerCategoryID = cc.CustomerCategoryID
        INNER JOIN Sales.Customers FOR SYSTEM_TIME AS OF @ValidFrom AS bt
        ON c.BillToCustomerID = bt.CustomerID
        INNER JOIN [Application].People FOR SYSTEM_TIME AS OF @ValidFrom AS p
        ON c.PrimaryContactPersonID = p.PersonID
        WHERE c.CustomerID = @CustomerID;

        FETCH NEXT FROM CustomerChangeList INTO @CustomerID, @ValidFrom;
    END;

    CLOSE CustomerChangeList;
    DEALLOCATE CustomerChangeList;

    -- add an index to make lookups faster

    CREATE INDEX IX_CustomerChanges ON #CustomerChanges ([WWI Customer ID], [Valid From]);

    -- work out the [Valid To] value by taking the [Valid From] of any row that's for the same customer but later
    -- otherwise take the end of time

    UPDATE cc
    SET [Valid To] = COALESCE((SELECT MIN([Valid From]) FROM #CustomerChanges AS cc2
                                                        WHERE cc2.[WWI Customer ID] = cc.[WWI Customer ID]
                                                        AND cc2.[Valid From] > cc.[Valid From]), @EndOfTime)
    FROM #CustomerChanges AS cc;

    SELECT [WWI Customer ID], Customer, [Bill To Customer], Category,
           [Buying Group], [Primary Contact], [Postal Code],
           [Valid From], [Valid To]
    FROM #CustomerChanges
    ORDER BY [Valid From];

    DROP TABLE #CustomerChanges;

    RETURN 0;
END;
GO
/****** Object:  StoredProcedure [Integration].[GetEmployeeUpdates]    Script Date: 22/10/2022 01:21:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Integration].[GetEmployeeUpdates]
@LastCutoff datetime2(7),
@NewCutoff datetime2(7)
WITH EXECUTE AS OWNER
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    DECLARE @EndOfTime datetime2(7) = '99991231 23:59:59.9999999';

    CREATE TABLE #EmployeeChanges
    (
        [WWI Employee ID] int,
        Employee nvarchar(50),
        [Preferred Name] nvarchar(50),
        [Is Salesperson] bit,
        Photo varbinary(max),
        [Valid From] datetime2(7),
        [Valid To] datetime2(7)
    );

    DECLARE @PersonID int;
    DECLARE @ValidFrom datetime2(7);

    -- need to find any employee changes that have occurred, including during the initial load

    DECLARE EmployeeChangeList CURSOR FAST_FORWARD READ_ONLY
    FOR
    SELECT p.PersonID,
           p.ValidFrom
    FROM [Application].People_Archive AS p
    WHERE p.ValidFrom > @LastCutoff
    AND p.ValidFrom <= @NewCutoff
    AND p.IsEmployee <> 0
    UNION ALL
    SELECT p.PersonID,
           p.ValidFrom
    FROM [Application].People AS p
    WHERE p.ValidFrom > @LastCutoff
    AND p.ValidFrom <= @NewCutoff
    AND p.IsEmployee <> 0
    ORDER BY ValidFrom;

    OPEN EmployeeChangeList;
    FETCH NEXT FROM EmployeeChangeList INTO @PersonID, @ValidFrom;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        INSERT #EmployeeChanges
            ([WWI Employee ID], Employee, [Preferred Name], [Is Salesperson], Photo,
             [Valid From], [Valid To])
        SELECT p.PersonID, p.FullName, p.PreferredName, p.IsSalesperson, p.Photo,
               p.ValidFrom, p.ValidTo
        FROM [Application].People FOR SYSTEM_TIME AS OF @ValidFrom AS p
        WHERE p.PersonID = @PersonID;

        FETCH NEXT FROM EmployeeChangeList INTO @PersonID, @ValidFrom;
    END;

    CLOSE EmployeeChangeList;
    DEALLOCATE EmployeeChangeList;

    -- add an index to make lookups faster

    CREATE INDEX IX_EmployeeChanges ON #EmployeeChanges ([WWI Employee ID], [Valid From]);

    -- work out the [Valid To] value by taking the [Valid From] of any row that's for the same entry but later
    -- otherwise take the end of time

    UPDATE cc
    SET [Valid To] = COALESCE((SELECT MIN([Valid From]) FROM #EmployeeChanges AS cc2
                                                        WHERE cc2.[WWI Employee ID] = cc.[WWI Employee ID]
                                                        AND cc2.[Valid From] > cc.[Valid From]), @EndOfTime)
    FROM #EmployeeChanges AS cc;

    SELECT [WWI Employee ID], Employee, [Preferred Name], [Is Salesperson], Photo,
           [Valid From], [Valid To]
    FROM #EmployeeChanges
    ORDER BY [Valid From];

    DROP TABLE #EmployeeChanges;

    RETURN 0;
END;
GO
/****** Object:  StoredProcedure [Integration].[GetMovementUpdates]    Script Date: 22/10/2022 01:21:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Integration].[GetMovementUpdates]
@LastCutoff datetime2(7),
@NewCutoff datetime2(7)
WITH EXECUTE AS OWNER
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    SELECT CAST(sit.TransactionOccurredWhen AS date) AS [Date Key],
           sit.StockItemTransactionID AS [WWI Stock Item Transaction ID],
           sit.InvoiceID AS [WWI Invoice ID],
           sit.PurchaseOrderID AS [WWI Purchase Order ID],
           CAST(sit.Quantity AS int) AS Quantity,
           sit.StockItemID AS [WWI Stock Item ID],
           sit.CustomerID AS [WWI Customer ID],
           sit.SupplierID AS [WWI Supplier ID],
           sit.TransactionTypeID AS [WWI Transaction Type ID],
           sit.TransactionOccurredWhen AS [Transaction Occurred When]
    FROM Warehouse.StockItemTransactions AS sit
    WHERE sit.LastEditedWhen > @LastCutoff
    AND sit.LastEditedWhen <= @NewCutoff
    ORDER BY sit.StockItemTransactionID;

    RETURN 0;
END;
GO
/****** Object:  StoredProcedure [Integration].[GetOrderUpdates]    Script Date: 22/10/2022 01:21:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Integration].[GetOrderUpdates]
@LastCutoff datetime2(7),
@NewCutoff datetime2(7)
WITH EXECUTE AS OWNER
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;


    SELECT CAST(o.OrderDate AS date) AS [Order Date Key],
           CAST(ol.PickingCompletedWhen AS date) AS [Picked Date Key],
           o.OrderID AS [WWI Order ID],
           o.BackorderOrderID AS [WWI Backorder ID],
           ol.[Description],
           pt.PackageTypeName AS Package,
           ol.Quantity AS Quantity,
           ol.UnitPrice AS [Unit Price],
           ol.TaxRate AS [Tax Rate],
           ROUND(ol.Quantity * ol.UnitPrice, 2) AS [Total Excluding Tax],
           ROUND(ol.Quantity * ol.UnitPrice * ol.TaxRate / 100.0, 2) AS [Tax Amount],
           ROUND(ol.Quantity * ol.UnitPrice, 2) + ROUND(ol.Quantity * ol.UnitPrice * ol.TaxRate / 100.0, 2) AS [Total Including Tax],
           c.DeliveryCityID AS [WWI City ID],
           c.CustomerID AS [WWI Customer ID],
           ol.StockItemID AS [WWI Stock Item ID],
           o.SalespersonPersonID AS [WWI Salesperson ID],
           o.PickedByPersonID AS [WWI Picker ID],
           CASE WHEN ol.LastEditedWhen > o.LastEditedWhen THEN ol.LastEditedWhen ELSE o.LastEditedWhen END AS [Last Modified When]
    FROM Sales.Orders AS o
    INNER JOIN Sales.OrderLines AS ol
    ON o.OrderID = ol.OrderID
    INNER JOIN Warehouse.PackageTypes AS pt
    ON ol.PackageTypeID = pt.PackageTypeID
    INNER JOIN Sales.Customers AS c
    ON c.CustomerID = o.CustomerID
    WHERE CASE WHEN ol.LastEditedWhen > o.LastEditedWhen THEN ol.LastEditedWhen ELSE o.LastEditedWhen END > @LastCutoff
    AND CASE WHEN ol.LastEditedWhen > o.LastEditedWhen THEN ol.LastEditedWhen ELSE o.LastEditedWhen END <= @NewCutoff
    ORDER BY o.OrderID;

    RETURN 0;
END;
GO
/****** Object:  StoredProcedure [Integration].[GetPaymentMethodUpdates]    Script Date: 22/10/2022 01:21:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Integration].[GetPaymentMethodUpdates]
@LastCutoff datetime2(7),
@NewCutoff datetime2(7)
WITH EXECUTE AS OWNER
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    DECLARE @EndOfTime datetime2(7) = '99991231 23:59:59.9999999';

    CREATE TABLE #PaymentMethodChanges
    (
        [WWI Payment Method ID] int,
        [Payment Method] nvarchar(50),
        [Valid From] datetime2(7),
        [Valid To] datetime2(7)
    );

    DECLARE @PaymentMethodID int;
    DECLARE @ValidFrom datetime2(7);

    -- need to find any payment method changes that have occurred, including during the initial load

    DECLARE ChangeList CURSOR FAST_FORWARD READ_ONLY
    FOR
    SELECT p.PaymentMethodID,
           p.ValidFrom
    FROM [Application].PaymentMethods_Archive AS p
    WHERE p.ValidFrom > @LastCutoff
    AND p.ValidFrom <= @NewCutoff
    UNION ALL
    SELECT p.PaymentMethodID,
           p.ValidFrom
    FROM [Application].PaymentMethods AS p
    WHERE p.ValidFrom > @LastCutoff
    AND p.ValidFrom <= @NewCutoff
    ORDER BY ValidFrom;

    OPEN ChangeList;
    FETCH NEXT FROM ChangeList INTO @PaymentMethodID, @ValidFrom;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        INSERT #PaymentMethodChanges
            ([WWI Payment Method ID], [Payment Method], [Valid From], [Valid To])
        SELECT p.PaymentMethodID, p.PaymentMethodName, p.ValidFrom, p.ValidTo
        FROM [Application].PaymentMethods FOR SYSTEM_TIME AS OF @ValidFrom AS p
        WHERE p.PaymentMethodID = @PaymentMethodID;

        FETCH NEXT FROM ChangeList INTO @PaymentMethodID, @ValidFrom;
    END;

    CLOSE ChangeList;
    DEALLOCATE ChangeList;

    -- add an index to make lookups faster

    CREATE INDEX IX_PaymentMethodChanges ON #PaymentMethodChanges ([WWI Payment Method ID], [Valid From]);

    -- work out the [Valid To] value by taking the [Valid From] of any row that's for the same entry but later
    -- otherwise take the end of time

    UPDATE cc
    SET [Valid To] = COALESCE((SELECT MIN([Valid From]) FROM #PaymentMethodChanges AS cc2
                                                        WHERE cc2.[WWI Payment Method ID] = cc.[WWI Payment Method ID]
                                                        AND cc2.[Valid From] > cc.[Valid From]), @EndOfTime)
    FROM #PaymentMethodChanges AS cc;

    SELECT [WWI Payment Method ID], [Payment Method], [Valid From], [Valid To]
    FROM #PaymentMethodChanges
    ORDER BY [Valid From];

    DROP TABLE #PaymentMethodChanges;

    RETURN 0;
END;
GO
/****** Object:  StoredProcedure [Integration].[GetPurchaseUpdates]    Script Date: 22/10/2022 01:21:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Integration].[GetPurchaseUpdates]
@LastCutoff datetime2(7),
@NewCutoff datetime2(7)
WITH EXECUTE AS OWNER
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;


    SELECT CAST(po.OrderDate AS date) AS [Date Key],
           po.PurchaseOrderID AS [WWI Purchase Order ID],
           pol.OrderedOuters AS [Ordered Outers],
           pol.OrderedOuters * si.QuantityPerOuter AS [Ordered Quantity],
           pol.ReceivedOuters AS [Received Outers],
           pt.PackageTypeName AS Package,
           pol.IsOrderLineFinalized AS [Is Order Finalized],
           po.SupplierID AS [WWI Supplier ID],
           pol.StockItemID AS [WWI Stock Item ID],
           CASE WHEN pol.LastEditedWhen > po.LastEditedWhen THEN pol.LastEditedWhen ELSE po.LastEditedWhen END AS [Last Modified When]
    FROM Purchasing.PurchaseOrders AS po
    INNER JOIN Purchasing.PurchaseOrderLines AS pol
    ON po.PurchaseOrderID = pol.PurchaseOrderID
    INNER JOIN Warehouse.StockItems AS si
    ON pol.StockItemID = si.StockItemID
    INNER JOIN Warehouse.PackageTypes AS pt
    ON pol.PackageTypeID = pt.PackageTypeID
    WHERE CASE WHEN pol.LastEditedWhen > po.LastEditedWhen THEN pol.LastEditedWhen ELSE po.LastEditedWhen END > @LastCutoff
    AND CASE WHEN pol.LastEditedWhen > po.LastEditedWhen THEN pol.LastEditedWhen ELSE po.LastEditedWhen END <= @NewCutoff
    ORDER BY po.PurchaseOrderID;

    RETURN 0;
END;
GO
/****** Object:  StoredProcedure [Integration].[GetSaleUpdates]    Script Date: 22/10/2022 01:21:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Integration].[GetSaleUpdates]
@LastCutoff datetime2(7),
@NewCutoff datetime2(7)
WITH EXECUTE AS OWNER
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    SELECT CAST(i.InvoiceDate AS date) AS [Invoice Date Key],
           CAST(i.ConfirmedDeliveryTime AS date) AS [Delivery Date Key],
           i.InvoiceID AS [WWI Invoice ID],
           il.[Description],
           pt.PackageTypeName AS Package,
           il.Quantity,
           il.UnitPrice AS [Unit Price],
           il.TaxRate AS [Tax Rate],
           il.ExtendedPrice - il.TaxAmount AS [Total Excluding Tax],
           il.TaxAmount AS [Tax Amount],
           il.LineProfit AS Profit,
           il.ExtendedPrice AS [Total Including Tax],
           CASE WHEN si.IsChillerStock = 0 THEN il.Quantity ELSE 0 END AS [Total Dry Items],
           CASE WHEN si.IsChillerStock <> 0 THEN il.Quantity ELSE 0 END AS [Total Chiller Items],
           c.DeliveryCityID AS [WWI City ID],
           i.CustomerID AS [WWI Customer ID],
           i.BillToCustomerID AS [WWI Bill To Customer ID],
           il.StockItemID AS [WWI Stock Item ID],
           i.SalespersonPersonID AS [WWI Saleperson ID],
           CASE WHEN il.LastEditedWhen > i.LastEditedWhen THEN il.LastEditedWhen ELSE i.LastEditedWhen END AS [Last Modified When]
    FROM Sales.Invoices AS i
    INNER JOIN Sales.InvoiceLines AS il
    ON i.InvoiceID = il.InvoiceID
    INNER JOIN Warehouse.StockItems AS si
    ON il.StockItemID = si.StockItemID
    INNER JOIN Warehouse.PackageTypes AS pt
    ON il.PackageTypeID = pt.PackageTypeID
    INNER JOIN Sales.Customers AS c
    ON i.CustomerID = c.CustomerID
    INNER JOIN Sales.Customers AS bt
    ON i.BillToCustomerID = bt.CustomerID
    WHERE CASE WHEN il.LastEditedWhen > i.LastEditedWhen THEN il.LastEditedWhen ELSE i.LastEditedWhen END > @LastCutoff
    AND CASE WHEN il.LastEditedWhen > i.LastEditedWhen THEN il.LastEditedWhen ELSE i.LastEditedWhen END <= @NewCutoff
    ORDER BY i.InvoiceID, il.InvoiceLineID;

    RETURN 0;
END;
GO
/****** Object:  StoredProcedure [Integration].[GetStockHoldingUpdates]    Script Date: 22/10/2022 01:21:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Integration].[GetStockHoldingUpdates]
WITH EXECUTE AS OWNER
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    SELECT sih.QuantityOnHand AS [Quantity On Hand],
           sih.BinLocation AS [Bin Location],
           sih.LastStocktakeQuantity AS [Last Stocktake Quantity],
           sih.LastCostPrice AS [Last Cost Price],
           sih.ReorderLevel AS [Reorder Level],
           sih.TargetStockLevel AS [Target Stock Level],
           sih.StockItemID AS [WWI Stock Item ID]
    FROM Warehouse.StockItemHoldings AS sih
    ORDER BY sih.StockItemID;

    RETURN 0;
END;
GO
/****** Object:  StoredProcedure [Integration].[GetStockItemUpdates]    Script Date: 22/10/2022 01:21:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Integration].[GetStockItemUpdates]
@LastCutoff datetime2(7),
@NewCutoff datetime2(7)
WITH EXECUTE AS OWNER
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    DECLARE @EndOfTime datetime2(7) = '99991231 23:59:59.9999999';

    CREATE TABLE #StockItemChanges
    (
        [WWI Stock Item ID] int,
        [Stock Item] nvarchar(100),
        Color nvarchar(20),
        [Selling Package] nvarchar(50),
        [Buying Package] nvarchar(50),
        Brand nvarchar(50),
        Size nvarchar(20),
        [Lead Time Days] int,
        [Quantity Per Outer] int,
        [Is Chiller Stock] bit,
        Barcode nvarchar(50),
        [Tax Rate] decimal(18,3),
        [Unit Price] decimal(18,2),
        [Recommended Retail Price] decimal(18,2),
        [Typical Weight Per Unit] decimal(18,3),
        Photo varbinary(max),
        [Valid From] datetime2(7),
        [Valid To] datetime2(7)
    );

    DECLARE @StockItemID int;
    DECLARE @ValidFrom datetime2(7);

    -- need to find any StockItem changes that have occurred, including during the initial load

    DECLARE StockItemChangeList CURSOR FAST_FORWARD READ_ONLY
    FOR
    SELECT c.StockItemID,
           c.ValidFrom
    FROM Warehouse.StockItems_Archive AS c
    WHERE c.ValidFrom > @LastCutoff
    AND c.ValidFrom <= @NewCutoff
    UNION ALL
    SELECT c.StockItemID,
           c.ValidFrom
    FROM Warehouse.StockItems AS c
    WHERE c.ValidFrom > @LastCutoff
    AND c.ValidFrom <= @NewCutoff
    ORDER BY ValidFrom;

    OPEN StockItemChangeList;
    FETCH NEXT FROM StockItemChangeList INTO @StockItemID, @ValidFrom;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        INSERT #StockItemChanges
            ([WWI Stock Item ID], [Stock Item], Color, [Selling Package],
             [Buying Package], Brand, Size, [Lead Time Days], [Quantity Per Outer],
             [Is Chiller Stock], Barcode, [Tax Rate], [Unit Price], [Recommended Retail Price],
             [Typical Weight Per Unit], Photo, [Valid From], [Valid To])
        SELECT si.StockItemID, si.StockItemName, c.ColorName, spt.PackageTypeName,
               bpt.PackageTypeName, si.Brand, si.Size, si.LeadTimeDays, si.QuantityPerOuter,
               si.IsChillerStock, si.Barcode, si.LeadTimeDays, si.UnitPrice, si.RecommendedRetailPrice,
               si.TypicalWeightPerUnit, si.Photo, si.ValidFrom, si.ValidTo
        FROM Warehouse.StockItems FOR SYSTEM_TIME AS OF @ValidFrom AS si
        INNER JOIN Warehouse.PackageTypes FOR SYSTEM_TIME AS OF @ValidFrom AS spt
        ON si.UnitPackageID = spt.PackageTypeID
        INNER JOIN Warehouse.PackageTypes FOR SYSTEM_TIME AS OF @ValidFrom AS bpt
        ON si.OuterPackageID = bpt.PackageTypeID
        LEFT OUTER JOIN Warehouse.Colors FOR SYSTEM_TIME AS OF @ValidFrom AS c
        ON si.ColorID = c.ColorID
        WHERE si.StockItemID = @StockItemID;

        FETCH NEXT FROM StockItemChangeList INTO @StockItemID, @ValidFrom;
    END;

    CLOSE StockItemChangeList;
    DEALLOCATE StockItemChangeList;

    -- add an index to make lookups faster

    CREATE INDEX IX_StockItemChanges ON #StockItemChanges ([WWI Stock Item ID], [Valid From]);

    -- work out the [Valid To] value by taking the [Valid From] of any row that's for the same StockItem but later
    -- otherwise take the end of time

    UPDATE cc
    SET [Valid To] = COALESCE((SELECT MIN([Valid From]) FROM #StockItemChanges AS cc2
                                                        WHERE cc2.[WWI Stock Item ID] = cc.[WWI Stock Item ID]
                                                        AND cc2.[Valid From] > cc.[Valid From]), @EndOfTime)
    FROM #StockItemChanges AS cc;

    SELECT [WWI Stock Item ID], [Stock Item],
           ISNULL(Color, N'N/A') AS Color,
           [Selling Package], [Buying Package],
           ISNULL(Brand, N'N/A') AS Brand,
           ISNULL(Size, N'N/A') AS Size,
           [Lead Time Days], [Quantity Per Outer], [Is Chiller Stock],
           ISNULL(Barcode, N'N/A') AS Barcode,
           [Tax Rate], [Unit Price], [Recommended Retail Price], [Typical Weight Per Unit],
           Photo, [Valid From], [Valid To]
    FROM #StockItemChanges
    ORDER BY [Valid From];

    DROP TABLE #StockItemChanges;

    RETURN 0;
END;
GO
/****** Object:  StoredProcedure [Integration].[GetSupplierUpdates]    Script Date: 22/10/2022 01:21:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Integration].[GetSupplierUpdates]
@LastCutoff datetime2(7),
@NewCutoff datetime2(7)
WITH EXECUTE AS OWNER
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    DECLARE @EndOfTime datetime2(7) = '99991231 23:59:59.9999999';
    DECLARE @InitialLoadDate date = '20130101';

    CREATE TABLE #SupplierChanges
    (
        [WWI Supplier ID] int,
        Supplier nvarchar(100),
        Category nvarchar(50),
        [Primary Contact] nvarchar(50),
        [Supplier Reference] nvarchar(20),
        [Payment Days] int,
        [Postal Code] nvarchar(10),
        [Valid From] datetime2(7),
        [Valid To] datetime2(7)
    );

    DECLARE @SupplierCategoryID int;
    DECLARE @SupplierID int;
    DECLARE @ValidFrom datetime2(7);

    -- need to find any Supplier category changes that have occurred since initial load

    DECLARE SupplierCategoryChangeList CURSOR FAST_FORWARD READ_ONLY
    FOR
    SELECT cc.SupplierCategoryID,
           cc.ValidFrom
    FROM Purchasing.SupplierCategories_Archive AS cc
    WHERE cc.ValidFrom > @LastCutoff
    AND cc.ValidFrom <= @NewCutoff
    AND cc.ValidFrom <> @InitialLoadDate
    UNION ALL
    SELECT cc.SupplierCategoryID,
           cc.ValidFrom
    FROM Purchasing.SupplierCategories AS cc
    WHERE cc.ValidFrom > @LastCutoff
    AND cc.ValidFrom <= @NewCutoff
    AND cc.ValidFrom <> @InitialLoadDate
    ORDER BY ValidFrom;

    OPEN SupplierCategoryChangeList;
    FETCH NEXT FROM SupplierCategoryChangeList INTO @SupplierCategoryID, @ValidFrom;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        INSERT #SupplierChanges
            ([WWI Supplier ID], Supplier, Category, [Primary Contact], [Supplier Reference],
             [Payment Days], [Postal Code], [Valid From], [Valid To])
        SELECT s.SupplierID, s.SupplierName, sc.SupplierCategoryName, p.FullName, s.SupplierReference,
               s.PaymentDays, s.DeliveryPostalCode, s.ValidFrom, s.ValidTo
        FROM Purchasing.Suppliers FOR SYSTEM_TIME AS OF @ValidFrom AS s
        INNER JOIN Purchasing.SupplierCategories FOR SYSTEM_TIME AS OF @ValidFrom AS sc
        ON s.SupplierCategoryID = sc.SupplierCategoryID
        INNER JOIN [Application].People FOR SYSTEM_TIME AS OF @ValidFrom AS p
        ON s.PrimaryContactPersonID = p.PersonID
        WHERE sc.SupplierCategoryID = @SupplierCategoryID;

        FETCH NEXT FROM SupplierCategoryChangeList INTO @SupplierCategoryID, @ValidFrom;
    END;

    CLOSE SupplierCategoryChangeList;
    DEALLOCATE SupplierCategoryChangeList;

    -- finally need to find any Supplier changes that have occurred, including during the initial load

    DECLARE SupplierChangeList CURSOR FAST_FORWARD READ_ONLY
    FOR
    SELECT c.SupplierID,
           c.ValidFrom
    FROM Purchasing.Suppliers_Archive AS c
    WHERE c.ValidFrom > @LastCutoff
    AND c.ValidFrom <= @NewCutoff
    UNION ALL
    SELECT c.SupplierID,
           c.ValidFrom
    FROM Purchasing.Suppliers AS c
    WHERE c.ValidFrom > @LastCutoff
    AND c.ValidFrom <= @NewCutoff
    ORDER BY ValidFrom;

    OPEN SupplierChangeList;
    FETCH NEXT FROM SupplierChangeList INTO @SupplierID, @ValidFrom;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        INSERT #SupplierChanges
            ([WWI Supplier ID], Supplier, Category, [Primary Contact], [Supplier Reference],
             [Payment Days], [Postal Code], [Valid From], [Valid To])
        SELECT s.SupplierID, s.SupplierName, sc.SupplierCategoryName, p.FullName, s.SupplierReference,
               s.PaymentDays, s.DeliveryPostalCode, s.ValidFrom, s.ValidTo
        FROM Purchasing.Suppliers FOR SYSTEM_TIME AS OF @ValidFrom AS s
        INNER JOIN Purchasing.SupplierCategories FOR SYSTEM_TIME AS OF @ValidFrom AS sc
        ON s.SupplierCategoryID = sc.SupplierCategoryID
        INNER JOIN [Application].People FOR SYSTEM_TIME AS OF @ValidFrom AS p
        ON s.PrimaryContactPersonID = p.PersonID
        WHERE s.SupplierID = @SupplierID;

        FETCH NEXT FROM SupplierChangeList INTO @SupplierID, @ValidFrom;
    END;

    CLOSE SupplierChangeList;
    DEALLOCATE SupplierChangeList;

    -- add an index to make lookups faster

    CREATE INDEX IX_SupplierChanges ON #SupplierChanges ([WWI Supplier ID], [Valid From]);

    -- work out the [Valid To] value by taking the [Valid From] of any row that's for the same Supplier but later
    -- otherwise take the end of time

    UPDATE cc
    SET [Valid To] = COALESCE((SELECT MIN([Valid From]) FROM #SupplierChanges AS cc2
                                                        WHERE cc2.[WWI Supplier ID] = cc.[WWI Supplier ID]
                                                        AND cc2.[Valid From] > cc.[Valid From]), @EndOfTime)
    FROM #SupplierChanges AS cc;

    SELECT [WWI Supplier ID], Supplier, Category, [Primary Contact],
           [Supplier Reference], [Payment Days], [Postal Code],
           [Valid From], [Valid To]
    FROM #SupplierChanges
    ORDER BY [Valid From];

    DROP TABLE #SupplierChanges;

    RETURN 0;
END;
GO
/****** Object:  StoredProcedure [Integration].[GetTransactionTypeUpdates]    Script Date: 22/10/2022 01:21:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Integration].[GetTransactionTypeUpdates]
@LastCutoff datetime2(7),
@NewCutoff datetime2(7)
WITH EXECUTE AS OWNER
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    DECLARE @EndOfTime datetime2(7) = '99991231 23:59:59.9999999';

    CREATE TABLE #TransactionTypeChanges
    (
        [WWI Transaction Type ID] int,
        [Transaction Type] nvarchar(50),
        [Valid From] datetime2(7),
        [Valid To] datetime2(7)
    );

    DECLARE @TransactionTypeID int;
    DECLARE @ValidFrom datetime2(7);

    -- need to find any Transaction Type changes that have occurred, including during the initial load

    DECLARE ChangeList CURSOR FAST_FORWARD READ_ONLY
    FOR
    SELECT tt.TransactionTypeID,
           tt.ValidFrom
    FROM [Application].TransactionTypes_Archive AS tt
    WHERE tt.ValidFrom > @LastCutoff
    AND tt.ValidFrom <= @NewCutoff
    UNION ALL
    SELECT tt.TransactionTypeID,
           tt.ValidFrom
    FROM [Application].TransactionTypes AS tt
    WHERE tt.ValidFrom > @LastCutoff
    AND tt.ValidFrom <= @NewCutoff
    ORDER BY ValidFrom;

    OPEN ChangeList;
    FETCH NEXT FROM ChangeList INTO @TransactionTypeID, @ValidFrom;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        INSERT #TransactionTypeChanges
            ([WWI Transaction Type ID], [Transaction Type], [Valid From], [Valid To])
        SELECT p.TransactionTypeID, p.TransactionTypeName, p.ValidFrom, p.ValidTo
        FROM [Application].TransactionTypes FOR SYSTEM_TIME AS OF @ValidFrom AS p
        WHERE p.TransactionTypeID = @TransactionTypeID;

        FETCH NEXT FROM ChangeList INTO @TransactionTypeID, @ValidFrom;
    END;

    CLOSE ChangeList;
    DEALLOCATE ChangeList;

    -- add an index to make lookups faster

    CREATE INDEX IX_TransactionTypeChanges ON #TransactionTypeChanges ([WWI Transaction Type ID], [Valid From]);

    -- work out the [Valid To] value by taking the [Valid From] of any row that's for the same entry but later
    -- otherwise take the end of time

    UPDATE cc
    SET [Valid To] = COALESCE((SELECT MIN([Valid From]) FROM #TransactionTypeChanges AS cc2
                                                        WHERE cc2.[WWI Transaction Type ID] = cc.[WWI Transaction Type ID]
                                                        AND cc2.[Valid From] > cc.[Valid From]), @EndOfTime)
    FROM #TransactionTypeChanges AS cc;

    SELECT [WWI Transaction Type ID], [Transaction Type], [Valid From], [Valid To]
    FROM #TransactionTypeChanges
    ORDER BY [Valid From];

    DROP TABLE #TransactionTypeChanges;

    RETURN 0;
END;
GO
/****** Object:  StoredProcedure [Integration].[GetTransactionUpdates]    Script Date: 22/10/2022 01:21:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Integration].[GetTransactionUpdates]
@LastCutoff datetime2(7),
@NewCutoff datetime2(7)
WITH EXECUTE AS OWNER
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    SELECT CAST(ct.TransactionDate AS date) AS [Date Key],
           ct.CustomerTransactionID AS [WWI Customer Transaction ID],
           CAST(NULL AS int) AS [WWI Supplier Transaction ID],
           ct.InvoiceID AS [WWI Invoice ID],
           CAST(NULL AS int) AS [WWI Purchase Order ID],
           CAST(NULL AS nvarchar(20)) AS [Supplier Invoice Number],
           ct.AmountExcludingTax AS [Total Excluding Tax],
           ct.TaxAmount AS [Tax Amount],
           ct.TransactionAmount AS [Total Including Tax],
           ct.OutstandingBalance AS [Outstanding Balance],
           ct.IsFinalized AS [Is Finalized],
           COALESCE(i.CustomerID, ct.CustomerID) AS [WWI Customer ID],
           ct.CustomerID AS [WWI Bill To Customer ID],
           CAST(NULL AS int) AS [WWI Supplier ID],
           ct.TransactionTypeID AS [WWI Transaction Type ID],
           ct.PaymentMethodID AS [WWI Payment Method ID],
           ct.LastEditedWhen AS [Last Modified When]
    FROM Sales.CustomerTransactions AS ct
    LEFT OUTER JOIN Sales.Invoices AS i
    ON ct.InvoiceID = i.InvoiceID
    WHERE ct.LastEditedWhen > @LastCutoff
    AND ct.LastEditedWhen <= @NewCutoff

    UNION ALL

    SELECT CAST(st.TransactionDate AS date) AS [Date Key],
           CAST(NULL AS int) AS [WWI Customer Transaction ID],
           st.SupplierTransactionID AS [WWI Supplier Transaction ID],
           CAST(NULL AS int) AS [WWI Invoice ID],
           st.PurchaseOrderID AS [WWI Purchase Order ID],
           st.SupplierInvoiceNumber AS [Supplier Invoice Number],
           st.AmountExcludingTax AS [Total Excluding Tax],
           st.TaxAmount AS [Tax Amount],
           st.TransactionAmount AS [Total Including Tax],
           st.OutstandingBalance AS [Outstanding Balance],
           st.IsFinalized AS [Is Finalized],
           CAST(NULL AS int) AS [WWI Customer ID],
           CAST(NULL AS int) AS [WWI Bill To Customer ID],
           st.SupplierID AS [WWI Supplier ID],
           st.TransactionTypeID AS [WWI Transaction Type ID],
           st.PaymentMethodID AS [WWI Payment Method ID],
           st.LastEditedWhen AS [Last Modified When]
    FROM Purchasing.SupplierTransactions AS st
    WHERE st.LastEditedWhen > @LastCutoff
    AND st.LastEditedWhen <= @NewCutoff;

    RETURN 0;
END;
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Tables and procedures required for integration with the data warehouse' , @level0type=N'SCHEMA',@level0name=N'Integration'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Details of suppliers and of purchasing of stock items' , @level0type=N'SCHEMA',@level0name=N'Purchasing'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Views and stored procedures that provide the only access for the reporting system' , @level0type=N'SCHEMA',@level0name=N'Reports'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Details of customers, salespeople, and of sales of stock items' , @level0type=N'SCHEMA',@level0name=N'Sales'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Numeric ID used for reference to a line on a purchase order within the database' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'PurchaseOrderLines', @level2type=N'COLUMN',@level2name=N'PurchaseOrderLineID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Purchase order that this line is associated with' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'PurchaseOrderLines', @level2type=N'COLUMN',@level2name=N'PurchaseOrderID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Stock item for this purchase order line' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'PurchaseOrderLines', @level2type=N'COLUMN',@level2name=N'StockItemID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Quantity of the stock item that is ordered' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'PurchaseOrderLines', @level2type=N'COLUMN',@level2name=N'OrderedOuters'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Description of the item to be supplied (Often the stock item name but could be supplier description)' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'PurchaseOrderLines', @level2type=N'COLUMN',@level2name=N'Description'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Total quantity of the stock item that has been received so far' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'PurchaseOrderLines', @level2type=N'COLUMN',@level2name=N'ReceivedOuters'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Type of package received' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'PurchaseOrderLines', @level2type=N'COLUMN',@level2name=N'PackageTypeID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'The unit price that we expect to be charged' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'PurchaseOrderLines', @level2type=N'COLUMN',@level2name=N'ExpectedUnitPricePerOuter'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'The last date on which this stock item was received for this purchase order' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'PurchaseOrderLines', @level2type=N'COLUMN',@level2name=N'LastReceiptDate'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Is this purchase order line now considered finalized? (Receipted quantities and weights are often not precise)' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'PurchaseOrderLines', @level2type=N'COLUMN',@level2name=N'IsOrderLineFinalized'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Detail lines from supplier purchase orders' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'PurchaseOrderLines'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Numeric ID used for reference to a purchase order within the database' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'PurchaseOrders', @level2type=N'COLUMN',@level2name=N'PurchaseOrderID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Supplier for this purchase order' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'PurchaseOrders', @level2type=N'COLUMN',@level2name=N'SupplierID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Date that this purchase order was raised' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'PurchaseOrders', @level2type=N'COLUMN',@level2name=N'OrderDate'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'How this purchase order should be delivered' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'PurchaseOrders', @level2type=N'COLUMN',@level2name=N'DeliveryMethodID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'The person who is the primary contact for this purchase order' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'PurchaseOrders', @level2type=N'COLUMN',@level2name=N'ContactPersonID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Expected delivery date for this purchase order' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'PurchaseOrders', @level2type=N'COLUMN',@level2name=N'ExpectedDeliveryDate'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Supplier reference for our organization (might be our account number at the supplier)' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'PurchaseOrders', @level2type=N'COLUMN',@level2name=N'SupplierReference'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Is this purchase order now considered finalized?' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'PurchaseOrders', @level2type=N'COLUMN',@level2name=N'IsOrderFinalized'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Any comments related this purchase order (comments sent to the supplier)' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'PurchaseOrders', @level2type=N'COLUMN',@level2name=N'Comments'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Any internal comments related this purchase order (comments for internal reference only and not sent to the supplier)' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'PurchaseOrders', @level2type=N'COLUMN',@level2name=N'InternalComments'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Details of supplier purchase orders' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'PurchaseOrders'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Numeric ID used for reference to a supplier category within the database' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'SupplierCategories', @level2type=N'COLUMN',@level2name=N'SupplierCategoryID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Full name of the category that suppliers can be assigned to' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'SupplierCategories', @level2type=N'COLUMN',@level2name=N'SupplierCategoryName'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Categories for suppliers (ie novelties, toys, clothing, packaging, etc.)' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'SupplierCategories'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Numeric ID used for reference to a supplier within the database' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'Suppliers', @level2type=N'COLUMN',@level2name=N'SupplierID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Supplier''s full name (usually a trading name)' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'Suppliers', @level2type=N'COLUMN',@level2name=N'SupplierName'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Supplier''s category' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'Suppliers', @level2type=N'COLUMN',@level2name=N'SupplierCategoryID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Primary contact' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'Suppliers', @level2type=N'COLUMN',@level2name=N'PrimaryContactPersonID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Alternate contact' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'Suppliers', @level2type=N'COLUMN',@level2name=N'AlternateContactPersonID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Standard delivery method for stock items received from this supplier' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'Suppliers', @level2type=N'COLUMN',@level2name=N'DeliveryMethodID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'ID of the delivery city for this address' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'Suppliers', @level2type=N'COLUMN',@level2name=N'DeliveryCityID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'ID of the mailing city for this address' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'Suppliers', @level2type=N'COLUMN',@level2name=N'PostalCityID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Supplier reference for our organization (might be our account number at the supplier)' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'Suppliers', @level2type=N'COLUMN',@level2name=N'SupplierReference'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Supplier''s bank account name (ie name on the account)' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'Suppliers', @level2type=N'COLUMN',@level2name=N'BankAccountName'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Supplier''s bank branch' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'Suppliers', @level2type=N'COLUMN',@level2name=N'BankAccountBranch'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Supplier''s bank account code (usually a numeric reference for the bank branch)' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'Suppliers', @level2type=N'COLUMN',@level2name=N'BankAccountCode'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Supplier''s bank account number' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'Suppliers', @level2type=N'COLUMN',@level2name=N'BankAccountNumber'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Supplier''s bank''s international code (such as a SWIFT code)' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'Suppliers', @level2type=N'COLUMN',@level2name=N'BankInternationalCode'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Number of days for payment of an invoice (ie payment terms)' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'Suppliers', @level2type=N'COLUMN',@level2name=N'PaymentDays'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Internal comments (not exposed outside organization)' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'Suppliers', @level2type=N'COLUMN',@level2name=N'InternalComments'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Phone number' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'Suppliers', @level2type=N'COLUMN',@level2name=N'PhoneNumber'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Fax number  ' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'Suppliers', @level2type=N'COLUMN',@level2name=N'FaxNumber'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'URL for the website for this supplier' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'Suppliers', @level2type=N'COLUMN',@level2name=N'WebsiteURL'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'First delivery address line for the supplier' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'Suppliers', @level2type=N'COLUMN',@level2name=N'DeliveryAddressLine1'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Second delivery address line for the supplier' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'Suppliers', @level2type=N'COLUMN',@level2name=N'DeliveryAddressLine2'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Delivery postal code for the supplier' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'Suppliers', @level2type=N'COLUMN',@level2name=N'DeliveryPostalCode'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Geographic location for the supplier''s office/warehouse' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'Suppliers', @level2type=N'COLUMN',@level2name=N'DeliveryLocation'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'First postal address line for the supplier' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'Suppliers', @level2type=N'COLUMN',@level2name=N'PostalAddressLine1'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Second postal address line for the supplier' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'Suppliers', @level2type=N'COLUMN',@level2name=N'PostalAddressLine2'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Postal code for the supplier when sending by mail' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'Suppliers', @level2type=N'COLUMN',@level2name=N'PostalPostalCode'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Main entity table for suppliers (organizations)' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'Suppliers'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Numeric ID used to refer to a supplier transaction within the database' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'SupplierTransactions', @level2type=N'COLUMN',@level2name=N'SupplierTransactionID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Supplier for this transaction' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'SupplierTransactions', @level2type=N'COLUMN',@level2name=N'SupplierID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Type of transaction' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'SupplierTransactions', @level2type=N'COLUMN',@level2name=N'TransactionTypeID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'ID of an purchase order (for transactions associated with a purchase order)' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'SupplierTransactions', @level2type=N'COLUMN',@level2name=N'PurchaseOrderID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'ID of a payment method (for transactions involving payments)' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'SupplierTransactions', @level2type=N'COLUMN',@level2name=N'PaymentMethodID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Invoice number for an invoice received from the supplier' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'SupplierTransactions', @level2type=N'COLUMN',@level2name=N'SupplierInvoiceNumber'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Date for the transaction' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'SupplierTransactions', @level2type=N'COLUMN',@level2name=N'TransactionDate'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Transaction amount (excluding tax)' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'SupplierTransactions', @level2type=N'COLUMN',@level2name=N'AmountExcludingTax'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Tax amount calculated' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'SupplierTransactions', @level2type=N'COLUMN',@level2name=N'TaxAmount'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Transaction amount (including tax)' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'SupplierTransactions', @level2type=N'COLUMN',@level2name=N'TransactionAmount'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Amount still outstanding for this transaction' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'SupplierTransactions', @level2type=N'COLUMN',@level2name=N'OutstandingBalance'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Date that this transaction was finalized (if it has been)' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'SupplierTransactions', @level2type=N'COLUMN',@level2name=N'FinalizationDate'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Is this transaction finalized (invoices, credits and payments have been matched)' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'SupplierTransactions', @level2type=N'COLUMN',@level2name=N'IsFinalized'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'All financial transactions that are supplier-related' , @level0type=N'SCHEMA',@level0name=N'Purchasing', @level1type=N'TABLE',@level1name=N'SupplierTransactions'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Numeric ID used for reference to a buying group within the database' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'BuyingGroups', @level2type=N'COLUMN',@level2name=N'BuyingGroupID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Full name of a buying group that customers can be members of' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'BuyingGroups', @level2type=N'COLUMN',@level2name=N'BuyingGroupName'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Customer organizations can be part of groups that exert greater buying power' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'BuyingGroups'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Numeric ID used for reference to a customer category within the database' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'CustomerCategories', @level2type=N'COLUMN',@level2name=N'CustomerCategoryID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Full name of the category that customers can be assigned to' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'CustomerCategories', @level2type=N'COLUMN',@level2name=N'CustomerCategoryName'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Categories for customers (ie restaurants, cafes, supermarkets, etc.)' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'CustomerCategories'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Numeric ID used for reference to a customer within the database' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'CustomerID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Customer''s full name (usually a trading name)' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'CustomerName'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Customer that this is billed to (usually the same customer but can be another parent company)' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'BillToCustomerID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Customer''s category' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'CustomerCategoryID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Customer''s buying group (optional)' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'BuyingGroupID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Primary contact' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'PrimaryContactPersonID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Alternate contact' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'AlternateContactPersonID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Standard delivery method for stock items sent to this customer' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'DeliveryMethodID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'ID of the delivery city for this address' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'DeliveryCityID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'ID of the postal city for this address' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'PostalCityID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Credit limit for this customer (NULL if unlimited)' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'CreditLimit'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Date this customer account was opened' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'AccountOpenedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Standard discount offered to this customer' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'StandardDiscountPercentage'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Is a statement sent to this customer? (Or do they just pay on each invoice?)' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'IsStatementSent'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Is this customer on credit hold? (Prevents further deliveries to this customer)' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'IsOnCreditHold'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Number of days for payment of an invoice (ie payment terms)' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'PaymentDays'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Phone number' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'PhoneNumber'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Fax number  ' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'FaxNumber'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Normal delivery run for this customer' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'DeliveryRun'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Normal position in the delivery run for this customer' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'RunPosition'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'URL for the website for this customer' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'WebsiteURL'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'First delivery address line for the customer' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'DeliveryAddressLine1'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Second delivery address line for the customer' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'DeliveryAddressLine2'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Delivery postal code for the customer' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'DeliveryPostalCode'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Geographic location for the customer''s office/warehouse' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'DeliveryLocation'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'First postal address line for the customer' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'PostalAddressLine1'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Second postal address line for the customer' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'PostalAddressLine2'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Postal code for the customer when sending by mail' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'PostalPostalCode'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Main entity tables for customers (organizations or individuals)' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Customers'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Numeric ID used to refer to a customer transaction within the database' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'CustomerTransactions', @level2type=N'COLUMN',@level2name=N'CustomerTransactionID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Customer for this transaction' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'CustomerTransactions', @level2type=N'COLUMN',@level2name=N'CustomerID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Type of transaction' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'CustomerTransactions', @level2type=N'COLUMN',@level2name=N'TransactionTypeID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'ID of an invoice (for transactions associated with an invoice)' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'CustomerTransactions', @level2type=N'COLUMN',@level2name=N'InvoiceID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'ID of a payment method (for transactions involving payments)' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'CustomerTransactions', @level2type=N'COLUMN',@level2name=N'PaymentMethodID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Date for the transaction' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'CustomerTransactions', @level2type=N'COLUMN',@level2name=N'TransactionDate'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Transaction amount (excluding tax)' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'CustomerTransactions', @level2type=N'COLUMN',@level2name=N'AmountExcludingTax'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Tax amount calculated' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'CustomerTransactions', @level2type=N'COLUMN',@level2name=N'TaxAmount'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Transaction amount (including tax)' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'CustomerTransactions', @level2type=N'COLUMN',@level2name=N'TransactionAmount'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Amount still outstanding for this transaction' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'CustomerTransactions', @level2type=N'COLUMN',@level2name=N'OutstandingBalance'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Date that this transaction was finalized (if it has been)' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'CustomerTransactions', @level2type=N'COLUMN',@level2name=N'FinalizationDate'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Is this transaction finalized (invoices, credits and payments have been matched)' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'CustomerTransactions', @level2type=N'COLUMN',@level2name=N'IsFinalized'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'All financial transactions that are customer-related' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'CustomerTransactions'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Numeric ID used for reference to a line on an invoice within the database' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'InvoiceLines', @level2type=N'COLUMN',@level2name=N'InvoiceLineID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Invoice that this line is associated with' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'InvoiceLines', @level2type=N'COLUMN',@level2name=N'InvoiceID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Stock item for this invoice line' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'InvoiceLines', @level2type=N'COLUMN',@level2name=N'StockItemID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Description of the item supplied (Usually the stock item name but can be overridden)' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'InvoiceLines', @level2type=N'COLUMN',@level2name=N'Description'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Type of package supplied' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'InvoiceLines', @level2type=N'COLUMN',@level2name=N'PackageTypeID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Quantity supplied' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'InvoiceLines', @level2type=N'COLUMN',@level2name=N'Quantity'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Unit price charged' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'InvoiceLines', @level2type=N'COLUMN',@level2name=N'UnitPrice'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Tax rate to be applied' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'InvoiceLines', @level2type=N'COLUMN',@level2name=N'TaxRate'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Tax amount calculated' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'InvoiceLines', @level2type=N'COLUMN',@level2name=N'TaxAmount'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Profit made on this line item at current cost price' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'InvoiceLines', @level2type=N'COLUMN',@level2name=N'LineProfit'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Extended line price charged' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'InvoiceLines', @level2type=N'COLUMN',@level2name=N'ExtendedPrice'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Detail lines from customer invoices' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'InvoiceLines'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Numeric ID used for reference to an invoice within the database' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Invoices', @level2type=N'COLUMN',@level2name=N'InvoiceID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Customer for this invoice' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Invoices', @level2type=N'COLUMN',@level2name=N'CustomerID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Bill to customer for this invoice (invoices might be billed to a head office)' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Invoices', @level2type=N'COLUMN',@level2name=N'BillToCustomerID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Sales order (if any) for this invoice' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Invoices', @level2type=N'COLUMN',@level2name=N'OrderID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'How these stock items are beign delivered' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Invoices', @level2type=N'COLUMN',@level2name=N'DeliveryMethodID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Customer contact for this invoice' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Invoices', @level2type=N'COLUMN',@level2name=N'ContactPersonID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Customer accounts contact for this invoice' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Invoices', @level2type=N'COLUMN',@level2name=N'AccountsPersonID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Salesperson for this invoice' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Invoices', @level2type=N'COLUMN',@level2name=N'SalespersonPersonID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Person who packed this shipment (or checked the packing)' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Invoices', @level2type=N'COLUMN',@level2name=N'PackedByPersonID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Date that this invoice was raised' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Invoices', @level2type=N'COLUMN',@level2name=N'InvoiceDate'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Purchase Order Number received from customer' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Invoices', @level2type=N'COLUMN',@level2name=N'CustomerPurchaseOrderNumber'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Is this a credit note (rather than an invoice)' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Invoices', @level2type=N'COLUMN',@level2name=N'IsCreditNote'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Reason that this credit note needed to be generated (if applicable)' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Invoices', @level2type=N'COLUMN',@level2name=N'CreditNoteReason'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Any comments related to this invoice (sent to customer)' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Invoices', @level2type=N'COLUMN',@level2name=N'Comments'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Any comments related to delivery (sent to customer)' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Invoices', @level2type=N'COLUMN',@level2name=N'DeliveryInstructions'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Any internal comments related to this invoice (not sent to the customer)' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Invoices', @level2type=N'COLUMN',@level2name=N'InternalComments'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Total number of dry packages (information for the delivery driver)' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Invoices', @level2type=N'COLUMN',@level2name=N'TotalDryItems'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Total number of chiller packages (information for the delivery driver)' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Invoices', @level2type=N'COLUMN',@level2name=N'TotalChillerItems'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Delivery run for this shipment' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Invoices', @level2type=N'COLUMN',@level2name=N'DeliveryRun'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Position in the delivery run for this shipment' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Invoices', @level2type=N'COLUMN',@level2name=N'RunPosition'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'JSON-structured data returned from delivery devices for deliveries made directly by the organization' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Invoices', @level2type=N'COLUMN',@level2name=N'ReturnedDeliveryData'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Confirmed delivery date and time promoted from JSON delivery data' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Invoices', @level2type=N'COLUMN',@level2name=N'ConfirmedDeliveryTime'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Confirmed receiver promoted from JSON delivery data' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Invoices', @level2type=N'COLUMN',@level2name=N'ConfirmedReceivedBy'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Details of customer invoices' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Invoices'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Ensures that if returned delivery data is present that it is valid JSON' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Invoices', @level2type=N'CONSTRAINT',@level2name=N'CK_Sales_Invoices_ReturnedDeliveryData_Must_Be_Valid_JSON'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Numeric ID used for reference to a line on an Order within the database' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'OrderLines', @level2type=N'COLUMN',@level2name=N'OrderLineID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Order that this line is associated with' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'OrderLines', @level2type=N'COLUMN',@level2name=N'OrderID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Stock item for this order line (FK not indexed as separate index exists)' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'OrderLines', @level2type=N'COLUMN',@level2name=N'StockItemID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Description of the item supplied (Usually the stock item name but can be overridden)' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'OrderLines', @level2type=N'COLUMN',@level2name=N'Description'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Type of package to be supplied' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'OrderLines', @level2type=N'COLUMN',@level2name=N'PackageTypeID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Quantity to be supplied' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'OrderLines', @level2type=N'COLUMN',@level2name=N'Quantity'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Unit price to be charged' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'OrderLines', @level2type=N'COLUMN',@level2name=N'UnitPrice'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Tax rate to be applied' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'OrderLines', @level2type=N'COLUMN',@level2name=N'TaxRate'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Quantity picked from stock' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'OrderLines', @level2type=N'COLUMN',@level2name=N'PickedQuantity'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'When was picking of this line completed?' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'OrderLines', @level2type=N'COLUMN',@level2name=N'PickingCompletedWhen'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Detail lines from customer orders' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'OrderLines'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Numeric ID used for reference to an order within the database' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Orders', @level2type=N'COLUMN',@level2name=N'OrderID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Customer for this order' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Orders', @level2type=N'COLUMN',@level2name=N'CustomerID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Salesperson for this order' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Orders', @level2type=N'COLUMN',@level2name=N'SalespersonPersonID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Person who picked this shipment' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Orders', @level2type=N'COLUMN',@level2name=N'PickedByPersonID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Customer contact for this order' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Orders', @level2type=N'COLUMN',@level2name=N'ContactPersonID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'If this order is a backorder, this column holds the original order number' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Orders', @level2type=N'COLUMN',@level2name=N'BackorderOrderID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Date that this order was raised' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Orders', @level2type=N'COLUMN',@level2name=N'OrderDate'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Expected delivery date' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Orders', @level2type=N'COLUMN',@level2name=N'ExpectedDeliveryDate'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Purchase Order Number received from customer' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Orders', @level2type=N'COLUMN',@level2name=N'CustomerPurchaseOrderNumber'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'If items cannot be supplied are they backordered?' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Orders', @level2type=N'COLUMN',@level2name=N'IsUndersupplyBackordered'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Any comments related to this order (sent to customer)' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Orders', @level2type=N'COLUMN',@level2name=N'Comments'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Any comments related to order delivery (sent to customer)' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Orders', @level2type=N'COLUMN',@level2name=N'DeliveryInstructions'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Any internal comments related to this order (not sent to the customer)' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Orders', @level2type=N'COLUMN',@level2name=N'InternalComments'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'When was picking of the entire order completed?' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Orders', @level2type=N'COLUMN',@level2name=N'PickingCompletedWhen'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Detail of customer orders' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'Orders'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'ID (sequence based) for a special deal' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'SpecialDeals', @level2type=N'COLUMN',@level2name=N'SpecialDealID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Stock item that the deal applies to (if NULL, then only discounts are permitted not unit prices)' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'SpecialDeals', @level2type=N'COLUMN',@level2name=N'StockItemID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'ID of the customer that the special pricing applies to (if NULL then all customers)' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'SpecialDeals', @level2type=N'COLUMN',@level2name=N'CustomerID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'ID of the buying group that the special pricing applies to (optional)' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'SpecialDeals', @level2type=N'COLUMN',@level2name=N'BuyingGroupID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'ID of the customer category that the special pricing applies to (optional)' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'SpecialDeals', @level2type=N'COLUMN',@level2name=N'CustomerCategoryID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'ID of the stock group that the special pricing applies to (optional)' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'SpecialDeals', @level2type=N'COLUMN',@level2name=N'StockGroupID'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Description of the special deal' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'SpecialDeals', @level2type=N'COLUMN',@level2name=N'DealDescription'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Date that the special pricing starts from' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'SpecialDeals', @level2type=N'COLUMN',@level2name=N'StartDate'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Date that the special pricing ends on' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'SpecialDeals', @level2type=N'COLUMN',@level2name=N'EndDate'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Discount per unit to be applied to sale price (optional)' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'SpecialDeals', @level2type=N'COLUMN',@level2name=N'DiscountAmount'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Discount percentage per unit to be applied to sale price (optional)' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'SpecialDeals', @level2type=N'COLUMN',@level2name=N'DiscountPercentage'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Special price per unit to be applied instead of sale price (optional)' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'SpecialDeals', @level2type=N'COLUMN',@level2name=N'UnitPrice'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Special pricing (can include fixed prices, discount $ or discount %)' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'SpecialDeals'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Ensures that each special price row contains one and only one of DiscountAmount, DiscountPercentage, and UnitPrice' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'SpecialDeals', @level2type=N'CONSTRAINT',@level2name=N'CK_Sales_SpecialDeals_Exactly_One_NOT_NULL_Pricing_Option_Is_Required'
GO
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Ensures that if a specific price is allocated that it applies to a specific stock item' , @level0type=N'SCHEMA',@level0name=N'Sales', @level1type=N'TABLE',@level1name=N'SpecialDeals', @level2type=N'CONSTRAINT',@level2name=N'CK_Sales_SpecialDeals_Unit_Price_Deal_Requires_Special_StockItem'
GO
