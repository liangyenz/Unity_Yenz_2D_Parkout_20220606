using UnityEngine;

namespace YEN
{
public class APIStatic : MonoBehaviour
{

        /// <summary>
        /// API Stati�R�A�ϥΤ覡
        /// </summary>


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
            print("���Υ��x"+ Application.isConsolePlatform);


                #endregion
        }

        private void Update()
        {
            #region �ǲ�
            print("int random range" + Random.Range(1, 3));
            #endregion

            #region �m���D
            print("��J���N��" + Input.anyKey);


            #endregion

        }
    }
}

