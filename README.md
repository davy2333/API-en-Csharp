# API
#crear la siguiente base de datos en sql server 

CREATE DATABASE empresa;

USE empresa;

CREATE TABLE empleados
(idEmpleado int primary key IDENTITY(1,1),
nombre varchar(100),
apellido varchar(100),
edad int,
direccion varchar, 
numero varchar(100),
email varchar(100))

#e ingresar estos o lagunos registros de prueba
INSERT INTO empleados (nombre, apellido, edad, direccion, numero, email)
VALUES
('Juan', 'Perez', 30, 'A', '12345678', 'juan.perez@example.com'),
('Maria', 'Gomez', 25, 'B', '87654321', 'maria.gomez@example.com'),
('Carlos', 'Rodriguez', 45, 'C', '31223344', 'carlos.r@example.com'),
('Miguel', 'Mendoza', 34, 'D', '11225444', 'miguel.r@example.com'),
('Steven', 'Rivera', 54, 'E', '02633344', 'steven.r@example.com');

#verificar que la cadena de conexion sea la correcta
