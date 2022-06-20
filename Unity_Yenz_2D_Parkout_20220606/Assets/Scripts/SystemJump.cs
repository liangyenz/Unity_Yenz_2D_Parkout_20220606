
using UnityEngine;


namespace Yen
{
/// <summary>
/// 
/// ���D�\��
/// </summary>
public class SystemJump : MonoBehaviour
{
        #region ���
        
        [SerializeField, Header("���D����"), Tooltip("�o�O���⪺���D����"), Range(0, 3000)]
        private float heightJump = 350;

        private Animator ani;
        private Rigidbody2D rig;

        private bool clickJump;//�W�[clickJump���A�bDebug�Ҧ��U�|���



        #endregion

        #region �\��:
        private void JumpKey()
        {
            //���a ���U �ť��� �N���W���D
            //if�P�_���y�k: if(���L��) {���L�Ȭ� True ����{��}

            if (Input.GetKeyDown(KeyCode.Space))
            {
                print("���D");
                clickJump = true;//unity Debug ���� �b���U�ť��� clickJump�|����
            }
        }

        private void JumpForce()
        {
            if (clickJump)
            {
                rig.AddForce(new Vector2(0, heightJump));//AddForce���O�AheightJump���h��
                clickJump = false;
            }
        }


        #endregion

        #region �ƥ�

        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }

       

        private void Update()
        {

            JumpKey();

        }

        private void FixedUpdate()//�T�w�V�ơA�C���������פ~�@��
        {
            JumpForce();
        }



        #endregion
    }

}

