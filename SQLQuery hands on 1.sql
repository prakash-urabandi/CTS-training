use finalcheck

create table Trainer_Info
(
Trainer_Id char(20)  constraint jp primary key,
Salutation char(7),
Trainer_Name char(30),
Trainer_Location char(30),
Trainer_Track char(15),
TrainerQualification char(100),
Trainer_Experience int,
Trainer_Email char(100),
Trainer_Password char(20)
)

insert into  Trainer_Info values ('F001','Mr.','PANKAJ GHOSH','Pune','Java','Bachelor of Technology',12,'Pankaj.Ghosh@alliance.com','fac1@123')
insert into  Trainer_Info values ('F002','Mr.','SANJAY RADHAKRISHNAN' ,'Bangalore','DotNet','Bachelor of Technology',12,'Sanjay.Radhakrishnan@alliance.com','fac2@123')
insert into  Trainer_Info values ('F003','Mr.','VIJAY MATHUR','Chennai','Mainframe','Bachelor of Technology',10,'Vijay.Mathur@alliance.com','fac3@123')
insert into  Trainer_Info values ('F004','Mrs.','NANDINI NAIR','Kolkata','Java','Master of Computer Applications',9,'Nandini.Nair@alliance.com','fac4@123')
insert into  Trainer_Info values ('F005','Miss.','ANITHA PAREKH','Hyderabad','Testing','Master of Computer Applications',6,'Anitha.Parekh@alliance.com','fac5@123')
insert into  Trainer_Info values ('F006','Mr.','MANOJ AGRAWAL' ,'Mumbai','Mainframe','Bachelor of Technology',9,'Manoj.Agrawal@alliance.com','fac6@123')
insert into  Trainer_Info values ('F007','Ms.','MEENA KULKARNI','Coimbatore','Testing','Bachelor of Technology',5,'Meena.Kulkarni@alliance.com','fac7@123')
insert into  Trainer_Info values ('F009','Mr.','SAGAR MENON' ,'Mumbai','Java','Master of Science In Information Technology',12,'Sagar.Menon@alliance.com','fac8@123')

select *from  Trainer_Info

create table Batch_info
(Batch_Id char(20) constraint jp_batch primary key ,
Batch_Owner char(30),
Batch_BU_Name char(30)
)

insert into  Batch_info values ('B001','MRS.SWATI ROY','MSP')
insert into  Batch_info values ('B002','MRS.ARURNA K','HEALTHCARE')
insert into  Batch_info values ('B003','MR.RAJESH KRISHNAN','LIFE SCIENCES')
insert into  Batch_info values ('B004','MR.SACHIN SHETTY','BFS')
insert into  Batch_info values ('B005','MR.RAMESH PATEL','COMMUNICATIONS')
insert into  Batch_info values ('B006','MRS.SUSAN CHERIAN','RETAIL & HOSPITALITY')
insert into  Batch_info values ('B007','MRS.SAMPADA JAIN','MSP')
insert into  Batch_info values ('B008','MRS.KAVITA REGE','BPO')
insert into  Batch_info values ('B009','MR.RAVI SEJPAL','MSP')

select *from Batch_info

create table Module_info
(
Module_Id char(20) constraint jp_module primary key,
Module_Name char(40),
Module_Duration int
)

insert into Module_info values ('O10SQL','Oracle 10g SQL','16')
insert into Module_info values ('O10PLSQL','Oracle 10g PL/ SQL' ,'16')
insert into Module_info values ('J2SE','Core Java SE 1.6','288')
insert into Module_info values ('J2EE','Advanced Java EE 1.6','80')
insert into Module_info values ('JAVAFX','JavaFX 2.1','80')
insert into Module_info values ('DOTNT4','.Net Framework 4.0' ,'50')
insert into Module_info values ('SQL2008','MS SQl Server 2008','120')
insert into Module_info values ('MSBI08','MS BI Studio 2008','158')
insert into Module_info values ('HRPNT','MS Share Point','80')
insert into Module_info values ('ANDRD4','Android 4.0','200')
insert into Module_info values ('EM001','Instructor','0')
insert into Module_info values ('EM002','Course Material','0')
insert into Module_info values ('EM003','Learning Effectiveness','0')
insert into Module_info values ('EM004','Environment','0')
insert into Module_info values ('EM005','Job Impact','0')
insert into Module_info values ('TM001','Attendees','0')
insert into Module_info values ('TM002','Course Material','0')
insert into Module_info values ('TM003','Environment','0')

