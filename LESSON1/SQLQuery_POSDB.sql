create database POSDB;
use POSDB

create table pos_nameTbl (
name_id int IDENTITY(1,1),
pos_id varchar(20) primary key,
name1 varchar(50), name2 varchar(50),
name3 varchar(50), name4 varchar(50),
name5 varchar(50), name6 varchar(50),
name7 varchar(50), name8 varchar(50),
name9 varchar(50), name10 varchar(50),
name11 varchar(50), name12 varchar(50),
name13 varchar(50), name14 varchar(50),
name15 varchar(50), name16 varchar(50),
name17 varchar(50), name18 varchar(50),
name19 varchar(50), name20 varchar(50),
employee_id varchar(20));

-- Drop and recreate the tables with matching data types
DROP TABLE pos_priceTbl;
DROP TABLE pos_picTbl;
DROP TABLE pos_nameTbl;

-- Recreate with matching pos_id types (all VARCHAR)
create table pos_nameTbl (
    name_id int IDENTITY(1,1),
    pos_id varchar(20) primary key,
    name1 varchar(50), name2 varchar(50),
    name3 varchar(50), name4 varchar(50),
    name5 varchar(50), name6 varchar(50),
    name7 varchar(50), name8 varchar(50),
    name9 varchar(50), name10 varchar(50),
    name11 varchar(50), name12 varchar(50),
    name13 varchar(50), name14 varchar(50),
    name15 varchar(50), name16 varchar(50),
    name17 varchar(50), name18 varchar(50),
    name19 varchar(50), name20 varchar(50),
    employee_id varchar(20)
);

create table pos_picTbl (
    pic_id int identity(1,1) primary key,
    pic1 text, pic2 text, pic3 text, pic4 text, 
    pic5 text, pic6 text, pic7 text, pic8 text,
    pic9 text, pic10 text, pic11 text, pic12 text,
    pic13 text, pic14 text, pic15 text, pic16 text,
    pic17 text, pic18 text, pic19 text, pic20 text,
    pos_id varchar(20)  -- CHANGED FROM INT TO VARCHAR(20)
);

create table pos_priceTbl (
    price_id int identity(1, 1) primary key,
    price1 varchar(50), price2 varchar(50), price3 varchar(50), price4 varchar(50), 
    price5 varchar(50), price6 varchar(50), price7 varchar(50), price8 varchar(50),
    price9 varchar(50), price10 varchar(50), price11 varchar(50), price12 varchar(50),
    price13 varchar(50), price14 varchar(50), price15 varchar(50), price16 varchar(50),
    price17 varchar(50), price18 varchar(50), price19 varchar(50), price20 varchar(50),
    pos_id varchar(20)  -- CHANGED FROM INT TO VARCHAR(20)
);

CREATE TABLE salesTbl (
    transaction_id INT IDENTITY (1,1) PRIMARY KEY,
    product_name VARCHAR(100),
    product_price VARCHAR(100),  -- using VARCHAR for now
    product_quantity_per_transaction VARCHAR(50),
    discount_option VARCHAR(50),
    discount_amount_per_transaction VARCHAR(50),
    discounted_amount_per_transaction VARCHAR(50),
    summary_total_quantity VARCHAR(50),
    summary_total_disc_given VARCHAR(50),
    summary_total_discounted_amount VARCHAR(50),
    terminal_no VARCHAR(50),
    time_date_ VARCHAR(50),
    emp_id VARCHAR(20)
);

CREATE TABLE pos_empRegTbl (empReg_id int IDENTITY(1, 1),
emp_id varchar(20) primary key,
emp_fname varchar(100), emp_mname varchar(50), emp_surname varchar(100),
emp_age int, emp_gender varchar(30), emp_sss_no int,
emp_tin_no int, emp_philhealth_no int, emp_pagibig_no int,
emp_status varchar(50), emp_height varchar(50), emp_weight varchar(50),
add_yrs_stay int, add_house_no int, add_sub_name text, add_phase_no int, 
add_street varchar(100), add_baranggay varchar(100), add_municipality varchar(100),
add_city varchar(100), add_state_province varchar(100), add_country varchar(100),
add_zipcode int, elem_name text, elem_address text, elem_yr_grad varchar(50),
elem_award varchar(50), junior_high_name text, junior_high_address text, junior_high_yr_grad varchar(50),
junior_high_award varchar(50), senior_high_name text, senior_high_address text, senior_high_yr_grad varchar(50),
senior_high_award varchar(50), track varchar(50), college_school_name text, college_address text,
college_yr_grad varchar(50), college_award varchar(50), college_course varchar(100), others text,
position varchar(50), emp_work_status varchar(50), emp_date_hired varchar(50), emp_department varchar(50), 
emp_no_of_dependents int, picpath text);

