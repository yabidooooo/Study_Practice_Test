using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // 다시하기 옵션
    public void _OnClickRestart()
    {
        // 게임 속도를 1배속으로 전환한다.
        Time.timeScale = 1f;

        // 현재 씬 번호를 다시 로드한다.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        // 로딩 화면 씬을 로드한다.
        SceneManager.LoadScene(1);
    }
}
