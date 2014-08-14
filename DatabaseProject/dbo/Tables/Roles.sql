CREATE TABLE [dbo].[Roles] (
    [RoldeId]  INT            IDENTITY (1, 1) NOT NULL,
    [RoleName] NVARCHAR (MAX) NOT NULL,
    [v3Column] VARCHAR(50) NULL, 
    CONSTRAINT [PK_dbo.Roles] PRIMARY KEY CLUSTERED ([RoldeId] ASC)
);

