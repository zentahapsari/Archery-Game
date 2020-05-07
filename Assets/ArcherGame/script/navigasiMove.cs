using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class navigasiMove : MonoBehaviour
{
    public void PindahHalaman(string NamaHalaman) {
      SceneManager.LoadScene(NamaHalaman);
  }
}