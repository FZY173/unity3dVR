using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skillsShow : MonoBehaviour
{
    Animator personAnimator;
    private bool isSkill1 = false;
    private bool isSkill2 = false;
    private bool isSkill3 = false;
    private bool isSkill4 = false;
    public float coolingTimer = 1.0f;
    private float currentTime = 0.0f;
    public GameObject skill1;
    public GameObject skill2;
    public GameObject skill3;
    public GameObject skill4;
    public Text win;
    public GameObject skills;
    public GameObject skillsother;
    public bool isEndPlayerTwo = true;
    void Start()
    {
        personAnimator = GetComponent<Animator>();
        win.text = "";
        skills.SetActive(true);
        skillsother.SetActive(true);
    }

    void Update()
    {
        if (FindObjectOfType<weaponTwo>().HpTwo.value == 0)
        {
            StopCoroutine(pesonTwoFinishSkills());
            personAnimator.SetBool("death", true);
            personAnimator.SetBool("skillOne", false);
            personAnimator.SetBool("skillTwo", false);
            personAnimator.SetBool("skillThree", false);
            personAnimator.SetBool("skillFour", false);
            StartCoroutine(gameOver());
        }
        if (FindObjectOfType<skilslShow>().isEndPlayerOne)
        {
            if (FindObjectOfType<weaponTwo>().HpTwo.value != 0)
            {
                if (FindObjectOfType<distance>().distanceVaule <= 7.5f)
                {
                    StartCoroutine(pesonTwoFinishSkills());
                }
                if (FindObjectOfType<distance>().distanceVaule > 7.5f)
                {
                 
                }

            }
        }
        if (!FindObjectOfType<skilslShow>().isEndPlayerOne)
        {
            StopCoroutine(pesonTwoFinishSkills());
            personAnimator.SetBool("skillOne", false);
            personAnimator.SetBool("skillTwo", false);
            personAnimator.SetBool("skillThree", false);
            personAnimator.SetBool("skillFour", false);

        }
        skillrefesh();
    }

    IEnumerator gameOver()
    {
        isEndPlayerTwo = false;
        skills.SetActive(false);
        skillsother.SetActive(false);
        personAnimator.SetBool("deathPlayerTwo", true);
        yield return new WaitForSeconds(2f);
        win.text = "詹姆斯赢了";
      //  Application.Quit();
    }

     IEnumerator pesonTwoFinishSkills()
    {
        yield return new WaitForSeconds(2f);
        personAnimator.SetBool("skillOne", true);

        isSkill1 = true;
        yield return new WaitForSeconds(2f);
        personAnimator.SetBool("skillOne", false);
        isSkill1 = true;
        Debug.Log("2秒");
        yield return new WaitForSeconds(3f);
        personAnimator.SetBool("skillTwo", true);
        isSkill2 = true;
        yield return new WaitForSeconds(2f);
        personAnimator.SetBool("skillTwo", false);
        isSkill2 = true;
        Debug.Log("3秒");
        yield return new WaitForSeconds(4f);
        personAnimator.SetBool("skillThree", true);
        isSkill3 = true;
        yield return new WaitForSeconds(2f);
        personAnimator.SetBool("skillThree", false);
        isSkill3 = true;
        Debug.Log("4秒");
        yield return new WaitForSeconds(6f);
        personAnimator.SetBool("skillFour", true);
        isSkill4 = true;
        yield return new WaitForSeconds(2f);
        personAnimator.SetBool("skillFour", false);
        isSkill4 = true;
        Debug.Log("6秒");
    }

    public void skillOneDown()
    {
        personAnimator.SetBool("skillOne", true);
    }
    public void skillOneUp()
    {
        personAnimator.SetBool("skillOne", false);
    }
    public void skillTwoDown()
    {
        personAnimator.SetBool("skillTwo", true);
    }
    public void skillTwoUp()
    {
        personAnimator.SetBool("skillTwo", false);
    }
    public void skillThreeDown()
    {
        personAnimator.SetBool("skillThree", true);
    }
    public void skillThreeUp()
    {
        personAnimator.SetBool("skillThree", false);
    }
    public void skillFourDown()
    {
        personAnimator.SetBool("skillFour", true);
    }
    public void skillFourUp()
    {
        personAnimator.SetBool("skillFour", false);
    }

    void skillrefesh() {
        if (isSkill1)
        {
            skill1.GetComponent<Image>().fillAmount -= 0.01f;
            if (skill1.GetComponent<Image>().fillAmount == 0)
            {
                skill1.GetComponent<Image>().fillAmount = 1;
                isSkill1 = false;
            }
        }
        if (isSkill2)
        {
            skill2.GetComponent<Image>().fillAmount -= 0.01f;
            if (skill2.GetComponent<Image>().fillAmount == 0)
            {
                skill2.GetComponent<Image>().fillAmount = 1;
                isSkill2 = false;
            }
        }
        if (isSkill3)
        {
            skill3.GetComponent<Image>().fillAmount -= 0.01f;
            if (skill3.GetComponent<Image>().fillAmount == 0)
            {
                skill3.GetComponent<Image>().fillAmount = 1;
                isSkill3 = false;
            }
        }
        if (isSkill4)
        {
            skill4.GetComponent<Image>().fillAmount -= 0.01f;
            if (skill4.GetComponent<Image>().fillAmount == 0)
            {
                skill4.GetComponent<Image>().fillAmount = 1;
                isSkill4 = false;
            }
        }

    }

}
