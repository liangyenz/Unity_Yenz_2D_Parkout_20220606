using UnityEngine;



namespace Yen
{
/// <summary>
/// ���`�޲z
/// </summary>

public class ManagerDead : MonoBehaviour
{

        [SerializeField, Header("�ؼЦW��")]
        private string nameTarget = "����";//���⪫��W��

        [SerializeField, Header("�����޲z��")]
        private ManagerFinal managerfinal;

        [SerializeField, Header("CM��v�������")]//�l����v��
        private GameObject goCM;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.name.Contains(nameTarget))
            {
                managerfinal.stringTitle = "�D�ԥ���~";
                managerfinal.enabled = true;
                goCM.SetActive(false);//������v��
            }
        }




    }

}

