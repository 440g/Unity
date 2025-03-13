using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
public class D04_Mesh_Material : MonoBehaviour 

{
    MeshFilter ThisMeshFilter; 
    public GameObject Sphere, Capsule; 

    void Start() 
    { 
        ThisMeshFilter = GetComponent<MeshFilter>(); 
    } 

    // Update is called once per frame
    void Update() 
    { 
        if (Input.GetMouseButtonDown(0)) 
        { 
            ThisMeshFilter.mesh = Sphere.GetComponent<MeshFilter>().mesh; 
        } 
        if (Input.GetMouseButtonDown(1)) 
        { 
            ThisMeshFilter.mesh = Capsule.GetComponent<MeshFilter>().mesh; 
        } 
        
        //마우스가 없어서 추가적으로 작성 
        if (Input.GetKey(KeyCode.X)) 
        { 
            ThisMeshFilter.mesh = Sphere.GetComponent<MeshFilter>().mesh; 
        } 
        if (Input.GetKey(KeyCode.C)) 
        { 
            ThisMeshFilter.mesh = Capsule.GetComponent<MeshFilter>().mesh; 
        } 
    } 
} 
