select * from FoodTruck;

/*
insert into FoodTruck (TipoDog, TotalVenda, DataVenda)
values ('Dog Soya', '14', '11/03/2019');
*/

select TipoDog,
	    SUM(TotalVenda) as 'Media de Venda',
	    MONTH(DataVenda) as 'Mes Vendido'	
	from FoodTruck
group by TipoDog, TotalVenda, DataVenda
order by TotalVenda desc;