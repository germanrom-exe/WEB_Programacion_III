Para cargar las bases de datos que se encuentran en el repo hay que previamente realizar estos pasos:


COMANDO PARA CREAR BASE DE DATOS

(borrar carpeta migration del proyecto si ya tiene algo)

Add-Migration "nombre_cualquiera_BD" (sin comillas)

Update-Database


Luego de crear la BD localizar su ubicacion (generalmente "C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA") y reemplazar los archivos TPMvcMateriasDB.mdf y TPMvcMateriasDB_log.ldf por los presentes en el repo.

Los archivos de la BD sin registro de users son para el tp-04 y los que tienen BD con registro de users son para tp-06 aunque se pueden usar los archivos de BD del tp-06 para el tp-04.