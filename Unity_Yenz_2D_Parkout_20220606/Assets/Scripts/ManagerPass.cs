using UnityEngine;


namespace Yen
{

    /// <summary>
    /// �޲z�L��
    /// </summary>
public class ManagerPass : MonoBehaviour
{


        [SerializeField, Header("�ؼЦW��")]
        private string nameTarget = "����";//�򨤦�W�٤@��
        [SerializeField, Header("�]�B�t��")]
        private SystemRun systemrun;

        [SerializeField, Header("���D�t��")]
        private SystemJump systemjump;

        [SerializeField, Header("�����޲z��")]
        private ManagerFinal managerfinal;



        #region �䤤�@�Ӫ��󦳤Ŀ� Is Trigger

        //��Ӫ���I���ɰ���@��
        private void OnTriggerEnter2D(Collider2D collision)
        {
            // print(collision.name);


            if (collision.name.Contains(nameTarget))//�p�G �I�����󪺦W�� �]�tcontains (����)
            {
                systemrun.enabled = false; //�����]�B�t��
                systemjump.enabled = false;//�������D�t��

                managerfinal.enabled = true;//�Ұʵ����޲z��
                managerfinal.stringTitle = "���ߧA�L��~";
            }
        }

        //��Ӫ���I�����}�ɰ���@��

        private void OnTriggerExit2D(Collider2D collision)
        {
            
        }


        //��Ӫ���I�����|�ɫ������

        private void OnTriggerStay2D(Collider2D collision)
        {
            
        }

        #endregion


        #region ��Ӫ��󳣨S���Ŀ� Is Trigger

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
