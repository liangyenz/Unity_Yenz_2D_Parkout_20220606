using UnityEngine;

namespace YEN
{
public class APIStatic : MonoBehaviour
{

        /// <summary>
        /// API Stati�R�A�ϥΤ覡
        /// </summary>
        private Vector3 a = new Vector3(1, 1, 1);
        private Vector3 b = new Vector3(22, 22, 22);

        private void Start()
        {
            #region �ǲ�
            print("�H����" + Random.value);

            print("PI" + Mathf.PI);
            print("�L���j" + Mathf.Infinity);
            Time.timeScale = 0.5f;

            print("float random range" + Random.Range(10f, 30f));
            #endregion

            #region �m���D
            print("camera number is " + Camera.allCamerasCount);
            print("���Υ��x"+ Application.platform);

            Physics.sleepThreshold = 10;
            print("�ίv�{�ɭ�" + Physics.sleepThreshold);

            Time.timeScale = 0.5f;
            print("�ɶ��j�p" + Time.timeScale);

            print("999.99�h���p���I�|�ˤ��J"+Mathf.Round(999.99f));

            float distance = Vector3.Distance(a,b);
            print("<color=yellow>�Z��" + distance + "</color>");

            Application.OpenURL("https://unity.com/");


                #endregion
        }

        private void Update()
        {
            #region �ǲ�
            print("int random range" + Random.Range(1, 3));
            #endregion

            #region �m���D
            //print("��J���N��" + Input.anyKeyDown);
            //print("�C���g�L�ɶ�" + Time.timeSinceLevelLoad);
            print("<color=red>�O�_���U�ť���" + Input.GetKeyDown(KeyCode.Space)+"</color>");

            #endregion

        }
    }
}

