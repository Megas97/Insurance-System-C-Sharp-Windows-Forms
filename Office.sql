CREATE TABLE [dbo].[Office] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Username] NVARCHAR (50) NULL,
    [Password] NVARCHAR (50) NULL,
    [Name]     NVARCHAR (50) NULL,
    [Location] NVARCHAR (50) NULL,
    [Director] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);