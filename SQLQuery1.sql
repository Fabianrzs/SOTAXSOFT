CREATE TABLE Personas (
    Identificacion VARCHAR(12)  PRIMARY KEY NOT NULL,
    Rol VARCHAR(12),
    PrimerNombre VARCHAR(20),
    SegundoNombre VARCHAR (20),
    PrimerApellido VARCHAR(20),
    SegundoApellido VARCHAR(20),
    NumeroContacto VARCHAR(10)
);

CREATE TABLE Taxis (
    Placa VARCHAR(15) PRIMARY KEY NOT NULL,
    Modelo VARCHAR(10),
    Kilometraje VARCHAR(20),
    IdPropietario VARCHAR(20),
    IdConductor VARCHAR(20),
    CONSTRAINT fk_Persona_IdPropietario FOREIGN KEY (IdPropietario) REFERENCES Personas (Identificacion),
    CONSTRAINT fk_Persona_IdConductor FOREIGN KEY (IdConductor) REFERENCES Personas (Identificacion)
);


CREATE TABLE Detalles (
    CodigoDetalle VARCHAR(10) PRIMARY KEY NOT NULL,
    TipoDetalle VARCHAR(10),
    FechaDetalle DATETIME,
    ValorDetalle DECIMAL,
    Descripcion VARCHAR(10),
    Placa VARCHAR(15),
    CONSTRAINT fk_Detalles_Placa FOREIGN KEY (Placa) REFERENCES Taxis (Placa)
);