﻿create view user_total
as
select 账号,昵称,财富,流水号,编号,购买时间,购买号码
from user_info,total
where user_info.账号=total.账号