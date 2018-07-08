using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

	//[Header("Settings")]
	

	[Header("Links")]
	[SerializeField] Transform m_SpawnBullet;
	[SerializeField] GameObject m_pfBullet;
	[SerializeField] Transform m_PointA;
    [SerializeField] Transform m_PointB;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown(0)) //se apertar o botão do mouse, executa:
		{
			GameObject go = Instantiate(m_pfBullet, m_SpawnBullet.transform.position, m_SpawnBullet.rotation);
			go.GetComponent<Bullet>().SetPoints(m_PointA, m_PointB);
		}
	}
}
