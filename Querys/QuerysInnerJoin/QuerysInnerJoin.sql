/*
Trazer somente as marcas que Felipe cadastrou
Trazer somente as marcas que Giomar cadastrou
*/

select Nome as 'Marcas Cadastradas' from Marcas where usuInc = 1;
---------------------------------------------------------------------------------------
select nome as 'Marcas Cadastradas' from marcas where usuInc = 2;


/*
Trazer somente a quantidade de marcas que Felipe cadastrou do maior para menor
Trazer somente a quantidade de marcas que Giomar cadastrou do menor para maior
*/

select count (Nome) as 'Qnt Marcas Cadastradas'
from marcas where usuInc = 1
order by 1 desc;
---------------------------------------------------------------------------------------
select count (Nome) as 'Qnt Marcas Cadastradas'
from marcas where usuInc = 2
order by 1 asc;

/*
Trazer somente a quantidade de marcas que Felipe e Giomar cadastraram 
*/


select count (M.Nome) as 'Marcas Cadastradas',
       U.Usuario
from Marcas M inner join Usuarios U on M.UsuAlt = U.Id
group by  U.Usuario

/*
Trazer somente os carros que Felipe cadastrou
Trazer somente os carros que Giomar cadastrou
*/

select Modelo as 'Carros Cadastrados' 
from Carros
where UsuInc = 1
order by 1 desc;
---------------------------------------------------------------------------------------
select Modelo as 'Carros Cadastrados' 
from Carros
where UsuInc = 2
order by 1 asc;

/*
Trazer somente a quantidade de carros que Felipe cadastrou maior para menor
Trazer somente a quantidade de carros que Giomar cadastrou menor para maior
*/

select count (Modelo) as 'Qnt Carro Cadastrado'
from carros
where UsuInc = 1;
---------------------------------------------------------------------------------------
select count (Modelo) as 'Qnt Carro Cadastrado'
from carros
where UsuInc = 2;

/*
Trazer somente a quantidade de carros que Felipe e Giomar cadastraram 
*/

select count (C.Modelo) as 'Qtd Cadastrada',
       U.Usuario     
from Carros C inner join Usuarios U on C.UsuInc = U.Id
group by Usuario;

/*
Trazer somente os carros das marcas que Felipe cadastrou
Trazer somente os carros das marcas que Giomar cadastrou
*/

select C.Modelo,
       M.Nome as 'Marca',
       U.Usuario
from Marcas M
             inner join Carros C on C.Marca = M.Id
			 inner join Usuarios U on c.UsuInc = U.id
where u.id = 1;
---------------------------------------------------------------------------------------
select C.Modelo,
       M.Nome as 'Marca',
       U.Usuario
from Marcas M
             inner join Carros C on C.Marca = M.Id
			 inner join Usuarios U on c.UsuInc = U.id
where u.id = 2;

/*
Trazer somente a quantidade de carros das marcas que Felipe cadastrou maior para menor
Trazer somente a quantidade de carros das marcas que Giomar cadastrou menor para maior
*/
select 
      U.Usuario,
	  M.Nome as 'Marca',
      count (C.Modelo) as 'Carros Cadastrados'
   from Marcas M
             inner join Carros C on C.Marca = M.Id
			 inner join Usuarios U on c.UsuInc = U.id
where u.id = 1
group by U.Usuario, M.Nome
order by 2 desc;

---------------------------------------------------------------------------------------

select 
      U.Usuario,
	  M.Nome as 'Marca',
      count (C.Modelo) as 'Carros Cadastrados'
  from Marcas M
             inner join Carros C on C.Marca = M.Id
			 inner join Usuarios U on c.UsuInc = U.id
where u.id = 2
group by U.Usuario,  M.Nome
order by 2 asc;

/*
Trazer o valor total de vendas 2019 isolado
Trazer a quantidade total de vendas 2019 isolado
*/

select sum (valor * quantidade) as 'Valot Total Vendas' 
      ,year (datInc) as 'Ano'
	  from vendas
where year (datInc) = '2019'
group by year (datInc);

---------------------------------------------------------------------------------------

select sum (Quantidade) as 'Valot Total Quantidades'
      ,year (datInc) as 'Ano'
	  from vendas
