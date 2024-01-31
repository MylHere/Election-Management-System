--USE [Election Management System]
--INSERT INTO Parties (PartyID, PartyName, Symbol, FoundedDate, Leader)
--VALUES
--    (1, 'PMLN', 'Lion', '1993', 'Nawaz Sharif'),
--    (2, 'PTI', 'Bat', '1996', 'Imran Khan'),
--    (3, 'PPP', 'Arrow', '1967', 'Bilawal Bhutto'),
--    (4, 'MQM', 'Kite', '1984', 'Khalid Maqbool'),
--    (5, 'PMLQ', 'Cycle', '2002', 'Shujat Hussain'),
--    (6, 'JUI-F', 'Pen', '1980', 'Maulana Fazal-ur-Rehman'),
--    (7, 'ANP', 'Lantern', '1986', 'Asfandyar Wali Khan'),
--    (8, 'BAP', 'Mountain', '2018', 'Jam Kamal Khan'),
--    (9, 'TLP', 'Crane', '2015', 'Allama Khadim Hussain Rizvi'),
--    (10, 'GDA', 'Hand Pump', '2018', 'Pir of Pagaro'),
--    (11, 'MMA', 'Book', '2002', 'Fazal-ur-Rehman'),
--    (12, 'PSP', 'Dolphin', '2016', 'Mustafa Kamal');


--INSERT INTO Voters (VoterID, FirstName, LastName, DateOfBirth, Address, ContactNumber, VoterCardNumber)
--VALUES
--    (1, 'Mohammad', 'Ali', '1988-02-15', 'Lahore, Punjab', '+92 300 1234567', 'V1'),
--    (2, 'Fatima', 'Khan', '1990-05-20', 'Karachi, Sindh', '+92 321 2345678', 'V2'),
--    (3, 'Ahmed', 'Raza', '1985-09-10', 'Islamabad', '+92 333 3456789', 'V3'),
--    (4, 'Aisha', 'Hassan', '1993-04-25', 'Quetta, Balochistan', '+92 311 4567890', 'V4'),
--    (5, 'Farhan', 'Malik', '1980-07-12', 'Rawalpindi, Punjab', '+92 300 5678901', 'V5'),
--    (6, 'Nadia', 'Bashir', '1986-01-30', 'Multan, Punjab', '+92 321 6789012', 'V6'),
--    (7, 'Bilal', 'Hussain', '1995-03-18', 'Faisalabad, Punjab', '+92 333 7890123', 'V7'),
--    (8, 'Sara', 'Ahmed', '1982-11-05', 'Sialkot, Punjab', '+92 311 8901234', 'v8'),
--    (9, 'Kamran', 'Fatima', '1991-08-22', 'Hyderabad, Sindh', '+92 300 0123456', 'v9'),
--    (10, 'Fariha', 'Iqbal', '1989-06-17', 'Peshawar, KPK', '+92 321 1234567', 'V10'),
--    (11, 'Imran', 'Yousaf', '1984-12-08', 'Gujranwala, Punjab', '+92 333 2345678', 'V11'),
--    (12, 'Noreen', 'Akhtar', '1992-10-03', 'Larkana, Sindh', '+92 311 3456789', 'V12'),
--    (13, 'Asad', 'Sultan', '1987-09-15', 'Sargodha, Punjab', '+92 300 4567890', 'V13'),
--    (14, 'Sadia', 'Riaz', '1998-04-20', 'Bahawalpur, Punjab', '+92 321 5678901', 'V38'),
--    (15, 'Waqar', 'Ameen', '1981-05-26', 'Gujrat, Punjab', '+92 333 6789012', 'V23'),
--    (16, 'Tahira', 'Bibi', '1983-02-09', 'Abbottabad, KPK', '+92 311 7890123', 'V29'),
--    (17, 'Usman', 'Khalid', '1994-07-14', 'Mirpur, Azad Kashmir', '+92 300 0123456', 'V124'),
--    (18, 'Rukhsar', 'Malik', '1986-11-28', 'Mardan, KPK', '+92 321 1234567', 'V`7'),
--    (19, 'Irfan', 'Sadiq', '1990-03-05', 'Jhang, Punjab', '+92 333 2345678', 'V116'),
--    (20, 'Mehak', 'Imran', '1993-12-18', 'Kohat, KPK', '+92 311 3456789', 'V112'),
--    (21, 'Adnan', 'Khan', '1989-08-22', 'Okara, Punjab', '+92 300 4567890', 'V100'),
--    (22, 'Shabnam', 'Iqbal', '1985-04-20', 'Sukkur, Sindh', '+92 321 5678901', 'V18'),
--    (23, 'Babar', 'Hassan', '1997-01-15', 'Khuzdar, Balochistan', '+92 333 6789012', 'V15'),
--    (24, 'Rafia', 'Khan', '1982-06-09', 'Chiniot, Punjab', '+92 311 7890123', 'V19'),
--    (25, 'Arif', 'Saeed', '1988-10-24', 'Muzaffarabad, Azad Kashmir', '+92 300 0123456', 'V14');

