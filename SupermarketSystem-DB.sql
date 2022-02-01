create database SupermarketSystem;
use supermarketSystem; 

create table customers(
	idCustomer int auto_increment,
    customerName varchar(50),
    ssn int,
    address varchar(50),
    phoneNumber int,
    constraint PK_idCustomer primary key(idCustomer)
);

create table employees(
	idEmployee int auto_increment,
    employeeName varchar(50),
    email varchar(20),
    address varchar(50),
    phoneNumber int,
    constraint PK_idEmployee primary key(idEmployee)
);

create table checkoutCounter(
	idCheckoutCounter int auto_increment,
    idEmployee int,
    counterNumber int,
    employeeName varchar(50),
    constraint PK_idCheckoutCounter primary key(idCheckoutCounter),
    constraint FK_idEmployee_checkoutCounter foreign key(idEmployee) references employees(idEmployee)
);

create table paymentMethods(
	idPaymentMethod int auto_increment,
    methodName varchar(20),
    constraint PK_idPaymentMethod primary key(idPaymentMethod)
);

create table products(
	idProduct int auto_increment,
    productName varchar(30),
    productType varchar(20),
    cost double,
    constraint PK_idProduct primary key(idProduct)
);

create table suppliers(
	idSupplier int auto_increment,
    idProduct int,
    lot int,
    supplierName varchar(100),
    supplierDate date,
    constraint PK_idSupplier primary key(idSupplier),
    constraint FK_idProduct_Supplier foreign key(idProduct) references products(idProduct)
);

create table users(
	idUser int auto_increment,
    idEmployee int,
    userName varchar(30),
    userPassword varchar(20),
    nationality varchar(20),
    alternativeEmail varchar(50),
    favoriteFood varchar(20),
    constraint PK_idUser primary key(idUser),
    constraint FK_idEmployee_User foreign key(idEmployee) references employees(idEmployee)
);

create table sale(
	invoiceNumber int auto_increment,
    idCustomer int,
    idEmployee int,
    idPaymentMethod int,
    idProduct int,
    idCheckoutCounter int,
    saleDate datetime,
    total double,
    quantity int,
    constraint PK_invoiceNumber primary key(invoiceNumber),
    constraint FK_idCustomer_Sale foreign key(idCustomer) references customers(idCustomer),
    constraint FK_idEmployee_Sale foreign key(idEmployee) references employees(idEmployee),
    constraint FK_idPaymentMethod_Sale foreign key(idPaymentMethod) references paymentMethods(idPaymentMethod),
    constraint FK_idProduct_Sale foreign key(idProduct) references products(idProduct),
    constraint FK_idCheckoutCounter_Sale foreign key(idCheckoutCounter) references checkoutCounter(idCheckoutCounter)
);

