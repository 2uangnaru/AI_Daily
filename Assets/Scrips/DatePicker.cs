using UnityEngine;
using UnityEngine.UI; // Bắt buộc phải có để nhận Dropdown

public class DatePicker : MonoBehaviour
{
    public Dropdown dayDropdown;    // slot kéo DayDropdown
    public Dropdown monthDropdown;  // slot kéo MonthDropdown
    public Dropdown yearDropdown;   // slot kéo YearDropdown

    void Start()
    {
        // Điền số ngày từ 1 → 31
        dayDropdown.ClearOptions();
        dayDropdown.options.Add(new Dropdown.OptionData("--")); // mặc định
        for (int i = 1; i <= 31; i++)
            dayDropdown.options.Add(new Dropdown.OptionData(i.ToString()));
        dayDropdown.value = 0;
        dayDropdown.RefreshShownValue();

        // Điền số tháng từ 1 → 12
        monthDropdown.ClearOptions();
        monthDropdown.options.Add(new Dropdown.OptionData("--"));
        for (int i = 1; i <= 12; i++)
            monthDropdown.options.Add(new Dropdown.OptionData(i.ToString()));
        monthDropdown.value = 0;
        monthDropdown.RefreshShownValue();

        // Điền số năm từ 1900 → năm hiện tại
        yearDropdown.ClearOptions();
        yearDropdown.options.Add(new Dropdown.OptionData("--"));
        for (int i = 1980; i <= System.DateTime.Now.Year; i++)
            yearDropdown.options.Add(new Dropdown.OptionData(i.ToString()));
        yearDropdown.value = 0;
        yearDropdown.captionText.text = "--";
        yearDropdown.RefreshShownValue();
    }


    // Lấy ngày đã chọn dạng "dd/mm/yyyy"
    public string GetSelectedDate()
    {
        string day = dayDropdown.options[dayDropdown.value].text;
        string month = monthDropdown.options[monthDropdown.value].text;
        string year = yearDropdown.options[yearDropdown.value].text;

        return day + "/" + month + "/" + year;
    }
}
