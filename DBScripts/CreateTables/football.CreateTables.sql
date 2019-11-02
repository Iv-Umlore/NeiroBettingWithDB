BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT

CREATE TABLE football.Tournament
	(
	id_Tournament numeric(38, 0) NOT NULL IDENTITY (1, 1),
	Tournament_name nvarchar(50) NOT NULL,
	Tournament_size smallint NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE football.Tournament ADD CONSTRAINT
	PK_Tournament PRIMARY KEY CLUSTERED 
	(
	id_Tournament
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE football.Tournament SET (LOCK_ESCALATION = TABLE)
GO

CREATE TABLE football.Comands
	(
	id_team numeric(38, 0) NOT NULL IDENTITY (1, 1),
	abbrevitions nvarchar(6) NOT NULL,
	team_name nvarchar(50) NOT NULL,
	tier_team smallint NOT NULL,
	team_point int NOT NULL 
	)  ON [PRIMARY]
GO
ALTER TABLE football.Comands ADD CONSTRAINT
	PK_Comands PRIMARY KEY CLUSTERED 
	(
	id_team
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE football.Comands SET (LOCK_ESCALATION = TABLE)
GO

CREATE TABLE football.PastMatches
	(
	id_match numeric(38, 0) NOT NULL IDENTITY (1, 1),
	[Team-A] numeric(38,0) NOT NULL,
	[Team-B] numeric(38,0) NOT NULL,
	[Score-A] smallint NOT NULL,
	[Score-B] smallint NOT NULL,
	[Important-A] smallint NOT NULL,
	[Important-B] smallint NOT NULL,
	[Violations-A] smallint NOT NULL,
	[Violations-B] smallint NOT NULL,
	[shot_on_target-A] smallint NOT NULL,
	[shot_on_target-B] smallint NOT NULL,
	[save-A] smallint NOT NULL,
	[save-B] smallint NOT NULL,
	tournament numeric(38,0) NOT NULL,
	is_ready_for_learning bit NOT NULL,
	[replacements-A] smallint NOT NULL,
	[replacements-B] smallint NOT NULL,
	match_date date NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE football.PastMatches ADD CONSTRAINT
	PK_PastMatches PRIMARY KEY CLUSTERED 
	(
	id_match
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE football.PastMatches SET (LOCK_ESCALATION = TABLE)
GO

ALTER TABLE football.PastMatches
ADD CONSTRAINT FK_TeamA FOREIGN KEY([Team-A]) REFERENCES football.Comands(id_team)
ON DELETE CASCADE
ON UPDATE CASCADE
GO

/*ALTER TABLE football.PastMatches
ADD CONSTRAINT FK_TeamB FOREIGN KEY([Team-B]) REFERENCES football.Comands(id_team)
ON UPDATE CASCADE
GO*/

ALTER TABLE football.PastMatches
ADD CONSTRAINT FK_Tournament FOREIGN KEY(tournament) REFERENCES football.Tournament(id_Tournament)
ON DELETE CASCADE
ON UPDATE CASCADE
GO

CREATE TABLE football.WaitResults
	(
	id_game numeric(38, 0) NOT NULL IDENTITY (1, 1),
	[Team-A] numeric(38,0) NOT NULL,
	[Team-B] numeric(38,0) NOT NULL,
	tournament numeric(38,0) NOT NULL,
	[replacements-A] int NOT NULL,
	[replacements-B] int NOT NULL,
	[important-A] int NOT NULL,
	[important-B] int NOT NULL,
	[prediction] nvarchar(30) NULL,
	[date] date NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE football.WaitResults ADD CONSTRAINT
	PK_WaitResults PRIMARY KEY CLUSTERED 
	(
	id_game
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE football.WaitResults SET (LOCK_ESCALATION = TABLE)
GO

ALTER TABLE football.WaitResults
ADD CONSTRAINT FK_WR_A FOREIGN KEY([Team-A]) REFERENCES football.Comands(id_team)
ON DELETE CASCADE
ON UPDATE CASCADE
GO

/*ALTER TABLE football.WaitResults
ADD CONSTRAINT FK_WR_B FOREIGN KEY([Team-B]) REFERENCES football.Comands(id_team)
ON DELETE CASCADE
ON UPDATE CASCADE
GO*/

ALTER TABLE football.WaitResults
ADD CONSTRAINT FK_WR_Tournament FOREIGN KEY(tournament) REFERENCES football.Tournament(id_Tournament)
ON DELETE CASCADE
ON UPDATE CASCADE
GO
