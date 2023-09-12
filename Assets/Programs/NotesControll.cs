using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private int NoteSpeed;

    //public GameObject Note;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        NoteSpeed = 10;
        transform.position -= Vector3.forward * Time.deltaTime * NoteSpeed;

        if (transform.position.z < -5) {
            Destroy(gameObject);
        }
    }
}
