create database student


drop table Student_Info
create table Student_Info
(
	Reg_Number Varchar(20),
	Student_Name  Varchar(30) ,
	Branch  Varchar(30),
	Contact_Number  Varchar(20),
    Date_of_Birth Date, 
	Date_of_Joining Date ,	
	Address Varchar(250),
	Email_id Varchar(250)
)

insert into Student_Info values ('MC101301','James','MCA','9714589787','12-01-1984','08-07-2010','No 10 South Block Nivea',	'james.mca@yahoo.com')
insert into Student_Info values ('BEC111402','Manio','ECE','8912457875','23-02-1983','25-06-2011','8/12','Park View,Sieera','manioma@gmail.com')
insert into Student_Info values ('BEEI101204','Mike	EI','8974567897','10-02-1983','25-08-2010','Cross villa,NY','mike.james@ymail.com')
insert into Student_Info values ('MB111305','Paulson','MBA	','8547986123','13-12-1984','08-08-2010','Lake view,NJ','paul.son@rediffmail.com ')

select *from Student_Info

drop table  Subject_Master
create table Subject_Master
(
	Subject_Code varchar(10),
	Subject_Name Varchar(30), 
	Weightage int
)

insert into Subject_Master values ('EE01DCF','DCF',30)
insert into Subject_Master values ('EC02MUP','Microprocessor',40)
insert into Subject_Master values ('MC06DIP','Digital Image Processing',30)
insert into Subject_Master values ('MB03MAR','Marketing Techniques', 20)
insert into Subject_Master values ('EI05IP','Instrumentation Precision', 40)
insert into Subject_Master values ('CPSC02DS','Data Structures',40)

select *from Subject_Master

drop table Student_Marks
 create table Student_Marks
 (
 	Reg_Number  Varchar(20),
    Subject_Code varchar(10),
	Semester int,
	Marks int
)

insert into Student_Marks values ('MC101301','EE01DCF',1,75)
insert into Student_Marks values  ('MC101301',	'EC02MUP',	1,	65)
insert into Student_Marks values  ('MC101301',	 ' MC06DIP'	,1,	70)
insert into Student_Marks values  ('BEC111402',	'EE01DCF',	1,	55)
insert into Student_Marks values ('BEC111402','EC02MUP',	1,80)
insert into Student_Marks values ('BEC111402','MC06DIP	',1	,60)
insert into Student_Marks values ('BEEI101204',	'EE01DCF',1	,85)
insert into Student_Marks values ('BEEI101204','EC02MUP	',1,78)
insert into Student_Marks values ('BEEI101204','MC06DIP	',1	,80)
insert into Student_Marks values ('BEEI101204','MB03MAR	',2	,75)
insert into Student_Marks values ('BEEI101204','EI05IP',2,65)
insert into Student_Marks values ('BEEI101204','CPSC02DS',2,75)
insert into Student_Marks values ('MB111305','EE01DCF',1,65)
insert into Student_Marks values ('MB111305','EC02MUP',1,68)
insert into Student_Marks values ('MB111305','MC06DIP',1,63)
insert into Student_Marks values ('MB111305','MB03MAR',2,85)
insert into Student_Marks values ('MB111305','EI05IP',2 ,74) 
insert into Student_Marks values ('MB111305','CPSC02DS',2,62)

select *from Student_Marks

drop table Student_Result
create table Student_Result
(
	Reg_Number Varchar(30),
	Semester int,
	GPA int ,
	Is_Eligible_Scholarship char(3) 
)

insert into Student_Result values ('MC101301',1,7.5,'Y')
insert into Student_Result values ('BEC111402',	1,7.1,'Y')
insert into Student_Result values ('BEEI101204'	,1,	8.3	,'Y')
insert into Student_Result values ('BEEI101204',2,6.9,'N')
insert into Student_Result values ('MB111305',1,6.5,'N')
insert into Student_Result values ('MB111305',2,6.8,'N')

select *from Student_Result