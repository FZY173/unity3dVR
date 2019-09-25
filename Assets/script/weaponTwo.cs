using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class weaponTwo : MonoBehaviour
{
    public Slider HpTwo;
    private float number;
    void Start()
    {
        HpTwo.value = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter(Collider personOne)
    {
        if (FindObjectOfType<distance>().distanceVaule <= 7.5f && FindObjectOfType<weaponOne>().HpOne.value != 0)
        {
            if (personOne.gameObject.CompareTag("wanponOne"))
        {
            Debug.Log("詹姆斯打到杜兰特");
                number = Random.Range(0f, 10f);

                if (number < 4f && number > 0f)
                {
                    HpTwo.value = HpTwo.value - 0.1f;

                }
                if (number < 7f && number > 4f)
                {
                    HpTwo.value = HpTwo.value - 0.15f;
                }
                if (number < 9f && number > 7f)
                {
                    HpTwo.value = HpTwo.value - 0.2f;
                }
                if (number < 10f && number > 9f)
                {
                    HpTwo.value = HpTwo.value - 0.3f;
                }
            }
        
           

        }
        if (FindObjectOfType<distance>().distanceVaule > 7.5f)
        {
            HpTwo.value = 1.0f;
        }

            Debug.Log("HpTwo" + HpTwo.value);
    }


}
