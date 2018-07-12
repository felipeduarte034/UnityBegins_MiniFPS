using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{

    [Header("Settings")]
    [SerializeField] float m_Speed = 5f;
    [SerializeField] float m_LifeTimeBullet = 30f;

    Transform m_tA;
    Transform m_tB;
    Vector3 m_Direction;
    Rigidbody rb;

    void Awake() //Primeira função a ser chamada - 
    {
        rb = GetComponent<Rigidbody>();    
    }

	void Start() //Função chamada no primeiro quadro(Frame) do jogo
	{
		m_Direction = (m_tA.position - m_tB.position).normalized; //Calcula um vetor que contem a direção da arma;

		Destroy(gameObject, m_LifeTimeBullet);
	}

    void FixedUpdate() //Loop usado para física
    {
        rb.velocity = m_Direction * m_Speed;
    }

	public void SetPoints(Transform t1, Transform t2) // ATDM (Ajuste Técnico Disponível no Momento)
	{
		m_tA = t1;
		m_tB = t2;
	}
}
