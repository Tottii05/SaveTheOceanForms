CREATE TABLE Rescue (
    ResCode VARCHAR(100) PRIMARY KEY,
    ResDate DATE,
    ResFamily VARCHAR(100),
    ResAfection INTEGER,
    ResLocation VARCHAR(100)
);

CREATE TABLE ExtraInfo (
    ExtraInfoID SERIAL PRIMARY KEY,
    Name VARCHAR(100),
    ResFamily VARCHAR(100),
    Specie VARCHAR(100),
    Weight DOUBLE PRECISION,
    ResCode VARCHAR(100) REFERENCES Rescue(ResCode)
);

