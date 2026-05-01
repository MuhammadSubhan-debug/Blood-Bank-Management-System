use BBSM
create table Users(FullName varchar(max),city varchar(50),age int,Password varchar(50),gender varchar(6),email varchar(max),
cnic varchar(15), userId int primary key identity(1,1),bloodGroup varchar(3))
ALTER TABLE Users
ADD IsVerified varchar(5) NOT NULL DEFAULT 'false';
ALTER TABLE Users
ADD Role varchar(5) NOT NULL DEFAULT 'user';
ALTER TABLE Users
ADD Path varchar(max)   DEFAULT 'no image';
ALTER TABLE Users
ADD isActive varchar(max)   DEFAULT 'active';


  CREATE TABLE DonationAppointment
    (
        AppointmentId INT IDENTITY(1,1) PRIMARY KEY,
        UserId INT NOT NULL,
        AppointmentDate DATETIME NOT NULL,
        AdditionalRemarks VARCHAR(MAX),
        Status VARCHAR(20) DEFAULT 'Pending',

        FOREIGN KEY (UserId) REFERENCES Users(UserId)
    );
    ALTER TABLE Users
ADD LastDonationDate DATETIME NULL;

CREATE TABLE BloodRequest
(
    RequestId INT IDENTITY(1,1) PRIMARY KEY,

    FromUserId INT NOT NULL,

    RequestDate DATETIME NOT NULL,
    NeedDate DATETIME NOT NULL,

    UnitsRequested INT NOT NULL,
    UnitsAssigned INT DEFAULT 0,

    Condition NVARCHAR(100),
    Status NVARCHAR(50),

    CONSTRAINT FK_BloodRequest_User
        FOREIGN KEY (FromUserId)
        REFERENCES Users(UserId)
);
ALTER TABLE BloodRequest ADD BloodGroup VARCHAR(5)

CREATE TABLE BloodUnit
(
    BloodUnitId INT IDENTITY(1,1) PRIMARY KEY,

    DonorId INT NOT NULL,                -- FK to Users
    BloodGroup VARCHAR(3) NOT NULL,     

    CollectionDate DATETIME NOT NULL,
  

    Status VARCHAR(20) DEFAULT 'Testing',  -- Available / Used / Expired

    CONSTRAINT FK_BloodUnit_Donor
        FOREIGN KEY (DonorId)
        REFERENCES Users(UserId)
);

CREATE VIEW Inventory AS
SELECT bg.BloodGroup,
       COUNT(b.BloodUnitId) AS AvailableUnits
FROM (VALUES 
    ('A+'), ('A-'), ('B+'), ('B-'),
    ('AB+'), ('AB-'), ('O+'), ('O-')
) AS bg(BloodGroup)
LEFT JOIN BloodUnit b 
    ON bg.BloodGroup = b.BloodGroup 
    AND b.Status = 'Available'
GROUP BY bg.BloodGroup; 

CREATE TABLE BloodAssignment (
    AssignmentId INT IDENTITY(1,1) PRIMARY KEY,
    RequestId INT NOT NULL,
    BloodUnitId INT NOT NULL,
    AssignedDate DATETIME DEFAULT GETDATE(),
   

    FOREIGN KEY (RequestId) REFERENCES BloodRequest(RequestId),
    FOREIGN KEY (BloodUnitId) REFERENCES BloodUnit(BloodUnitId)
);

SELECT 
    BloodGroup,
    COUNT(*) AS TotalUnits
FROM BloodUnit
WHERE Status <> 'Testing'
GROUP BY BloodGroup;


update DonationAppointment set Status='Pending' where AppointmentId = 4


update BloodUnit set Status='Available' where donorid in (5,7)



delete from users where userId=10


    select * from users

select * from BloodUnit

update Users set isActive='active' where userId = 1
 
 update users set IsVerified= 'false' where userid = 

delete from BloodUnit where DonorId=10

select * from BloodRequest where Condition='Emergency'
 
select fullname,users.bloodgroup,userid from users join BloodRequest on users.userId=BloodRequest.FromUserId

select fullname from Users join BloodUnit on users.userId=BloodUnit.DonorId

select Fullname , age , appointmentDate from users u join donationappointment d on u.userid=d.userid

select * from DonationAppointment

select * from BloodUnit

select * from users 

select * from Inventory

select * from BloodAssignment

update BloodUnit set Status=''

update users set isactive ='Active' where userId =5












------------Admin
--  Insert into users(FullName,city,age,Password,gender,email,cnic,bloodGroup,IsVerified,Role)
-- values ('Muhammad Subhan','Rawalpindi',19,'Muhammad@1','Male','msk2224656@gmail.com','37405-4965680-1','AB+','true','admin')