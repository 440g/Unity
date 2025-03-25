using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D07_SampleLantern : MonoBehaviour
{
    public GameObject Lantern;
    // Start is called before the first frame update
    void Start()
    {
        Lantern.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L)){
            Lantern.SetActive(true);
        }
    }
}
