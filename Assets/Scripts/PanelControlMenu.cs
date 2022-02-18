using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelControlMenu : MonoBehaviour
{
    [SerializeField] float time;

    private Color newcolor = Color.black;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeSinceLevelLoad < time)
        {
            float alfa = Time.deltaTime / time;
            newcolor.a -= alfa;
            GetComponent<Image>().color = newcolor;
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
