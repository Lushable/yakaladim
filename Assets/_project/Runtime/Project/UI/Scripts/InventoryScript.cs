using System.Collections;
using UnityEngine;

namespace _project.Runtime.Project.UI.Scripts
{
    public class InventoryScript : MonoBehaviour
    { 
        public Animator animator;
        public string triggerName = "StartAnimation";
        public float animationDuration = 0.3f;
        private bool animationPlayed = false;

        void Start()
        {
            // Animasyonu oynatma işlemini başlat
            animator.SetTrigger(triggerName);
        }

        void Update()
        {
            // Animasyonu oynatıldıysa ve süre tamamlandıysa
            if (animationPlayed && Time.time >= animationDuration)
            {
                // Animasyonu durdurmak için trigger'ı sıfırlayın
                animator.ResetTrigger(triggerName);
                // Artık animasyonun oynatılmadığını belirtmek için flag'i güncelleyin
                animationPlayed = false;
            }
        }

        // Animasyon oynatıldığında bu metod tetiklenir
        public void OnAnimationPlayed()
        {
            // Animasyonun oynatıldığını belirtmek için flag'i güncelleyin
            animationPlayed = true;
        }
    }
}