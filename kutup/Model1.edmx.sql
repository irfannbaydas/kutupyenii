
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/05/2024 11:51:21
-- Generated from EDMX file: C:\Users\irfan\Desktop\kutup\kutup\kutup\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [kutup];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[kullanicilar]', 'U') IS NOT NULL
    DROP TABLE [dbo].[kullanicilar];
GO
IF OBJECT_ID(N'[dbo].[perskutupveritabani]', 'U') IS NOT NULL
    DROP TABLE [dbo].[perskutupveritabani];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'perskutupveritabani'
CREATE TABLE [dbo].[perskutupveritabani] (
    [personel_id] int IDENTITY(1,1) NOT NULL,
    [personel_ad] nvarchar(50)  NULL,
    [personel_soyad] nvarchar(50)  NULL,
    [personel_tc] nvarchar(11)  NULL,
    [personel_tel] nvarchar(11)  NULL,
    [personel_mail] nvarchar(50)  NULL,
    [personel_kullaniciAd] nvarchar(50)  NULL,
    [personel_sfire] nvarchar(50)  NULL
);
GO

-- Creating table 'kullanicilar'
CREATE TABLE [dbo].[kullanicilar] (
    [kullanici_id] int IDENTITY(1,1) NOT NULL,
    [kullanici_ad] nvarchar(50)  NULL,
    [kullanici_soyad] nvarchar(50)  NULL,
    [kullanici_tc] nvarchar(11)  NULL,
    [kullanici_tel] nvarchar(11)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [personel_id] in table 'perskutupveritabani'
ALTER TABLE [dbo].[perskutupveritabani]
ADD CONSTRAINT [PK_perskutupveritabani]
    PRIMARY KEY CLUSTERED ([personel_id] ASC);
GO

-- Creating primary key on [kullanici_id] in table 'kullanicilar'
ALTER TABLE [dbo].[kullanicilar]
ADD CONSTRAINT [PK_kullanicilar]
    PRIMARY KEY CLUSTERED ([kullanici_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------