using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server_Backend.Controllers
{
    public class AttackController : Controller
    {

        int playerAttack = 0;
        int enemyDefense = 0;

        int attackResult = 0;

        [HttpPost]
        [Route("api/[controller]/StartAttack/{playerID}/{enemyID}")]
        public IActionResult startAttack(string playerID, string enemyID)
        {
            //krijg stats van player
            playerAttack = Convert.ToInt32(playerID);
            //krijg stats van enemy
            enemyDefense = Convert.ToInt32(enemyID);
            DoAttack();

            return Ok(attackResult);
        }

        private void DoAttack()
        {
            int hp = 100;
            hp = hp - DamageToBeDealt(playerAttack, enemyDefense);
            attackResult = hp;
        }

        private int DamageToBeDealt(int attack, int defense)
        {
            var result = attack - defense;
            return result;
        }
    }
}
