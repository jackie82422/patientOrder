CREATE TABLE IF NOT EXISTS patients (
    id VARCHAR(36) PRIMARY KEY,
    name VARCHAR(255),
    birth_date DATE,
    gender ENUM('Male', 'Female', 'Other'),
    created_by VARCHAR(255),
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    is_deleted BOOLEAN DEFAULT FALSE
);

CREATE TABLE IF NOT EXISTS orders (
    id VARCHAR(36) PRIMARY KEY,
    patient_id VARCHAR(36),
    order_text TEXT,
    created_by VARCHAR(255),
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_by VARCHAR(255),
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    is_deleted BOOLEAN DEFAULT FALSE,
    FOREIGN KEY (patient_id) REFERENCES patients(id)
);



INSERT INTO patients (id, name, birth_date, gender, created_by) VALUES
('83b81b4c-bd65-4ee6-9c1a-79fd2e9f8b29', 'John Doe', '1990-05-15', 'Male', 'Doctor A'),
('d7c6c7ad-0883-4a1d-bb1a-5823a1c42c4b', 'Jane Doe', '1988-09-20', 'Female', 'Doctor B'),
('29c22a95-d8d3-4dd0-b0c8-3042ad1d5a24', 'Alice Smith', '1975-03-10', 'Female', 'Doctor C'),
('6a5d6188-52e1-4d8b-ba2d-1a48c8e16724', 'Bob Johnson', '1980-11-25', 'Male', 'Doctor D'),
('18b8e864-b1db-475d-b6ed-df1e48f9d9f7', 'Emily Brown', '1995-07-05', 'Female', 'Doctor E'),
('b5b50c77-c0b8-4da7-94b8-4aef09120e30', 'Michael Wilson', '1982-01-30', 'Male', 'Doctor F'),
('f13469c1-3d64-48c8-abe9-1a90d08311d2', 'Jessica Lee', '1992-04-18', 'Female', 'Doctor G'),
('f8f64c49-dbe4-4683-81eb-c54344a1b1b8', 'David Clark', '1970-10-08', 'Male', 'Doctor H'),
('3d2bc3b2-f8f8-4f3e-9e85-9b5d20c07bfa', 'Samantha Taylor', '1986-06-12', 'Female', 'Doctor I'),
('0e774af3-1e50-4428-8d54-c4d5937c5dd7', 'Christopher Martinez', '1984-12-03', 'Male', 'Doctor J');

INSERT INTO orders (id, patient_id, order_text, created_by) VALUES
('cf3176de-f611-4a1a-b294-7007a85f4a12', '83b81b4c-bd65-4ee6-9c1a-79fd2e9f8b29','Take medication X twice a day.', 'Doctor A'),
('d38b73db-4c7f-4676-bca5-efbfed4e1971', 'd7c6c7ad-0883-4a1d-bb1a-5823a1c42c4b','Rest and drink plenty of fluids.', 'Doctor B'),
('ed1acdc7-9ef8-4841-b4d5-936a3011f166', '29c22a95-d8d3-4dd0-b0c8-3042ad1d5a24','Complete blood test and report back.', 'Doctor C'),
('9bcbb8de-92b7-4cd9-bae3-8fb40d89c8c2', '6a5d6188-52e1-4d8b-ba2d-1a48c8e16724','Follow up appointment next week.', 'Doctor D');

