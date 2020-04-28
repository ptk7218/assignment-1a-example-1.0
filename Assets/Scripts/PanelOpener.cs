using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
    public GameObject panel1, panel2, panel3, panel4;

    public void OpenPanel() {
        panel2.SetActive(false);
        panel3.SetActive(false);
        panel4.SetActive(false);

        if (panel1 != null) {
            bool isActive = panel1.activeSelf;

            panel1.SetActive(!isActive);
        }
    }
}
