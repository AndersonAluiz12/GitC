CREATE TABLE [dbo].[Estoque] (
    [Id]         INT IDENTITY (1, 1) NOT NULL,
    [Carro]      INT NOT NULL,
    [Disponivel] BIT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Estoque_Carro] FOREIGN KEY ([Carro]) REFERENCES [dbo].[Carros] ([Id])
);

