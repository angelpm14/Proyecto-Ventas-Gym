CREATE DATABASE GYMMEGAMUSCULO_VENTAS;
USE GYMMEGAMUSCULO_VENTAS;


CREATE TABLE PRODUCTO(
	ID_PROD int PRIMARY KEY identity, 
	ID_CATE int,
	COD_PROD varchar(50),
	NOMB_PROD varchar(80), 
	PREC_PROD decimal (9,2), 
	STOCK_PROD int, 
	DESCRI_PROD varchar(150), 
	IMAG_PROD varchar(20),
	ESTAD_PROD bit default(1),
)
go
--DROP TABLE PRODUCTO

create tabLE CATEGORIA (
	ID_CATE integer primary key identity,
	NOM_CATE varchar(30) not null,
	DESCR_CATE varchar(100) null,
	ESTAD_CATE bit default(1)
)
go
--DROP TABLE CATEGORIA

CREATE TABLE CLIENTES(
    ID_CLIENTES INT PRIMARY KEY Identity,
    NOMB_CLIENTE VARCHAR(25),
    APE_CLIENTE VARCHAR(25),
    CORRE_CLIENTE VARCHAR(50),
    CELUL_CLIENTE VARCHAR(9)NOT NULL,
	DIRECC_CLIENTE VARCHAR(35),
	FOTO_CLIENTE VARCHAR(20),
	ESTAD_CLIENTE bit default(1)
)
go
--DROP TABLE CLIENTES

CREATE TABLE VENTAS(
    ID_VENTAS INT Identity,
    ID_CLIENTES int,
    ID_USUARIO int,
    TIPCOMPRB_VENTA varchar(20),
    SERIECOMPRB_VENTA varchar(7),
    NUMBCOMPRB_VENTA varchar(10),
    FECHA_VENTA DATEtime,
	IMPUEST_VENTA decimal (4,2) not null,
    TOTAL_VENTA decimal(9,2),
	ESTADO_VENT VARCHAR(20)
    PRIMARY KEY(ID_VENTAS),
    FOREIGN KEY(ID_CLIENTES) REFERENCES CLIENTES(ID_CLIENTES),
    FOREIGN KEY(ID_USUARIO) REFERENCES USUARIO(ID_USUARIO)
)
go
--DROP TABLE VENTAS


CREATE TABLE DETALL_VENTAS(
    ID_DETALLVENT INT Identity PRIMARY KEY,
    ID_VENTAS int,
    ID_PROD INT,
    CANT_DETALLVENT INT,
    PREC_DETALLVENT decimal(9,2),
    DESCUE_DETALLVENT decImal(9,2),
    FOREIGN KEY(ID_VENTAS) 
    REFERENCES VENTAS(ID_VENTAS),
    FOREIGN KEY(ID_PROD)
    REFERENCES PRODUCTO(ID_PROD)
)
go
--DROP TABLE DETALL_VENTAS

create table USUARIO(
	ID_USUARIO integer primary key identity,
	ID_ROL integer not null,
	NOMB_USU varchar(25) not null,
	USUARIO varchar(10)not null,
	TIPDOC_USU varchar(20) null,
	NUMDOC_USU varchar(12) null,
	DIREC_USU varchar(70) null,
	CEL_USU char(9) null,
	EMAIL varchar(50) not null,
	CONTRA varchar(10) not null,
	ESTADO bit default(1),
	FOREIGN KEY (ID_ROL) REFERENCES ROL (ID_ROL)
)
go
--DROP TABLE USUARIO

create table ROL (
	ID_ROL integer primary key identity,
	NOMB_ROL varchar(30) not null,
	DESCRIP_ROL varchar(100) null,
	ESTADO_ROL bit default(1)
)
go
--DROP TABLE ROL


create TYPE type_DETALLVENT as table
(
	ID_PROD int,	
	COD_PROD varchar(50),
	NOMB_PROD varchar(80),
	STOCK_PROD int,
	CANT_DETALLVENT int,
	PREC_DETALLVENT decimal(9,2),
	DESCUE_DETALLVENT decimal(9,2)
);
go


--DROP TYPE type_DETALLVENT

