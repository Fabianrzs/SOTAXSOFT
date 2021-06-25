CREATE TABLE Personas (
    Identificacion VARCHAR PRIMARY KEY NOT NULL,
    Rol VARCHAR,
    PrimerNombre VARCHAR,
    SegundoNombre VARCHAR,
    PrimerApellido VARCHAR,
    SegundoApellido VARCHAR,
    NumeroContacto VARCHAR
);




CREATE TABLE Taxis (
    Placa VARCHAR PRIMARY KEY NOT NULL,
    Modelo VARCHAR,
    Kilometraje VARCHAR,
    IdPropietario VARCHAR,
    IdConductor VARCHAR,
    CONSTRAINT fk_Persona_IdPropietario FOREIGN KEY (IdPropietario) REFERENCES Personas (Identificacion),
    CONSTRAINT fk_Persona_IdConductor FOREIGN KEY (IdConductor) REFERENCES Personas (Identificacion)
);


CREATE TABLE Detalles (
    CodigoDetalle VARCHAR PRIMARY KEY NOT NULL,
    TipoDetalle VARCHAR,
    FechaDetalle DATETIME,
    ValorDetalle DECIMAL,
    Descripcion VARCHAR,
    Placa VARCHAR,
    CONSTRAINT fk_Detalles_Placa FOREIGN KEY (Placa) REFERENCES Taxis (Placa)
);