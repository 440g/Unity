using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
using UnityEngine.SceneManagement; 
public class D06_UIGameObjects : MonoBehaviour 
{ 
    public void OnClick_Print(GameObject Target){ 
        print(Target.name); 
        SceneManager.LoadScene(0); //문자열로 씬 이름 넣어도 작동함 
    } 
} 
