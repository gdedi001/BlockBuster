using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockCollision : MonoBehaviour
{
    public int point = 1;
    public int GoldPoint = 2;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Object entered the trigger");
        Debug.Log(other.gameObject.name);
        if (other.gameObject.tag == "Block") // Assume your hand or controller has a Hand tag
        {
            ScoreManager.instance.AddPoints(point);
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Block_Gold")
        {
            ScoreManager.instance.AddPoints(GoldPoint);
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "StartMenu")
        {
            GameStart.Instance.SwitchScene();
        }


    }
}
