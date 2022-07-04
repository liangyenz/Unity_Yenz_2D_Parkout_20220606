using UnityEngine;


namespace Yen
{

    /// <summary>
    /// 管理過關
    /// </summary>
public class ManagerPass : MonoBehaviour
{


        [SerializeField, Header("目標名稱")]
        private string nameTarget = "面具";//跟角色名稱一樣
        [SerializeField, Header("跑步系統")]
        private SystemRun systemrun;

        [SerializeField, Header("跳躍系統")]
        private SystemJump systemjump;

        [SerializeField, Header("結束管理器")]
        private ManagerFinal managerfinal;



        #region 其中一個物件有勾選 Is Trigger

        //兩個物件碰撞時執行一次
        private void OnTriggerEnter2D(Collider2D collision)
        {
            // print(collision.name);


            if (collision.name.Contains(nameTarget))//如果 碰撞物件的名稱 包含contains (面具)
            {
                systemrun.enabled = false; //關閉跑步系統
                systemjump.enabled = false;//關閉跳躍系統

                managerfinal.enabled = true;//啟動結束管理器
                managerfinal.stringTitle = "恭喜你過關~";
            }
        }

        //兩個物件碰撞離開時執行一次

        private void OnTriggerExit2D(Collider2D collision)
        {
            
        }


        //兩個物件碰撞重疊時持續執行

        private void OnTriggerStay2D(Collider2D collision)
        {
            
        }

        #endregion


        #region 兩個物件都沒有勾選 Is Trigger

        private void OnCollisionEnter2D(Collision2D collision)
        {
            
        }


        private void OnCollisionExit2D(Collision2D collision)
        {
            
        }


        private void OnCollisionStay2D(Collision2D collision)
        {
            
        }
        #endregion


    }

}
