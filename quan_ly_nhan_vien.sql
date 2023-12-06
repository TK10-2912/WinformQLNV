-- Tạo bảng Nhân viên
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Address VARCHAR(255),
    PhoneNumber VARCHAR(15),
    Email VARCHAR(100)
);

-- Tạo bảng Chính sách lương
CREATE TABLE SalaryPolicies (
    PolicyID INT PRIMARY KEY,
    BasicSalary DECIMAL(10, 2),
    Bonus DECIMAL(5, 2),
    PolicyDescription VARCHAR(255),
    EmployeeID INT,
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);

-- Tạo bảng Theo dõi công tác
CREATE TABLE WorkHistory (
    HistoryID INT PRIMARY KEY,
    EmployeeID INT,
    StartDate DATE,
    EndDate DATE,
    JobDescription TEXT,
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);

-- Tạo bảng Theo dõi trả lương
CREATE TABLE SalaryPayments (
    PaymentID INT PRIMARY KEY,
    EmployeeID INT,
    PaymentDate DATE,
    Amount DECIMAL(10, 2),
    PaymentMethod VARCHAR(50),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);

-- Tạo bảng Tra cứu thông tin
CREATE TABLE SearchInfo (
    SearchID INT PRIMARY KEY,
    Keyword VARCHAR(50),
    Result TEXT,
    EmployeeID INT,
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);

-- Tạo bảng Thống kê
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

-- Tạo bảng In thông tin
CREATE TABLE PrintInfo (
    PrintID INT PRIMARY KEY,
    Content TEXT,
    Format VARCHAR(50),
    EmployeeID INT,
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);

-- Tạo bảng User
CREATE TABLE NguoiDung (
    UserID INT PRIMARY KEY,
	 UserName VARCHAR(50),
    PWord VARCHAR(255),
);