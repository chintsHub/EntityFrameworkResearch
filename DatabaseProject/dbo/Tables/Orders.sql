CREATE TABLE [dbo].[Orders] (
    [OrderId]             INT        IDENTITY (1, 1) NOT NULL,
    [Quantity]            INT        NOT NULL,
    [Amount]              FLOAT (53) NOT NULL,
    [Date]                DATETIME   NOT NULL,
    [Customer_CustomerId] INT        NOT NULL,
    [ExtraColumn] VARCHAR(50) NULL, 
    [JerryColumn] VARCHAR(50) NULL, 
    CONSTRAINT [PK_dbo.Orders] PRIMARY KEY CLUSTERED ([OrderId] ASC),
    CONSTRAINT [FK_dbo.Orders_dbo.Customers_Customer_CustomerId] FOREIGN KEY ([Customer_CustomerId]) REFERENCES [dbo].[Customers] ([CustomerId]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Customer_CustomerId]
    ON [dbo].[Orders]([Customer_CustomerId] ASC);

