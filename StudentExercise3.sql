INSERT INTO Student (firstName, lastName, slackHandle, cohortId)
VALUES ('Austin', 'Blade', 'thatbladeboy', 1 ),
		('Megan', 'Cruzen', 'mc', 1 ),
		('Brittany', 'Ramos-Janeway', 'brj', 1),
		('Mary', 'Remo', 'mremo', 1),
		('Madi', 'Peper', 'mspeper', 2),
		('Kayla', 'Reid', 'kaylareid', 2),
		('John', 'Wood', 'johnwood', 3)
;

SELECT * FROM Student;

INSERT INTO Student (firstName, lastName, slackHandle, cohortId)
VALUES ('Elyse', 'Dawson', 'elysedawson', 3);

SELECT * FROM Instructor;

INSERT INTO Instructor (firstName, lastName, slackHandle, cohortId)
VALUES ('Andy', 'Collins', 'andyc', 1 ),
		('Jisie', 'David', 'jisiedavid', 2 ),
		('Brenda', 'Long', 'brendalong', 3),
		('Steve', 'Brownlee', 'sbrownlee', 4)
;

SELECT * FROM Exercise;

INSERT INTO AssignedExercise(studentId, exerciseId)
VALUES  (5,3),
		(5,2),
		(6,1),
		(6,4),
		(7,1),
		(7,2),
		(8,1),
		(8,2),
		(9,1),
		(9,3),
		(10,2),
		(10,1);

		SELECT * FROM Student;
		SELECT * FROM Exercise;
		SELECT * FROM Cohort;
		SELECT * FROM Instructor;
		SELECT * FROM AssignedExercise;


