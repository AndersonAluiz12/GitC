CREATE TABLE [dbo].[Locacao] (
    [Id]      INT        IDENTITY (1, 1) NOT NULL,
    [Usuario] NCHAR (10) NOT NULL,
    [Cliente] INT        NOT NULL,
    [Estoque] INT        NOT NULL,
    [Carro]   NCHAR (10) NOT NULL,
    [UsuInc]  INT        NOT NULL,
    [UsuAlt]  INT        NOT NULL,
    [DatAloc] DATE       NOT NULL,
    [DatDev]  DATE       NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Locacao_Estoque] FOREIGN KEY ([Estoque]) REFERENCES [dbo].[Estoque] ([Id]),
    CONSTRAINT [FK_Locacao_Clientes] FOREIGN KEY ([Cliente]) REFERENCES [dbo].[Clientes] ([Id])
);

