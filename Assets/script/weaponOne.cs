using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class weaponOne : MonoBehaviour
{
    public Slider HpOne;
    private float number;
  
    void Start()
    {
        HpOne.value = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("HpOne" + HpOne.value);
    }

    private void OnTriggerEnter(Collider personTwo)
    {
        if (FindObjectOfType<distance>().distanceVaule <= 7.5f &&FindObjectOfType<weaponTwo>().HpTwo.value != 0)
        {
            if (personTwo.gameObject.CompareTag("wanponTwo"))
            {
                Debug.Log("杜兰特打到詹姆斯");
                
            }
            number = Random.Range(0f, 10f);
            if (number < 4f && number > 0f)
            {
                HpOne.value = HpOne.value - 0.01f;

            }
            if (number < 7f && number > 4f)
            {
                HpOne.value = HpOne.value - 0.01f;
            }
            if (number < 9f && number > 7f)
            {
                HpOne.value = HpOne.value - 0.01f;
            }
            if (number < 10f && number > 9f)
            {
                HpOne.value = HpOne.value - 0.02f;
            }

        }
        if (FindObjectOfType<distance>().distanceVaule > 7.5f)
        {
            HpOne.value = 1.0f;
        }

            Debug.Log("HpOne"+ HpOne.value);
    }


}


