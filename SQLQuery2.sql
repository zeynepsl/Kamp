--Select 
select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers 
--Select alians oldu ContactName, Adi olrak geldi
-- bana contactName ivs getir ama Adi, SiketAdi ismiyle getir
-- bu yazdıkların oracle da da çalışır == ANSI
select * from Customers where City='London'
-- tüm müşterieleri konlonlarıyla getir ama şehri london olanları
Select * from Products
-- ürünler tablosunu tüm koolonlarıyla getir, tüm ürünler gelecek
-- case insensitive küçük büyük harf duyarsızdır sql
Select * from Products where CategoryID=1 or CategoryID=3
-- bana 1veya 3 numaralı kategoriye ait ürünleri getir
-- e ticaret te kategorilere ayrıdığında ortaya çıkan kodsal sorgu budur
Select * from Products where CategoryID=1 and UnitPrice>=10
--sen e ticaret sitesinde fiyatları azalan sırada göster vs gibii filtrelemeler
select * from Products order by CategoryID, ProductName 
--Urunlee tablosundaki tüm sütunları getir ama categoryId yi küçükten büyüğe sırala onun içinde productNameleri de sırala
select * from Products order by UnitPrice asc
-- unitPrice ı küçükten büyüğe sırala ama ascending ama zaten default değeri asc
select * from Products order by UnitPrice desc
-- büyükten küçüğe, düşen

select * from Products where CategoryID=1 order by UnitPrice desc
-- kategoriId si 1 olanları filtrele UnitPrice ı azalan sırada

select COUNT(*) from Products
-- product tablosundaki tüm satırları say tek bir kolon tek bir sstır gelir çünkü sen sayıyı istiyorsun
--select COUNT(*), ProductName from Products hatalı kullanım , sen hem tek kolan istiyorsun count la yanında başka kolonlar getiremezsin
select COUNT(*) Adet from Products where CategoryID=2
-- categorId si 2 olanları Adet başlığı ile göster

--tek bir ürün olsa bile çalışmaz çünkü o arkaplanda dizi mantiıği ile çaılşır


--- hangi kategoride kaç farklı ürününümüz var dedi yönetim, 1 kolan ve 1 sayı istiyorum
-- count * al ama categoryId ye göre grupla
-- select * from Products group by CategoryID  bu hatalı
 -- bana data mı kategoryId ye göre grupla
-- group by kullandığın zaman selectettiğin kolan group by da yazadığın alan olabilir
-- veya kimülatif datalar olabilir   
-- datamı group by ifadesinin iinde belirtilene göre verdim
-- group by yaptığında arka oplanda bir tablo oluşturuluyormuş gibi düşünebilirsin 
select categoryId, COUNT(*) from Products group by CategoryID
-- her bir ketegoriiçin grub oluşturuyor
-- count her kategori için ayrı ayrı hesaplanır

select categoryId, COUNT(*) from Products group by CategoryID having count(*)<10
-- having group by a konu alan kimülatif sorguya yazılır
-- having kimülatiflere uygulanır * count vs.....
-- 10 dan küçük ürün barındıran kategorId lerş lşstele

select categoryId, COUNT(*) from Products where UnitPrice>20 
group by CategoryID having count(*)<10
-- önce her zaman where çalışır birimfiyatuı 20 den fazal üolan ürünleri kategoryId ye göre grupla 
--her bir gruptaki 10dan az olnalalrı göster

--vt tasarımında kendimizi tekrar etmemmemiz için tabloları iliişkilendirmeliyiz
--bir sistemde biz bunları bir araya getiririz
-- kategoryId si yerine kategori ismini getirmek gerek

-- tabloları bir araaya getirizi == join


-- sadece ürünleri değil ürün ve kategori birleşimini getirmek istiyorum
select *
from Products inner join Categories on Products.CategoryID=Categories.CategoryID
-- koşul == on 
-- * dediğim için ürünle rilgili her şeyi getirdi

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories 
on Products.CategoryID=Categories.CategoryID
-- Products.ProductID
--hangi_tablodan.hangi_kolonu istiyorsun
-- prodyct tablosundan 3 kolonu CAtegıri tablosundan 1 kolonu getir
-- ben bunları foreach ile kullanıcıya listelicem göstericem
-- görsel ürünlerler vs angular ile

--DTO Data Transformation Object
-- joinler yapıyoruz bu joinler ==DTO

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories 
on Products.CategoryID=Categories.CategoryID
where Products.UnitPrice>10 

-- fiyatı 10 dan büyük olan ürünler için
-- onu CAtegory ler ile join et ve kategory ismiyle bana geitr bana getir
-- inner join == 2 tabloda sadece eşleşenleri getirir eşleşmeyen data varsa onu getirmez

-- joinlerde her zaman * ile başala
-- boşlık olduğu için [] kullandık
-- join ederken 2 ortak kolonu bulmalısın
Select * from Products p inner join [Order Details] od
on p.ProductID=od.ProductID

Select * from Products p left join [Order Details] od
on p.ProductID=od.ProductID
-- solda olup sağda olmayanları da geitr
-- ürünler tablosunda var ama hiç satış yok
-- bütün ürün türlerinden satış yapmışım burada
-- çünkü ürünlerde olup sipariş detayında olmayan ürün yok

select * from Customers c inner join Orders o
on c.CustomerID=o.CustomerID

select * from Customers c left join Orders o
on c.CustomerID=o.CustomerID
where o.CustomerID is null
-- müşteride olup siparişlerde olmayanları da getir hem inner joinleri de getir hem left joinleri de
-- ilk siparişine özel %10 indirim sorgus bu işte :)))
-- siparişi olmayan ları getirecek
-- is null pk ye uygulanır , pk null olamayacağı için

select * from Customers c right join Orders o
on c.CustomerID=o.CustomerID
-- sadece joinler gelir

select * from Orders o right join Customers c
on c.CustomerID=o.CustomerID
-- işte şimdi uyara 

-- 2 den fazal tabloyu join etmek için
Select * from Products p inner join [Order Details] od
on p.ProductID=od.ProductID
inner join Orders o
on o.OrderID=od.OrderID

-- sql server != sql
-- sql veri sorgulama dilimiz
-- biz ansi standrtalarında sql öğrendik