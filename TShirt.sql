
CREATE TABLE contactDetails (
    --id int IDENTITY(1,1)  primary key ,
    name varchar(50) not null,
    email varchar(50) not null,
    subject varchar(50) not null,
    message varchar(500) not null
);
select * from contactDetails
delete from contactDetails

CREATE TABLE registration (
   
    userid varchar(10) not null,
    email varchar(50) not null,
    password1 varchar(12) not null,
    password2 varchar(12) not null
);
select * from registration

--product types--
CREATE TABLE products (
    productid int identity(1001,1) primary key, 
    productname varchar(50)
);
insert into products values ('T-Shirt');
insert into products values ('Polo Shirt');
insert into products values ('Full Sleeve');

select * from products

--all products
use tshirt;
	CREATE TABLE productdetail (
   	id int identity(1,1) primary key, 
	catagory varchar(50) null,
	subcatagory varchar(50) null,
	productid int foreign key references products(productid) ,
    productname varchar(20) not null,
    productdetails varchar(500) not null,
    color varchar(100) not null,
    quantity int  not null,
	discount int null,
	price decimal not null,
	image varchar(200)
	);

	insert into productdetail values ('Men','Polo Shirt',1002,'Orange T-Shirt','Normal','black',12,15,500,'~/pictures/tShirtimage/t1.jpg')
	insert into productdetail values ('Men','Polo Shirt',1002,'Orange T-Shirt','Normal','black',20,15,700,'~/pictures/tShirtimage/t2.jpg')
	select * from productdetail


	use tshirt;
	create table cart(
	id varchar(20) not null,
	size varchar(50) not null,
	quantity int not null,
	price int  null

	);
	insert into cart (id,size ,quantity,price) values (( select id from productdetail where id=1),'XL',5,2500)
	
	select * from cart
	select sum(price) from cart
	drop table cart



	cart table
	cartid, id(fk) from productDetails(id), productname (fk) from productDetails(productname), quantity, price, color, size
	
	
	drop table productDetails
insert into productDetails(catagory,subcatagory, productid, productname,productdetails,color,quantity,discount,price,image)
 values ('MEN','Polo Shirt',(select productid from products where productname = 'T-Shirt'), 'T_SHIRT001','Comfortable to wear','Blue',100,15,350.00,'pictures/men.jpg');

 select * from productDetails

 select productid from productDetails where subcatagory = 'Polo Shirt'

 select products.productid from products inner join productDetails on  products.productid = productDetails.productid

 CREATE TABLE imagedemo (
    id int , 
    image varchar(50)
);
select * from imagedemo