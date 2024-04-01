using System.Collections;
using _project.Runtime.Core.UI.Scripts.Manager;
using _project.Runtime.Project.Launcher.Scripts.Manager.Bootstrap;
using UnityEngine;

namespace _project.Runtime.Project.UI.Scripts
{
    public class InventoryButtonScript : MonoBehaviour
    {
        public Animator animator;
    
        public void OnButtonClicked()
        {
            animator.SetTrigger("StartAnimation");
            StartCoroutine(WaitAndLoadScreen());
        }

        IEnumerator WaitAndLoadScreen()
        {
            yield return new WaitForSeconds(0.3f);
            OpenInventoryScreen();
        }

        public async void OpenInventoryScreen()
        {
            var screenManager = ScreenManager.Instance;
            await screenManager.OpenScreen(ScreenKeys.InventoryMenuScreen, ScreenLayerKeys.FirstLayer);
        }
    }
}