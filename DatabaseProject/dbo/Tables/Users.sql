CREATE TABLE [dbo].[Users] (
    [UserId]         INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]      NVARCHAR (MAX) NOT NULL,
    [LastName]       NVARCHAR (MAX) NOT NULL,
    [MyRole_RoldeId] INT            NOT NULL,
    [SekharTest]     VARCHAR (50)   NULL,
    [ChintsTest] VARCHAR(50) NULL, 
    CONSTRAINT [PK_dbo.Users] PRIMARY KEY CLUSTERED ([UserId] ASC),
    CONSTRAINT [FK_dbo.Users_dbo.Roles_MyRole_RoldeId] FOREIGN KEY ([MyRole_RoldeId]) REFERENCES [dbo].[Roles] ([RoldeId]) ON DELETE CASCADE
);




GO
CREATE NONCLUSTERED INDEX [IX_MyRole_RoldeId]
    ON [dbo].[Users]([MyRole_RoldeId] ASC);