where year (datInc) = '2019'
group by year (datInc);

/*
Trazer o valor total de vendas em cada ano e ordernar do maior para o menor
Trazer a quantidade de vendas em cada ano e ordernar do maior para o menor
*/

select sum (valor * quantidade) as 'Valot Total Vendas'
      ,year (datInc) as 'Ano'
	  from vendas
group by year (datInc)
order by 1 desc;

---------------------------------------------------------------------------------------

select sum (Quantidade) as 'Valot Total Quantidades'
      ,year (datInc) as 'Ano'
	  from vendas
group by year (datInc)
order by 1 desc;

/*
Trazer o mês de cada ano que retornou a maior quantidade de vendas
		- Tradução "Retornar agrupado por mês e ordernar do maior para menor"
*/

select Month (datInc) as 'Mes' 
	  ,sum (quantidade) as 'Valot Total Vendas'
	  ,year (datInc) as 'Ano'
	  from vendas
group by Month (datInc),year (datInc)
order by 2 desc;

/*
Trazer o valor total de vendas que Felipe realizou
Trazer o valor total de vendas que Giomar realizou
*/

select sum (v.valor * quantidade) as 'Total Vendas Felipe'
from vendas v inner join usuarios u on v.UsuAlt = u.Id
where u.id = 1;

---------------------------------------------------------------------------------------

select sum (v.valor * quantidade) as 'Total Vendas Giomar'
from vendas v inner join usuarios u on v.UsuAlt = u.Id
where u.id = 2;

/*
Trazer a quantidade total de vendas que Felipe realizou
Trazer a quantidade de vendas que Giomar realizou
*/

select sum (v.quantidade) as 'Total Quantidades Felipe'
from vendas v inner join usuarios u on v.UsuAlt = u.Id
where u.id = 1;

---------------------------------------------------------------------------------------

select sum (v.quantidade) as 'Total Quantidades Giomar'
from vendas v inner join usuarios u on v.UsuAlt = u.Id
where u.id = 2;

/*
Trazer a quantidade total de vendas que Felipe e Giomar realizaram ordenando do maior para menor
Trazer o valor de vendas que Felipe e Giomar realizaram ordenando do maior para menor
*/
select sum (v.quantidade) as 'Quantidade Total',
       u.Usuario
from vendas v inner join usuarios u on v.UsuAlt = u.Id
group by u.Usuario
order by 1 desc;

---------------------------------------------------------------------------------------

select sum (v.Valor * quantidade) as 'Vendas Total',
       u.Usuario
from vendas v inner join usuarios u on v.UsuAlt = u.Id
group by u.Usuario
order by 1 desc;

/*
Trazer  a marca mais vendida de todos os anos
		- Tradução "Retornar todas as marcas que foram vendidas mas ordernada da maior para menor"
Trazer o valor total da marca mais vendida de todos os anos	
*/

select m.Nome  as 'Marca'
      ,sum (v.quantidade) as 'Quantidade Mais Vendida'
from Vendas v 
inner join Carros C on c.id = v.Carro
inner join Marcas m on m.id = c.marca
group by m.nome
order by 2 desc;

---------------------------------------------------------------------------------------

select m.Nome as 'Marca'
      ,sum (v.Valor * v.quantidade ) as 'Val Total Marca Mais Vendida'
from Vendas v 
inner join Carros C on c.id = v.Carro
inner join Marcas m on c.marca = m.id  
group by m.nome
order by 2 desc;

/*
Trazer a quantidade do carro mais vendido de todos os anos
Trazer o valor do carro mais vendido de todos os anos
*/

select top 2
       c.Modelo as 'Quantidade Mais Vendido'
      ,sum (v.quantidade) as 'Valor Obtido'
from Vendas v 
inner join Carros C on c.id = v.Carro
inner join Marcas m on m.id = c.marca
group by c.modelo
order by 2 desc;

select 
       c.Modelo  as 'Carro Mais vendido'
      ,sum (v.quantidade*Valor) as 'Valor Obtido'
from Vendas v 
inner join Carros C on c.id = v.Carro
inner join Marcas m on m.id = c.marca
group by c.modelo
order by 2 desc;


/*
select * from usuarios;
select * from Marcas;
select * from Carros;
select * from vendas;
*/