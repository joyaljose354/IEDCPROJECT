using UnityEngine;
using System.Collections;

public class collision : MonoBehaviour 
{
	public GUIText score;
	public int count;
	public GameObject ball;
	public GameObject ball2;
	public GameObject ball3;
	public GameObject ball4;

	void start()
	{
		count = 0;

	}
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("purple"))
			{
				ball.SetActive (false);
				count = count + 1;
			OnGUI();
			}
		if(other.gameObject.CompareTag("yellow"))
		{
			ball2.SetActive (false);
			count = count + 1;
			OnGUI();
		}
		if(other.gameObject.CompareTag("pink"))
		{
			ball3.SetActive (false);
			count = count + 1;
			OnGUI ();
		}
		if(other.gameObject.CompareTag("teal"))
		{
			ball4.SetActive (false);
			count = count + 1;
			OnGUI ();		}
	}
	void OnGUI ()
	{
		GUI.Label (new Rect (5, 5, 200, 30), "score" + count);
}
}




