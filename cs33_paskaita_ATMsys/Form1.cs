using cs33_paskaita_ATMsys.AtmFunctions;
using cs33_paskaita_ATMsys.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs33_paskaita_ATMsys
{
    public partial class Form1 : Form
    {
        public static int CardIndicator;

        public Form1()
        {
            InitializeComponent();
        }

        private void AtmMonitor_TextChanged(object sender, EventArgs e)
        {

        }

        private void TurnOn_Click(object sender, EventArgs e)
        {
            AtmMonitor.Clear();
            AtmMonitor.AppendText(ToolTipsSys.TurnOnTooltip());
            CardInitialisation.LoadCards();
        }
        private void TurnOff_Click(object sender, EventArgs e)
        {
            AtmMonitor.Clear();
        }

        #region CardIndicator
        private void Card1_Click(object sender, EventArgs e)
        {
            AtmMonitor.Clear();
            CardIndicator = 0;
            AtmMonitor.AppendText(CardInitialisation.CardSelector(CardIndicator));
        }

        private void Card2_Click(object sender, EventArgs e)
        {
            AtmMonitor.Clear();
            CardIndicator = 1;
            AtmMonitor.AppendText(CardInitialisation.CardSelector(CardIndicator));
        }

        private void Card3_Click(object sender, EventArgs e)
        {
            AtmMonitor.Clear();
            CardIndicator = 2;
            AtmMonitor.AppendText(CardInitialisation.CardSelector(CardIndicator));
        }

        private void Card4_Click(object sender, EventArgs e)
        {
            AtmMonitor.Clear();
            CardIndicator = 3;
            AtmMonitor.AppendText(CardInitialisation.CardSelector(CardIndicator));
        }
        #endregion

        #region KeyPad
        private void InputNum1_Click(object sender, EventArgs e)
        {
            AtmMonitor.AppendText("1");
            PasswordAuthentication.PasswordConstructor("1");
            WithdrawalHandler.WitthdrawalConstructor("1");
        }

        private void InputNum2_Click(object sender, EventArgs e)
        {
            AtmMonitor.AppendText("2");
            PasswordAuthentication.PasswordConstructor("2");
            WithdrawalHandler.WitthdrawalConstructor("2");
        }

        private void InputNum3_Click(object sender, EventArgs e)
        {
            AtmMonitor.AppendText("3");
            PasswordAuthentication.PasswordConstructor("3");
            WithdrawalHandler.WitthdrawalConstructor("3");
        }

        private void InputNum4_Click(object sender, EventArgs e)
        {
            AtmMonitor.AppendText("4");
            PasswordAuthentication.PasswordConstructor("4");
            WithdrawalHandler.WitthdrawalConstructor("4");
        }

        private void InputNum5_Click(object sender, EventArgs e)
        {
            AtmMonitor.AppendText("5");
            PasswordAuthentication.PasswordConstructor("5");
            WithdrawalHandler.WitthdrawalConstructor("5");
        }

        private void InputNum6_Click(object sender, EventArgs e)
        {
            AtmMonitor.AppendText("6");
            PasswordAuthentication.PasswordConstructor("6");
            WithdrawalHandler.WitthdrawalConstructor("6");
        }

        private void InputNum7_Click(object sender, EventArgs e)
        {
            AtmMonitor.AppendText("7");
            PasswordAuthentication.PasswordConstructor("7");
            WithdrawalHandler.WitthdrawalConstructor("7");
        }

        private void InputNum8_Click(object sender, EventArgs e)
        {
            AtmMonitor.AppendText("8");
            PasswordAuthentication.PasswordConstructor("8");
            WithdrawalHandler.WitthdrawalConstructor("8");
        }

        private void InputNum9_Click(object sender, EventArgs e)
        {
            AtmMonitor.AppendText("9");
            PasswordAuthentication.PasswordConstructor("9");
            WithdrawalHandler.WitthdrawalConstructor("9");
        }

        private void InputNum0_Click(object sender, EventArgs e)
        {
            AtmMonitor.AppendText("0");
            PasswordAuthentication.PasswordConstructor("0");
            WithdrawalHandler.WitthdrawalConstructor("0");
        }
        #endregion

        private void EnterButton_Click(object sender, EventArgs e)
        {
            List<UserDataType> userList = CardInitialisation.LoadCards();
            if (userList[CardIndicator].IsBlocked == true)
            {
                AtmMonitor.AppendText($"\n   (!) BLOKUOTA.");
            }
            else
            {
                if (PasswordAuthentication.PasswordValidation(userList, CardIndicator))
                {
                    AtmMonitor.Clear();
                    AtmMonitor.AppendText(ToolTipsSys.CardInsertTooltip());
                    PasswordAuthentication.ResetPasswordInputLimit(userList, CardIndicator);
                }

                if (!PasswordAuthentication.PasswordValidation(userList, CardIndicator))
                {
                    AtmMonitor.AppendText($"\nSlaptažodis neteisingas liko { 3 - userList[CardIndicator].PasswordInputLimit}" +
                                          $"\n   įvestis: ");
                    PasswordAuthentication.PasswordInputLimitCounter(userList, CardIndicator);
                    if (userList[CardIndicator].PasswordInputLimit == 3)
                    {
                        PasswordAuthentication.CardBlocking(userList, CardIndicator);
                        AtmMonitor.AppendText($"\n   (!) BLOKUOTA.");
                    }
                }
            }
            PasswordAuthentication.Password = "";
            WithdrawalHandler.Sum = "";
        }

        private void CheckBalance_Click(object sender, EventArgs e)
        {
            List<UserDataType> userList = CardInitialisation.LoadCards();
            AtmMonitor.Clear();
            AtmMonitor.AppendText($"\n     {userList[CardIndicator].Balance} Eur");
        }
        private void LastOperations_Click(object sender, EventArgs e)
        {
            List<UserDataType> userList = CardInitialisation.LoadCards();
            AtmMonitor.Clear();
            foreach (var item in userList[CardIndicator].LastFiveOperations)
            {
                AtmMonitor.AppendText($"\n     -{item} Eur");
            }
        }
        private void CashOut_Click(object sender, EventArgs e)
        {
            AtmMonitor.Clear();
            AtmMonitor.AppendText(ToolTipsSys.InputToolTip());
        }

        private void Withdraw_Click(object sender, EventArgs e)
        {
            List<UserDataType> userList = CardInitialisation.LoadCards();
            WithdrawalHandler.Withdraw(userList, CardIndicator);
            PasswordAuthentication.Password = "";
            WithdrawalHandler.Sum = "";
            AtmMonitor.Clear();
            AtmMonitor.AppendText($"\n             Naujas likutis: {userList[CardIndicator].Balance} Eur");
            AtmMonitor.AppendText($"\n Operacijų šiandien likutis: {userList[CardIndicator].OperationsLimit}");
        }

        private void Backspace_Click(object sender, EventArgs e)
        {

        }
    }

}
