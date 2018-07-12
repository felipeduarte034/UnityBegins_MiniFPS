using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    [SerializeField] int m_KillPoints = 1;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag.Equals(Constants.TAG_BULLET))
        {
            print(collisionInfo.gameObject.name);
            DataManager.SetScore(DataManager.GetScore() + m_KillPoints);
            Destroy(gameObject);
        }
    }
}
