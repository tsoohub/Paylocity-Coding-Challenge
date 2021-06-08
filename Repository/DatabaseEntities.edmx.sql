
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/06/2021 12:18:03
-- Generated from EDMX file: C:\Users\tsood\source\repos\PaylocityChallenge\Repository\DatabaseEntities.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ChallengerGray];
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

-- Creating table 'Employees'
CREATE TABLE [dbo].[Employees] (
    [EmployeeId] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [Paycheck_Id] int  NOT NULL
);
GO

-- Creating table 'Dependents'
CREATE TABLE [dbo].[Dependents] (
    [DependentId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [BenefitCost] nvarchar(max)  NOT NULL,
    [EmployeeEmployeeId] int  NOT NULL
);
GO

-- Creating table 'Paychecks'
CREATE TABLE [dbo].[Paychecks] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [amount] nvarchar(max)  NOT NULL,
    [total] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [EmployeeId] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [PK_Employees]
    PRIMARY KEY CLUSTERED ([EmployeeId] ASC);
GO

-- Creating primary key on [DependentId] in table 'Dependents'
ALTER TABLE [dbo].[Dependents]
ADD CONSTRAINT [PK_Dependents]
    PRIMARY KEY CLUSTERED ([DependentId] ASC);
GO

-- Creating primary key on [Id] in table 'Paychecks'
ALTER TABLE [dbo].[Paychecks]
ADD CONSTRAINT [PK_Paychecks]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [EmployeeEmployeeId] in table 'Dependents'
ALTER TABLE [dbo].[Dependents]
ADD CONSTRAINT [FK_EmployeeDependent]
    FOREIGN KEY ([EmployeeEmployeeId])
    REFERENCES [dbo].[Employees]
        ([EmployeeId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeeDependent'
CREATE INDEX [IX_FK_EmployeeDependent]
ON [dbo].[Dependents]
    ([EmployeeEmployeeId]);
GO

-- Creating foreign key on [Paycheck_Id] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [FK_PaycheckEmployee]
    FOREIGN KEY ([Paycheck_Id])
    REFERENCES [dbo].[Paychecks]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PaycheckEmployee'
CREATE INDEX [IX_FK_PaycheckEmployee]
ON [dbo].[Employees]
    ([Paycheck_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------