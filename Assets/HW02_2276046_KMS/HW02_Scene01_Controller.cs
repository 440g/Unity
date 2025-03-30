using System.Collections;
using System.Collections.Generic;
using TMPro; //text mesh pro
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HW02_Scene01_Controller : MonoBehaviour
{
    string UserInput = "";

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            PlayerPrefs.DeleteAll();
        }
    }

    public void OnClick_AssignData(TMP_InputField InputField)
    {
        UserInput = InputField.text; // 입력을 받아서 변수에 값 할당 (버튼에 할당)
    }

    public void OnClick_Display_UserInput(TMP_Text Message)
    {
        Message.text = $"{UserInput}";
    }

    public void OnClick_DisplayAndSet_UserInput(TMP_Text Message)
    {
        Message.text = $"{UserInput}";
        PlayerPrefs.SetString("Input", Message.text); // 다음 씬에서 읽을 수 있음 
    }


    public void OnClick_LoadScene(Object SceneObject)
    {
        SceneManager.LoadScene(SceneObject.name);
    }
}
