create database MyWISPSI default character set utf8;

use MyWISPSI;

create table Customer(
idCustomer varchar(20) not null primary key,
Full_Name varchar(200) not null,
Municipality varchar(45) not null,
Department varchar(45) not null,
Address varchar(60) not null,
Phone varchar(45),
E_mail varchar(60),
Status_customer varchar(15) not null,
Remark varchar(300)
);


create table Service_Plan(
idService_Plan varchar(20) not null primary key,
Name_Plan varchar(45) not null,
Price_Plan_CO double not null,
Description_service varchar(200) not null
);

create table Instalation(
idInstalation int not null primary key auto_increment,
Date_instalation date null,
Materials varchar(400) null,
Place_instalation varchar(300) not null,
Customer_idCustomer varchar(20) not null,
Service_Plan_idService_Plan varchar(20) not null,
foreign key (Customer_idCustomer) references Customer(idCustomer),
foreign key (Service_Plan_idService_Plan) references Service_Plan(idService_Plan)
);

create table Customer_device(
MAC_device varchar(40) not null primary key,
Name_device varchar(45) not null,
IP_device varchar(45) not null,
Brand_device varchar(45) not null,
Type_device varchar(45) not null,
Firmware_version varchar(45) null,
Instalation_idInstalation int not null,
foreign key (Instalation_idInstalation) references Instalation(idInstalation)
);
 
create table Session_Customer(
idSession_Customer varchar(20) not null primary key,
Full_Name varchar(200) not null,
Phone varchar(20) null,
E_mail varchar(60) null,
User_session varchar(45) not null,
Password_session varchar(45) not null,
Date_acquisition date null,
Status_session varchar(20) not null,
Remarks varchar(200) null
);

create table Equipment(
MAC_equipment varchar(40) not null primary key,
Name_Equipment varchar(60) not null,
Brand_Equipment varchar(45) not null,
Type_equipment varchar(30) not null,
IP_Equipment varchar(45) not null,
Frecuency_Equipment varchar(20) not null,
Firmware_version varchar(20) null,
Ubication_Node varchar(60) not null,
Date_instalation date null,
Remarks varchar(300) null
);

create table Point_of_Sale(
idPoint_of_Sale int not null primary key auto_increment,
Name_Point varchar(45) not null,
Department varchar(45) not null,
Municipality varchar(45) not null,
Address varchar(100) not null,
Name_Owner varchar(200) not null,
Phone varchar(20) null,
E_mail varchar(60) null,
Amount_codes varchar(10) null,
Prefix_code varchar(10) null
);

create table Company(
NIT varchar(20) not null primary key,
Name_Company varchar(200) not null,
City varchar(20) not null,
Department varchar(45) not null,
Address varchar(100) null,
Phone varchar(20) null,
E_mail varchar(100) null,
Website_Address varchar(45) null,
Image varchar(200) null
);

create table Users(
idUser int not null primary key auto_increment,
First_Name varchar(45) not null,
Last_Name varchar(45) null,
First_Surname varchar(45) not null,
Last_Surname varchar(45) null,
Name_User varchar(45) not null,
Password_User varchar(45) not null
);

insert into Users(First_Name, Last_Name, First_Surname, Last_Surname, Name_User, Password_User) values('My Name', '', 'My Lastname', '', 'myuser', MD5('1111'));
insert into Company(NIT, Name_Company, City, Department, Address, Phone, E_mail, Website_Address, Image) values('000000000', 'My Company', 'City', 'Department/State', 'Address of the company', '5555-555', 'email@mycompany.com', 'www.mycompany.com', '');


