using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // cho Dropdown


public class DOBManager : MonoBehaviour
{
    public Dropdown dayDropdown;
    public Dropdown monthDropdown;
    public Dropdown yearDropdown;

    [SerializeField] private string homeSceneName = "Home";
    // Gọi khi bấm nút Confirm
    public void SaveDOB()
    {
        int day = dayDropdown.value;   // index bắt đầu từ 0
        int month = monthDropdown.value;
        int year = int.Parse(yearDropdown.options[yearDropdown.value].text);

        // Lưu vào PlayerPrefs
        PlayerPrefs.SetInt("UserDay", day);
        PlayerPrefs.SetInt("UserMonth", month);
        PlayerPrefs.SetInt("UserYear", year);
        PlayerPrefs.Save();

        // 🔮 Gọi AstrologyHelper
        string zodiac = AstrologyHelper.GetZodiacSign(day, month);
        int lifePath = AstrologyHelper.GetLifePathNumber(day, month, year);

        Debug.Log($"Saved DOB: {day}/{month}/{year}");
        Debug.Log($"Zodiac: {zodiac}");
        Debug.Log($"Life Path Number: {lifePath}");

        // Chuyển sang HomeScene
        SceneManager.LoadScene(homeSceneName);

    }

    // Load DOB khi mở app
    public void LoadDOB()
    {
        if (PlayerPrefs.HasKey("UserYear"))
        {
            int day = PlayerPrefs.GetInt("UserDay");
            int month = PlayerPrefs.GetInt("UserMonth");
            int year = PlayerPrefs.GetInt("UserYear");

            Debug.Log($"Loaded DOB: {day}/{month}/{year}");
        }
        else
        {
            Debug.Log("No DOB saved yet!");
        }
    }
}
