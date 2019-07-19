CREATE TABLE [dbo].[Alunos] (
    [Id]        INT          IDENTITY (1, 1) NOT NULL,
    [NomeAluno] VARCHAR (50) NOT NULL,
    [NomeTurma] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Alunos] FOREIGN KEY ([NomeTurma]) REFERENCES [dbo].[Turmas] ([Id])
);

