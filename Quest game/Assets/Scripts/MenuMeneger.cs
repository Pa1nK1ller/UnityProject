using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMeneger : MonoBehaviour
{

public void GoToLevel(string sceneName)
    {

        SceneTransition.SwitchToScene(sceneName);
    }
}