select *from Module_info

create table Associate_Info
(
 Associate_Id char(20) constraint jp_associate primary key,
 Salutation char(7),
 Associate_Name char(30),
 Associate_Location char(30),
 Associate_Track char(15),
Associate_Qualification char(200),
 Associate_Email char(100),
 Associate_Password char(20)
 )

 insert into Associate_Info values ('A001','Miss.','GAYATHRI NARAYANAN','Gurgaon','Java','Bachelor of Technology','Gayathri.Narayanan@hp.com','tne1@123')
 insert into Associate_Info values ('A002','Mrs.','RADHIKA MOHAN','Kerala','Java','Bachelor of Engineering In Information Technology','Radhika.Mohan@cognizant.com','tne2@123')
 insert into Associate_Info values ('A003','Mr.','KISHORE SRINIVAS','Chennai','Java','Bachelor of Engineering In Computers','Kishore.Srinivas@ibm.com','tne3@123')
 insert into Associate_Info values ('A004','Mr.','ANAND RANGANATHAN','Mumbai','DotNet','Master of Computer Applications','Anand.Ranganathan@finolex.com','tne4@123')
 insert into Associate_Info values ('A005','Miss.','LEELA MENON','Kerala','Mainframe','Bachelor of Engineering In Information Technology','Leela.Menon@microsoft.com','tne5@123')
 insert into Associate_Info values ('A006','Mrs.','ARTI KRISHNAN','Pune','Testing','Master of Computer Applications','Arti.Krishnan@cognizant.com','tne6@123')
 insert into Associate_Info	 values ('A007','Mr.','PRABHAKAR SHUNMUGHAM','Mumbai','Java','Bachelor of Technology','Prabhakar.Shunmugham@honda.com','tne7@123')

 select *from Associate_Info

 create table	Quetions 
 (
 Quetions_Id char(20) unique,
 Module_Id char(20),
 Quetions_Text char(900)
 )
 insert into     Quetions values ('Q001','EM001','Instructor knowledgeable and able to handle all your queries')
 insert into 	Quetions  values ('Q002','EM001','All the topics in a particular course handled by the trainer without any gaps or slippages') 
 insert into 	Quetions  values ('Q003','EM002','The course materials presentation, handson etc. refered during the training are relevant and useful.')
insert into 	Quetions  values ('Q004','EM002','The Hands on session adequate enough to grasp the understanding of the topic.')
insert into 	Quetions  values ('Q005','EM002','The reference materials suggested for each module are adequate.')
insert into 	Quetions  values ('Q006','EM003','Knowledge and skills presented in this training are applicatible at your work')
insert into 	Quetions  values ('Q007','EM003','This training increases my proficiency level ')
insert into 	Quetions  values ('Q008','EM004','The physical environment e.g. classroom space, air-conditioning was conducive to learning.')
insert into 	Quetions  values ('Q009','EM004','The software/hardware environment provided was sufficient for the purpose of the training.')
insert into 	Quetions  values ('Q010','EM005','This training will improve your job performance.')
insert into 	Quetions  values ('Q011','EM005','This training align with the business priorities and goals.')
insert into 	Quetions  values ('Q012','TM001','Participants were receptive and had attitude towards learning.')
insert into 	Quetions  values ('Q013','TM001','All participats gained the knowledge and the practical skills after this training.')
insert into 	Quetions  values ('Q014','TM002','The course materials presentation, handson,  etc. available for the session covers the entire objectives of the course.')
insert into 	Quetions  values ('Q015','TM002','Complexity of the course is adequate for the particpate level.')
insert into 	Quetions  values ('Q016','TM002','Case study and practical demos helpful in understanding of the topic')
insert into 	Quetions  values ('Q017','TM003','The physical environment e.g. classroom space, air-conditioning was conducive to learning.')
insert into 	Quetions  values ('Q018','TM003','The software/hardware environment provided was adequate  for the purpose of the training.')

select *from Quetions

