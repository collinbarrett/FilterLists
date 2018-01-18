CREATE USER 'filterlists'@'localhost' IDENTIFIED BY 'password';
CREATE DATABASE filterlistsdata CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
GRANT ALL PRIVILEGES ON filterlistsdata.* TO 'filterlists'@'localhost';
FLUSH PRIVILEGES;