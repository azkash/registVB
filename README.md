PROGRAM INI MENGGUNAKAN DATABASE MYSQL

CREATE DATABASE datapasien;

CREATE TABLE pasien (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nama VARCHAR(100),
    ttl DATE,
    gender ENUM('P', 'L'),
    alamat TEXT
);
<<<<<<< HEAD
CREATE TABLE pasien (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nama VARCHAR(100),
    ttl DATE,
    gender ENUM('P', 'L'),
    alamat TEXT
);

=======
--azka last commit--
added all crud functionalities

3 task remaining
-report
-nomer antrian 
-create feature checkup (if necessary)
>>>>>>> master
