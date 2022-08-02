

using UnityEngine;
using System.Collections;
using Games.GlobeDefine;
using Games.LogicObj;

namespace Games.AI_Logic
{/// <summary>
 ///  客户端战斗AI
 /// </summary>
    public class AI_BaseCombat : BaseAI
    {
        public AI_BaseCombat()
        {
            m_AIType = CharacterDefine.AI_TYPE.AI_TYPE_COMBAT;
            AIStateType = CharacterDefine.AI_STATE_TYPE.AI_STATE_COMBAT;
        }
      

        //void Start()
        //{
          
        //}

        public override void UpdateAI()
        {
            base.UpdateAI();
           
           

            
        }
    }
}
