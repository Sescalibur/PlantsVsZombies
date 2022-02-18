using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using Image = UnityEngine.UI.Image;

public class PanelControl : MonoBehaviour
{
    [SerializeField] float time;

    private Color newcolor = new Color(0, 0, 0, 0);
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
            newcolor.a += alfa;
            GetComponent<Image>().color = newcolor;
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
