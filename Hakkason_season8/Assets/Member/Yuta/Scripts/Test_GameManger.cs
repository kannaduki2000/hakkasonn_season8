using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_GameManger : MonoBehaviour
{
    [SerializeField] GameObject lightObject;
    private float SpotAngle;  //���C�g�̑傫��
    public static bool Item = false;  //�A�C�e���擾�t���O
    private float time = 0f;  //���Ԍo�ߋL�^
    private bool GameOver = false;  //�Q�[���I�[�o�[�t���O

    void Start()
    {
        //�X�|�b�g���C�g�̃R���|�[�l���g�擾
        SpotAngle = lightObject.GetComponent<Light>().spotAngle;
        SpotAngle = 50.0f;  //�����̑傫��
        time = 0f;
        Item = false;
        GameOver = false;
    }

    void Update()
    {
        //���C�g�̑傫�����f
        lightObject.GetComponent<Light>().spotAngle = SpotAngle;

        time += Time.deltaTime;

        //3�b�o���A�Q�[���I�[�o�[�ł͖���������
        if (time >= 3f && !GameOver)
        {
            //���C�g������������
            SpotAngle -= 1f;
            time = 0f;
        }

        //�A�C�e�����������
        if (Item)
        {
            //���C�g�̑傫���������ɖ߂�
            SpotAngle = 50.0f;
            Item = false;
        }

        //���C�g�̑傫����5�ȉ���������
        if (SpotAngle <= 5f)
        {
            //�I���ɂ���
            GameOver = true;
            Debug.Log("�I���");
        }
    }
}
