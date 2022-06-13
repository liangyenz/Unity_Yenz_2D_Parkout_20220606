using UnityEngine;

namespace YEN
{
    /// <summary>
    /// 跑酷遊戲
    /// </summary>
    public class SystemRun : MonoBehaviour

    {
        #region 資料:保存系統需要的資料
        [SerializeField, Header("跑步速度"), Tooltip("這是角色的跑步速度"), Range(0,35)]
        private float speedRun = 3.5f;
        [SerializeField, Header("跳躍高度"), Tooltip("這是角色的跳躍高度"), Range(0,350)]
        private float heightJump = 350;
        private Animator ani;
        private Rigidbody2D rig;



        #endregion

        #region 功能:實作該系統的複雜方法




        #endregion

        #region 事件:程式入口

        private void Awake()
        {
            ani = GetComponent<Animator>();
        }

        private void Start()
        {
            print("Wellcome to the Running Game!");
        }

        private void Update()
        {
            print("<color=yellow>事件更新中</color>");
        }



        #endregion

    }

}


   

