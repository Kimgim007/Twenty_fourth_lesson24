using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twenty_fourth_lesson24.Elements;

namespace Twenty_fourth_lesson24.Pages
{
    public class PracticeForm
    {
        public static Element FirstName => new Element(By.XPath("//*[@id='firstName']"));
        public static Element LastName => new Element(By.XPath("//*[@id='lastName']"));

        // ТУТ НЕ СОВСЕМ ПОНЯЛ НАШЁЛ РЕШЕНИЕ В ИНТЕРНЕТЕ lable перекрывает Input и надо прописать так. /..
        public static Element GenderLableMale => new Element(By.XPath("//*[@id='gender-radio-1']/.."));
        public static Element GenderLableFemale => new Element(By.XPath("//*[@id='gender-radio-2']/.."));
        public static Element GenderLableOther => new Element(By.XPath("//*[@id='gender-radio-3']/.."));

        public static Element Email => new Element(By.XPath("//*[@id='userEmail']"));
        public static Element Mobile => new Element(By.XPath("//*[@id='userNumber']"));

        public static Element DateOfBirth => new Element(By.XPath("//*[@id='dateOfBirthInput']"));
        public static Element SelectedDay => new Element(By.XPath("//*[@id='dateOfBirth']/div[2]/div[2]/div/div/div[2]/div[2]/div[5]/div[7]"));
        public static Element SelectedMonth => new Element(By.XPath("//*[@id='dateOfBirth']/div[2]/div[2]/div/div/div[2]/div[1]/div[2]/div[1]/select"));
        public static Element SelectedYear => new Element(By.XPath("//*[@id='dateOfBirth']/div[2]/div[2]/div/div/div[2]/div[1]/div[2]/div[2]/select"));


        public static Element HobbiesLableSports => new Element(By.XPath("//*[@id='hobbies-checkbox-1']/.."));
        public static Element HobbiesLableReading => new Element(By.XPath("//*[@id='hobbies-checkbox-2']/.."));
        public static Element HobbiesLableMusic => new Element(By.XPath("//*[@id='hobbies-checkbox-3']/.."));


        public static Element InputPicture => new Element(By.XPath("//*[@id='uploadPicture']"));


        public static Element buttonSubmit => new Element(By.XPath("//*[@id='submit']"));
        public static Element modal_content => new Element(By.XPath("//*[@class='modal-content']"));
        //*[@class='modal-content']
        public static bool FillingInTheField(Element element, string text)
        {
            element.ClearField();
            element.SentValue($"{text}");
            var elementForDebug = element.GetValue();
            if (elementForDebug == null || elementForDebug.Length == 0 || elementForDebug != text)
            {
                return false;
            }
            return true;
        }

        public static bool WorkWithInput(Element element)
        {
            element.Click();
            var debugDot = GenderLableMale.IsInputFocused();
            return true;
        }

        public static bool WorkWithDateOfBirth()
        {
            DateOfBirth.Click();
            var yearSelected = SelectedYear.SelectElements();
            yearSelected[100].Click();
            var monthSelected = SelectedMonth.SelectElements();
            monthSelected[0].Click();
            SelectedDay.Click();
            var valueOnField = DateOfBirth.GetValue();

            if(valueOnField != "29 Jan 2000")
            {
                return false;
            }

            return true;
        }

        public static bool AddPicture()
        {
            //InputPicture.Click();
            var pathImage = Path.GetFullPath("YDzmQXWILAg.jpg");
            InputPicture.SentValue(pathImage);
            return true;
        }

        public static bool ClickButtonSubmit()
        {
            buttonSubmit.Click();  
            if(modal_content.ElementDispleed())
            {
                return true;
            }
            return false;
        }
    }
}
