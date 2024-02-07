

--
/*Tests
testid
testdate
duration
designedby
approvedby


Testpapers
Testpaperid
skillid

Questions
Qestionid
correctAnswerid


Answers
Answerid
Title

TestResult
TestresultId
TestId
empid



Skills:
	skillId
	Title
		1	java
		2	CSharp
		3	mysql
		4	python

SkillSetRating:
	skillratingid
	empid
	skillid
	rating
		1	23	1	7
		2	23	2	8
		3	21	1	8
		
Employees
	empid
	firstname
	lastname
	contactnumber
	emailid
*/

CREATE DATABASE assesmentdb;

use assesmentdb; 

CREATE TABLE
    employee(
        id INT AUTO_INCREMENT PRIMARY KEY,
        fname VARCHAR(20) NOT NULL,
	    lname VARCHAR(20) NOT NULL,
	   email VARCHAR(50) NOT NULL,
	   contactno VARCHAR(10) NOT NULL,
       
    );

INSERT INTO employee(fname,lname,email,contactno) VALUES ('Shreedhar','Patil','spatil@gmail.com', '9876543210');
INSERT INTO employee(fname,lname,email,contactno) VALUES ('Bhupendra','Walhekar','bwalhekar@gmail.com', '9876579210');
INSERT INTO employee(fname,lname,email,contactno) VALUES ('Yash','Patil','ypatil@gmail.com', '9876543999');
INSERT INTO employee(fname,lname,email,contactno) VALUES ('Yogesh','Pagar','ypagar@gmail.com', '9876547777');


CREATE TABLE
    Skill(
          SkillId INT PRIMARY KEY AUTO_INCREMENT,
		  Title varchar(20)
	    
    );
INSERT INTO Skill(Title) VALUES ("Java");
INSERT INTO Skill(Title) VALUES ("DotNet");
INSERT INTO Skill(Title) VALUES ("SQL");
INSERT INTO Skill(Title) VALUES ("Python");	


CREATE TABLE
    SkillSetRating(
          SkillRatingId int PRIMARY KEY AUTO_INCREMENT,
		  EmployeeID int,
		  SkillID int,
		  Rating int check (Rating<=10),
		  CONSTRAINT EmployeeID FOREIGN KEY(EmployeeID) REFERENCES employee(id),
		  CONSTRAINT SkillID FOREIGN KEY(SkillID) REFERENCES Skill(SkillId)
	      
    );
	
INSERT INTO SkillSetRating(EmployeeID,SkillID,Rating) VALUES (1,4,10);
INSERT INTO SkillSetRating(EmployeeID,SkillID,Rating) VALUES (2,2,9);
INSERT INTO SkillSetRating(EmployeeID,SkillID,Rating) VALUES (3,3,8);
INSERT INTO SkillSetRating(EmployeeID,SkillID,Rating) VALUES (1,2,5);



select employee.fname, Skill.Title, SkillSetRating.Rating
from employee,Skill,SkillSetRating
where employee.id=SkillSetRating.employeeid and Skill.Title="Java";

	
	

CONSTRAINT EmployeeID FOREIGN KEY(EmployeeID) REFERENCES employee(id) 
--Condition Query:

------------------------------------------------------------------------------------------------------------
*Evaulator*-> Portal -> Login -> Online Exam -> Technology ->FrontEnd ->(Exam Conduction)javascript,React,Angular
                               ->Fresher Criteria                     ->BackEnd  ->Spring boot,Hybernet,.NETWORK 
                                                                      ->Full Stack-> All
		       Rating->Technical
		             ->Communication
			         ->Verdict
			         ->Goals,Approch to Client,Learning,Leadership,Work ethics,team work,innovation
					 
*Candidate* -> Portal -> Login -> Technical Round -> Feedback
                    -> Internal
					-> External
---------------------------------------------------------------------------------------------------------------					
*Required Tables*
Evaulator (EvaulatorId,Emp.Name,Emp.Designation,EmpIdFk,SubjectIdFk)
Candidate (CandidateId,Emp.Name,Emp.Designation,Emp.JoinDate,Experince,EmpId)

Javscript (QustionId,Qustion,Option 1,Option2,Option3,Option4,Correct Answer)
React     (QustionId,Qustion,Option 1,Option2,Option3,Option4,Correct Answer)
Angular   (QustionId,Qustion,Option 1,Option2,Option3,Option4,Correct Answer)
DotNet    (QustionId,Qustion,Option 1,Option2,Option3,Option4,Correct Answer)
Qustion Bank (QBankId,QustionIdFk,SelectedAnswer)
Candidate Performance (CPId,Marks,QBankIdFk,QustionIdFk)



