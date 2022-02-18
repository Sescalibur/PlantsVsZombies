using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        GetComponent<Slider>().value -= Time.deltaTime;
        if (GetComponent<Slider>().value <= 0)
        {
            SceneManager.LoadScene("4Win");
        }
    }
}