create table ingreso(
	idingreso integer primary key identity,
	idproveedor integer not null,
	ID_USUARIO integer not null,
	tipo_comprobante varchar(20) not null,
	serie_comprobante varchar(7) null,
	num_comprobante varchar (10) not null,
	fecha datetime not null,
	impuesto decimal (4,2) not null,
	total decimal (11,2) not null,
	estado varchar(20) not null,
	FOREIGN KEY (idproveedor) REFERENCES CLIENTES (ID_CLIENTE),
	FOREIGN KEY (ID_USUARIO) REFERENCES USUARIO (ID_USUARIO)
);
go

--Tabla detalle_ingreso
create table detalle_ingreso (
	iddetalle_ingreso integer primary key identity,
	idingreso integer not null,
	idarticulo integer not null,
	cantidad integer not null,
	precio decimal(9,2) not null,
	FOREIGN KEY (idingreso) REFERENCES ingreso (idingreso) ON DELETE CASCADE,
	FOREIGN KEY (idarticulo) REFERENCES articulo (idarticulo)
);
go



--////////////////////////////////////////////
--////////////////////LISTAR//////////////////
--////////////////////////////////////////////
create proc sp_listaProductos
as 
select * from PRODUCTO
go

----------------------------------------------------------------------------------------
--Listar Categorias
create proc sp_listacategoria as
select*from categoria
go

----------------------------------------------------------------------------------------
CREATE PROC sp_listaClientes
as
select*from CLIENTES
go

----------------------------------------------------------------------------------------
create proc sp_listaUsuario
as
select u.ID_USUARIO as ID,u.ID_ROL, r.NOMB_ROL as ROL,u.NOMB_USU as NOMBRE,u.USUARIO as USUARIO,
u.TIPDOC_USU as TIPO_DOCUMENTO,u.NUMDOC_USU as NUMERO_DE_DOCUMENTO,
u.DIREC_USU as DIRECCION,u.CEL_USU as CELULAR,u.EMAIL as EMAIL,u.CONTRA as CONTRASEÑA,
u.estado as ESTADO
from USUARIO U inner join ROL R on u.ID_ROL=r.ID_ROL
order by u.ID_USUARIO desc
go

--select * from usuario

--DROP PROC sp_listaUsuario
----------------------------------------------------------------------------------------
CREATE PROC sp_listaRol
as
select*from ROL
go
----------------------------------------------------------------------------------------

create proc sp_listaVenta
as
select v.ID_VENTAS as ID,v.ID_USUARIO,u.NOMB_USU as USUARIO,p.NOMB_CLIENTE  as CLIENTE,
v.TIPCOMPRB_VENTA as TIPO_COMPROBANTE,v.SERIECOMPRB_VENTA as SERIE,
v.NUMBCOMPRB_VENTA as NUMERO_COMPROB,v.FECHA_VENTA as FECHA,v.IMPUEST_VENTA as IMPUESTOS, v.TOTAL_VENTA as TOTAL
from VENTAS v inner join USUARIO u on v.ID_USUARIO=u.ID_USUARIO
inner join CLIENTES p on v.ID_CLIENTES=p.ID_CLIENTES
Order by v.ID_VENTAS desc
go

--DROP PROC sp_listaVenta

--////////////////////////////////////////////
--///////////////INSERTAR////////////////////////
--////////////////////////////////////////////

--------------------------------------------------------------------
create proc sp_insertaProductos 
@ID_CATE int,
@COD_PROD varchar(50),
@NOMB_PROD varchar(80), 
@PREC_PROD decimal (9,2), 
@STOCK_PROD int, 
@DESCRI_PROD varchar(150), 
@IMAG_PROD varchar(20)
as 
insert into PRODUCTO(ID_CATE,COD_PROD,NOMB_PROD,PREC_PROD,STOCK_PROD,DESCRI_PROD,IMAG_PROD) 
values (@ID_CATE,@COD_PROD,@NOMB_PROD,@PREC_PROD,@STOCK_PROD,@DESCRI_PROD,@IMAG_PROD)
go
--exec sp_insertaProductos 1,'13131312','MAGNESIO',130.5, 500,'complemento vitamínico que puede aportar muchos beneficios a tu entrenamiento, ayudan a disminuir el cansancio y la fatiga.',''

