using UnityEngine;

namespace YEN
{
    /// <summary>
    /// �]�ŹC��
    /// </summary>
    public class SystemRun : MonoBehaviour

    {
        #region ���:�O�s�t�λݭn�����
        [SerializeField, Header("�]�B�t��"), Tooltip("�o�O���⪺�]�B�t��"), Range(0,35)]
        private float speedRun = 3.5f;
        [SerializeField, Header("���D����"), Tooltip("�o�O���⪺���D����"), Range(0,350)]
        private float heightJump = 350;
        private Animator ani;
        private Rigidbody2D rig;



        #endregion

        #region �\��:��@�Өt�Ϊ�������k




        #endregion

        #region �ƥ�:�{���J�f

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
            print("<color=yellow>�ƥ��s��</color>");
        }



        #endregion

    }

}


   

