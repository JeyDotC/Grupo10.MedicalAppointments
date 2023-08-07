CREATE DATABASE db_medical_clinics;

use db_medical_clinics;

CREATE TABLE Doctors (
	id int not null primary key AUTO_INCREMENT,
    name varchar(100),
    specialty varchar(100)
);

CREATE TABLE Medical_appointments (
	id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
	name VARCHAR(100),
    lastname VARCHAR(100),
    identification VARCHAR(50),
    phone VARCHAR(50),
    date DATETIME,
    doctor_id INT,
    FOREIGN KEY (doctor_id) REFERENCES Doctors(id)
    ON DELETE CASCADE
);

SELECT * FROM Medical_appointments;

INSERT INTO Doctors (id, name, specialty)
VALUES
    (101, 'Dr. Gómez', 'Pediatría'),
    (102, 'Dra. Rodríguez', 'Medicina General'),
    (103, 'Dr. Smith', 'Cardiología');

INSERT INTO Medical_appointments (id, name, lastname, identification, phone, date, doctor_id)
VALUES
    (1, 'Juan', 'Pérez', '12345', '555-1234', '2023-08-05 10:00:00'    , 101),
    (2, 'María', 'López', '67890', '555-9876', '2023-08-06 15:30:00'   , 102),
    (3, 'Carlos', 'Ramírez', '54321', '555-5555', '2023-08-07 11:45:00', 101),
    (4, 'Ana', 'Torres', '98765', '555-2222', '2023-08-08 14:00:00'    , 103),
    (5, 'Luis', 'Mendoza', '13579', '555-8888', '2023-08-09 12:30:00'  , 102),
    (6, 'Laura', 'García', '24680', '555-3333', '2023-08-10 09:15:00'  , 103);

