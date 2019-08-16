/*Select Mostra alocaçoes Mes*/

select 
	Ca.Carro, 
	--ca.Ano,
	count(Lo.Carro) as 'Total Locacoes',
	month(lo.DatAloc) as 'Mes Locacao'
from Locacao Lo inner join Carros Ca on lo.Carro = ca.Id
group by Ca.[Carro], month(lo.DatAloc)
order by 2 desc; 

---------------------

/*Select Mostra alocaçoes Ano*/

select 
	Ca.Carro, 
	--ca.Ano,
	count(Lo.Carro) as 'Total Locacoes',
	year (lo.DatAloc) as 'Ano Locacao'
from Locacao Lo inner join Carros Ca on lo.Carro = ca.Id
group by Ca.[Carro], year (lo.DatAloc)
order by 2 desc; 

----------------------

/*Select Mostra Alocacoes totais no ano*/

select 
	Ca.Carro, 
	ca.Ano,
	count(Lo.Carro) as 'N°Locacoes',
	year (lo.DatAloc) as 'Ano',
	lo.DatAloc as 'Data Locação'
from Locacao Lo inner join Carros Ca on lo.Carro = ca.Id
where lo.DatAloc between '2019/01/01' and '2019/12/01'
group by Ca.[Carro], lo.DatAloc, ca.ano
order by 1 ;
