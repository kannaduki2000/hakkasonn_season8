using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GManager : MonoBehaviour
{

    public static GManager instance = null; //�X�R�A(�Q�[���S�̂Ɋւ�肻���Ȃ���)�̃}�l�[�W���[�Ȃ̂ŃA�N�Z�X�A�Ăяo���₷���悤��static�ɂ��܂����B


    private bool isGameStartOnce = false;
    private bool isGameFinishOnce = false;

    private bool isGameStart = false;
    [HideInInspector]
    public bool Isgameclear = false;
    [HideInInspector]
    public bool Isgameover = false;

    [HideInInspector]
    public float elapsedTime = 0.0f;
    [HideInInspector]
    public float Scoretime = 0.0f;
    // Start is called before the first frame update

    private void Awake()//Start�̑O�ɌĂ΂��
    {
        //�V���O���g�� ��΂�1�������݂��Ȃ����̂��`����
        //�X�R�A�����������݂��Ȃ��悤�ɂ��邽��
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && isGameStartOnce == false)//�Q�[���N���A�����m�F�p
        {
            SceneManager.LoadScene("PlayerMoveScene");
            isGameStartOnce = true;
            isGameStart = true;
        }
        

        if (isGameStart == true && Input.GetKeyDown(KeyCode.K))//�Q�[���N���A�����m�F�p
        {
            Isgameclear = true;
        }

        if (isGameStart == true && Input.GetKeyDown(KeyCode.G))//�Q�[���I�[�o�[�����m�F�p
        {
            Isgameover = true;
        }

        if (isGameStart == true && Isgameclear == false)
        {
            elapsedTime += Time.deltaTime;
            Debug.Log((elapsedTime).ToString());
        }

        if (Isgameclear == true && isGameFinishOnce == false)
        {
            GameClear();
            isGameFinishOnce = true;
        }

        if (Isgameover == true && isGameFinishOnce == false)
        {
            GameOver();
            isGameFinishOnce = true;
        }

    }

    private void GameOver()
    {
        isGameStart = false;
        SceneManager.LoadScene("GameOverScene");

    }

    private void GameClear()
    {
        isGameStart = false;
        Scoretime = elapsedTime;
        Debug.Log(Scoretime);
        SceneManager.LoadScene("ResultScene");

    }
}
