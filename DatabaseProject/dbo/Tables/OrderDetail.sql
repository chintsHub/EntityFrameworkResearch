CREATE TABLE [dbo].[OrderDetail] (
    [OrderDetailId] INT NOT NULL,
    [ProductId]     INT NULL,
    [SomeOtherColumn] VARCHAR(50) NULL, 
    CONSTRAINT [PK_OrderDetail] PRIMARY KEY CLUSTERED ([OrderDetailId] ASC)
);

