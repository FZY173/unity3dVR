using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distance : MonoBehaviour
{

    public GameObject playerOne;
    public GameObject playerTwo;
    public Vector3 playerOneDistance;
    public Vector3 playerTwoDistance;
    public GameObject playerOneCanvas;
    public GameObject playerOneCanvasAttack;
    public GameObject playerTwoCanvas;
    public GameObject playerTwoCanvasAttack;
    [HideInInspector]
    public float distanceVaule;

    void Start() {
        playerOneCanvas.SetActive(true);
        playerTwoCanvas.SetActive(true);
        playerOneCanvasAttack.SetActive(false);
        playerTwoCanvasAttack.SetActive(false);
    }

    void Update()
    {
        playerOneDistance = playerOne.transform.position;
        playerTwoDistance = playerTwo.transform.position;
        distanceVaule = Vector3.Distance(playerOneDistance, playerTwoDistance);
       // Debug.Log("两者之间的距离为："+ distanceVaule);
        if (distanceVaule <= 7.5f)
        {
            playerOneCanvas.SetActive(false);
            playerTwoCanvas.SetActive(false);
            playerOneCanvasAttack.SetActive(true);
            playerTwoCanvasAttack.SetActive(true);
            playerOne.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
            playerTwo.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
            playerOne.transform.localRotation = Quaternion.Euler(0.0f, 107.808f, 0.0f);
            playerTwo.transform.localRotation = Quaternion.Euler(0.0f, -75.691f, 0.0f);
            playerOne.transform.localPosition = new Vector3(0.13f, 0.57f, -0.06f);
        }
        else {
            playerOneCanvas.SetActive(true);
            playerTwoCanvas.SetActive(true);
            playerOneCanvasAttack.SetActive(false);
            playerTwoCanvasAttack.SetActive(false);
            playerOne.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
            playerTwo.transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
            playerOne.transform.localRotation = Quaternion.Euler(0.0f, 194.798f, 0.0f);
            playerTwo.transform.localRotation = Quaternion.Euler(0.0f, -126.673f, 0.0f);
            playerOne.transform.localPosition = new Vector3(-0.017f, 0.322f, -0.005f);
           
        }
    }

}