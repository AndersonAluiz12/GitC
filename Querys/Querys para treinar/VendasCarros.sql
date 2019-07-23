select modelo,
       ano,
	   (SUM(Vendas) / Count(*)) as 'Media',
	    YEAR(dataVenda) as 'Ano'
	from Vendas
	where YEAR (DataVenda) = 2019
	group by modelo, ano, YEAR(DataVenda)) Temp



/*select 'Carros' as 'Carros',
	  SUM (Temp.Media) as 'Vendas',
	  Temp.AnoVenda
	from (select
				  Modelo,
				  Ano,
				  (SUM(vendas) / COUNT(*)) as 'Media',
				  YEAR(DataVenda) as 'AnoVenda'
		from Vendas
	group by Modelo, Ano, YEAR(DataVenda)) Temp
group by Temp.AnoVenda*/
