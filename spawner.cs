using UnityEngine;
using System.Collections;

public class spawner : MonoBehaviour {
	

	public Transform ballPos;
public Rigidbody Ball;

public float timeMax = 1;

	private int count;
	float rand;

void SpawnBall()
	{	
		float rb =Random.Range (-4f, 4f);
		Vector3 postn = new Vector3 (rb, 8f,0f);
	Rigidbody ballRigid;
		ballRigid = Instantiate(Ball,postn,Quaternion.identity) as Rigidbody;

}
void Start() 
	{
	float timeToSpawn = timeMax;
		timeMax++;
	InvokeRepeating("SpawnBall", timeToSpawn,4f);
	}
		

}