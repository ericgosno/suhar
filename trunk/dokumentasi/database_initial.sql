/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     2/17/2014 9:58:49 PM                         */
/*==============================================================*/


drop table if exists Customer;

drop table if exists Customer_Transaction;

drop table if exists Customer_Transaction_Product;

drop table if exists Price_History;

drop table if exists Product;

drop table if exists Product_Category;

drop table if exists Stock_Type;

drop table if exists Supplier;

drop table if exists Supplier_Transaction;

drop table if exists Supplier_Transaction_Product;

/*==============================================================*/
/* Table: Customer                                              */
/*==============================================================*/
create table Customer
(
   Customer_ID          int not null,
   Customer_Name        varchar(50) not null,
   Customer_Address     varchar(200),
   Customer_Email       varchar(50),
   Customer_Phone       varchar(12),
   primary key (Customer_ID)
);

/*==============================================================*/
/* Table: Customer_Transaction                                  */
/*==============================================================*/
create table Customer_Transaction
(
   Customer_Transaction_ID int not null,
   Customer_ID          int,
   Customer_Transaction_Total_Rupiah decimal(12,2),
   Customer_Transaction_Total_Dollar decimal(12,2),
   Customer_Transaction_Date datetime not null,
   Customer_Transaction_Status int not null,
   Customer_Transaction_Description varchar(200),
   primary key (Customer_Transaction_ID)
);

/*==============================================================*/
/* Table: Customer_Transaction_Product                          */
/*==============================================================*/
create table Customer_Transaction_Product
(
   Customer_Transaction_ID int not null,
   Product_ID           int not null,
   Customer_Transaction_Product_Quantity int,
   Customer_Transaction_Product_Price_Dollar decimal(12,2),
   Customer_Transaction_Product_Price_Rupiah decimal(12,2),
   primary key (Customer_Transaction_ID, Product_ID)
);

/*==============================================================*/
/* Table: Price_History                                         */
/*==============================================================*/
create table Price_History
(
   Price_History_ID     int not null,
   Product_ID           int,
   Price_History_Price  decimal(10,2) not null,
   Price_History_Kurs   int not null,
   primary key (Price_History_ID)
);

/*==============================================================*/
/* Table: Product                                               */
/*==============================================================*/
create table Product
(
   Product_ID           int not null,
   Supplier_ID          int not null,
   Product_Category_ID  int,
   Stock_Type_ID        int,
   Product_Name         varchar(20) not null,
   Product_Stock        int not null,
   Product_Buy_Price_Dollar decimal(12,2),
   Product_Buy_Price_Rupiah decimal(12,2),
   primary key (Product_ID)
);

/*==============================================================*/
/* Table: Product_Category                                      */
/*==============================================================*/
create table Product_Category
(
   Product_Category_ID  int not null,
   Product_Category_Name varchar(50) not null,
   primary key (Product_Category_ID)
);

/*==============================================================*/
/* Table: Stock_Type                                            */
/*==============================================================*/
create table Stock_Type
(
   Stock_Type_ID        int not null,
   Stock_Type_Name      varchar(50) not null,
   Stock_Type_Kilogram  decimal(10,2) not null,
   primary key (Stock_Type_ID)
);

/*==============================================================*/
/* Table: Supplier                                              */
/*==============================================================*/
create table Supplier
(
   Supplier_ID          int not null,
   Supplier_Name        varchar(50) not null,
   Supplier_Address     varchar(250),
   Supplier_Email       varchar(200),
   Supplier_Phone       longtext,
   primary key (Supplier_ID)
);

/*==============================================================*/
/* Table: Supplier_Transaction                                  */
/*==============================================================*/
create table Supplier_Transaction
(
   Supplier_Transaction_Total_Rupiah decimal(12,2),
   Supplier_Transaction_ID int not null,
   Supplier_ID          int,
   Supplier_Transaction_Total_Dollar decimal(12,2),
   Supplier_Transaction_Date datetime not null,
   Supplier_Transaction_Status int not null,
   Supplier_Transaction_Description varchar(200),
   primary key (Supplier_Transaction_ID)
);

/*==============================================================*/
/* Table: Supplier_Transaction_Product                          */
/*==============================================================*/
create table Supplier_Transaction_Product
(
   Product_ID           int not null,
   Supplier_Transaction_ID int not null,
   Supplier_Transaction_Product_Quantity int not null,
   Supplier_Transaction_Product_Price_Dollar decimal(10,2) not null,
   Supplier_Transaction_Product_Price_Rupiah decimal(10,2) not null,
   primary key (Product_ID, Supplier_Transaction_ID)
);

alter table Customer_Transaction add constraint FK_Relationship_8 foreign key (Customer_ID)
      references Customer (Customer_ID) on delete restrict on update restrict;

alter table Customer_Transaction_Product add constraint FK_Relationship_10 foreign key (Customer_Transaction_ID)
      references Customer_Transaction (Customer_Transaction_ID) on delete restrict on update restrict;

alter table Customer_Transaction_Product add constraint FK_Relationship_11 foreign key (Product_ID)
      references Product (Product_ID) on delete restrict on update restrict;

alter table Price_History add constraint FK_Relationship_3 foreign key (Product_ID)
      references Product (Product_ID) on delete restrict on update restrict;

alter table Product add constraint FK_Relationship_1 foreign key (Supplier_ID)
      references Supplier (Supplier_ID) on delete restrict on update restrict;

alter table Product add constraint FK_Relationship_2 foreign key (Product_Category_ID)
      references Product_Category (Product_Category_ID) on delete restrict on update restrict;

alter table Product add constraint FK_Relationship_4 foreign key (Stock_Type_ID)
      references Stock_Type (Stock_Type_ID) on delete restrict on update restrict;

alter table Supplier_Transaction add constraint FK_Relationship_6 foreign key (Supplier_ID)
      references Supplier (Supplier_ID) on delete restrict on update restrict;

alter table Supplier_Transaction_Product add constraint FK_Relationship_7 foreign key (Product_ID)
      references Product (Product_ID) on delete restrict on update restrict;

alter table Supplier_Transaction_Product add constraint FK_Relationship_9 foreign key (Supplier_Transaction_ID)
      references Supplier_Transaction (Supplier_Transaction_ID) on delete restrict on update restrict;

