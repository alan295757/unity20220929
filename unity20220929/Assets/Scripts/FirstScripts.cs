using UnityEngine;

namespace JAY
{
    /// <summary>
    /// �Ĥ@�ӵ{��
    /// </summary>
    public class FirstScripts : MonoBehaviour
    {
        #region ���Ѱϰ�
        // �Y�� �ֱ��� Tab
        // �榡�Ƥ�� Ctrl + K D
        // ������
        #endregion
            // ����ƥ�
        private void Awake()
        {
            print("���o");
        }

        // �}�l�ƥ�
        private void Start()
        {
            print("<color=yellow>�o�O�}�l�ƥ�</color>");
        }

        // ��s�ƥ�G�b Start ����� ���榸�Ƭ� 60 FPS
        private void Update()
        {
            print("<color=red>��s�ƥ�I</color>");
        }
        #region �ƥ�ϰ�


        #endregion
    }
}

 