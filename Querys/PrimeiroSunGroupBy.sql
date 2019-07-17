Select 
		Nome,
		Materia,
		/*Sum é usado para somar linhas , juntamente com o Count, para poder contar o numero de linhas*/
		(SUM(Nota) / count (*)) as 'Media',
		 count (Nota)as 'Provas'
	from NotaAlunos2
	group by Nome, Materia
	order by Nome asc;
/*
insert into NotaAlunos2 (Nome, Materia,Nota)
	Values ('Anderson', 'Corel', 10)
*/

select * from NotaAlunos2;