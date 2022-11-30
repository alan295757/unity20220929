using UnityEngine;

namespace JAY
{
    /// <summary>
    /// 玩家結束管理:死亡或過關
    /// </summary>
    public class PlayerFinal : MonoBehaviour
    {
        private void OnDestroy()
        {
            FinalManager.instance.GameOver("挑戰失敗!");
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            FinalManager.instance.GameOver("遊戲通過");
        }
    }
}
