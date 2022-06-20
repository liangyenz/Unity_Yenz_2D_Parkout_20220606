
using UnityEngine;


namespace Yen
{
/// <summary>
/// 
/// 跳躍功能
/// </summary>
public class SystemJump : MonoBehaviour
{
        #region 資料
        
        [SerializeField, Header("跳躍高度"), Tooltip("這是角色的跳躍高度"), Range(0, 3000)]
        private float heightJump = 350;

        private Animator ani;
        private Rigidbody2D rig;

        private bool clickJump;//增加clickJump欄位，在Debug模式下會顯示



        #endregion

        #region 功能:
        private void JumpKey()
        {
            //玩家 按下 空白鍵 就往上跳躍
            //if判斷式語法: if(布林值) {布林值為 True 執行程式}

            if (Input.GetKeyDown(KeyCode.Space))
            {
                print("跳躍");
                clickJump = true;//unity Debug 執行 在按下空白鍵 clickJump會打勾
            }
        }

        private void JumpForce()
        {
            if (clickJump)
            {
                rig.AddForce(new Vector2(0, heightJump));//AddForce推力，heightJump跳多高
                clickJump = false;
            }
        }


        #endregion

        #region 事件

        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }

       

        private void Update()
        {

            JumpKey();

        }

        private void FixedUpdate()//固定幀數，每次跳的高度才一樣
        {
            JumpForce();
        }



        #endregion
    }

}

