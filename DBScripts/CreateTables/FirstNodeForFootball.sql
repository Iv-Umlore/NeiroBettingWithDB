
insert into Matches.football.Tournament (Tournament_name, Tournament_size) Values ('Евро 2020. Квалификации',1) 

 insert into [Matches].[football].[Comands] (abbrevitions,team_name,tier_team,team_point) VALUES
('Ru','Russia',4,0),
('Ua','Ukrain',4,0),
('СанМар','Сан-Марино',20,0),
('Исп','Испания',3,0),
('Shve','Швеция',5,0)

insert into [Matches].[football].PastMatches ([Team-A],[Team-B],[Score-A],[Score-B],[Important-A],[Important-B],[Violations-A],[Violations-B],[shot_on_target-A],[shot_on_target-B],[save-A],[save-B],tournament,is_ready_for_learning,[replacements-A],[replacements-B],match_date)
VALUES (5,4,1,1,1,2,3,3,7,6,5,6,1,0,0,0,'20191015')