
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 04/14/2013 20:16:43
-- Generated from EDMX file: C:\TFS\Pluralsight\Caching\Source\Sixeyed.CarValet\Sixeyed.CarValet.Entities\PricingModel.edmx
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

IF OBJECT_ID(N'[dbo].[FK_PricingFactorTypePricingFactor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PricingFactors] DROP CONSTRAINT [FK_PricingFactorTypePricingFactor];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[PricingFactorTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PricingFactorTypes];
GO
IF OBJECT_ID(N'[dbo].[PricingFactors]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PricingFactors];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'PricingFactorTypes'
CREATE TABLE [dbo].[PricingFactorTypes] (
    [PricingFactorTypeCode] nvarchar(5)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PricingFactors'
CREATE TABLE [dbo].[PricingFactors] (
    [PricingFactorId] int IDENTITY(1,1) NOT NULL,
    [AppliesTo] nvarchar(max)  NOT NULL,
    [Factor] float  NOT NULL,
    [PricingFactorType_PricingFactorTypeCode] nvarchar(5)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [PricingFactorTypeCode] in table 'PricingFactorTypes'
ALTER TABLE [dbo].[PricingFactorTypes]
ADD CONSTRAINT [PK_PricingFactorTypes]
    PRIMARY KEY CLUSTERED ([PricingFactorTypeCode] ASC);
GO

-- Creating primary key on [PricingFactorId] in table 'PricingFactors'
ALTER TABLE [dbo].[PricingFactors]
ADD CONSTRAINT [PK_PricingFactors]
    PRIMARY KEY CLUSTERED ([PricingFactorId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PricingFactorType_PricingFactorTypeCode] in table 'PricingFactors'
ALTER TABLE [dbo].[PricingFactors]
ADD CONSTRAINT [FK_PricingFactorTypePricingFactor]
    FOREIGN KEY ([PricingFactorType_PricingFactorTypeCode])
    REFERENCES [dbo].[PricingFactorTypes]
        ([PricingFactorTypeCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PricingFactorTypePricingFactor'
CREATE INDEX [IX_FK_PricingFactorTypePricingFactor]
ON [dbo].[PricingFactors]
    ([PricingFactorType_PricingFactorTypeCode]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------