--select*from PRODUCTO
--drop table PRODUCTO
--drop proc sp_insertaProductos
--------------------------------------------------------------------
create proc sp_insertarcategoria(@NOM_CATE varchar(30),@DESCR_CATE varchar(100))
as
insert into categoria(NOM_CATE, DESCR_CATE) values(@NOM_CATE,@DESCR_CATE)
go
--exec sp_insertarcategoria 'SUPLEMENTOS','Creatina ,Colageno ,Vitamina C ,Glutamina ,etc.'
--exec sp_insertarcategoria 'ROPAS DEPORTIVAS','Shorts blanco ,Polos de tirantes ,Sosten Deportivo  ,etc.'
--exec sp_insertarcategoria 'EQUIPOS Y ACCESORIOS','Mancuerdas ,Barras ,Fajas ,etc.'
--select*from categoria
--------------------------------------------------------------------
--Insertar Roles
create proc sp_insertarroles
@NOMB_ROL varchar(30),
@DESCRIP_ROL varchar(100)
as
insert into rol(NOMB_ROL, DESCRIP_ROL) values(@NOMB_ROL,@DESCRIP_ROL)
go

--exec sp_insertarroles 'Administrador','toma de decisiones estratégicas, la gestión de personal, la planificación financiera, y la implementación de políticas y procedimientos.'
--exec sp_insertarroles 'Almacenero','recibir, clasificar, almacenar y dispensar mercancías de manera eficiente.'
--exec sp_insertarroles 'Vendedor','comprender las necesidades del cliente, ofrecer productos o servicios que satisfagan esas necesidades y construir relaciones positivas.'

--select*from ROL
------------------------------------------------------------------

create proc sp_insertaCliente
@NOMB_CLIENTE varchar(25),
@APE_CLIENTE varchar(25),
@CORRE_CLIENTE varchar(50),
@CELUL_CLIENTE VARCHAR(9),
@DIRECC_CLIENTE VARCHAR(35),
@FOTO_CLIENTE VARCHAR(20)
AS
insert into CLIENTES(NOMB_CLIENTE,APE_CLIENTE,CORRE_CLIENTE,CELUL_CLIENTE,DIRECC_CLIENTE,FOTO_CLIENTE) 
values (@NOMB_CLIENTE,@APE_CLIENTE,@CORRE_CLIENTE,@CELUL_CLIENTE,@DIRECC_CLIENTE,@FOTO_CLIENTE)
go

--exec sp_insertaCliente 'Gerardo','Palomino','gerardopalomino@gmail.com', '987554821','av.san felipe',''
--exec sp_insertaCliente 'Fiorela','Velazques','fiorelavelazques@gmail.com', '854751245','av.palacios',''
--exec sp_insertaCliente 'Hugo','Lopez','hugolopez@gmail.com', '932541245','av.independencia',''

--drop proc sp_insertaCliente
--drop table CLIENTES
--select*from CLIENTES

------------------------------------------------------------------------------------------

create proc sp_insertaUsuario
@ID_ROL integer,
@NOMB_USU varchar(25),
@USUARIO varchar(10),
@TIPDOC_USU varchar(20),
@NUMDOC_USU varchar(20),
@DIREC_USU varchar(70),
@CEL_USU varchar(20),
@EMAIL varchar(50),
@CONTRA varchar(10)
as
insert into usuario (ID_ROL,NOMB_USU,USUARIO,TIPDOC_USU,NUMDOC_USU,DIREC_USU,CEL_USU,EMAIL,CONTRA)
values (@ID_ROL,@NOMB_USU,@USUARIO,@TIPDOC_USU,@NUMDOC_USU,@DIREC_USU,@CEL_USU,@EMAIL,@CONTRA)
go



--exec sp_insertaUsuario 1,'Pepe Perez','pepe','DNI','784578412','Av.Alfredo Mediola','965874412','','123456'
--exec sp_insertaUsuario 2,'Jaime Oropeza','jaime','DNI','124578965','Av.Peru','987452114','','654321'
--exec sp_insertaUsuario 3,'Felipe Cañones','felipe','DNI','874563214','Av.Independencia','932121478','','159357'
--exec sp_listaUsuario
--DROP proc sp_insertaUsuario

