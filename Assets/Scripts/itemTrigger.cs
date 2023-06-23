using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemTrigger : MonoBehaviour
{
    [SerializeField] public GameObject itemGround;
    [SerializeField] public GameObject itemActive;

    [SerializeField] public Text mission;
    // Start is called before the first frame update
    private void OnTriggerStay(Collider other) {
        mission.text = "you found the missing gear!";
        if(Input.GetKey(KeyCode.E)){
            mission.text = "Gear +1";
            itemActive.SetActive(true);
            itemGround.SetActive(false);
        }
    }
}
