﻿using Assets.Scripts.Presenter.Start;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.View.Start
{
    public class ServerUiProperty : MonoBehaviour
    {
        public Text Text;
        public Image Image;
        public Sprite ServerItemSpriteRed;
        public Sprite ServerItemSpriteGreen;

        [HideInInspector] public string Ip = "127.0.0.1:8090";
        [HideInInspector] public string Name = "一区 马达加斯加";
        [HideInInspector] public int Count = 100;

        public void Set(string ip, string name, int count)
        {
            this.Ip = ip;
            this.Name = name;
            this.Count = count;

            Text.text = name;
            Image.sprite = Count > 50 ? ServerItemSpriteRed : ServerItemSpriteGreen;
        }

        public void SelectButtonClick()
        {
            StartMenuController.Instance.OnServerButtonClick(this);
        }
    }
}