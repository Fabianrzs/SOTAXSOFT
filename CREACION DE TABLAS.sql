CREATE TABLE Personas (
    Identificacion VARCHAR (20) PRIMARY KEY NOT NULL,
    Rol VARCHAR (20),
    PrimerNombre VARCHAR (20),
    SegundoNombre VARCHAR (20),
    PrimerApellido VARCHAR (20),
    SegundoApellido VARCHAR (20),
    NumeroContacto VARCHAR (20)
);


CREATE TABLE Taxis (
    Placa VARCHAR (20) PRIMARY KEY NOT NULL,
    Modelo VARCHAR (20),
    Kilometraje VARCHAR (20),
    IdPropietario VARCHAR (20),
    IdConductor VARCHAR (20),
    CONSTRAINT fk_Persona_IdPropietario FOREIGN KEY (IdPropietario) REFERENCES Personas (Identificacion),
    CONSTRAINT fk_Persona_IdConductor FOREIGN KEY (IdConductor) REFERENCES Personas (Identificacion)
);


CREATE TABLE Detalles (
    CodigoDetalle VARCHAR (20) PRIMARY KEY NOT NULL,
    TipoDetalle VARCHAR (20),
    FechaDetalle DATETIME,
    ValorDetalle DECIMAL (20),
    Descripcion VARCHAR (100),
    Placa VARCHAR (20),
    CONSTRAINT fk_Detalles_Placa FOREIGN KEY (Placa) REFERENCES Taxis (Placa)
);


drop table Personas;