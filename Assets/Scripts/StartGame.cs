using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
   [SerializeField] private Button _startButton;

   private void Start()
   {
      _startButton.onClick.AddListener(EnterGame);
   }

   public void EnterGame()
   {
      Debug.Log($"Enter Game");
      SceneManager.LoadScene("GameOverScene");
   }
}
