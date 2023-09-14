using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
	[SerializeField] private float noteSpeed;
	[SerializeField] private Vector2 startPos;
	[SerializeField] private Vector2 judgePos;

	private float noteTime;

	//public GameObject Note;

	// Start is called before the first frame update
	void Start()
	{
		Application.targetFrameRate = 60;
		this.noteTime = (this.startPos.x - this.judgePos.x) / this.noteSpeed;
	}

	// Update is called once per frame
	void Update()
	{
		NoteScroll();
		ThroughNote();
	}

	void NoteScroll()
	{
		this.noteSpeed = 10;
		transform.position -= Vector3.forward * Time.deltaTime * this.noteSpeed;
	}

	void NoteJudge()
	{
		if (Mathf.Abs(this.noteTime) <= 0.5f) {

		}
	}

	void ThroughNote()
	{
		if (transform.position.z < -5) {
			Destroy(gameObject);
		}
	}
}
