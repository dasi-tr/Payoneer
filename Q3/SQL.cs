using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HadassaGoodman.Q3
{
    class SQL
    {
        /*
        select  max(Score), PlayerId
        from Game_tbl       
        group by PlayerID
      */


        /*
        select p.playername
        from playerTable p left join gameTable g on g.playerid = p.playerid
        where g.playerid=null
         */


        /*
        select  PlayerId
        from Game_tbl
        group by PlayerID
        where sum(Score)>100
        */

    }
}
