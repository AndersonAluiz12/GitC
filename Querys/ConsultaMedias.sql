/*select * from AulaCsharp;
select * from NotaAluno;*/

select temp.*, IIF (temp.Media >=7, 'AProvado','Reprovado') from
 (select
        Nome,
		Materia,
		((Nota1 + Nota2 + Nota3) / 3) as 'Media'
	from NotaAluno) temp

--Inserir Material para o Aluno
/*insert into NotaAluno 
(Nome, Material, Nota1, Nota2, Nota3)
values
('Alecir', 'Paint3d', 9 , 8 , 5 )*/