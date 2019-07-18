CREATE TABLE [dbo].[Alunos] (
    [Id]      INT           IDENTITY (1, 1) NOT NULL,
    [Nome]    VARCHAR (100) NOT NULL,
    [Ativo]   BIT           NOT NULL,
    [UsuInc]  INT           NOT NULL,
    [UsuAlt]  INT           NOT NULL,
    [DateInc] DATETIME      NOT NULL,
    [DateAlt] DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Alunos_UsuarioInc] FOREIGN KEY ([UsuInc]) REFERENCES [dbo].[Usuario] ([Id]),
    CONSTRAINT [FK_Alunos_UsuarioAlt] FOREIGN KEY ([UsuAlt]) REFERENCES [dbo].[Usuario] ([Id])
);