CREATE TABLE useraccountTbl (useraccount_id int identity(1, 1),
user_id int primary key,
account_type varchar(100),
username varchar(100),
password varchar(100),
confirm_password varchar(100),
user_status varchar(50),
emp_id varchar(20),
pos_terminal_no varchar(50));







INSERT INTO useraccountTbl (
    user_id, 
    account_type, 
    username, 
    password, 
    confirm_password, 
    user_status, 
    emp_id, 
    pos_terminal_no
)
VALUES (
    101,                            -- A unique integer ID for user_id (since it's the PRIMARY KEY)
    'Administrator',                -- Account type
    'Jhovany',                   -- Username
    'admin123',                     -- Password (As per your table schema, storing it as text)
    'admin123',                     -- Confirm_password
    'Active',                       -- User status
    '1001',                       -- Assumed employee ID (make sure this exists in pos_empRegTbl)
    '1'                             -- Terminal number for POS1
);


-- Honorio Jhovany assigned to Terminal 2
INSERT INTO useraccountTbl (
    user_id, account_type, username, password, confirm_password, 
    user_status, emp_id, pos_terminal_no
)
VALUES (
    102,                -- Unique user ID
    'Administrator',    -- Account type
    'jhovany',         -- Username for login
    'admin123',        -- Password
    'admin123',        -- Confirm password
    'Active',          -- Status
    '2',               -- Links to emp_id = '2' (Honorio Jhovany)
    '2'                -- Assigned to Terminal 2
);


INSERT INTO pos_empRegTbl (emp_id, emp_fname, emp_surname) VALUES ('1', 'John', 'Doe');
INSERT INTO pos_empRegTbl (emp_id, emp_fname, emp_surname) VALUES ('2', 'Jhovany', 'Honorio');


select * from pos_empRegTbl;
select * from pos_nameTbl;
select * from useraccountTbl;
-- Run these queries in SQL Server to check:
SELECT * FROM pos_nameTbl WHERE pos_id = '1';
SELECT * FROM pos_picTbl WHERE pos_id = '1';
SELECT * FROM pos_priceTbl WHERE pos_id = '1';

SELECT * FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id WHERE pos_terminal_no = '1'
SELECT * FROM pos_nameTbl INNER JOIN pos_picTbl ON pos_nameTbl.pos_id = pos_picTbl.pos_id INNER JOIN pos_priceTbl ON pos_picTbl.pos_id = pos_priceTbl.pos_id WHERE pos_nameTbl.pos_id = 1
DELETE FROM pos_priceTbl WHERE pos_id = '1';



-- 1. CLEANUP (Assuming you want to clear the old test data)
DELETE FROM useraccountTbl WHERE user_id = 101;
DELETE FROM pos_empRegTbl WHERE emp_id = '1';

-- 2. CORRECTED INSERT for Employee Registration (Master Record)
-- We will use '1' as the consistent Employee ID
INSERT INTO pos_empRegTbl (emp_id, emp_fname, emp_surname) 
VALUES ('1', 'John', 'Doe');

-- 3. CORRECTED INSERT for User Account (Link to Terminal 1)
-- *** IMPORTANT: The emp_id now matches the value used above: '1' ***
INSERT INTO useraccountTbl (
    user_id, account_type, username, password, confirm_password, 
    user_status, emp_id, pos_terminal_no
)
VALUES (
    101, 
    'Administrator', 
    'Jhovany', 
    'admin123', 
    'admin123', 
    'Active', 
    '1',          -- <<< MATCHES emp_id IN pos_empRegTbl
    '1'
);


SELECT 
    E.emp_id, 
    E.emp_fname, 
    A.username, 
    A.pos_terminal_no 
FROM pos_empRegTbl AS E
INNER JOIN useraccountTbl AS A 
    ON E.emp_id = A.emp_id 
WHERE A.pos_terminal_no = '1';



SELECT * FROM pos_empRegTbl;

-- Check user accounts and terminal assignments
SELECT 
    E.emp_id,
    E.emp_fname,
    E.emp_surname,
    U.username,
    U.pos_terminal_no,
    U.user_status
FROM pos_empRegTbl E
INNER JOIN useraccountTbl U ON E.emp_id = U.emp_id
ORDER BY U.pos_terminal_no;
