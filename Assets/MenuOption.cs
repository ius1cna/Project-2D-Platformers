using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuOption : MonoBehaviour {

    public void MainMenuButton (){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }
}
