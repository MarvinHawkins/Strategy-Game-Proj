using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Healthbar : MonoBehaviour {
	// The TextMesh Component
	TextMesh tm;
	public ParticleSystem explosionPrefab;   
	
	// Use this for initialization
	void Start () {
		tm = GetComponent<TextMesh>();
	}
	
	// Update is called once per frame
	void Update () {
		// Face the Camera

		transform.forward = Camera.main.transform.forward;
	}

	public int current() {
		return tm.text.Length;
	}
	
	// Decrease the current Health by removing one '-'
	public void decrease(int damage) {
		if (current() > 0)
		{
		
			tm.text = tm.text.Remove(tm.text.Length - damage);
		}
		else
		{
			Destroy(transform.parent.gameObject);
			Instantiate (explosionPrefab, transform.position, Quaternion.identity);
		}
	}

}
