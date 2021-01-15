using System;
using CLarkTest.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace CLarkTest.Definitions
{
    [Binding]
    public class HappyScenariosSteps
    {
        [Given(@"Open link ""(.*)""")]
        public void GivenOpenLink(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                throw new Exception("Please specify url. It can't be empty");
            }

            ContractsPO.GoToUrl(url);

            CommonMethods.WaitForCondition(() => ContractsPO.cookiesAcceptButton.Enabled);
            ContractsPO.cookiesAcceptButton.Click();
        }
        
        [Given(@"Click on the button ""(.*)""")]
        public void GivenClickOnTheButton(string button)
        {
            if (string.IsNullOrWhiteSpace(button))
            {
                throw new Exception("Button value is missing, please specify it");
            }

            ContractsPO contPo = new ContractsPO();
            IWebElement desiredBut = null;
            try
            {
                desiredBut = (IWebElement)typeof(ContractsPO).GetProperty(button).GetValue(contPo);
            }
            catch
            {
                throw new Exception(String.Format("There are no available elements witn name {0}", desiredBut));
            }
            
            CommonMethods.WaitForCondition(() => desiredBut.Enabled);
            desiredBut.Click();
        }

        [Then(@"Select ""(.*)"" category")]
        public void ThenSelectCategory(string categoryName)
        {
            if (string.IsNullOrWhiteSpace(categoryName))
            {
                throw new Exception("Category is empty. please specify it");
            }
            CategoriesPO catPo = new CategoriesPO();
            IWebElement desiredCat = null;
            try
            {
                desiredCat = (IWebElement)typeof(CategoriesPO).GetProperty(categoryName).GetValue(catPo);
            }
            catch
            {
                throw new Exception(String.Format("There are no available elements witn name {0}", categoryName));
            }

            CommonMethods.WaitForCondition(() => CommonMethods.ElementPresent(desiredCat));
            ScenarioContext.Current.Add("categoryName", categoryName);
            desiredCat.Click();
        }

        [Then(@"Click ""(.*)"" to navigate to questionaire")]
        public void ThenClickToNavigateToQuestionaire(string buttonName)
        {
            if (string.IsNullOrWhiteSpace(buttonName))
            {
                throw new Exception("Element for click value is empty. please specify it");
            }
            QuestionnairePO qestPo = new QuestionnairePO();
            IWebElement desiredElement = null;
            try
            {
                desiredElement = (IWebElement)typeof(QuestionnairePO).GetProperty(buttonName).GetValue(qestPo);
            }
            catch 
            {
                throw new Exception(String.Format("There are no available elements witn name {0}", buttonName));
            }
            
            CommonMethods.WaitForCondition(() => CommonMethods.ElementPresent(desiredElement));
           /* string actualCatName = QuestionnairePO.CategoryName.Text;
            actualCatName = actualCatName.Replace("-", "");
            string selectedCategory = ScenarioContext.Current.Get<string>("categoryName");
            Assert.AreEqual(selectedCategory, actualCatName);*/
            desiredElement.Click();

        }

        [Then(@"Select ""(.*)"" answer for Wen möchtest du versichern\?")]
        public void ThenSelectAnswerForWenMochtestDuVersichern(string answerVal)
        {
            if (string.IsNullOrWhiteSpace(answerVal))
            {
                throw new Exception("Answer value is empty. please specify it");
            }

            SelectQuestionnaireAnswers(answerVal);
        }

        private static void SelectQuestionnaireAnswers(string answerVal)
        {
            QuestionnairePO qestPo = new QuestionnairePO();
            IWebElement desiredAnswer = null;
            try
            {
                desiredAnswer = (IWebElement) typeof(QuestionnairePO).GetProperty(answerVal).GetValue(qestPo);
            }
            catch
            {
                throw new Exception(String.Format("There are no available elements witn name {0}", answerVal));
            }

            CommonMethods.WaitForCondition(() => CommonMethods.ElementPresent(desiredAnswer));
            desiredAnswer.Click();
        }

        [Then(@"Select ""(.*)"" answer for Trifft einer der aufgeführten Fälle auf dich zu\?")]
        public void ThenSelectAnswerForTrifftEinerDerAufgefuhrtenFalleAufDichZu(string answerVal)
        {
            if (string.IsNullOrWhiteSpace(answerVal))
            {
                throw new Exception("Answer value is empty. please specify it");
            }

            SelectQuestionnaireAnswers(answerVal);
        }

        [Then(@"Select ""(.*)"" for Möchtest du bei einem Schadensfall einen Teil selbst bezahlen\?")]
        public void ThenSelectForMochtestDuBeiEinemSchadensfallEinenTeilSelbstBezahlen(string answerVal)
        {
            if (string.IsNullOrWhiteSpace(answerVal))
            {
                throw new Exception("Answer value is empty. please specify it");
            }

            SelectQuestionnaireAnswers(answerVal);
        }

        [Then(@"Input ""(.*)"" to the fild for Hast du noch weitere Informationen oder Anmerkungen für uns\?")]
        public void ThenInputToTheFildForHastDuNochWeitereInformationenOderAnmerkungenFurUns(string inputVal)
        {
            if (!string.IsNullOrEmpty(inputVal) || !string.IsNullOrWhiteSpace(inputVal))
            {
                CommonMethods.WaitForCondition(() => CommonMethods.ElementPresent(QuestionnairePO.CommentsInputField));
                QuestionnairePO.CommentsInputField.SendKeys(inputVal);
            }
            CommonMethods.WaitForCondition(() => CommonMethods.ElementPresent(QuestionnairePO.AngebotAnfordenButton));
            QuestionnairePO.AngebotAnfordenButton.Click();
        }

        [Then(@"Click Zum Angebote to open offers page")]
        public void ThenClickZumAngeboteToOpenOffersPage()
        {
            CommonMethods.WaitForCondition(() => CommonMethods.ElementPresent(QuestionnairePO.ZumAngebotButton));
            QuestionnairePO.ZumAngebotButton.Click();
        }

        [Then(@"Select ""(.*)"" insurance")]
        public void ThenSelectInsurance(string insurance)
        {
            OffersPO offPo = new OffersPO();
            IWebElement desiredInsurance = null;
            try
            {
                desiredInsurance = (IWebElement)typeof(OffersPO).GetProperty(insurance).GetValue(offPo);
            }
            catch
            {
                throw new Exception(String.Format("There are no available elements witn name {0}", insurance));
            }

            CommonMethods.WaitForCondition(() => CommonMethods.ElementPresent(desiredInsurance));
            desiredInsurance.Click();
        }

        [Then(@"Login to application using email ""(.*)"" and ""(.*)"" password")]
        [Obsolete]
        public void ThenLoginToApplicationUsingEmailAndPassword(string emailVal, string passVal)
        {
            if (string.IsNullOrWhiteSpace(emailVal))
            {
                throw new Exception("Email value cann't be empty. Please, input it");
            }

            if (string.IsNullOrWhiteSpace(passVal))
            {
                throw new Exception("Password value cann't be empty. Please, input it");
            }

            string fullEmail = string.Empty;
            if (emailVal == "Dynamic")
            {
                fullEmail = "clark@clark.clark" + DateTime.Now.ToString("yyyyMMddHHmmssfff");
                ScenarioContext.Current.Add("Email", fullEmail);
            }
            else
            {
                fullEmail = emailVal;
                ScenarioContext.Current.Add("Email", fullEmail);
            }
            CommonMethods.WaitForCondition(() => CommonMethods.ElementPresent(LoginPO.EmailField));
            LoginPO.EmailField.SendKeys(fullEmail);
            CommonMethods.WaitForCondition(() => CommonMethods.ElementPresent(LoginPO.PasswordField));
            LoginPO.PasswordField.SendKeys(passVal);
            CommonMethods.WaitForCondition(() => CommonMethods.ElementPresent(LoginPO.RegisterButton));
            LoginPO.RegisterButton.Click();
        }


        [Then(@"Input value Anrede ""(.*)"" Vorname ""(.*)"" Nachname ""(.*)"" Geburtsdatum ""(.*)"" Strase ""(.*)"" Hausnr ""(.*)"" PLZ ""(.*)"" Ort ""(.*)"" Telefonnummer ""(.*)""")]
        public void ThenInputValueAnredeVornameNachnameGeburtsdatumStraseHausnrPLZOrtTelefonnummer(string anrede, string vornameVal, string nachnameVal, string geburtsdatumVal, string straseVal, string hausnVal, string plzVal, string ortVal, string telVal)
        {
            ProfilePO profPo = new ProfilePO();
            IWebElement desiredAnrede = null;
            try
            {
                desiredAnrede = (IWebElement)typeof(ProfilePO).GetProperty(anrede).GetValue(profPo);
            }
            catch
            {
                throw new Exception(String.Format("There are no available elements witn name {0}", anrede));
            }

            CommonMethods.WaitForCondition(() => CommonMethods.ElementPresent(desiredAnrede));
            CommonMethods.MouseClick(desiredAnrede);

            CommonMethods.WaitForCondition(() => CommonMethods.ElementPresent(ProfilePO.VornameField));
            ProfilePO.VornameField.SendKeys(vornameVal);
            ScenarioContext.Current.Add("Vorname", vornameVal);

            CommonMethods.WaitForCondition(() => CommonMethods.ElementPresent(ProfilePO.NachNameField));
             ProfilePO.NachNameField.SendKeys(nachnameVal);
            ScenarioContext.Current.Add("Nachname", nachnameVal);

            CommonMethods.WaitForCondition(() => CommonMethods.ElementPresent(ProfilePO.GeburtsDatumField));
            ProfilePO.GeburtsDatumField.SendKeys(geburtsdatumVal);
            ScenarioContext.Current.Add("GeburtsDatum", geburtsdatumVal);

            CommonMethods.WaitForCondition(() => CommonMethods.ElementPresent(ProfilePO.StraseField));
            ProfilePO.StraseField.SendKeys(straseVal);
            ScenarioContext.Current.Add("Strase", straseVal);

            CommonMethods.WaitForCondition(() => CommonMethods.ElementPresent(ProfilePO.HausnrField));
            ProfilePO.HausnrField.SendKeys(hausnVal);
            ScenarioContext.Current.Add("Hausnnr", hausnVal);

            CommonMethods.WaitForCondition(() => CommonMethods.ElementPresent(ProfilePO.PlzField));
            ProfilePO.PlzField.SendKeys(plzVal);
            ScenarioContext.Current.Add("PLZ", plzVal);

            CommonMethods.WaitForCondition(() => CommonMethods.ElementPresent(ProfilePO.OrtField));
            ProfilePO.OrtField.SendKeys(ortVal);
            ScenarioContext.Current.Add("Ort", ortVal);

            CommonMethods.WaitForCondition(() => CommonMethods.ElementPresent(ProfilePO.TelefonnummerField));
            ProfilePO.TelefonnummerField.SendKeys(telVal);
            ScenarioContext.Current.Add("Telefonnummer", telVal);

            CommonMethods.WaitForCondition(() => CommonMethods.ElementPresent(ProfilePO.WeiterButton));
            ProfilePO.WeiterButton.Click();

        }

        [Then(@"Select ""(.*)"" for Gewünschter Versicherungsbeginn and ""(.*)"" for Vorschäden")]
        public void ThenSelectForGewunschterVersicherungsbeginnAndForVorschaden(string firstAnswer, string secondAnswer)
        {
            StartDatePO startPo= new StartDatePO();
            IWebElement desiredFirstAnswer = null;
            try
            {
                desiredFirstAnswer = (IWebElement)typeof(StartDatePO).GetProperty(firstAnswer).GetValue(startPo);
            }
            catch
            {
                throw new Exception(String.Format("There are no available elements witn name {0}", firstAnswer));
            }

            CommonMethods.WaitForCondition(() => CommonMethods.ElementPresent(desiredFirstAnswer));
            CommonMethods.MouseClick(desiredFirstAnswer);
            IWebElement desiredSecondAnswer = null;
            try
            {
                desiredSecondAnswer = (IWebElement)typeof(StartDatePO).GetProperty(secondAnswer).GetValue(startPo);
            }
            catch
            {
                throw new Exception(String.Format("There are no available elements witn name {0}", secondAnswer));
            }

            CommonMethods.WaitForCondition(() => CommonMethods.ElementPresent(desiredSecondAnswer));
            CommonMethods.MouseClick(desiredSecondAnswer);

            CommonMethods.WaitForCondition(() => CommonMethods.ElementPresent(StartDatePO.WeiterButton));
            StartDatePO.WeiterButton.Click();
        }

        [Then(@"Input IBAN ""(.*)"" and select checkbox ""(.*)""")]
        public void ThenInputIBANAndSelectCheckbox(string ibanVal, bool checkboxVal)
        {
            CommonMethods.WaitForCondition(() => CommonMethods.ElementPresent(PaymentDetailsPO.ibanFields));
            PaymentDetailsPO.ibanFields.SendKeys(ibanVal);
            ScenarioContext.Current.Add("IBAN", ibanVal);
            CommonMethods.WaitForCondition(() => CommonMethods.ElementPresent(PaymentDetailsPO.checkbox));
            if (checkboxVal)
            {
                CommonMethods.MouseClick(PaymentDetailsPO.checkbox);
            }
            CommonMethods.WaitForCondition(() => CommonMethods.ElementPresent(PaymentDetailsPO.WeiterButton));
            PaymentDetailsPO.WeiterButton.Click();
        }

        [Then(@"Verify Deine Angaben block")]
        public void ThenVerifyDeineAngabenBlock()
        {
            string telefonInputted = ScenarioContext.Current.Get<string>("Telefonnummer");
            CommonMethods.WaitForCondition(() => CommonMethods.ElementPresent(SummaryPO.TelefonField));
            string telefoActual = SummaryPO.TelefonField.Text;
            Assert.IsTrue(telefonInputted == telefoActual);
            //and in such way for all other fields that can be saved and compared during all scenario
            
            CommonMethods.WaitForCondition(() => CommonMethods.ElementPresent(SummaryPO.ZumAbschlussButton));
            SummaryPO.ZumAbschlussButton.Click();
        }

        [Then(@"Verify Awesome page appearence")]
        public void ThenVerifyAwesomePageAppearence()
        {
            CommonMethods.WaitForCondition(() => CommonMethods.ElementPresent(AwesomePO.ZurVertagsubersichtButton));
            AwesomePO.ZurVertagsubersichtButton.Click();
        }

        [Then(@"Verify redirect to Manager page")]
        public void ThenVerifyRedirectToManagerPage()
        {
            CommonMethods.WaitForCondition(() => CommonMethods.ElementPresent(ManagerPO.JaButton));
            ManagerPO.JaButton.Click();

            var currentUrl = Hooks.driver.Url;
            Assert.IsTrue(currentUrl == ManagerPO.managerUrl);
        }

    }
}
