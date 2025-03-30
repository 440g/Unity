using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
public class HW02_Audio_Controller_TV : MonoBehaviour 
{ 
    public AudioSource[] Audio; 
    void Start() 
    { 
        Audio[0].loop = true; 
        Audio[0].Play(); 
    } 
    void Update() 
    { 
        if (Input.GetKeyDown(KeyCode.I)) 
        { 
            if (Audio[0].isPlaying) 
            { 
                Audio[0].Pause(); 
            } 
            else 
            { 
                Audio[0].Play(); 
            } 
        }  
    } 
    private void OnMouseDown() 
    { 
        if (Audio[0].isPlaying) 
        { 
            Audio[0].Pause(); 
        } 
        else 
        { 
            Audio[0].Play(); 
        } 
    } 
} 
