﻿drop table Players
create table Players
(
  id int,
  coach_id int, 
  first_name varchar(255),
  last_name varchar(255),
  country varchar(3),
  date_of_birth date,
  height int,
  weight int
)

ALTER TABLE table_name
--RENAME COLUMN old_name to new_name;

INSERT into players (first_name, last_name, country) values ('john','smith','usa')

select * from Players
where first_name = 'john'


delete Players where first_name = 'john'

delete Players 


INSERT INTO Players (id, coach_id, first_name, last_name, country, date_of_birth, height, weight)
VALUES
(1, 4, 'Bartosz', 'Kurek', 'POL', '1988-08-29', 209, 96),
(2, 5, 'Wilfredo', 'Leon', 'CUB', '1993-07-31', 202, 90),
(3, 3, 'Matt', 'Anderson', 'USA', '1987-04-18', 201, 100),
(4, 2, 'Maxim', 'Mikhaylov', 'RUS', '1988-03-19', 205, 98),
(5, 6, 'Facundo', 'Conte', 'ARG', '1989-05-28', 198, 90),
(6, 1, 'Earvin', 'Ngapeth', 'FRA', '1991-02-12', 194, 93),
(7, 7, 'Yuji', 'Nishida', 'JPN', '2000-10-30', 190, 80),
(8, 8, 'Lucas', 'Saatkamp', 'BRA', '1986-05-06', 207, 95),
(9, 9, 'Gyorgy', 'Grozer', 'HUN', '1984-11-27', 202, 102),
(10, 10, 'Tsvetan', 'Sokolov', 'BUL', '1989-12-31', 209, 102),
(11, 11, 'Ivan', 'Zaytsev', 'ITA', '1988-10-02', 202, 100),
(12, 12, 'Osmany', 'Juantorena', 'CUB', '1985-07-12', 200, 90),
(13, 13, 'Yuki', 'Ishikawa', 'JPN', '1995-05-31', 194, 80),
(14, 14, 'Michal', 'Kubiak', 'POL', '1988-02-23', 194, 88),
(15, 15, 'Simone', 'Giannelli', 'ITA', '1996-08-09', 202, 95),
(16, NULL, 'Bruno', 'Rezende', 'BRA', '1986-07-02', 185, 75),
(17, 17, 'Mattia', 'Candellaro', 'ITA', '1992-05-03', 205, 100);
