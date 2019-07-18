select 
		Lv.Id,
		Lv.Nome,
		IIF(Lv.Alocado = 1 , 'Sim', 'Não') as 'Alocado',
		BL.Nome as 'Nome da Biblioteca'
	from Biblioteca1 BL
		inner join Livro1 LV on BL.Id= LV.Biblioteca;

select
		Bl.Nome,
		Count(Lv.Id) as 'QuantLivros',
		US.Nome as 'UserName'
	from Biblioteca1 BL
	inner join Livro1 LV on BL.ID = LV.Biblioteca
	inner join Usuario US on LV.UserInc = US.Id
	group by BL.nome, US.nome


select * from Livro1;

/*
delete from Biblioteca1;
*/