--INSERT INTO Elections (ElectionID, ElectionName, ElectionDate, ElectionType, Status)
--VALUES
--    (1, 'General Election 2024', '2024-01-15', 'General', 'Upcoming'),
--    (2, 'Local Election 2024', '2024-08-15', 'Local', 'Ongoing');


--INSERT INTO Candidates (CandidateID, FirstName, LastName, DateOfBirth, Address, ContactNumber, PartyAffiliation,PartyID, ElectionID)
--VALUES
--    (1, 'Nasir', 'Khan', '1975-12-10', 'Rawalpindi, Punjab', '+92 333 1112233', 'PMLN',1, 1),
--    (2, 'Sana', 'Ahmed', '1980-07-05', 'Faisalabad, Punjab', '+92 300 2233445', 'PTI',2, 1),
--    (3, 'Zahra', 'Riaz', '1988-03-20', 'Larkana, Sindh', '+92 321 3344556', 'PPP',3, 1),
--    (4, 'Usman', 'Farooq', '1982-06-15', 'Multan, Punjab', '+92 311 4455667', 'MQM',4, 1),
--    (5, 'Ayesha', 'Malik', '1985-01-22', 'Islamabad', '+92 333 5566778', 'PMLQ',5, 1),
--    (6, 'Irfan', 'Hussain','1982-04-12', 'Lahore, Punjab', '+92 321 6677889', 'PMLN',1, 1),
--	(7, 'Sadia', 'Ali', '1987-04-12', 'Karachi, Sindh', '+92 321 6677889', 'ANP',7, 1),
--    (8, 'Ahmed', 'Khan', '1983-09-05', 'Hyderabad, Sindh', '+92 311 7788990', 'BAP',8, 1),
--    (9, 'Zainab', 'Rashid', '1990-11-18', 'Quetta, Balochistan', '+92 300 8899001', 'TLP',9, 1),
--    (10, 'Faisal', 'Akram', '1986-07-27', 'Gujranwala, Punjab', '+92 321 9900112', 'GDA',10, 1),
--    (11, 'Naima', 'Mumtaz', '1992-02-15', 'Sialkot, Punjab', '+92 333 0011223', 'MMA',11, 1),
--    (12, 'Salman', 'Iqbal', '1989-05-30', 'Sukkur, Sindh', '+92 311 1122334', 'PSP',12, 1),
--    (13, 'Ayesha', 'Yousaf', '1985-08-22', 'Lahore, Punjab', '+92 300 2233445', 'PMLN',1, 1),
--    (14, 'Zubair', 'Malik', '1980-04-20', 'Karachi, Sindh', '+92 321 3344556', 'PTI',2, 1),
--    (15, 'Rukhsar', 'Riaz', '1995-11-15', 'Islamabad', '+92 311 4455667', 'PPP',3, 1),
--    (16, 'Ali', 'Farooq', '1982-06-10', 'Multan, Punjab', '+92 333 5566778', 'MQM',4, 1),
--    (17, 'Saima', 'Khalid', '1987-01-12', 'Faisalabad, Punjab', '+92 300 6677889', 'PMLQ',5, 1),
--    (18, 'Yasir', 'Hussain', '1984-09-25', 'Sargodha, Punjab', '+92 321 7788990', 'ANP',7, 1),
--    (19, 'Hina', 'Rashid', '1993-12-18', 'Quetta, Balochistan', '+92 311 8899001', 'BAP',8, 1),
--    (20, 'Kamran', 'Akram', '1988-07-27', 'Gujranwala, Punjab', '+92 333 9900112', 'TLP',9, 1),
--    (21, 'Rabia', 'Iqbal', '1986-05-30', 'Hyderabad, Sindh', '+92 300 0011223', 'GDA',10, 1),
--    (22, 'Arsalan', 'Mumtaz', '1991-08-22', 'Sukkur, Sindh', '+92 321 1122334', 'MMA',11, 1),
--    (23, 'Sadia', 'Iqbal', '1985-04-20', 'Lahore, Punjab', '+92 311 2233445', 'PSP',12, 1),
--    (24, 'Ahmed', 'Malik', '1980-11-15', 'Karachi, Sindh', '+92 300 3344556', 'PMLN',1, 1),
--    (25, 'Zahra', 'Riaz', '1982-06-10', 'Islamabad', '+92 321 4455667', 'PTI',2, 1);


