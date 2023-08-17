create table PERSONA(
IdPersona int primary key identity (1,1),
DocumentoIdentidad varchar (60),
Nombres varchar(60),
Apellidos varchar (60),
Telefono varchar (60),
Foto varbinary(max) NULL,
Activo bit default 1,
Fecharegistro datetime default getdate()
)

go 

select * from PERSONA



go


---procedimiento para crear

create procedure sp_CrearPersona(
@DocumentoIdentidad varchar (60),
@Nombres varchar (60),
@Apellidos varchar (60),
@Telefono varchar (60),
@Foto varbinary(max),
@Resultado bit output
)
as
begin
    set @Resultado = 1
    if not exists (select * from [dbo].[PERSONA] where DocumentoIdentidad = @DocumentoIdentidad)

        insert into [dbo].[PERSONA](DocumentoIdentidad,Nombres,Apellidos,Telefono,Foto) values (
        @DocumentoIdentidad,
        @Nombres,
        @Apellidos,
        @Telefono,
        @Foto
        )
    else
        set @Resultado = 0
end

go

-----modificar
create procedure sp_ModificarPersona(
@IdPersona int,
@DocumentoIdentidad varchar (60),
@Nombres varchar (60),
@Apellidos varchar (60),
@Telefono varchar (60),
@Foto varbinary(max),
@Resultado bit output
)
as
begin 
    set @Resultado = 1
    IF not exists (select * from [dbo].[PERSONA] where DocumentoIdentidad = @DocumentoIdentidad and IdPersona != @IdPersona)

        update [dbo].[PERSONA] set
        DocumentoIdentidad = @DocumentoIdentidad,
        Nombres = @Nombres,
        Apellidos = @Apellidos,
        Telefono = @Telefono,
        Foto = @Foto
        where IdPersona = @IdPersona

    else
        set @Resultado = 0
end

go


--------obtener
create procedure sp_ObtenerPersonas
as
begin
    select Idpersona,DocumentoIdentidad,Nombres,Apellidos,Telefono,Foto from [dbo].[PERSONA] where Activo = 1
end

select * from [dbo].[PERSONA]