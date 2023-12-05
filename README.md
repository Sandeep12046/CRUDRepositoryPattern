# CRUDRepositoryPattern Library DataBase

-- Create a database named 'library'
CREATE DATABASE IF NOT EXISTS library;

-- Use the 'library' database
USE library;

-- Create a table named 'books' with the specified columns
CREATE TABLE IF NOT EXISTS books (
    book_id INTEGER PRIMARY KEY AUTOINCREMENT,
    book_name TEXT,
    author_name TEXT,
    price REAL,
    summary TEXT,
    publish_date DATE
);

-- Insert 5 sample records into the 'books' table
INSERT INTO books (book_name, author_name, price, summary, publish_date)
VALUES
    ('The Great Gatsby', 'F. Scott Fitzgerald', 15.99, 'Classic novel about the American Dream', '1925-04-10'),
    ('To Kill a Mockingbird', 'Harper Lee', 12.50, 'Powerful story of racial injustice in the South', '1960-07-11'),
    ('1984', 'George Orwell', 14.95, 'Dystopian novel set in a totalitarian society', '1949-06-08'),
    ('The Catcher in the Rye', 'J.D. Salinger', 11.75, 'Coming-of-age novel with a rebellious protagonist', '1951-07-16'),
    ('Pride and Prejudice', 'Jane Austen', 13.25, 'Classic romantic novel set in 19th-century England', '1813-01-28');
