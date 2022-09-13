using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LobbyManager : MonoBehaviour
{
    public void _OnClickNextStage()
    {
        SceneManager.LoadScene(1);
    }
}