--INSERT INTO Results (ResultID, ElectionID, CandidateID, VotesReceived, Position, Winner)
--VALUES
--    (1, 1, 1, 1200, 'Prime Minister', 1), 
--    (2, 1, 2, 1100, 'Prime Minister', 0),
--    (3, 1, 3, 1000, 'Prime Minister', 0),
--    (4, 1, 4, 800, 'Prime Minister', 0),
--    (5, 1, 5, 950, 'Prime Minister', 0),
--    (6, 1, 6, 850, 'MPA', 1),
--    (7, 1, 7, 350, 'MPA', 0),
--    (8, 1, 8, 300, 'MPA', 0),
--    (9, 1, 9, 250, 'MPA', 0),
--    (10, 1, 10, 50, 'MPA', 0),
--    (11, 1, 11, 450, 'MPA', 0),
--    (12, 1, 12, 400, 'MPA', 0),
--    (13, 1, 13, 800, 'MPA', 1),
--    (14, 1, 14, 600, 'MPA', 1),
--    (15, 1, 15, 550, 'MPA', 1),
--    (16, 1, 16, 240, 'MPA', 1),
--    (17, 1, 17, 530, 'MPA', 1),
--    (18, 1, 18, 100, 'MPA', 0),
--    (19, 1, 19, 50, 'MPA', 0),
--    (20, 1, 20, 25, 'MPA', 0),
--    (21, 1, 21, 20, 'MPA', 0),
--    (22, 1, 22, 15, 'MPA', 0),
--    (23, 1, 23, 10, 'MPA', 0),
--    (24, 1, 24, 500, 'MPA', 1),
--    (25, 1, 25, 430, 'MPA', 1);

--INSERT INTO Users (UserID, Username, Password, UserType, ElectionID)
--VALUES
--    (1, 'Ahmed Ch', 'admin123', 'Admin',1),
--    (2, 'M. Ali', 'officer123', 'Election Officer',1),
--    (3, 'Saleem Dar', 'clerk456', 'Data Entry Clerk',1),
--    (4, 'Usman Khan', 'monitor789', 'Monitoring Staff',1);



