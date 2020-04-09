CREATE TABLE [dbo].[Customer] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [LicencePlate] NVARCHAR (50) NULL,
    [Name]         NVARCHAR (50) NULL,
    [Phone]        NVARCHAR (50) NULL,
    [OfficeId]     INT           NULL,
    [Status]       NVARCHAR (50) NULL,
    [Date]         NVARCHAR (50) NULL,
    [Time]         NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Customer_Office] FOREIGN KEY ([OfficeId]) REFERENCES [dbo].[Office] ([Id])
);