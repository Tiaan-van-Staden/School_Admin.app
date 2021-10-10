CREATE DATABASE StudentDB
go

USE StudentDB
GO

CREATE TABLE StudentInfo 
(
StudentID INT,
StudentNames VARCHAR(40), 
StudentImg IMAGE,
StudentDOB VARCHAR(50),
StudentGender VARCHAR(30),
StudentPhone VARCHAR(10),
StudentAddress VARCHAR(50),
ModuleCodes INT,
);

CREATE TABLE ModuleInfo
(
ModuleCodes INT, 
ModuleName VARCHAR(50),
ModuleDesc VARCHAR(100),
ModuleLinks VARCHAR(200) 
);





INSERT INTO StudentInfo (StudentID,StudentNames,StudentImg,StudentDOB,StudentGender,StudentPhone,StudentAddress,ModuleCodes) VALUES ('627','Lucien Van Wyk','D:\hdeff\OneDrive\Documents\GitHub\MilestonePRG282-class\PRG282_Project\PRG282_Project\Images\IDpic8.jpg','2001/03/12','Male','0876253849','18 Prion St Pretoria','111');
INSERT INTO StudentInfo (StudentID,StudentNames,StudentImg,StudentDOB,StudentGender,StudentPhone,StudentAddress,ModuleCodes) VALUES ('981','Elmar Jacobs','D:\hdeff\OneDrive\Documents\GitHub\MilestonePRG282-class\PRG282_Project\PRG282_Project\Images\IDpic1.jpg','2000/01/02','Male','0747738290','10 Apple St Cape Town','222');
INSERT INTO StudentInfo (StudentID,StudentNames,StudentImg,StudentDOB,StudentGender,StudentPhone,StudentAddress,ModuleCodes) VALUES ('123','Tiaan Van Staden','D:\hdeff\OneDrive\Documents\GitHub\MilestonePRG282-class\PRG282_Project\PRG282_Project\Images\IDpic5.jpg','1999/08/18','Male','0234629873','88 StJohn St Port Elizabeth', '333');
INSERT INTO StudentInfo (StudentID,StudentNames,StudentImg,StudentDOB,StudentGender,StudentPhone,StudentAddress,ModuleCodes) VALUES ('322','Christiaan Van Der Colff','D:\hdeff\OneDrive\Documents\GitHub\MilestonePRG282-class\PRG282_Project\PRG282_Project\Images\IDpic6.jpg','1998/09/11','Male','0989263748','21 Jump St Durban', '444');
INSERT INTO StudentInfo (StudentID,StudentNames,StudentImg,StudentDOB,StudentGender,StudentPhone,StudentAddress,ModuleCodes) VALUES ('333','Jannita Water','D:\hdeff\OneDrive\Documents\GitHub\MilestonePRG282-class\PRG282_Project\PRG282_Project\Images\IDpic2.jpg','1980/11/25','Female','0983462111','22 Jump St Durban', '555');
INSERT INTO StudentInfo (StudentID,StudentNames,StudentImg,StudentDOB,StudentGender,StudentPhone,StudentAddress,ModuleCodes) VALUES ('736','Janco Botha','D:\hdeff\OneDrive\Documents\GitHub\MilestonePRG282-class\PRG282_Project\PRG282_Project\Images\IDpic7.jpg','1992/08/18','Male','0712349101','92 Berry Ave Pretoria', '222');
INSERT INTO StudentInfo (StudentID,StudentNames,StudentImg,StudentDOB,StudentGender,StudentPhone,StudentAddress,ModuleCodes) VALUES ('109','Iana Kemp','D:\hdeff\OneDrive\Documents\GitHub\MilestonePRG282-class\PRG282_Project\PRG282_Project\Images\IDpic4.jpg','1988/01/25','Female','0413244567','128 Open St Port Elizabeth', '333');
INSERT INTO StudentInfo (StudentID,StudentNames,StudentImg,StudentDOB,StudentGender,StudentPhone,StudentAddress,ModuleCodes) VALUES ('110','Dan Jacob','D:\hdeff\OneDrive\Documents\GitHub\MilestonePRG282-class\PRG282_Project\PRG282_Project\Images\IDpic9.jpg','2004/09/09','Male','0845893048','111 Apple St Cape Town', '666');
INSERT INTO StudentInfo (StudentID,StudentNames,StudentImg,StudentDOB,StudentGender,StudentPhone,StudentAddress,ModuleCodes) VALUES ('291','Kwame Port','D:\hdeff\OneDrive\Documents\GitHub\MilestonePRG282-class\PRG282_Project\PRG282_Project\Images\IDpic3.jpg','2005/09/11','Female','0613172839','77 Candy St Durban','777');

INSERT INTO ModuleInfo (ModuleCodes, ModuleName, ModuleDesc, ModuleLinks) Values ('111','LPR281','Linear Programming','https://www.youtube.com/watch?v=dQw4w9WgXcQ');
INSERT INTO ModuleInfo (ModuleCodes, ModuleName, ModuleDesc, ModuleLinks) Values ('222','MAT281','Mathematics','https://www.youtube.com/watch?v=dQw4w9WgXcQ');
INSERT INTO ModuleInfo (ModuleCodes, ModuleName, ModuleDesc, ModuleLinks) Values ('333','STA281','Statistics','https://www.youtube.com/watch?v=dQw4w9WgXcQ');
INSERT INTO ModuleInfo (ModuleCodes, ModuleName, ModuleDesc, ModuleLinks) Values ('444','PRG282','Programming','https://www.youtube.com/watch?v=dQw4w9WgXcQ');
INSERT INTO ModuleInfo (ModuleCodes, ModuleName, ModuleDesc, ModuleLinks) Values ('555','INL101','Innovation and leadership','https://www.youtube.com/watch?v=dQw4w9WgXcQ');
INSERT INTO ModuleInfo (ModuleCodes, ModuleName, ModuleDesc, ModuleLinks) Values ('666','INF181','Information systems','https://www.youtube.com/watch?v=dQw4w9WgXcQ');
INSERT INTO ModuleInfo (ModuleCodes, ModuleName, ModuleDesc, ModuleLinks) Values ('777','COA181','Computer architecture','https://www.youtube.com/watch?v=dQw4w9WgXcQ');

SELECT * FROM StudentInfo
SELECT * FROM ModuleInfo


