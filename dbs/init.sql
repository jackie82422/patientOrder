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

