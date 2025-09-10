using UnityEngine;
using UnityEngine.SceneManagement;

public class OnboardingManager : MonoBehaviour
{
    [SerializeField] private string onboardingSceneName = "OnboardingScene";
    [SerializeField] private string homeSceneName = "HomeScene";

    void Start()
    {
        // Kiểm tra xem user đã nhập DOB chưa
        if (PlayerPrefs.HasKey("UserYear"))
        {
            // Nếu có rồi → vào màn hình chính
            SceneManager.LoadScene(homeSceneName);
        }
        else
        {
            // Nếu chưa có → mở form Onboarding nhập DOB
            SceneManager.LoadScene(onboardingSceneName);
        }
    }
}
