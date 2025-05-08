// create table users
// (
// 	id serial primary key,
// 	fullName varchar(50) not null,
// 	email varchar(30) unique,
// 	phone varchar(30)
// );

// insert into users (fullName, email, phone) values
// ('Alice Johnson', 'alice@example.com', '123-456-7890'),
// ('Bob Smith', 'bob@example.com', '234-567-8901'),
// ('Charlie Brown', 'charlie@example.com', '345-678-9012'),
// ('Diana Prince', 'diana@example.com', '456-789-0123'),
// ('Ethan Hunt', 'ethan@example.com', '567-890-1234');

// select * from users

// create table markets
// (
// 	id serial primary key,
// 	name varchar(50) not null,
// 	address varchar(50)
// );

// insert into markets (name, address) values
// ('Fresh Market', '123 Main St'),
// ('Green Mart', '456 Oak Ave'),
// ('SuperSaver', '789 Elm St'),
// ('Budget Bazaar', '321 Pine Rd'),
// ('Organic Hub', '654 Maple Ln');

// select * from markets

// create table category
// (
// 	id serial primary key,
// 	name varchar(50) not null
// );

// insert into category (name) values
// ('Fruits'),
// ('Vegetables'),
// ('Dairy'),
// ('Bakery'),
// ('Meat');

// select * from category

// create table products
// (
// 	id serial primary key,
// 	name varchar(50) unique not null,
// 	price decimal,
// 	categoryId int references category(id),
// 	marketId int references markets(id),
// 	quantity int
// );

// insert into products (name, price, categoryId, marketId, quantity) values
// ('Apple', 0.99, 1, 1, 100),
// ('Carrot', 0.49, 2, 2, 200),
// ('Milk', 1.29, 3, 3, 150),
// ('Bread', 1.99, 4, 4, 80),
// ('Chicken Breast', 5.49, 5, 5, 60);

// select * from products