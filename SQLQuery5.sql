create view user_total
as
select user_info.账号,user_info.昵称,财富,中奖号码,流水号,编号
from user_info,total
where user_info.账号=total.账号
