
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 10/21/2012 18:56:44
-- Generated from EDMX file: c:\users\benny\documents\visual studio 2012\Projects\08-05-01\08-05-01\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [XIN];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_GradeClassStudent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Student] DROP CONSTRAINT [FK_GradeClassStudent];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[GradeClass]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GradeClass];
GO
IF OBJECT_ID(N'[dbo].[Student]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Student];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'GradeClass'
CREATE TABLE [dbo].[GradeClass] (
    [GradeID] char(5)  NOT NULL,
    [Grade] tinyint  NOT NULL,
    [ClassID] tinyint  NOT NULL,
    [Graduate] bit  NOT NULL
);
GO

-- Creating table 'Student'
CREATE TABLE [dbo].[Student] (
    [StudentID] char(6)  NOT NULL,
    [Name] nvarchar(10)  NOT NULL,
    [Sex] char(1)  NOT NULL,
    [BirthDate] datetime  NULL,
    [Address] nvarchar(40)  NULL,
    [Phone] varchar(20)  NULL,
    [Parent] nvarchar(10)  NULL,
    [Relationship] nvarchar(10)  NULL,
    [GradeID] char(5)  NOT NULL,
    [ID] tinyint  NOT NULL,
    [ExitDate] datetime  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [GradeID] in table 'GradeClass'
ALTER TABLE [dbo].[GradeClass]
ADD CONSTRAINT [PK_GradeClass]
    PRIMARY KEY CLUSTERED ([GradeID] ASC);
GO

-- Creating primary key on [StudentID] in table 'Student'
ALTER TABLE [dbo].[Student]
ADD CONSTRAINT [PK_Student]
    PRIMARY KEY CLUSTERED ([StudentID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [GradeID] in table 'Student'
ALTER TABLE [dbo].[Student]
ADD CONSTRAINT [FK_GradeClassStudent]
    FOREIGN KEY ([GradeID])
    REFERENCES [dbo].[GradeClass]
        ([GradeID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_GradeClassStudent'
CREATE INDEX [IX_FK_GradeClassStudent]
ON [dbo].[Student]
    ([GradeID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------