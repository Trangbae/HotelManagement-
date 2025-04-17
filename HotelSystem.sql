-- Xóa các bảng nếu đã tồn tại để tránh xung đột
IF OBJECT_ID('dbo.Reservation_Services', 'U') IS NOT NULL DROP TABLE dbo.Reservation_Services;
IF OBJECT_ID('dbo.Reservations', 'U') IS NOT NULL DROP TABLE dbo.Reservations;
IF OBJECT_ID('dbo.Serviceb', 'U') IS NOT NULL DROP TABLE dbo.Serviceb;
IF OBJECT_ID('dbo.Room', 'U') IS NOT NULL DROP TABLE dbo.Room;
IF OBJECT_ID('dbo.Employee', 'U') IS NOT NULL DROP TABLE dbo.Employee;
IF OBJECT_ID('dbo.Customer', 'U') IS NOT NULL DROP TABLE dbo.Customer;

-- Tạo bảng Customer (khách hàng)
CREATE TABLE Customer (
    id VARCHAR(255) NOT NULL PRIMARY KEY, 
    name VARCHAR(255),
    phone VARCHAR(255),
    email VARCHAR(255),
    address VARCHAR(255),
    city VARCHAR(255),
    id_card VARCHAR(255),  -- Số CMND hoặc CCCD
    img VARCHAR(255)       -- Đường dẫn hình ảnh của khách hàng
);

-- Tạo bảng Room (phòng)
CREATE TABLE Room (
    id VARCHAR(255) NOT NULL PRIMARY KEY, 
    room_type VARCHAR(255),
    price_per_night VARCHAR(255),  -- Sử dụng DECIMAL cho dữ liệu tiền tệ
    capacity VARCHAR(255),
    status VARCHAR(255) 
);

-- Tạo bảng Employee (nhân viên)
CREATE TABLE Employee (
    id VARCHAR(255) NOT NULL PRIMARY KEY, 
    name VARCHAR(255),
    userName VARCHAR(255),
    password VARCHAR(255) NOT NULL,
    role VARCHAR(255) NOT NULL
);

CREATE TABLE Serviceb (
    id VARCHAR(255) NOT NULL PRIMARY KEY,
    name VARCHAR(255),
    description VARCHAR(255),
    price VARCHAR(255)
);


-- Tạo bảng Reservations (thông tin đặt phòng) với các khóa ngoại
CREATE TABLE Reservations (
    id VARCHAR(255) NOT NULL PRIMARY KEY, 
    customer_id VARCHAR(255), -- Đổi guest_id thành customer_id để phù hợp với bảng Customer
    room_id VARCHAR(255),
    check_in_date DATE,
    check_out_date DATE,
    total_amount DECIMAL(10, 2),
    employee_id VARCHAR(255),
    FOREIGN KEY (customer_id) REFERENCES Customer(id) ON DELETE CASCADE,
    FOREIGN KEY (room_id) REFERENCES Room(id),
    FOREIGN KEY (employee_id) REFERENCES Employee(id)
);

-- Tạo bảng Reservation_Services (dịch vụ đã sử dụng trong thời gian lưu trú)
CREATE TABLE Reservation_Services (
    reservation_id VARCHAR(255),
    service_id VARCHAR(255),
    quantity INT,
    FOREIGN KEY (reservation_id) REFERENCES Reservations(id) ON DELETE CASCADE,
    FOREIGN KEY (service_id) REFERENCES Serviceb(id) ON DELETE CASCADE,
    PRIMARY KEY (reservation_id, service_id)
);
SELECT * FROM dbo.Serviceb;
INSERT INTO Customer (id, name, phone, email, address, city, id_card, img)
VALUES 
('CUST001', 'Nguyen Van A', '0901234567', 'a@example.com', '123 Street', 'Hanoi', '123456789', 'image_a.jpg'),
('CUST002', 'Le Thi B', '0909876543', 'b@example.com', '456 Avenue', 'Ho Chi Minh City', '987654321', 'image_b.jpg');
INSERT INTO Room (id, room_type, price_per_night, capacity, status)
VALUES 
('ROOM001', 'Single', 100.00, 1, 'available'),
('ROOM002', 'Double', 150.00, 2, 'occupied'),
('ROOM003', 'Suite', 300.00, 4, 'reserved');
INSERT INTO Employee (id, name, userName, password, role)
VALUES 
('EMP001', 'Tran Van C', 'tranvanc', 'password123', 'receptionist'),
('EMP002', 'Pham Thi D', 'phamthid', 'password456', 'manager')
INSERT INTO Serviceb (id, name, description, price)
VALUES 
('SERVICE001', 'Room Cleaning', 'Daily room cleaning service', 50.00),
('SERVICE002', 'Breakfast', 'Buffet breakfast', 20.00),
('SERVICE003', 'Airport Pickup', 'Transportation from airport to hotel', 100.00);
;
