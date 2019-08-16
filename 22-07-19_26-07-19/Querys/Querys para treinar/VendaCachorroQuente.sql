select * from FoodTruck
order by TipoDog;

/*
insert into FoodTruck (TipoDog, TotalVenda, DataVenda)
values ('Dog Soya', '14', '11/03/2019');
*/

select TipoDog,
	   Id,
	    (SUM(TotalVenda)/ count(*)) as 'Media de Venda',
	    MONTH(DataVenda) as 'Mes Vendido'	
	from FoodTruck
	where Id between 2 and 3
group by TipoDog, MONTH (DataVenda), Id
order by 'Media de Venda' desc;

/*
select TipoDog,
	    (SUM(TotalVenda)/ count(*)) as 'Media de Venda',
	    MONTH(DataVenda) as 'Mes Vendido'	
	from FoodTruck
	where MONTH (DataVenda) between 2 and 3
group by TipoDog, MONTH (DataVenda)
order by 'Media de Venda' desc;
*/