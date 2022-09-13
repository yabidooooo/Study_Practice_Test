using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // �ٽ��ϱ� �ɼ�
    public void _OnClickRestart()
    {
        // ���� �ӵ��� 1������� ��ȯ�Ѵ�.
        Time.timeScale = 1f;

        // ���� �� ��ȣ�� �ٽ� �ε��Ѵ�.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        // �ε� ȭ�� ���� �ε��Ѵ�.
        SceneManager.LoadScene(1);
    }
}
