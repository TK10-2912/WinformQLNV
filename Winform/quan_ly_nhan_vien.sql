-- T?o b?ng Nh�n vi�n
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Address VARCHAR(255),
    PhoneNumber VARCHAR(15),
    Email VARCHAR(100)
);

-- T?o b?ng Ch�nh s�ch l??ng
CREATE TABLE SalaryPolicies (
    PolicyID INT PRIMARY KEY,
    BasicSalary DECIMAL(10, 2),
    Bonus DECIMAL(5, 2),
    PolicyDescription VARCHAR(255),
    EmployeeID INT,
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);

-- T?o b?ng Theo d�i c�ng t�c
CREATE TABLE WorkHistory (
    HistoryID INT PRIMARY KEY,
    EmployeeID INT,
    StartDate DATE,
    EndDate DATE,
    JobDescription TEXT,
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);

-- T?o b?ng Theo d�i tr? l??ng
CREATE TABLE SalaryPayments (
    PaymentID INT PRIMARY KEY,
    EmployeeID INT,
    PaymentDate DATE,
    Amount DECIMAL(10, 2),
    PaymentMethod VARCHAR(50),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);

-- T?o b?ng Tra c?u th�ng tin
CREATE TABLE SearchInfo (
    SearchID INT PRIMARY KEY,
    Keyword VARCHAR(50),
    Result TEXT,
    EmployeeID INT,
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);

-- T?o b?ng Th?ng k�
CREATE TABLE Report (
    StatID INT PRIMARY KEY,
    Month INT,
    Quarter INT,
    Year INT,
    EmployeeCount INT,
    TotalSalary DECIMAL(15, 2),
    EmployeeID INT,
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);

-- T?o b?ng In th�ng tin
CREATE TABLE PrintInfo (
    PrintID INT PRIMARY KEY,
    Content TEXT,
    Format VARCHAR(50),
    EmployeeID INT,
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);

-- T?o b?ng User
CREATE TABLE NguoiDung (
    UserID INT PRIMARY KEY,
	 UserName VARCHAR(50),
    PWord VARCHAR(255),
);