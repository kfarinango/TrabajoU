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