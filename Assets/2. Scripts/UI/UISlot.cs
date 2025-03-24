using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    public Item item;

    UIInventory inventory;

    private Outline outline;
    //private Image itemIcon;
    [SerializeField] private Image itemIcon;

    public int index;
    private bool equipped;


    private void Awake()
    {
        outline = GetComponent<Outline>();
    }

    private void OnEnable()
    {
        outline.enabled = equipped;
    }

    public void SetItem(Item item)  // ���Կ� �κ��丮�� �ִ� ������ �ֱ�
    {
        itemIcon.sprite = item.icon;
        //icon.gameObject.SetActive(true);


        if (outline != null)
        {
            outline.enabled = equipped;
        }
    }

    public void RefreshUI()
    {
        item = null;
        //icon.gameObject.SetActive(false);
    }
}