create proc sp_insertarVenta
@ID_USUARIO int,
@ID_CLIENTES int,
@TIPCOMPRB_VENTA varchar(20),
@SERIECOMPRB_VENTA varchar(7),
@NUMBCOMPRB_VENTA varchar(10),
@FECHA_VENTA DATETIME,
@IMPUEST_VENTA decimal(4,2),
@TOTAL_VENTA decimal(9,2),
@ESTADO_VENT VARCHAR(20),
@DETALL type_DETALLVENT READONLY
as
begin
	insert into VENTAS(ID_USUARIO,ID_CLIENTES,TIPCOMPRB_VENTA,SERIECOMPRB_VENTA,
	NUMBCOMPRB_VENTA,FECHA_VENTA,IMPUEST_VENTA,TOTAL_VENTA,ESTADO_VENT)
	values (@ID_USUARIO,@ID_CLIENTES,@TIPCOMPRB_VENTA,@SERIECOMPRB_VENTA,
	@NUMBCOMPRB_VENTA,getdate(),@IMPUEST_VENTA,@TOTAL_VENTA,'Aceptado');
	
	insert DETALL_VENTAS(ID_VENTAS,ID_PROD,CANT_DETALLVENT,PREC_DETALLVENT,DESCUE_DETALLVENT)
	select @@IDENTITY,d.COD_PROD,d.CANT_DETALLVENT,d.PREC_DETALLVENT,d.DESCUE_DETALLVENT
	from @DETALL d;
end
go

--DROP PROC sp_insertarVenta

--////////////////////////////////////////////
--//////////////ACTUALIZAR//////////////////////
--////////////////////////////////////////////

create proc sp_ActualizaProducto
@ID_PROD int,
@ID_CATE int, 
@COD_PROD varchar(50),
@NOMB_PROD varchar(80), 
@PREC_PROD decimal (9,2), 
@STOCK_PROD int, 
@DESCRI_PROD varchar(150), 
@IMAG_PROD varchar(20)
as 
update PRODUCTO 
set ID_CATE=@ID_CATE,COD_PROD=@COD_PROD,NOMB_PROD=@NOMB_PROD,PREC_PROD=@PREC_PROD,
STOCK_PROD=@STOCK_PROD,DESCRI_PROD=@DESCRI_PROD,IMAG_PROD=@IMAG_PROD 
where ID_PROD=@ID_PROD
go

create proc sp_actualizarcategoria(@ID_CATE int,@NOM_CATE varchar(30),@DESCR_CATE varchar(100))
as
update CATEGORIA set NOM_CATE=@NOM_CATE, DESCR_CATE=@DESCR_CATE
where ID_CATE=@ID_CATE
go

create proc sp_actualizarrol(@ID_ROL int,@NOM_ROL varchar(30),@DESCRIP_ROL varchar(100))
as
update ROL set NOMB_ROL=@NOM_ROL, DESCRIP_ROL=@DESCRIP_ROL
where ID_ROL=@ID_ROL
go


create proc sp_actualizaCliente
@NOMB_CLIENTE VARCHAR(25),
@APE_CLIENTE VARCHAR(25),
@CORRE_CLIENTE VARCHAR(50),
@CELUL_CLIENTE VARCHAR(9),
@DIRECC_CLIENTE VARCHAR(35),
@FOTO_CLIENTE VARCHAR(20)
as
insert into CLIENTES(NOMB_CLIENTE,APE_CLIENTE,CORRE_CLIENTE,CELUL_CLIENTE,DIRECC_CLIENTE,FOTO_CLIENTE)
values(@NOMB_CLIENTE,@APE_CLIENTE,@CORRE_CLIENTE,@CELUL_CLIENTE,@DIRECC_CLIENTE,@FOTO_CLIENTE)
go

