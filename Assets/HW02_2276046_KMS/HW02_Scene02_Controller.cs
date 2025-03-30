using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro; //text mesh pro
using UnityEngine.SceneManagement;

public class HW02_Scene02_Controller : MonoBehaviour
{
    string UserInput;
    public TMP_Text Message;

    void Start()
    {
        UserInput = PlayerPrefs.GetString("Input"); // 저장한 값을 불러옴 getint/float/string(키)
        if (string.IsNullOrEmpty(UserInput))
        {
            Message.text = "PlayerPrefs에 저장한 데이터가 없습니다.";
        }
        else
        {
            Message.text = UserInput;
        }
    }

    public void OnClick_LoadScene(Object SceneObject)
    {
        SceneManager.LoadScene(SceneObject.name);
    }
}
