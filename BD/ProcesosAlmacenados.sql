--Crear Proveedor (Proceso almacenado)
create procedure CrearProveedor
@CompanyName nvarchar(40),
@ContactName nvarchar(30),
@ContactTitle nvarchar(30),
@Address nvarchar(60)
as
insert into Suppliers (CompanyName,ContactName,ContactTitle,Address)
values (@CompanyName,@ContactName,@ContactTitle,@Address) 

CrearProveedor '2','1','1','1'

--Eliminar Proveedor (Proceso almacenado)
create procedure EliminarProveedor
@SupplierID int 
as 
delete from Products where SupplierID = @SupplierID
delete from Suppliers where SupplierID = @SupplierID

EliminarProveedor '32'

create procedure ActualizarProveedor
@SupplierID int, 
@CompanyName nvarchar(40),
@ContactName nvarchar(30),
@ContactTitle nvarchar(30),
@Address nvarchar(60)
as 
Update Suppliers 
set CompanyName = @CompanyName , ContactName = @ContactName, ContactTitle = @ContactTitle, Address = @Address 
where SupplierID = @SupplierID

ActualizarProveedor '30','2','2','2','2'

-------------------------------------------------------------------------------------------
--Crear Cliente (Proceso almacenado)

create procedure CrearCliente
@CustomerID nchar(5),
@CompanyName nvarchar(40),
@ContactName nvarchar(30),
@ContactTitle nvarchar(30),
@Address nvarchar(60)
as
insert into Customers (CustomerID,CompanyName,ContactName,ContactTitle,Address)
values (@CustomerID,@CompanyName,@ContactName,@ContactTitle,@Address) 

CrearCleintes '2','1','1','1'

--Eliminar Cliente (Proceso almacenado)

create procedure EliminarCliente
@CustomerID nchar(5) 
as 
delete from Customers where CustomerID = @CustomerID
delete from Customers where CustomerID = @CustomerID

EliminarCliente '32'

--ActualizarCliente
create procedure ActualizarCliente
@CustomerID nchar(5), 
@CompanyName nvarchar(40),
@ContactName nvarchar(30),
@ContactTitle nvarchar(30),
@Address nvarchar(60)
as 
Update Customers 
set CompanyName = @CompanyName , ContactName = @ContactName, ContactTitle = @ContactTitle, Address = @Address 
where CustomerID = @CustomerID

ActualizarCliente '30','2','2','2','2'