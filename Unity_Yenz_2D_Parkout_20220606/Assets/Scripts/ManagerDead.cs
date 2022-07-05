using UnityEngine;



namespace Yen
{
/// <summary>
/// 死亡管理
/// </summary>

public class ManagerDead : MonoBehaviour
{

        [SerializeField, Header("目標名稱")]
        private string nameTarget = "面具";//角色物件名稱

        [SerializeField, Header("結束管理器")]
        private ManagerFinal managerfinal;

        [SerializeField, Header("CM攝影機控制物件")]//追蹤攝影機
        private GameObject goCM;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.name.Contains(nameTarget))
            {
                managerfinal.stringTitle = "挑戰失敗~";
                managerfinal.enabled = true;
                goCM.SetActive(false);//關閉攝影機
            }
        }




    }

}