create table Associate_Status
(
Associate_Id char(20) constraint jp_associateid foreign key references Associate_info(Associate_Id),
Module_Id char(20) constraint jp_moduleid foreign key references Module_info(Module_Id),
Start_Date char(20),
End_Date char(20),
AfeedbackGiven char(20),
TfeedbackGiven char(20)
)
 
 insert into  Associate_Status values ('A001','O10SQL','B001','F001','2000-12-15','2000-12-25')
insert into  Associate_Status values  ('A002','O10SQL','B001','F001','2000-12-15','2000-12-25')
insert into  Associate_Status values  ('A003','O10SQL','B001','F001','2000-12-15','2000-12-25')
insert into  Associate_Status values ('A001','O10PLSQL','B002','F002','2001-2-1','2001-2-12')
insert into  Associate_Status values ('A002','O10PLSQL','B002','F002','2001-2-1','2001-2-12')
insert into  Associate_Status values ('A003','O10PLSQL','B002','F002','2001-2-1','2001-2-12')
insert into  Associate_Status values ('A001','J2SE','B003','F003','2002-8-20','2002-10-25')
insert into  Associate_Status values ('A002','J2SE','B003','F003','2002-8-20','2002-10-25')
insert into  Associate_Status values ('A001','J2EE','B004','F004','2005-12-1','2005-12-25')
insert into  Associate_Status values ('A002','J2EE','B004','F004','2005-12-1','2005-12-25')
insert into  Associate_Status values ('A003','J2EE','B004','F004','2005-12-1','2005-12-25')
insert into  Associate_Status values ('A004','J2EE','B004','F004','2005-12-1','2005-12-25')
insert into  Associate_Status values ('A005','JAVAFX','B005','F006','2005-12-4','2005-12-20')
insert into  Associate_Status values ('A006','JAVAFX','B005','F006','2005-12-4','2005-12-20')
insert into  Associate_Status values ('A006','SQL2008','B006','F007','2007-6-21','2007-6-28')
insert into  Associate_Status values ('A007','SQL2008','B006','F007','2007-6-21','2007-6-28')
insert into  Associate_Status values ('A002','MSBI08','B007','F006','2009-6-26','2009-6-29')
insert into  Associate_Status values ('A003','MSBI08','B007','F006','2009-6-26','2009-6-29')
insert into  Associate_Status values ('A004','MSBI08','B007','F006','2009-6-26','2009-6-29')
insert into  Associate_Status values ('A002','ANDRD4','B008','F005','2010-6-5','2010-6-28')
insert into  Associate_Status values ('A005','ANDRD4','B008','F005','2010-6-5','2010-6-28')
insert into  Associate_Status values ('A003','ANDRD4','B009','F005','2011-8-1','2011-8-20')
insert into  Associate_Status values ('A006','ANDRD4','B009','F005','2011-8-1','2011-8-20')

select *from Associate_Status

create table TrainerFeedBack 
(
Trainer_Id char(20) constraint trainerid foreign key references Trainer_info(Trainer_Id),
Quetion_Id char(20) constraint quetionid foreign key references Quetions(Quetions_Id),
Batch_Id char(20) constraint batchid foreign key references Batch_info(Batch_Id),
Module_Id char(20) constraint moduleid foreign key references Module_info(Module_Id),
Trainer_Rating int
)

create table Associate_Feedback
(
Associate_Id char(20) constraint associateid foreign key references  Associate_Info(Associate_Id),
Quetion_Id char(20) constraint fquetionid foreign key references Quetions(Quetions_Id),
Module_Id char(20) constraint fmoduleid foreign key references Module_info(Module_Id),
Associate_Rating int
)

create login Login_Details
(
 User-Id char(20),
User_Password char(20)
)

-------2.2-------

alter table Associate_Status add Batch_Id char(20) constraint batch_id foreign key references Batch_info(Batch_Id)


alter table Associate_Status add Trainer_Id char(20) constraint trainer_id foreign key references Trainer_Info(Trainer_Id)

alter table Associate_Status alter column Start_Date date

alter table Associate_Status alter column End_Date date

------2.4------

update Trainer_Info set Trainer_Password = 'nn4@123' where Trainer_Id = 'F004';

-------2.5------

drop table Associate_Status  Where 'A003,J2EE,B004,F004,2005-12-1,2005-12-25'

-------2.6--------

select top  5 *from Trainer_Info where Trainer_Experience >= 9

------2.9-------

drop table Login_Details


