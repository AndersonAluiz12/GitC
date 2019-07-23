CREATE TABLE [dbo].[Usuarios] (
    [Id]      INT          IDENTITY (1, 1) NOT NULL,
    [Usuario] VARCHAR (50) NOT NULL,
    [DatInc]  DATE         NOT NULL,
    [DatAlt]  DATE         NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

