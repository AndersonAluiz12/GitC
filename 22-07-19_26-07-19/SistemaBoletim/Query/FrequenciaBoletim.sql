CREATE TABLE [dbo].[Frequencia] (
    [Id]         INT  IDENTITY (1, 1) NOT NULL,
    [Aluno]      INT  NOT NULL,
    [Data]       DATE NOT NULL,
    [Frequencia] BIT  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Frequencia_Frequencia] FOREIGN KEY ([Aluno]) REFERENCES [dbo].[Alunos] ([Id])
);

