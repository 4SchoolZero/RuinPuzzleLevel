using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathScript : MonoBehaviour
{
    private void Update() {
        if(Input.GetKey(KeyCode.R)){
            SceneManager.LoadScene("level");
        }
    }
    public void deathScreen(){
        SceneManager.LoadScene("deathScreen");
    }
}
