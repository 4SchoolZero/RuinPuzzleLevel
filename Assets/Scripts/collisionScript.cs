using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class collisionScript : MonoBehaviour
{
    [SerializeField] public GameObject spawnCrystal;
    [SerializeField] public GameObject secondCrystal;
    [SerializeField] public GameObject towerCrystal;
    [SerializeField] public GameObject palaceCrystal;
    
    [SerializeField] public GameObject spawnCrystalOpen;
    [SerializeField] public GameObject secondCrystalOpen;
    [SerializeField] public GameObject towerCrystalOpen;
    [SerializeField] public GameObject palaceCrystalOpen;
    
    [SerializeField] public GameObject elevator;
    [SerializeField] public GameObject elevatorUp;

    [SerializeField] public GameObject triggerEvent1;
    [SerializeField] public GameObject triggerEvent2;
    [SerializeField] public GameObject triggerEvent3;
    [SerializeField] public GameObject triggerEvent4;

    [SerializeField] public GameObject spawnBeam;
    [SerializeField] public GameObject lBeam;
    [SerializeField] public GameObject towerBeam;
    [SerializeField] public GameObject palaceBeam;
    
    [SerializeField] public GameObject itemActive;
    [SerializeField] public Text interactMsg;
    [SerializeField] public Text mission;

    
    float amountOfCrystals = 4;
    void OnTriggerStay(Collider other){
        if(itemActive.activeSelf){
            interactMsg.text = "Activate [E]";
            if(Input.GetKey(KeyCode.E)){
                switch(amountOfCrystals){
                case 1:
                    mission.text = "Last Crystal activated";
                    interactMsg.text = ".";
                    palaceBeam.SetActive(true);
                    palaceCrystal.SetActive(false);
                    palaceCrystalOpen.SetActive(true);
                    triggerEvent4.SetActive(false);
                    break;
                case 2:
                    mission.text = "Third Crystal activated";
                    interactMsg.text = ".";
                    towerBeam.SetActive(true);
                    towerCrystal.SetActive(false);
                    towerCrystalOpen.SetActive(true);
                    triggerEvent3.SetActive(false);
                    break;
                case 3:
                    mission.text = "Second Crystal activated";
                    interactMsg.text = ".";
                    lBeam.SetActive(true);
                    triggerEvent2.SetActive(false);
                    secondCrystal.SetActive(false);
                    secondCrystalOpen.SetActive(true);
                    break;
                case 4:
                    mission.text = "First Crystal activated";
                    interactMsg.text = ".";
                    spawnBeam.SetActive(true);
                    triggerEvent1.SetActive(false);
                    spawnCrystalOpen.SetActive(true);
                    spawnCrystal.SetActive(false);
                    elevator.SetActive(false);
                    elevatorUp.SetActive(true);
                    break;
                }
                amountOfCrystals--;
            }
        }
        else{
            mission.text = "The elevator wont work, seems like you're missing a gear!";
        }
    }
}
