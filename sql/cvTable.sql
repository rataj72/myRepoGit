drop table users;

create table Users(
id serial primary key,
name text,
password text,
language text,
age text,
experience text,
extraSkills text
);


insert into users(name,age) values ('sito','156');
insert into users(name,age) values ('jan','798');
insert into users(name,age) values ('ada','79');
insert into users(name,age) values ('hania','1');
insert into users(name,age) values ('sito','156');
insert into users(name,age) values ('jan','798');
insert into users(name,age) values ('ada','79');
insert into users(name,age) values ('hania','3');

select * from Users;
