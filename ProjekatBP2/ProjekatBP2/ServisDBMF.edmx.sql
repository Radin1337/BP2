
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/29/2021 18:50:39
-- Generated from EDMX file: C:\Users\Radin\Desktop\ProjekatBP\BP2\ProjekatBP2\ProjekatBP2\ServisDBMF.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ServisDBMF];
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

-- Creating table 'Servis'
CREATE TABLE [dbo].[Servis] (
    [IDS] int IDENTITY(1,1) NOT NULL,
    [NazivS] nvarchar(max)  NOT NULL,
    [Telefon] nvarchar(max)  NOT NULL,
    [Adresa] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Servisers'
CREATE TABLE [dbo].[Servisers] (
    [JMBG] int IDENTITY(1,1) NOT NULL,
    [Ime] nvarchar(max)  NOT NULL,
    [Prezime] nvarchar(max)  NOT NULL,
    [TipServ] nvarchar(max)  NOT NULL,
    [ServisIDS] int  NULL
);
GO

-- Creating table 'Automobils'
CREATE TABLE [dbo].[Automobils] (
    [SASIJA] int IDENTITY(1,1) NOT NULL,
    [Marka] nvarchar(max)  NOT NULL,
    [TipMot] nvarchar(max)  NOT NULL,
    [ServisIDS] int  NOT NULL,
    [BrSK] int  NOT NULL,
    [DatSK] datetime  NOT NULL
);
GO

-- Creating table 'Pregleds'
CREATE TABLE [dbo].[Pregleds] (
    [DatPre] datetime  NOT NULL,
    [Stanje] bit  NOT NULL,
    [AutomobilSASIJA] int  NOT NULL,
    [DijagnosticarJMBG] int  NOT NULL
);
GO

-- Creating table 'Deos'
CREATE TABLE [dbo].[Deos] (
    [DEOID] int IDENTITY(1,1) NOT NULL,
    [NazivD] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Pokvarens'
CREATE TABLE [dbo].[Pokvarens] (
    [PregledAutomobilSASIJA] int  NOT NULL,
    [PregledDijagnosticarJMBG] int  NOT NULL,
    [DeoDEOID] int  NOT NULL
);
GO

-- Creating table 'MajstorZas'
CREATE TABLE [dbo].[MajstorZas] (
    [MajstorJMBG] int  NOT NULL,
    [DeoDEOID] int  NOT NULL
);
GO

-- Creating table 'Popravljens'
CREATE TABLE [dbo].[Popravljens] (
    [PokvarenPregledAutomobilSASIJA] int  NOT NULL,
    [PokvarenPregledDijagnosticarJMBG] int  NOT NULL,
    [PokvarenDeoDEOID] int  NOT NULL,
    [MajstorZaDeoDEOID] int  NOT NULL,
    [MajstorZaMajstorJMBG] int  NOT NULL,
    [DatPop] datetime  NOT NULL
);
GO

-- Creating table 'Servisers_Dijagnosticar'
CREATE TABLE [dbo].[Servisers_Dijagnosticar] (
    [JMBG] int  NOT NULL
);
GO

-- Creating table 'Servisers_Majstor'
CREATE TABLE [dbo].[Servisers_Majstor] (
    [JMBG] int  NOT NULL
);
GO

-- Creating table 'Automobils_Sus'
CREATE TABLE [dbo].[Automobils_Sus] (
    [Gorivo] nvarchar(max)  NOT NULL,
    [SASIJA] int  NOT NULL
);
GO

-- Creating table 'Automobils_Elektricni'
CREATE TABLE [dbo].[Automobils_Elektricni] (
    [BrMot] int  NOT NULL,
    [SASIJA] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IDS] in table 'Servis'
ALTER TABLE [dbo].[Servis]
ADD CONSTRAINT [PK_Servis]
    PRIMARY KEY CLUSTERED ([IDS] ASC);
GO

-- Creating primary key on [JMBG] in table 'Servisers'
ALTER TABLE [dbo].[Servisers]
ADD CONSTRAINT [PK_Servisers]
    PRIMARY KEY CLUSTERED ([JMBG] ASC);
GO

-- Creating primary key on [SASIJA] in table 'Automobils'
ALTER TABLE [dbo].[Automobils]
ADD CONSTRAINT [PK_Automobils]
    PRIMARY KEY CLUSTERED ([SASIJA] ASC);
GO

-- Creating primary key on [AutomobilSASIJA], [DijagnosticarJMBG] in table 'Pregleds'
ALTER TABLE [dbo].[Pregleds]
ADD CONSTRAINT [PK_Pregleds]
    PRIMARY KEY CLUSTERED ([AutomobilSASIJA], [DijagnosticarJMBG] ASC);
GO

-- Creating primary key on [DEOID] in table 'Deos'
ALTER TABLE [dbo].[Deos]
ADD CONSTRAINT [PK_Deos]
    PRIMARY KEY CLUSTERED ([DEOID] ASC);
GO

-- Creating primary key on [PregledAutomobilSASIJA], [PregledDijagnosticarJMBG], [DeoDEOID] in table 'Pokvarens'
ALTER TABLE [dbo].[Pokvarens]
ADD CONSTRAINT [PK_Pokvarens]
    PRIMARY KEY CLUSTERED ([PregledAutomobilSASIJA], [PregledDijagnosticarJMBG], [DeoDEOID] ASC);
GO

-- Creating primary key on [DeoDEOID], [MajstorJMBG] in table 'MajstorZas'
ALTER TABLE [dbo].[MajstorZas]
ADD CONSTRAINT [PK_MajstorZas]
    PRIMARY KEY CLUSTERED ([DeoDEOID], [MajstorJMBG] ASC);
GO

-- Creating primary key on [PokvarenPregledAutomobilSASIJA], [PokvarenPregledDijagnosticarJMBG], [PokvarenDeoDEOID], [MajstorZaDeoDEOID], [MajstorZaMajstorJMBG] in table 'Popravljens'
ALTER TABLE [dbo].[Popravljens]
ADD CONSTRAINT [PK_Popravljens]
    PRIMARY KEY CLUSTERED ([PokvarenPregledAutomobilSASIJA], [PokvarenPregledDijagnosticarJMBG], [PokvarenDeoDEOID], [MajstorZaDeoDEOID], [MajstorZaMajstorJMBG] ASC);
GO

-- Creating primary key on [JMBG] in table 'Servisers_Dijagnosticar'
ALTER TABLE [dbo].[Servisers_Dijagnosticar]
ADD CONSTRAINT [PK_Servisers_Dijagnosticar]
    PRIMARY KEY CLUSTERED ([JMBG] ASC);
GO

-- Creating primary key on [JMBG] in table 'Servisers_Majstor'
ALTER TABLE [dbo].[Servisers_Majstor]
ADD CONSTRAINT [PK_Servisers_Majstor]
    PRIMARY KEY CLUSTERED ([JMBG] ASC);
GO

-- Creating primary key on [SASIJA] in table 'Automobils_Sus'
ALTER TABLE [dbo].[Automobils_Sus]
ADD CONSTRAINT [PK_Automobils_Sus]
    PRIMARY KEY CLUSTERED ([SASIJA] ASC);
GO

-- Creating primary key on [SASIJA] in table 'Automobils_Elektricni'
ALTER TABLE [dbo].[Automobils_Elektricni]
ADD CONSTRAINT [PK_Automobils_Elektricni]
    PRIMARY KEY CLUSTERED ([SASIJA] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ServisIDS] in table 'Servisers'
ALTER TABLE [dbo].[Servisers]
ADD CONSTRAINT [FK_ServisServiser]
    FOREIGN KEY ([ServisIDS])
    REFERENCES [dbo].[Servis]
        ([IDS])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ServisServiser'
CREATE INDEX [IX_FK_ServisServiser]
ON [dbo].[Servisers]
    ([ServisIDS]);
GO

-- Creating foreign key on [ServisIDS] in table 'Automobils'
ALTER TABLE [dbo].[Automobils]
ADD CONSTRAINT [FK_AutomobilServis]
    FOREIGN KEY ([ServisIDS])
    REFERENCES [dbo].[Servis]
        ([IDS])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AutomobilServis'
CREATE INDEX [IX_FK_AutomobilServis]
ON [dbo].[Automobils]
    ([ServisIDS]);
GO

-- Creating foreign key on [AutomobilSASIJA] in table 'Pregleds'
ALTER TABLE [dbo].[Pregleds]
ADD CONSTRAINT [FK_PregledAutomobil]
    FOREIGN KEY ([AutomobilSASIJA])
    REFERENCES [dbo].[Automobils]
        ([SASIJA])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [DijagnosticarJMBG] in table 'Pregleds'
ALTER TABLE [dbo].[Pregleds]
ADD CONSTRAINT [FK_PregledDijagnosticar]
    FOREIGN KEY ([DijagnosticarJMBG])
    REFERENCES [dbo].[Servisers_Dijagnosticar]
        ([JMBG])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PregledDijagnosticar'
CREATE INDEX [IX_FK_PregledDijagnosticar]
ON [dbo].[Pregleds]
    ([DijagnosticarJMBG]);
GO

-- Creating foreign key on [PregledAutomobilSASIJA], [PregledDijagnosticarJMBG] in table 'Pokvarens'
ALTER TABLE [dbo].[Pokvarens]
ADD CONSTRAINT [FK_PokvarenPregled]
    FOREIGN KEY ([PregledAutomobilSASIJA], [PregledDijagnosticarJMBG])
    REFERENCES [dbo].[Pregleds]
        ([AutomobilSASIJA], [DijagnosticarJMBG])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [DeoDEOID] in table 'Pokvarens'
ALTER TABLE [dbo].[Pokvarens]
ADD CONSTRAINT [FK_PokvarenDeo]
    FOREIGN KEY ([DeoDEOID])
    REFERENCES [dbo].[Deos]
        ([DEOID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PokvarenDeo'
CREATE INDEX [IX_FK_PokvarenDeo]
ON [dbo].[Pokvarens]
    ([DeoDEOID]);
GO

-- Creating foreign key on [MajstorJMBG] in table 'MajstorZas'
ALTER TABLE [dbo].[MajstorZas]
ADD CONSTRAINT [FK_MajstorZaMajstor]
    FOREIGN KEY ([MajstorJMBG])
    REFERENCES [dbo].[Servisers_Majstor]
        ([JMBG])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MajstorZaMajstor'
CREATE INDEX [IX_FK_MajstorZaMajstor]
ON [dbo].[MajstorZas]
    ([MajstorJMBG]);
GO

-- Creating foreign key on [DeoDEOID] in table 'MajstorZas'
ALTER TABLE [dbo].[MajstorZas]
ADD CONSTRAINT [FK_MajstorZaDeo]
    FOREIGN KEY ([DeoDEOID])
    REFERENCES [dbo].[Deos]
        ([DEOID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [PokvarenPregledAutomobilSASIJA], [PokvarenPregledDijagnosticarJMBG], [PokvarenDeoDEOID] in table 'Popravljens'
ALTER TABLE [dbo].[Popravljens]
ADD CONSTRAINT [FK_PopravljenPokvaren]
    FOREIGN KEY ([PokvarenPregledAutomobilSASIJA], [PokvarenPregledDijagnosticarJMBG], [PokvarenDeoDEOID])
    REFERENCES [dbo].[Pokvarens]
        ([PregledAutomobilSASIJA], [PregledDijagnosticarJMBG], [DeoDEOID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [MajstorZaDeoDEOID], [MajstorZaMajstorJMBG] in table 'Popravljens'
ALTER TABLE [dbo].[Popravljens]
ADD CONSTRAINT [FK_PopravljenMajstorZa]
    FOREIGN KEY ([MajstorZaDeoDEOID], [MajstorZaMajstorJMBG])
    REFERENCES [dbo].[MajstorZas]
        ([DeoDEOID], [MajstorJMBG])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PopravljenMajstorZa'
CREATE INDEX [IX_FK_PopravljenMajstorZa]
ON [dbo].[Popravljens]
    ([MajstorZaDeoDEOID], [MajstorZaMajstorJMBG]);
GO

-- Creating foreign key on [JMBG] in table 'Servisers_Dijagnosticar'
ALTER TABLE [dbo].[Servisers_Dijagnosticar]
ADD CONSTRAINT [FK_Dijagnosticar_inherits_Serviser]
    FOREIGN KEY ([JMBG])
    REFERENCES [dbo].[Servisers]
        ([JMBG])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [JMBG] in table 'Servisers_Majstor'
ALTER TABLE [dbo].[Servisers_Majstor]
ADD CONSTRAINT [FK_Majstor_inherits_Serviser]
    FOREIGN KEY ([JMBG])
    REFERENCES [dbo].[Servisers]
        ([JMBG])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [SASIJA] in table 'Automobils_Sus'
ALTER TABLE [dbo].[Automobils_Sus]
ADD CONSTRAINT [FK_Sus_inherits_Automobil]
    FOREIGN KEY ([SASIJA])
    REFERENCES [dbo].[Automobils]
        ([SASIJA])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [SASIJA] in table 'Automobils_Elektricni'
ALTER TABLE [dbo].[Automobils_Elektricni]
ADD CONSTRAINT [FK_Elektricni_inherits_Automobil]
    FOREIGN KEY ([SASIJA])
    REFERENCES [dbo].[Automobils]
        ([SASIJA])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------