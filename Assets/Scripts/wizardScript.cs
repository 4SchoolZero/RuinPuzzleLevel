using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wizardScript : MonoBehaviour
{
    [SerializeField] public GameObject brige1;
    [SerializeField] public GameObject brige2;
    [SerializeField] public GameObject gate;
    [SerializeField] public GameObject palaceCrystalUp;
    [SerializeField] public GameObject wizardBeam;
    [SerializeField] public GameObject finalBeam;
    [SerializeField] public GameObject portalEffect;
    [SerializeField] public Text interactMsg;
    [SerializeField] public Text mission;


    private void OnTriggerStay(Collider other) {
        interactMsg.text = "Activate Wizard [E]";
        if(Input.GetKey(KeyCode.E)){
            if(palaceCrystalUp.activeSelf){
                interactMsg.text = ".";
                mission.text = "With the power of 2 light beams the portal lights up";
                brige1.SetActive(false);
                brige2.SetActive(true);
                wizardBeam.SetActive(false);
                finalBeam.SetActive(true);
                portalEffect.SetActive(true);
            }
            else{
                interactMsg.text = ".";
                mission.text = "A magic gate has opened";
                wizardBeam.SetActive(true);
                gate.SetActive(false);
            }
        }
    }
}
