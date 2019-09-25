using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OldScene : MonoBehaviour
{
    private bool isSwitch;
    public void LoadNewScene()
    {
        isSwitch = !isSwitch;
        
        //保存需要加载的目标场景
       
	
    }

    void Start()
    {
        Globe.nextSceneName = "playerShow";
        isSwitch = false;
    }

    void Update()
    {
        if (isSwitch)
        {
           
            SceneManager.LoadScene("loading");
        }
    }
}
