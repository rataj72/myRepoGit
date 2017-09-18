drop table users;

create table Users(
id serial primary key,
Name text,
number text);

insert into users(name,number) values ('sito','111');
insert into users(name,number) values ('chmura','357');
insert into users(name,number) values ('arczi','986');
insert into users(name,number) values ('adi','5437');
select * from users;