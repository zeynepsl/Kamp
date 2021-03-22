Select Products.ProductName as UrunAdi, 
sum([Order Details].unitprice * [Order Details].quantity) as KazanılanToplamMiktar
From ((products 
inner join [Order Details] on products.productId = [Order Details].ProductId)
inner join Orders on Orders.OrderId = [Order Details].OrderId)
Group by ProductName order by KazanılanToplamMiktar desc
