select AL.NomeALuno, 
	   SUM(NT.Nota) / count(FR.Frequencia) as 'Média',
	   IIF((Sum(NT.Nota) / Count (NT.Nota) >=7), 'Passou','Reprovou') as 'Passaou por Média? ',
       IIF (((sum(convert(money,FR.Frequencia)) / convert(money, count(FR.Frequencia)*100))>75), 'Passou','Reprovou') as 'Passou por Frequecia?'
from Alunos AL
inner join Frequencia FR on AL.Id = FR.Aluno
inner join Notas NT on AL.Id = NT.Aluno
group by AL.NomeAluno
