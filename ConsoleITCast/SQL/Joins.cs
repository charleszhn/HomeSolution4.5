﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleITCast.SQL
{
    class Joins
    {
        /*
         * 与union不同，这个是把列连接到一块
         * 当多个列在不同的表中，要跨表查询，可以使用inner join
         * select ×　from table as kkd inner join tables  as kkk where kkd.id=kkk.id 
         * left join 在左表中没有的在右表中显示的显示为null
         * select tbale1.*,table2.*,table3.* from table1 left outer join table2 on table1.id=table2.id
         * 右外链接
         * 表示要将right join 表中的数据全部显示，左表只显示那些匹配的数据
         * 
         * 交叉连接就是直接将两个表一块查询 select * from table 1，table2
         * 
         * 自连接
         * select * from t1 inner join  (select * from t1 where id>10)as tb1 where tb1.id=t1.id
         * 
         * 视图是一张虚拟表他表示一张表的部分数据或多张表的综合数据，其结构和数据是建立在对标的查询基础上
         * 视图在错做上和数据表没有什么区别，但两者的差异是本质不相同，数据表示实际存储记录的地方，然而视图并不保存任何记录
         */
    }
}
