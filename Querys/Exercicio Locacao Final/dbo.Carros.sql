CREATE TABLE [dbo].[Carros] (
    [Id]     INT          IDENTITY (1, 1) NOT NULL,
    [Carro]  VARCHAR (50) NOT NULL,
    [Ano]    INT          NOT NULL,
    [UsuInc] VARCHAR (50) NOT NULL,
    [UsuAlt] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

