using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
using UnityEngine.SceneManagement; 
public class HW01_UIGameObjects : MonoBehaviour 
{ 
    public void OnClick_Print(){
        print("scene changed"); 
        SceneManager.LoadScene("HW01_2276046_KMS_Load"); 
    } 
} 
