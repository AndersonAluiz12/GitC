CREATE TABLE [dbo].[Notas] (
    [Id]    INT IDENTITY (1, 1) NOT NULL,
    [Prova] INT NOT NULL,
    [Aluno] INT NOT NULL,
    [Turma] INT NOT NULL,
    [Nota]  INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Notas_Turmas] FOREIGN KEY ([Turma]) REFERENCES [dbo].[Turmas] ([Id]),
    CONSTRAINT [FK_Notas_Alunos] FOREIGN KEY ([Aluno]) REFERENCES [dbo].[Alunos] ([Id])
);

