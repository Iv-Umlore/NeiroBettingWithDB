ALTER PROCEDURE [football].DeleteSpace
AS
BEGIN

UPDATE [Matches].[football].[Comands] SET team_name = com.name , abbrevitions = com.abb
FROM (select id_team, RTRIM(team_name) as name, RTRIM(abbrevitions) as abb FROM [Matches].[football].[Comands]) as com
inner join [Matches].[football].[Comands] as com2
ON com2.id_team = com.id_team

UPDATE [Matches].[football].Tournament SET Tournament_name = com.name 
FROM (select id_Tournament, RTRIM(Tournament_name) as name FROM [Matches].[football].Tournament) as com
inner join [Matches].[football].Tournament as com2
ON com2.id_Tournament = com.id_Tournament

END
GO