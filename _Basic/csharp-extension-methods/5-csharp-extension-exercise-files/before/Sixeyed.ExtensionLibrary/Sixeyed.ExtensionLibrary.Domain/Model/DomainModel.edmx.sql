
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/27/2013 07:03:46
-- Generated from EDMX file: C:\src\M4\SAMPLES\Sixeyed.ExtensionLibrary\Sixeyed.ExtensionLibrary.Domain\Model\DomainModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Sixeyed.ExtensionLibrary.Domain];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CustomerOrder]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Orders] DROP CONSTRAINT [FK_CustomerOrder];
GO
IF OBJECT_ID(N'[dbo].[FK_OrderProducts_Order]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrderProduct] DROP CONSTRAINT [FK_OrderProducts_Order];
GO
IF OBJECT_ID(N'[dbo].[FK_OrderProducts_Product]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrderProduct] DROP CONSTRAINT [FK_OrderProducts_Product];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Products]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Products];
GO
IF OBJECT_ID(N'[dbo].[Orders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Orders];
GO
IF OBJECT_ID(N'[dbo].[Customers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Customers];
GO
IF OBJECT_ID(N'[dbo].[OrderProduct]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OrderProduct];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Orders'
CREATE TABLE [dbo].[Orders] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Reference] nvarchar(max)  NOT NULL,
    [Audit_Created] datetime  NOT NULL,
    [Audit_Updated] datetime  NOT NULL,
    [Audit_User] nvarchar(max)  NOT NULL,
    [Customer_Id] int  NOT NULL
);
GO

-- Creating table 'Customers'
CREATE TABLE [dbo].[Customers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [Audit_Created] datetime  NOT NULL,
    [Audit_Updated] datetime  NOT NULL,
    [Audit_User] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'OrderProduct'
CREATE TABLE [dbo].[OrderProduct] (
    [OrderProducts_Product_Id] int  NOT NULL,
    [Products_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [PK_Orders]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [PK_Customers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [OrderProducts_Product_Id], [Products_Id] in table 'OrderProduct'
ALTER TABLE [dbo].[OrderProduct]
ADD CONSTRAINT [PK_OrderProduct]
    PRIMARY KEY CLUSTERED ([OrderProducts_Product_Id], [Products_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Customer_Id] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [FK_CustomerOrder]
    FOREIGN KEY ([Customer_Id])
    REFERENCES [dbo].[Customers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CustomerOrder'
CREATE INDEX [IX_FK_CustomerOrder]
ON [dbo].[Orders]
    ([Customer_Id]);
GO

-- Creating foreign key on [OrderProducts_Product_Id] in table 'OrderProduct'
ALTER TABLE [dbo].[OrderProduct]
ADD CONSTRAINT [FK_OrderProducts_Order]
    FOREIGN KEY ([OrderProducts_Product_Id])
    REFERENCES [dbo].[Orders]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Products_Id] in table 'OrderProduct'
ALTER TABLE [dbo].[OrderProduct]
ADD CONSTRAINT [FK_OrderProducts_Product]
    FOREIGN KEY ([Products_Id])
    REFERENCES [dbo].[Products]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_OrderProducts_Product'
CREATE INDEX [IX_FK_OrderProducts_Product]
ON [dbo].[OrderProduct]
    ([Products_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------