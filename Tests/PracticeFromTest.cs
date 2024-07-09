using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twenty_fourth_lesson24.Pages;

namespace Twenty_fourth_lesson24.Tests
{
    internal class PracticeFromTest : BaseTest
    {
        [Test]
        public void PracticFromTests()
        {
            Assert.That(PracticeForm.FillingInTheField(PracticeForm.FirstName,"Dima"),Is.True);
            Assert.That(PracticeForm.FillingInTheField(PracticeForm.LastName,"Bububu"), Is.True);
            Assert.That(PracticeForm.FillingInTheField(PracticeForm.Email, "asdasd@dfddsf.ru"), Is.True);

            Assert.That(PracticeForm.WorkWithInput(PracticeForm.GenderLableMale), Is.True);
            Assert.That(PracticeForm.WorkWithInput(PracticeForm.GenderLableFemale), Is.True);
            Assert.That(PracticeForm.WorkWithInput(PracticeForm.GenderLableOther), Is.True);

            Assert.That(PracticeForm.FillingInTheField(PracticeForm.Mobile, "7777777777"), Is.True);

           
            PracticeForm.WorkWithDateOfBirth();

            Assert.That(PracticeForm.WorkWithInput(PracticeForm.HobbiesLableSports), Is.True);
            Assert.That(PracticeForm.WorkWithInput(PracticeForm.HobbiesLableMusic), Is.True);
            Assert.That(PracticeForm.WorkWithInput(PracticeForm.HobbiesLableReading), Is.True);

            PracticeForm.AddPicture();
            Assert.That(PracticeForm.ClickButtonSubmit(), Is.True);
            
        }
    }
}
