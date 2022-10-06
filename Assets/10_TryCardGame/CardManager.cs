using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public GameObject Card;

    private void Start()
    {
        OnClickTutorial();
    }

    public void OnClickTutorial()
    {
        int isTutorial = 0;
        int tutorialCardLengthX = 4;
        int tutorialCardLengthY = 3;

        SetCardPosition(isTutorial, tutorialCardLengthX, tutorialCardLengthY);
    }

    public void OnClickLevelOne()
    {

    }
    public void OnClickLevelTwo()
    {

    }
    public void OnClickLevelThree()
    {

    }
    public void OnClickLevelFour()
    {

    }
    public void OnClickLevelFive()
    {

    }

    public void SetCardPosition(int gameMode, int cardLengthX, int cardLengthY)
    {
        // 튜토리얼은 카드 포지션 -3, -2 부터 시작
        if (gameMode.Equals(0))
        {
            for (int i = 0; i < cardLengthY; i++)
            {
                for (int j = 0; j < cardLengthX; j++)
                {
                    Instantiate(Card, Card.transform.position, Card.transform.rotation);

                    Card.transform.position = new Vector3(-3 + (2 * j), 0.5f, -2 + (2 * i));
                }
            }
        }
        // 일반게임, 경쟁게임은
        // 1단계 : -2, -2
        // 2단계 : -3, -2
        // 3,4,5단계 : -4.5, -2
        // 부터 시작해서 나눠주기
    }
}