create proc sp_actualizaUsuario(
@ID_USUARIO int,
@ID_ROL int,
@NOMB_USU varchar(100),
@TIPDOC_USU varchar(20),
@NUMDOC_USU varchar(12),
@DIREC_USU varchar(70),
@CEL_USU char(9),
@EMAIL varchar(50),
@CONTRA varbinary(MAX)
)
as
if @CONTRA<>''
update USUARIO set ID_ROL=@ID_ROL,NOMB_USU=@NOMB_USU,TIPDOC_USU=@TIPDOC_USU,
NUMDOC_USU=@NUMDOC_USU,DIREC_USU=@DIREC_USU,CEL_USU=@CEL_USU,
EMAIL=@EMAIL,CONTRA=HASHBYTES('SHA2_256', @CONTRA)
where ID_USUARIO=@ID_USUARIO;
else
update usuario set ID_ROL=@ID_ROL,NOMB_USU=@NOMB_USU,TIPDOC_USU=@TIPDOC_USU,
NUMDOC_USU=@NUMDOC_USU,DIREC_USU=@DIREC_USU,CEL_USU=@CEL_USU,
EMAIL=@EMAIL
where ID_USUARIO=@ID_USUARIO;
go

--////////////////////////////////////////////
--///////////////BUSCAR///////////////////////
--////////////////////////////////////////////


--Buscar Categoria
create proc sp_BuscarCategoria(@variable varchar(60))
as
select ID_CATE as id, NOM_CATE as Nombre,DESCR_CATE 
from CATEGORIA 
where NOM_CATE like '%'+@variable+'%' --donde nombre sea la palabra  escrita en la variable " "
or --or= o
DESCR_CATE like '%'+@variable+'%' order by 1--donde descripcion sea la palabra  escrita en la variable, ademas de estar ordenado por id
go

--exec sp_BuscarCategoria 'be'

--select*from categoria where nombre= '%' + @variable+ '%' or descripcion= '%' + @variable + '%' 

--Buscar-----------------------------------------------------------------------------------
create proc sp_BuscaProducto (@valor varchar(50))
as 
select * from PRODUCTO
where ID_PROD like '%'+@valor+'%' or NOMB_PROD like '%'+@valor+'%'
order by NOMB_PROD asc
go


create proc sp_BuscarVenta
@valor varchar(50)
as 
select v.ID_VENTAS as ID,v.ID_USUARIO,u.NOMB_USU as USUARIO,c.NOMB_CLIENTE as CLIENTE,
v.TIPCOMPRB_VENTA as Tipo_Comprobante,v.SERIECOMPRB_VENTA as SERIE,
v.NUMBCOMPRB_VENTA as NUMERO_COMPROBANTE,v.FECHA_VENTA as FECHA,v.IMPUEST_VENTA as IMPUESTOS,
v.TOTAL_VENTA as Total,v.ESTADO_VENT as Estado
from VENTAS v inner join USUARIO u on v.ID_USUARIO=u.ID_USUARIO
inner join CLIENTES c on v.ID_CLIENTES=c.ID_CLIENTES
where v.NUMBCOMPRB_VENTA like '%' + @valor + '%' Or c.NOMB_CLIENTE like '%' + @valor + '%'
Order by v.FECHA_VENTA asc
go

--DROP PROC sp_BuscarVenta

create proc sp_BuscarUsuario
@valor varchar(50)
as
select u.ID_USUARIO as ID,u.ID_ROL, r.NOMB_ROL as Rol,u.NOMB_USU as Nombre,
u.TIPDOC_USU as Tipo_Documento,u.NUMDOC_USU as Num_Documento,
u.DIREC_USU as Direccion,u.CEL_USU as Telefono,u.email as Email,
u.estado as Estado
 from USUARIO u inner join ROL r on u.ID_ROL=r.ID_ROL
 where u.NOMB_USU like '%' +@valor + '%' Or u.email like '%' +@valor + '%'
 order by u.NOMB_USU asc
 go

create proc sp_BuscarCliente(@valor varchar(80))
as 
select * from CLIENTES
where NOMB_CLIENTE like '%'+@valor+'%' or APE_CLIENTE like '%'+@valor+'%' or ID_CLIENTES like '%'+@valor+'%'
order by NOMB_CLIENTE asc
go


