using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderObjectCrate : MonoBehaviour
{
    [SerializeField] Camera myCamera;
    private Money money;
    // Start is called before the first frame update
    void Start()
    {
        money = GameObject.FindObjectOfType<Money>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        MouseRealWorld();
        PositionsNear(MouseRealWorld());
        GameObject newGameObject = PanelElementControl.selectedElement;
        int cost = newGameObject.GetComponent<Defenders>().cost;
        if (money.CashUse(cost) == Money.MoneyControl.successful)
        {
            realworld();
        }
    }

    void realworld()
    {
        GameObject ata = Instantiate(PanelElementControl.selectedElement, PositionsNear(MouseRealWorld()), Quaternion.identity) as GameObject;
        ata.transform.parent = GameObject.Find("Defend").transform;
    }
    Vector2 PositionsNear(Vector2 near)
    {
        float nearX = Mathf.CeilToInt(near.x);
        float nearY = Mathf.CeilToInt(near.y);
        return new Vector2(nearX, nearY);
    }
    Vector2 MouseRealWorld()
    {
        float mouseX = Input.mousePosition.x;
        float mouseY = Input.mousePosition.y;
        float camera = 15;
        Vector3 mouseposition = new Vector3(mouseX, mouseY, camera);
        Vector2 realworld = myCamera.ScreenToWorldPoint(mouseposition);
        return realworld;
    }
}
