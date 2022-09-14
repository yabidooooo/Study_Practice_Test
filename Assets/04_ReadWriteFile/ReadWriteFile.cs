using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class ReadWriteFile : MonoBehaviour
{
    public RawImage rawImg;    // �ҷ��� �̹���

    void Start()
    {
        LoadGameData();
    }

    public void LoadGameData()
    {
        // ��� ����
        string _path = Application.persistentDataPath + "/Jeju.PNG";

        if (!File.Exists(_path))
        {
            Debug.Log("������ ���µ���");
            return;
        }

        // �̹����� byte�� �б�
        byte[] byteTextures = File.ReadAllBytes(_path);

        // ���� ����
        File.WriteAllBytes(_path, byteTextures);

        // �ӽ��̹����� ��ȯ
        var tempImage = File.ReadAllBytes(_path);

        // �ؽ��� ���� ��, �ӽ��̹����� ��ȯ
        Texture2D texture = new Texture2D(2048, 1024);
        texture.LoadImage(tempImage);

        // ����Ƽ �̹����� �ӽ��̹��� �ֱ�
        rawImg.texture = texture;
    }

}