--INSERT INTO VoterAuthentication (AuthenticationID, VoterID, ElectionID, Authenticated, AuthDate)
--VALUES
--    (1, 1, 1, 1, '2024-01-15 12:00:00'),  -- VoterID 1 authenticated for ElectionID 1
--    (2, 2, 1, 1, '2024-01-15 13:00:00'),  -- VoterID 2 authenticated for ElectionID 1
--    (3, 3, 1, 0, '2024-01-15 14:00:00'),  -- VoterID 3 not authenticated for ElectionID 1
--    (4, 4, 1, 1, '2024-01-15 15:00:00'),  -- VoterID 4 authenticated for ElectionID 1
--    (5, 5, 1, 1, '2024-01-15 16:00:00'),  -- VoterID 5 authenticated for ElectionID 1
--    (6, 6, 1, 0, '2024-01-15 17:00:00'),  -- VoterID 6 not authenticated for ElectionID 1
--    (7, 7, 1, 1, '2024-01-15 18:00:00'),  -- VoterID 7 authenticated for ElectionID 1
--    (8, 8, 1, 1, '2024-01-15 19:00:00'),  -- VoterID 8 authenticated for ElectionID 1
--    (9, 9, 1, 0, '2024-01-15 20:00:00'),  -- VoterID 9 not authenticated for ElectionID 1
--    (10, 10, 1, 1, '2024-01-15 21:00:00'), -- VoterID 10 authenticated for ElectionID 1
--    (11, 11, 1, 1, '2024-01-15 22:00:00'), -- VoterID 11 authenticated for ElectionID 1
--    (12, 12, 1, 0, '2024-01-15 23:00:00'), -- VoterID 12 not authenticated for ElectionID 1
--    (13, 13, 1, 1, '2024-01-16 01:00:00'), -- VoterID 13 authenticated for ElectionID 1
--    (14, 14, 1, 1, '2024-01-16 02:00:00'), -- VoterID 14 authenticated for ElectionID 1
--    (15, 15, 1, 0, '2024-01-16 03:00:00'), -- VoterID 15 not authenticated for ElectionID 1
--    (16, 16, 1, 1, '2024-01-16 04:00:00'), -- VoterID 16 authenticated for ElectionID 1
--    (17, 17, 1, 1, '2024-01-16 05:00:00'), -- VoterID 17 authenticated for ElectionID 1
--    (18, 18, 1, 0, '2024-01-16 06:00:00'), -- VoterID 18 not authenticated for ElectionID 1
--    (19, 19, 1, 1, '2024-01-16 07:00:00'), -- VoterID 19 authenticated for ElectionID 1
--    (20, 20, 1, 1, '2024-01-16 08:00:00'), -- VoterID 20 authenticated for ElectionID 1
--    (21, 21, 1, 0, '2024-01-16 09:00:00'), -- VoterID 21 not authenticated for ElectionID 1
--    (22, 22, 1, 1, '2024-01-16 10:00:00'), -- VoterID 22 authenticated for ElectionID 1
--    (23, 23, 1, 1, '2024-01-16 11:00:00'), -- VoterID 23 authenticated for ElectionID 1
--    (24, 24, 1, 0, '2024-01-16 12:00:00'), -- VoterID 24 not authenticated for ElectionID 1
--    (25, 25, 1, 1, '2024-01-16 13:00:00'); -- VoterID 25 authenticated for ElectionID 1
    


--INSERT INTO Nominations (NominationID, CandidateID, ElectionID, Position)
--VALUES
--    (1, 1, 1, 'Prime Minister'),  
--    (2, 2, 1, 'Prime Minister'),
--    (3, 3, 1, 'Prime Minister'),
--    (4, 4, 1, 'Prime Minister'),
--    (5, 5, 1, 'Prime Minister'),
--	(6, 6, 1, 'MPA'), 
--    (7, 7, 1, 'MPA'),
--    (8, 8, 1, 'MPA'),
--    (9, 9, 1, 'MPA'),
--    (10, 10, 1, 'MPA'),
--    (11, 11, 1, 'MPA'),
--    (12, 12, 1, 'MPA'),
--    (13, 13, 1, 'MPA'),
--	(14, 14, 1, 'MPA'),
--    (15, 15, 1, 'MPA'),
--    (16, 16, 1, 'MPA'),
--    (17, 17, 1, 'MPA'),
--    (18, 18, 1, 'MPA'), 
--    (19, 19, 1, 'MPA'),
--    (20, 20, 1, 'MPA'),
--    (21, 21, 1, 'MPA'),
--    (22, 22, 1, 'MPA'),
--    (23, 23, 1, 'MPA'),
--    (24, 24, 1, 'MPA'),
--    (25, 25, 1, 'MPA');



--INSERT INTO PollingStations (StationID, StationName, Location, ElectionID)
--VALUES
--    (1, 'Lahore Station', 'Urban', 1),
--    (2, 'Karachi Station', 'Urban', 1),
--    (3, 'Islamabad Station', 'Urban', 1),
--    (4, 'Peshawar Station', 'Rural', 1),
--    (5, 'Quetta Station', 'Rural', 1),
--	(6, 'Faisalabada Station', 'Urban', 1);
	


--INSERT INTO AuditTrail (AuditID, UserID, Action, ActionDate, ActionDetails)
--VALUES
--    (1, 1, 'Login', '2024-01-10 08:00:00', 'Admin login'),
--    (2, 2, 'CandidateRegistration', '2024-01-11 10:30:00', 'New candidate registration'),
--    (3, 3, 'Logout', '2024-01-12 12:15:00', 'User logout'),
--    (4, 4, 'VoteSubmission', '2024-01-13 14:45:00', 'Vote submitted'),
--    (5, 1, 'CandidateWithdrawal', '2024-01-14 16:20:00', 'Candidate withdrew application');



