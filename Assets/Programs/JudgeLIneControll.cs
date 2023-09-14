using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgeLIneControll : MonoBehaviour
{

    private GameObject notePrefab;

    // Start is called before the first frame update
    void Start()
    {
        this.notePrefab = GameObject.Find("NotePrefab");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
