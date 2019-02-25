/*
TEAM 3: Scrumbledore's Army
Members: Isabella Brodzinski, Eric Smith, Amanda Morton
CISS 311: Agile Development II
Course Project: Tiny Library

Summary: This database is part of a Library Data Management System for
a small library. It will have tables for books, authors, authors of books
(joint table), borrowers, checkout, and checkout history.
*/

/*To drop database in case we need to start over */
 If DB_ID(N'TinyLibrary') IS NOT NULL DROP DATABASE TinyLibrary;

 /*Create database*/
CREATE DATABASE TinyLibrary;
 GO

 /*Connect to database*/
USE TinyLibrary;
GO

/*Create Schemas to organize tables
Library will contain library materials and info 
such as books, authors, and the book-author table.
Membership will contain borrowers, checkout and
checkout history table */
CREATE SCHEMA Library AUTHORIZATION dbo;
GO
CREATE SCHEMA Membership AUTHORIZATION dbo;
GO

/*Create tables in Library schema*/
/*Books table*/
CREATE TABLE Library.books
(
	book_id			INT		        NOT NULL	IDENTITY,
	title			NVARCHAR(225)	NOT NULL,
	copyright_year	INT				NOT NULL,
	isbn			CHAR(13)		NOT NULL,
	location		NVARCHAR(50)	NOT NULL,
	copies			INT				NOT NULL,
	CONSTRAINT PK_books PRIMARY KEY (book_id)
);

/*Authors table*/
CREATE TABLE Library.authors
(
	author_id			INT				NOT NULL	IDENTITY,
	first_name			NVARCHAR(50)	NOT NULL,
	last_name			NVARCHAR(50)	NOT NULL,
	about_the_author	NVARCHAR(max)	NOT NULL,
	CONSTRAINT PK_authors PRIMARY KEY (author_id)
);

/*Author-book table to serve as joint table*/
CREATE TABLE Library.author_book
(
	author_id		INT		NOT NULL,
	book_id			INT		NOT NULL,
	CONSTRAINT FK_author_book_authors FOREIGN KEY (author_id) REFERENCES Library.authors (author_id),
	CONSTRAINT FK_author_book_books FOREIGN KEY (book_id) REFERENCES Library.books (book_id)
);

/*Create tables in Membership schema*/
/*Borrowers table*/
CREATE TABLE Membership.borrowers
(
	borrower_id		INT				NOT NULL	IDENTITY,
	type			NCHAR(20)		NOT NULL,
	first_name		NVARCHAR(50)	NOT NULL,
	last_name		NVARCHAR(50)	NOT NULL,
	CONSTRAINT PK_borrowers PRIMARY KEY (borrower_id)
);

/*Checkout table*/
CREATE TABLE Membership.checkout
(
	borrower_id		INT			NOT NULL,
	book_id			INT			NOT NULL,
	date			DATETIME	NOT NULL,
	CONSTRAINT FK_checkout_borrowers FOREIGN KEY (borrower_id) REFERENCES Membership.borrowers (borrower_id),
	CONSTRAINT FK_checkout_books FOREIGN KEY (book_id) REFERENCES Library.books (book_id)
);

/*Checkout history table*/
CREATE TABLE Membership.checkout_history
(
	borrower_id		INT			NOT NULL,
	book_id			INT			NOT NULL,
	CONSTRAINT FK_checkout_history_borrowers FOREIGN KEY (borrower_id) REFERENCES Membership.borrowers (borrower_id),
	CONSTRAINT FK_checkout_history_books FOREIGN KEY (book_id) REFERENCES Library.books (book_id)
);
