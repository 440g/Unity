using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
public class D04_Mesh_Renderer : MonoBehaviour 

{
    // Start is called before the first frame update 
    void Start() 
    { 
        //editor에서 테스트 용으로만 작동, 디버깅 시 X
        print("Hello World!"); 
        //스크립트가 붙어있는 게임오브젝트만 예외적으로 소문자로 시작 
        Debug.Log(gameObject.name); 
        // ThisMeshFilter = GetComponent<MeshFilter>(); 
    } 

    // Update is called once per frame
    void Update() 
    { 
        //getkeydown: 누르기 
        //getkeyup: 떼기 
        //gameObject 관점에서 이동
        if (Input.GetKey(KeyCode.UpArrow)) // 위 방향키를 누르고 있다면 
        {
            transform.Translate(0, 0, 0.01f); // translate z + 1
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -0.01f);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -0.1f, 0);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0.1f, 0);
        }
        // if (Input.GetMouseButtonDown(0)) 
        // { 
        //     ThisMeshFilter.mesh = Sphere.GetComponent<MeshFilter>().mesh; 
        // } 
        // if (Input.GetMouseButtonDown(1)) 
        // { 
        //     ThisMeshFilter.mesh = Capsule.GetComponent<MeshFilter>().mesh; 
        // } 
    } 
} 
