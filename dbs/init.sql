CREATE DATABASE IF NOT EXISTS patients_db;
USE patients_db;

CREATE TABLE IF NOT EXISTS patients (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(255),
    birth_date DATE,
    gender ENUM('Male', 'Female', 'Other'),
    created_by VARCHAR(255),
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    is_deleted BOOLEAN DEFAULT FALSE
);

INSERT INTO patients (name, birth_date, gender, created_by) VALUES ('John Doe', '1990-05-15', 'Male', 'Doctor A');
INSERT INTO patients (name, birth_date, gender, created_by) VALUES ('Jane Doe', '1988-09-20', 'Female', 'Doctor B');
INSERT INTO patients (name, birth_date, gender, created_by) VALUES ('Alice Smith', '1975-03-10', 'Female', 'Doctor C');
INSERT INTO patients (name, birth_date, gender, created_by) VALUES ('Bob Johnson', '1980-11-25', 'Male', 'Doctor D');
INSERT INTO patients (name, birth_date, gender, created_by) VALUES ('Emily Brown', '1995-07-05', 'Female', 'Doctor E');
INSERT INTO patients (name, birth_date, gender, created_by) VALUES ('Michael Wilson', '1982-01-30', 'Male', 'Doctor F');
INSERT INTO patients (name, birth_date, gender, created_by) VALUES ('Jessica Lee', '1992-04-18', 'Female', 'Doctor G');
INSERT INTO patients (name, birth_date, gender, created_by) VALUES ('David Clark', '1970-10-08', 'Male', 'Doctor H');
INSERT INTO patients (name, birth_date, gender, created_by) VALUES ('Samantha Taylor', '1986-06-12', 'Female', 'Doctor I');
INSERT INTO patients (name, birth_date, gender, created_by) VALUES ('Christopher Martinez', '1984-12-03', 'Male', 'Doctor J');


CREATE TABLE IF NOT EXISTS orders (
    id INT AUTO_INCREMENT PRIMARY KEY,
    patient_id INT,
    doctor_name VARCHAR(255),
    order_text TEXT,
    created_by VARCHAR(255),
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_by VARCHAR(255),
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    is_deleted BOOLEAN DEFAULT FALSE,
    FOREIGN KEY (patient_id) REFERENCES patients(id)
);

INSERT INTO orders (patient_id, doctor_name, order_text, created_by) VALUES 
(1, 'Doctor A', 'Take medication X twice a day.', 'Doctor A'),
(2, 'Doctor B', 'Rest and drink plenty of fluids.', 'Doctor B'),
(3, 'Doctor C', 'Complete blood test and report back.', 'Doctor C'),
(4, 'Doctor D', 'Follow up appointment next week.', 'Doctor D'),
(5, 'Doctor E', 'Prescription for pain relief.', 'Doctor E'),
(6, 'Doctor F', 'Schedule surgery for next month.', 'Doctor F'),
(7, 'Doctor G', 'Change in medication dosage.', 'Doctor G'),
(8, 'Doctor H', 'Physical therapy sessions.', 'Doctor H'),
(9, 'Doctor I', 'Annual checkup appointment.', 'Doctor I'),
(10, 'Doctor J', 'Referral to specialist.', 'Doctor J');
