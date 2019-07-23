select Materia from diario;

select 
		Nome,
		Materia,
		((Nota1+Nota2+Nota3+Nota4+Nota5+Nota6+Nota7)/7) as 'Media',
		IIF (((Nota1+Nota2+Nota3+Nota4+Nota5+Nota6+Nota7)/7) >=5, 'Aprovado', 'Reprovado')
		as 'Status'
		from Diario
		

/*
Insert into Diario (Nome, Materia, Nota1, Nota2, Nota3, Nota4, Nota5, Nota6, Nota7)
Values ('Alecir', 'Corel', 6, 7, 8, 9, 4, 9, 8)
*/