using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelElementControl : MonoBehaviour
{
    [SerializeField] GameObject elemetPrefab;
    private PanelElementControl[] panelElement;
    public static GameObject selectedElement;
    // Start is called before the first frame update
    void Start()
    {
        panelElement = GameObject.FindObjectsOfType<PanelElementControl>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        selectedElement = elemetPrefab;
        foreach (PanelElementControl element in panelElement)
        {
            element.GetComponent<SpriteRenderer>().color=Color.black;
            
        }
        GetComponent<SpriteRenderer>().color = Color.white;
    }
}
