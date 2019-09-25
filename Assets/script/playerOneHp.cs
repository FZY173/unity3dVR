using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerOneHp : MonoBehaviour
{
    public Slider Hp;

    void Start()
    {
        Hp.value = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("personTwo"))
        {
            Debug.Log("詹姆斯打到杜兰特");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("personTwo"))
        {
            Debug.Log("碰到物体");
            Destroy(collision.gameObject);
        }
    }
}