--INSERT INTO Ballots (BallotID, ElectionID, CandidateID, Position, VotesReceived)
--VALUES
--    (1, 1, 1, 'Prime Minister', 1200),
--    (2, 1, 2, 'Prime Minister', 1100),
--    (3, 1, 3, 'Prime Minister', 1000),
--    (4, 1, 4, 'Prime Minister', 800),
--    (5, 1, 5, 'Prime Minister', 950),
--    (6, 1, 6, 'MPA', 850),
--    (7, 1, 7, 'MPA', 350),
--    (8, 1, 8, 'MPA', 300),
--    (9, 1, 9, 'MPA', 250),
--    (10, 1, 10, 'MPA', 50),
--    (11, 1, 11, 'MPA', 450),
--    (12, 1, 12, 'MPA', 400),
--    (13, 1, 13, 'MPA', 800),
--    (14, 1, 14, 'MPA', 600),
--    (15, 1, 15, 'MPA', 550),
--    (16, 1, 16, 'MPA', 240),
--    (17, 1, 17, 'MPA', 530),
--    (18, 1, 18, 'MPA', 100),
--    (19, 1, 19, 'MPA', 50),
--    (20, 1, 20, 'MPA', 25),
--    (21, 1, 21, 'MPA', 20),
--    (22, 1, 22, 'MPA', 15),
--    (23, 1, 23, 'MPA', 10),
--    (24, 1, 24, 'MPA', 500),
--    (25, 1, 25, 'MPA', 430);


--INSERT INTO ElectionOfficers (OfficerID, FirstName, LastName, ContactNumber, ElectionID)
--VALUES
--    (1, 'Aisha', 'Khan', '0301-1234567', 1),
--    (2, 'Muhammad', 'Ali', '0312-2345678', 1),
--    (3, 'Fatima', 'Ahmed', '0321-3456789', 1),
--    (4, 'Usman', 'Malik', '0333-4567890', 1),
--    (5, 'Saima', 'Hussain', '0344-5678901', 1);
--CREATE TABLE [Election Management System].[dbo].[Nominations](
--    [NominationID] INT IDENTITY(1,1) PRIMARY KEY,
--    [CandidateID] INT,
--    [ElectionID] INT,
--    [Position] NVARCHAR(255),
    
--);


---- Insert nominations for Prime Minister, MPA, and MNA with automatically generated NominationID
--INSERT INTO [Election Management System].[dbo].[Nominations] ([CandidateID], [ElectionID], [Position])
--SELECT [CandidateID], 1, 'PM'
--FROM [Election Management System].[dbo].[Candidates]
--WHERE [ElectionID] = 1 AND [CandidateID] BETWEEN 1 AND 12
--UNION ALL
--SELECT [CandidateID], 1, 'MPA'
--FROM [Election Management System].[dbo].[Candidates]
--WHERE [ElectionID] = 1 AND [CandidateID] BETWEEN 13 AND 26
--UNION ALL
--SELECT [CandidateID], 1, 'MNA'
--FROM [Election Management System].[dbo].[Candidates]
--WHERE [ElectionID] = 1 AND [CandidateID] BETWEEN 27 AND 40;
CREATE PROCEDURE usp_IElection
    @ElectionID INT,
    @ElectionName NVARCHAR(255),
    @ElectionDate DATE,
    @ElectionType NVARCHAR(50),
    @Status NVARCHAR(50)
AS
BEGIN
    INSERT INTO Elections (ElectionID, ElectionName, ElectionDate, ElectionType, Status)
    VALUES (@ElectionID, @ElectionName, @ElectionDate, @ElectionType, @Status);
END

CREATE PROCEDURE usp_UElection
    @ElectionID INT,
    @ElectionName NVARCHAR(255),
    @ElectionDate DATE,
    @ElectionType NVARCHAR(50),
    @Status NVARCHAR(50)
AS
BEGIN
    UPDATE Elections
    SET ElectionName = @ElectionName,
        ElectionDate = @ElectionDate,
        ElectionType = @ElectionType,
        Status = @Status
    WHERE ElectionID = @ElectionID;
END

CREATE PROCEDURE usp_DElection
    @ElectionID INT
AS
BEGIN
    DELETE FROM Elections WHERE ElectionID = @ElectionID;
END
