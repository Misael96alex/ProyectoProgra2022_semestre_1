/*creamos la base de datos*/
CREATE SCHEMA `proyectoprogra` ;

/*cremos la tabla clinica*/
CREATE TABLE CLINICA (
id_clinica int,
nombre_clinica varchar(50),
direccion varchar(100),
correo varchar(100),
no_telelefono int,
nit int,
PRIMARY KEY (id_clinica),
INDEX (id_clinica)
);

/*se crea tabla usuario*/
CREATE TABLE USUARIO (
id_usuario int,
id_clinica int,
nombre_usuario varchar(50),
apellido_usuario varchar(50),
fecha_nac date,
dpi varchar (20),
nit int,
direccion varchar(100),
correo varchar(100),
no_telelefono int,
PRIMARY KEY (id_usuario),
INDEX (id_usuario),
FOREIGN KEY(id_clinica) REFERENCES CLINICA(id_clinica)
);

/*se crea la tabla empleados*/
CREATE TABLE EMPLEADOS (
id_empleados int,
id_clinica int,
nombre_empleado varchar(50),
apellido_empleado varchar(50),
dpi varchar (13),
nit int,
direccion varchar(150),
correo varchar(45),
no_telelefono int,
PRIMARY KEY (id_empleados),
INDEX (id_empleados),
FOREIGN KEY(id_clinica) REFERENCES CLINICA(id_clinica)
);

/*se crea la tabla paciente*/
CREATE TABLE PACIENTE (
id_paciente int,
nombre_paciente varchar(50),
apellido_paciente varchar(50),
familiar_responsable varchar(50),
fecha_nac date,
tipo_sangre varchar(50),
enferm_preexitente varchar(50),
dpi varchar (20),
nit int,
direccion varchar(150),
correo varchar(45),
no_telelefono int,
PRIMARY KEY (id_paciente),
INDEX (id_paciente)
);

/*se crea la tabla de registro de consultas*/
CREATE TABLE REGISTRO_CONSULTAS(
id_reg_consul int,
id_paciente int,
fecha_creacion date,
usuario_creador int,
PRIMARY KEY (id_reg_consul),
INDEX (id_reg_consul),
FOREIGN KEY(id_paciente) REFERENCES PACIENTE (id_paciente)
);


/*creo la tabla de medicamentos*/
CREATE TABLE MEDICAMENTOS (
id_medicamento int,
id_reg_consul int,
descripcion varchar(100),
precio decimal(10,2),
marca varchar(100),
cantidad decimal(10,2),
dosis varchar(100),
presentacion varchar(100),
PRIMARY KEY (id_medicamento),
INDEX (id_medicamento),
FOREIGN KEY (id_reg_consul) REFERENCES  REGISTRO_CONSULTAS(id_reg_consul)
);

/*se crea la tabla enfermedad*/
CREATE TABLE ENFERMEDAD (
id_enfermedad int,
id_reg_consul int,
nombre_enfermedad varchar(80),
tipo_enfermedad varchar(80),
nivel_contagio varchar(50),
PRIMARY KEY (id_enfermedad),
INDEX (id_enfermedad),
FOREIGN KEY (id_reg_consul) REFERENCES  REGISTRO_CONSULTAS(id_reg_consul)
);

/*crear tabla consulta*/
CREATE TABLE CONSULTA(
id_consulta int,
id_reg_consul int,
medico varchar(80),
diagnostico varchar(80),
medicamentos varchar(80),
estudios varchar(80),
PRIMARY KEY (id_consulta),
INDEX (id_consulta),
FOREIGN KEY (id_reg_consul) REFERENCES  REGISTRO_CONSULTAS(id_reg_consul)
);



/*crear tabla registro de citas*/
CREATE TABLE REGISTRO_CITAS(
id_reg_cita int,
id_paciente int,
id_clinica int,
usuario_creador int,
PRIMARY KEY (id_reg_cita),
INDEX (id_reg_cita),
FOREIGN KEY (id_paciente) REFERENCES  PACIENTE(id_paciente),
FOREIGN KEY (id_clinica) REFERENCES  CLINICA(id_clinica)
);

/*crear tabla cita*/
CREATE TABLE CITA(
id_cita int,
id_reg_cita int,
fecha datetime,
costo decimal(10,2),
no_consultorio int,
forma_pago varchar(80),
PRIMARY KEY (id_cita),
INDEX (id_cita),
FOREIGN KEY (id_reg_cita) REFERENCES  REGISTRO_CITAS(id_reg_cita)
);





