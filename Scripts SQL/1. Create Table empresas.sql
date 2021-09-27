CREATE TABLE empresas (
	ID int IDENTITY(1,1) PRIMARY KEY,
	emp_tipo_doc VARCHAR(5) NOT NULL,
	emp_num_doc BIGINT NOT NULL,
	emp_razon_soc VARCHAR(100),
	emp_pri_nombre VARCHAR(50),
	emp_seg_nombre VARCHAR(50),
	emp_pri_apellido VARCHAR(50),
	emp_seg_apellido VARCHAR(50),
	emp_correo VARCHAR(100),
	emp_aut_cel INT,
	emp_aut_correo INT
)