create proc sp_ListarDetallVenta
@ID_VENTAS int
as
select d.ID_PROD as ID,a.COD_PROD as CODIGO, a.NOMB_PROD as PRODUCTO,
d.CANT_DETALLVENT as CANTIDAD,d.PREC_DETALLVENT as PRECIO,d.DESCUE_DETALLVENT as DESCUENTO,
((d.CANT_DETALLVENT*d.PREC_DETALLVENT)-d.DESCUE_DETALLVENT) as IMPORTE
from DETALL_VENTAS d inner join PRODUCTO a on d.ID_PROD=a.ID_PROD
where d.ID_VENTAS=@ID_VENTAS
go

CREATE TRIGGER Venta_ActualizarStockProduc
   ON DETALL_VENTAS
   FOR INSERT
   AS
   UPDATE a SET a.STOCK_PROD=a.STOCK_PROD-d.CANT_DETALLVENT
   FROM PRODUCTO AS a INNER JOIN
   INSERTED AS d ON d.ID_PROD=a.ID_PROD
go


create proc sp_BuscarCodigoVentaProducto
@valor varchar(50)
as
select ID_PROD,COD_PROD,NOMB_PROD,PREC_PROD,STOCK_PROD
from PRODUCTO
where ID_PROD=@valor and STOCK_PROD>0
go

create proc sp_BuscarProductoVenta
@valor varchar(50)
as
select a.ID_PROD as ID,a.ID_CATE,c.NOM_CATE as Categoria,
a.COD_PROD as Codigo,a.NOMB_PROD as Nombre,a.PREC_PROD as Precio_Venta,
a.STOCK_PROD as Stock,a.DESCRI_PROD as Descripcion,a.IMAG_PROD as Imagen,
a.ESTAD_PROD as Estado
from PRODUCTO a inner join CATEGORIA c on a.ID_CATE=c.ID_CATE
where (a.NOMB_PROD like '%' +@valor + '%' Or a.DESCRI_PROD like '%' +@valor + '%')
and a.STOCK_PROD>0
order by a.NOMB_PROD asc
go


--////////////////////////////////////////////
--///////////////ELIMINAR////////////////////
--////////////////////////////////////////////


--Eliminar Categorias
create proc sp_eliminarcategoria(@ID_CATE int)
as
delete from CATEGORIA where ID_CATE=@ID_CATE
go

--drop proc sp_eliminarcategoria
--------------------------------------------------------------------------------------------------------------------------------

--Eliminar Categorias
create proc sp_eliminarrol(@COD_ROL int)
as
delete from ROL where ID_ROL=@COD_ROL
go

--Eliminar------------------------------------------------------------------------------------- 
create proc sp_EliminarProducto @ID_PROD int 
as 
delete from PRODUCTO
where ID_PROD=@ID_PROD
go

create proc sp_ventaanular
@idventa int
as
update VENTAS set estado='Anulado'
where ID_VENTAS=@idventa
go

create proc sp_eliminaUsuario
@ID_USUARIO integer
as
delete from usuario
where ID_USUARIO=@ID_USUARIO
go

create proc sp_eliminaCliente
@ID_CLIENTES integer
as
delete from CLIENTES
where ID_CLIENTES=@ID_CLIENTES
go


create proc sp_ActivarProducto
@ID_PROD int
as
update PRODUCTO set ESTAD_PROD = 1
where ID_PROD=@ID_PROD
go

create proc sp_DesactivarProducto
@ID_PROD int
as
update PRODUCTO set ESTAD_PROD = 0
where ID_PROD=@ID_PROD
go


create proc sp_DesactivarUsuario
@ID_USUARIO integer
as
update USUARIO set ESTADO=0
where ID_USUARIO=@ID_USUARIO
go

--Procedimiento Activar
create proc sp_ActivarUsuario
@ID_USUARIO integer
as
update usuario set ESTADO=1
where ID_USUARIO=@ID_USUARIO
go

create proc sp_UsuarioExistente
@valor varchar(100),
@existente bit output
as
	if exists (select EMAIL from USUARIO where EMAIL = ltrim(rtrim(@valor)))
		begin
			set @existente=1
		end
	else
		begin
			set @existente=0
		end
	go


CREATE PROC sp_LoginUsuario
    @USUARIO VARCHAR(10),
    @CONTRA VARCHAR(10)
AS
BEGIN
    SELECT COUNT(*) FROM USUARIO
    WHERE USUARIO = @USUARIO AND CONTRA = @CONTRA
END

--drop proc sp_LoginUsuario