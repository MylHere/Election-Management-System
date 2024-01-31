USE [Election Management System]
-- Parties table
CREATE TABLE Parties (
    PartyID INT PRIMARY KEY,
    PartyName VARCHAR(100),
    Symbol VARCHAR(50),
    FoundedDate DATE,
    Leader VARCHAR(100)
);

-- Users table
CREATE TABLE Users (
    UserID INT PRIMARY KEY,
    Username VARCHAR(50),
    Password VARCHAR(255),
    UserType VARCHAR(20),
    ElectionID INT,
    FOREIGN KEY (ElectionID) REFERENCES Elections(ElectionID)
);

-- Elections table
CREATE TABLE Elections (
    ElectionID INT PRIMARY KEY,
    ElectionName VARCHAR(100),
    ElectionDate DATE,
    ElectionType VARCHAR(50),
    Status VARCHAR(20)
);

-- Voters table
CREATE TABLE Voters (
    VoterID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DateOfBirth DATE,
    Address VARCHAR(255),
    ContactNumber VARCHAR(15),
    VoterCardNumber VARCHAR(20) UNIQUE
);

-- Candidates table
CREATE TABLE Candidates (
    CandidateID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DateOfBirth DATE,
    Address VARCHAR(255),
    ContactNumber VARCHAR(15),
    PartyAffiliation VARCHAR(50),
	PartyID INT,
    ElectionID INT,
    FOREIGN KEY (PartyID) REFERENCES Parties(PartyID),
    FOREIGN KEY (ElectionID) REFERENCES Elections(ElectionID) );


-- Ballots table
CREATE TABLE Ballots (
    BallotID INT PRIMARY KEY,
    ElectionID INT,
    CandidateID INT,
    Position VARCHAR(50),
    VotesReceived INT,
    FOREIGN KEY (ElectionID) REFERENCES Elections(ElectionID),
    FOREIGN KEY (CandidateID) REFERENCES Candidates(CandidateID)
);

-- PollingStations table
CREATE TABLE PollingStations (
    StationID INT PRIMARY KEY,
    StationName VARCHAR(100),
    Location VARCHAR(255),
    ElectionID INT,
    FOREIGN KEY (ElectionID) REFERENCES Elections(ElectionID)
);

-- Results table
CREATE TABLE Results (
    ResultID INT PRIMARY KEY,
    ElectionID INT,
    CandidateID INT,
    VotesReceived INT,
    Position VARCHAR(50),
    Winner BIT,
    FOREIGN KEY (ElectionID) REFERENCES Elections(ElectionID),
    FOREIGN KEY (CandidateID) REFERENCES Candidates(CandidateID));

-- AuditTrail table
CREATE TABLE AuditTrail (
    AuditID INT PRIMARY KEY,
    UserID INT,
    Action VARCHAR(255),
    ActionDate DATETIME,
    ActionDetails VARCHAR(255),
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

-- ElectionOfficers table
CREATE TABLE ElectionOfficers (
    OfficerID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    ContactNumber VARCHAR(15),
    ElectionID INT,
    FOREIGN KEY (ElectionID) REFERENCES Elections(ElectionID)
);

-- Nominations table
CREATE TABLE Nominations (
    NominationID INT PRIMARY KEY,
    CandidateID INT,
    ElectionID INT,
    Position VARCHAR(20), 
    FOREIGN KEY (CandidateID) REFERENCES Candidates(CandidateID),
    FOREIGN KEY (ElectionID) REFERENCES Elections(ElectionID)
);

-- VoterAuthentication table
CREATE TABLE VoterAuthentication (
    AuthenticationID INT PRIMARY KEY,
    VoterID INT,
    ElectionID INT,
    Authenticated BIT, 
    AuthDate DATETIME, 
    FOREIGN KEY (VoterID) REFERENCES Voters(VoterID),
    FOREIGN KEY (ElectionID) REFERENCES Elections(ElectionID)
);


-- CandidatesNominatedPositions table
CREATE TABLE CandidatesNominatedPositions (
    NominationPositionID INT PRIMARY KEY,
    CandidateID INT,
    ElectionID INT,
    Position VARCHAR(50),
    FOREIGN KEY (CandidateID) REFERENCES Candidates(CandidateID),
    FOREIGN KEY (ElectionID) REFERENCES Elections(ElectionID)
);

-- ElectionIssues table
CREATE TABLE ElectionIssues (
    IssueID INT PRIMARY KEY,
    ElectionID INT,
    IssueDescription VARCHAR(255),
    IssueDate DATE,
    Status VARCHAR(20),
    FOREIGN KEY (ElectionID) REFERENCES Elections(ElectionID)
);
