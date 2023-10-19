using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Item")) 
        {
            ItemSlot itemSlotScript = GetComponent<ItemSlot>();
           
            
            Destroy(other.gameObject); // 아이템을 획득했으므로 아이템 GameObject를 삭제
        }
    }
}
