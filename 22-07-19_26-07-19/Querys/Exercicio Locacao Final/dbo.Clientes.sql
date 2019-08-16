CREATE TABLE [dbo].[Clientes] (
    [Id]      INT          IDENTITY (1, 1) NOT NULL,
    [Usuario] INT          NOT NULL,
    [Cliente] VARCHAR (50) NOT NULL,
    [Idade]   INT          NOT NULL,
    [DatInc]  DATE         NOT NULL,
    [DatAlt]  DATE         NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Clientes_Usuarios] FOREIGN KEY ([Usuario]) REFERENCES [dbo].[Usuarios] ([Id])
);

