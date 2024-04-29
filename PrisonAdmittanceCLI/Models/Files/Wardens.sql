create TABLE Wardens (
    Warden_ID INT PRIMARY KEY,
    Warden_FirstName VARCHAR(25),
    Warden_LastName VARCHAR(25),
    Age INT,
    Gender VARCHAR(10),
    Race VARCHAR(10),
    FOREIGN KEY (Prison_ID) REFERENCES Prisons(Prison_ID)
);
INSERT INTO Wardens (
        Warden_ID,
        Warden_FirstName,
        Warden_LastName,
        Age,
        Gender,
        Race,
        Prison_ID
    )
VALUES (001, 'Kanye', 'West', 46, 'Male', 'Black', 001);