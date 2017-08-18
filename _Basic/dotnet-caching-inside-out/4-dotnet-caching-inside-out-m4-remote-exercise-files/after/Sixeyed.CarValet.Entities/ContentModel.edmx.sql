
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 04/22/2013 10:58:51
-- Generated from EDMX file: E:\TFS-SC-ES\Pluralsight\Caching\Source\Sixeyed.CarValet\Sixeyed.CarValet.Entities\ContentModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CarValet];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Contents'
CREATE TABLE [dbo].[Contents] (
    [ContentCode] nvarchar(10)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ContentItems'
CREATE TABLE [dbo].[ContentItems] (
    [ContentItemId] int IDENTITY(1,1) NOT NULL,
    [Index] int  NOT NULL,
    [Value] nvarchar(max)  NOT NULL,
    [IsHtml] bit  NOT NULL,
    [Content_ContentCode] nvarchar(10)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ContentCode] in table 'Contents'
ALTER TABLE [dbo].[Contents]
ADD CONSTRAINT [PK_Contents]
    PRIMARY KEY CLUSTERED ([ContentCode] ASC);
GO

-- Creating primary key on [ContentItemId] in table 'ContentItems'
ALTER TABLE [dbo].[ContentItems]
ADD CONSTRAINT [PK_ContentItems]
    PRIMARY KEY CLUSTERED ([ContentItemId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Content_ContentCode] in table 'ContentItems'
ALTER TABLE [dbo].[ContentItems]
ADD CONSTRAINT [FK_ContentContentItem]
    FOREIGN KEY ([Content_ContentCode])
    REFERENCES [dbo].[Contents]
        ([ContentCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ContentContentItem'
CREATE INDEX [IX_FK_ContentContentItem]
ON [dbo].[ContentItems]
    ([Content_ContentCode]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------