using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Text.RegularExpressions;
using ClassLibrary;

namespace CoursachOOP
{
    public partial class Form1 : Form
    {
        Client client;
        int code;
        string currency;
        string space = new string('\t', 20);
        Regex phone = new Regex(@"^(\+?38?[(0 \-]?)?\d{2,3}[) \-]?[ \-]?\d{2,3}[ \-.]?\d{2}[ \-.]?\d{2,3}$");
        Regex password = new Regex(@"^\d{4}$");
        public static bool flag = false;
        
        public Form1()
        {
            InitializeComponent();
            pictureBoxScreen.SendToBack();
            pictureBoxCard.BringToFront();
            pictureBoxMoney.BringToFront();
            buttonEnter.BringToFront();
            buttonPutMoney.BringToFront();
            buttonGetMoney.BringToFront();
            buttonGetBalance.BringToFront();
            buttonPutPhone.BringToFront();
            buttonOkPutMoney.BringToFront();
            buttonOkGetMoney.BringToFront();
            buttonOkPutPhone.BringToFront();
            textBoxPinCode.BringToFront();
            textBoxPushMoney.BringToFront();
            textBoxNumberOfPhone.BringToFront();
            label1.BringToFront();
            label2.BringToFront();
            label3.BringToFront();
            label4.BringToFront();
            label5.BringToFront();
            label6.BringToFront();
            label7.BringToFront();
            label8.BringToFront();
            label9.BringToFront();
            label10.BringToFront();
            label11.BringToFront();
            label12.BringToFront();
            label13.BringToFront();
            label14.BringToFront();
            label15.BringToFront();
            label16.BringToFront();
            label17.BringToFront();
            label18.BringToFront();
            label19.BringToFront();
        }

        private void pictureBoxCard_Click(object sender, EventArgs e)
        {
            client = new Client();

            textBoxInfo.Visible = true;
            pictureBoxCard.Visible = false;
            buttonEnter.Visible = true;
            buttonCancel.Visible = true;
            buttonPutMoney.Visible = true;
            buttonGetMoney.Visible = true;
            buttonPayUtilities.Visible = true;
            buttonYes.Visible = true;
            buttonHryvnia.Visible = true;
            buttonRuble.Visible = true;
            buttonEuro.Visible = true;
            buttonDollar.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button0.Visible = true;
            buttonPlus.Visible = true;
            buttonMinus.Visible = true;
            textBoxMenu.Visible = true;
            textBoxPinCode.Visible = true;
            
            buttonCancel.Enabled = false;
            buttonPutMoney.Enabled = false;
            buttonGetMoney.Enabled = false;
            buttonPayUtilities.Enabled = false;
            buttonYes.Enabled = false;
            buttonHryvnia.Enabled = false;
            buttonRuble.Enabled = false;
            buttonEuro.Enabled = false;
            buttonDollar.Enabled = false;
            buttonPlus.Enabled = false;
            buttonMinus.Enabled = false;
            
            Random rnd = new Random();
            code = rnd.Next(1000, 9999);
            textBoxInfo.Text = "Ваш PIN-код:\t" + code;
            textBoxMenu.Text = "ДОБРО ПОЖАЛОВАТЬ! ПОЖАЛУЙСТА, ВВЕДИТЕ ВАШ PIN-КОД И НАЖМИТЕ ENTER:";

            textBoxPinCode.Focus();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string pinCode = textBoxPinCode.Text;
            int err;
            int.TryParse(pinCode, out err);

            if (err != code || err < 1000 || err > 9999 || !(password.IsMatch(textBoxPinCode.Text)))
            {
                textBoxMenu.Text = "ОШИБКА!!!\nВЫ ВВЕЛИ НЕПРАВИЛЬНЫЙ PIN-КОД!\nПОВТОРИТЕ ПОПЫТКУ";
                textBoxPinCode.Visible = true;
                textBoxPinCode.Text = null;
                textBoxNumberOfPhone.Text = null;
                return;
            }
            else
            {
                textBoxPinCode.Visible = false;
                buttonEnter.Visible = false;
                buttonNext.Visible = true;

                textBoxMenu.Text = "ПОЖАЛУЙСТА, ВЫБЕРИТЕ ВАЛЮТУ:";
                
                label16.Visible = true;
                label17.Visible = true;
                label18.Visible = true;
                label19.Visible = true;

                buttonNext.Enabled = false;
                buttonHryvnia.Enabled = true;
                buttonRuble.Enabled = true;
                buttonEuro.Enabled = true;
                buttonDollar.Enabled = true;

                textBoxPinCode.Text = null;
                textBoxInfo.Visible = false;
            }            
        }

        private void buttonHryvnia_Click(object sender, EventArgs e)
        {
            currency = " ₴";

            buttonNext_Click(sender, e);
        }

        private void buttonRuble_Click(object sender, EventArgs e)
        {
            currency = " ₽";

            buttonNext_Click(sender, e);
        }

        private void buttonEuro_Click(object sender, EventArgs e)
        {
            currency = " €";

            buttonNext_Click(sender, e);
        }

        private void buttonDollar_Click(object sender, EventArgs e)
        {
            currency = " $";

            buttonNext_Click(sender, e);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {  
            textBoxMenu.Text = "ПОЖАЛУЙСТА, ВЫБЕРИТЕ ОДНУ ИЗ ОПЕРАЦИЙ:";
                        
            textBoxPushMoney.Text = null;
            textBoxNumberOfPhone.Text = null;
                        
            buttonPutMoney.Visible = true;
            buttonGetMoney.Visible = true;
            buttonGetBalance.Visible = true;
            buttonPutPhone.Visible = true;
            buttonPayUtilities.Visible = true;            
            buttonExit.Visible = true;
            buttonOk.Visible = true;
            buttonOkPutMoney.Visible = false;
            buttonOkGetMoney.Visible = false;
            buttonOkPutPhone.Visible = false;
            buttonYes.Visible = true;
            buttonNo.Visible = false;
            buttonHryvnia.Visible = false;
            buttonRuble.Visible = false;
            buttonEuro.Visible = false;
            buttonDollar.Visible = false;
            textBoxPushMoney.Visible = false;
            textBoxNumberOfPhone.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = true;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;

            buttonPutMoney.Enabled = true;
            buttonGetMoney.Enabled = true;
            buttonGetBalance.Enabled = true;
            buttonPutPhone.Enabled = true;
            buttonPayUtilities.Enabled = true;
            buttonExit.Enabled = true;
            buttonCancel.Enabled = true;
            buttonNext.Enabled = true;
            buttonOk.Enabled = false;
            buttonPlus.Enabled = false;
            buttonMinus.Enabled = false;
        }

        private void buttonPutMoney_Click(object sender, EventArgs e)
        {
            textBoxMenu.Text = "ВВЕДИТЕ СУММУ КРАТНУЮ ДЕСЯТИ И НАЖМИТЕ OK:";
            
            buttonOkPutMoney.Visible = true;
            textBoxPushMoney.Visible = true;
            textBoxNumberOfPhone.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = true;
            label7.Visible = false;
            label8.Visible = true;
            label13.Visible = false;

            buttonPutMoney.Enabled = false;
            buttonGetMoney.Enabled = false;
            buttonGetBalance.Enabled = false;
            buttonPutPhone.Enabled = false;
            buttonPayUtilities.Enabled = false;
            buttonExit.Enabled = false;
            buttonOkPutMoney.Enabled = true;

            textBoxPushMoney.Focus();
        }

        private void buttonOkPutMoney_Click(object sender, EventArgs e)
        {
            int sum;
            string coin = textBoxPushMoney.Text;
            int.TryParse(coin, out sum);

            if(sum == 0)
            {
                textBoxMenu.Text = "ОШИБКА! НЕВОЗМОЖНО ВЫПОЛНИТЬ ОПЕРАЦИЮ. ПОВТОРИТЕ ПОПЫТКУ И НАЖМИТЕ OK:";
                textBoxPushMoney.Text = null;
            }
            else if (sum % 10 != 0)
            {
                textBoxMenu.Text = "ОШИБКА! ВВЕДИТЕ СУММУ КРАТНУЮ ДЕСЯТИ И НАЖМИТЕ OK:";
                textBoxPushMoney.Text = null;
            }
            else
            {
                textBoxInfo.Text = client.putMoney(sum).ToString();

                textBoxMenu.Text = "СЧЕТ УСПЕШНО ПОПОЛНЕНО. ЧТОБЫ ПРОДОЛЖИТЬ НАЖМИТЕ ДАЛЕЕ";

                textBoxPushMoney.Visible = false;
                label6.Visible = false;
                label8.Visible = false;

                buttonOkPutMoney.Enabled = false;
            }            
        }

        private void buttonGetMoney_Click(object sender, EventArgs e)
        {
            textBoxMenu.Text = "ВВЕДИТЕ СУММУ КРАТНУЮ ДЕСЯТИ И НАЖМИТЕ OK:";

            flag = true;
            int sum;
            string coin = textBoxPushMoney.Text;
            int.TryParse(coin, out sum);

            buttonOkGetMoney.Visible = true;
            buttonOkPutPhone.Visible = false;
            textBoxPushMoney.Visible = true;
            textBoxNumberOfPhone.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = true;
            label7.Visible = false;
            label8.Visible = true;
            label13.Visible = false;

            buttonPutMoney.Enabled = false;
            buttonGetMoney.Enabled = false;
            buttonGetBalance.Enabled = false;
            buttonPutPhone.Enabled = false;
            buttonPayUtilities.Enabled = false;
            buttonExit.Enabled = false;
            buttonOkGetMoney.Enabled = true;

            textBoxPushMoney.Focus();
        }

        private void buttonOkGetMoney_Click(object sender, EventArgs e)
        {
            int sum;
            string coin = textBoxPushMoney.Text;
            int.TryParse(coin, out sum);
            int balance = 0;

            if (sum == 0)
            {
                textBoxMenu.Text = "ОШИБКА! НЕВОЗМОЖНО ВЫПОЛНИТЬ ОПЕРАЦИЮ. ПОВТОРИТЕ ПОПЫТКУ И НАЖМИТЕ OK:";
                textBoxPushMoney.Text = null;
            }
            else if (sum % 10 != 0)
            {
                textBoxMenu.Text = "ОШИБКА! ВВЕДИТЕ СУММУ КРАТНУЮ ДЕСЯТИ И НАЖМИТЕ OK:";
                textBoxPushMoney.Text = null;
            }
            else
            {
                balance = client.getMoney(sum);
                if (balance == 0)
                    textBoxMenu.Text = "ОШИБКА!!!\nУ ВАС НЕДОСТАТОЧНО СРЕДСТВ! ЧТОБЫ ПРОДОЛЖИТЬ НАЖМИТЕ ДАЛЕЕ";
                else
                    textBoxMenu.Text = "УСПЕШНО. ЧТОБЫ ПРОДОЛЖИТЬ НАЖМИТЕ ДАЛЕЕ";

                textBoxInfo.Text = balance.ToString();

                textBoxPushMoney.Visible = false;
                textBoxNumberOfPhone.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;

                buttonOkGetMoney.Enabled = false;
            }
        }

        private void buttonGetBalance_Click(object sender, EventArgs e)
        {
            textBoxMenu.Text = "НА ВАШЕМ СЧЕТУ: " + client.getBalance() + currency + " ЧТОБЫ ПРОДОЛЖИТЬ НАЖМИТЕ ДАЛЕЕ";
            textBoxInfo.Text = client.getBalance().ToString();

            textBoxPushMoney.Visible = false;
            textBoxNumberOfPhone.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label13.Visible = false;

            buttonPutMoney.Enabled = false;
            buttonGetMoney.Enabled = false;
            buttonGetBalance.Enabled = false;
            buttonPutPhone.Enabled = false;
            buttonPayUtilities.Enabled = false;
            buttonExit.Enabled = false;
        }

        private void buttonPutPhone_Click(object sender, EventArgs e)
        {
            textBoxMenu.Text = "ВВЕДИТЕ НОМЕР ТЕЛЕФОНА И НАЖМИТЕ OK:";

            buttonOkPutPhone.Visible = true;
            textBoxNumberOfPhone.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = true;
            label7.Visible = true;
            label13.Visible = false;

            buttonPutMoney.Enabled = false;
            buttonGetMoney.Enabled = false;
            buttonGetBalance.Enabled = false;
            buttonPutPhone.Enabled = false;
            buttonPayUtilities.Enabled = false;
            buttonExit.Enabled = false;
            buttonPlus.Enabled = true;
            buttonMinus.Enabled = true;

            textBoxNumberOfPhone.Focus();
        }

        private void buttonOkPutPhone_Click(object sender, EventArgs e)
        {
            string num = textBoxNumberOfPhone.Text;
            int mobile = 0;
            mobile = client.putPhone(num);
            
            if (mobile == 0)
            {
                textBoxMenu.Text = "ОШИБКА!!! ВВЕДИТЕ НОМЕР ТЕЛЕФОНА И НАЖМИТЕ OK:";
            }
            else if (!(phone.IsMatch(textBoxNumberOfPhone.Text)))
            {
                textBoxMenu.Text = "ОШИБКА!!! НЕВЕРНЫЙ ФОРМАТ ТЕЛЕФОНА ПОВТОРИТЕ ПОПЫТКУ И НАЖМИТЕ OK:";
                textBoxNumberOfPhone.Text = null;
            }
            else
                buttonGetMoney_Click(sender, e);

            textBoxPushMoney.Text = null;
        }

        private void buttonPayUtilities_Click(object sender, EventArgs e)
        {
            textBoxMenu.Text = "ПОЖАЛУЙСТА, ВЫБЕРИТЕ УСЛУГУ:";

            buttonPutMoney.Visible = false;
            buttonGetMoney.Visible = false;
            buttonGetBalance.Visible = false;
            buttonPutPhone.Visible = false;
            buttonElectricity.Visible = true;
            buttonHeating.Visible = true;
            buttonWaterService.Visible = true;
            buttonGas.Visible = true;
            textBoxPushMoney.Visible = false;
            textBoxNumberOfPhone.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = false;

            buttonPayUtilities.Enabled = false;
            buttonElectricity.Enabled = true;
            buttonHeating.Enabled = true;
            buttonWaterService.Enabled = true;
            buttonGas.Enabled = true;
            buttonExit.Enabled = false;
            buttonOkGetMoney.Enabled = false;
        }

        private void buttonElectricity_Click(object sender, EventArgs e)
        {
            textBoxMenu.Text = "ОПЛАТА ЭЛЕКТРОЕНЕРГИИ! ВВЕДИТЕ СУММУ ПЛАТЕЖА И НАЖМИТЕ OK:";

            textBoxPushMoney.Visible = true;
            label6.Visible = true;
            label8.Visible = true;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;

            buttonElectricity.Enabled = false;
            buttonHeating.Enabled = false;
            buttonWaterService.Enabled = false;
            buttonGas.Enabled = false;
            buttonOk.Enabled = true;

            textBoxPushMoney.Focus();
        }

        private void buttonHeating_Click(object sender, EventArgs e)
        {
            textBoxMenu.Text = "ОПЛАТА ОТОПЛЕНИЯ! ВВЕДИТЕ СУММУ ПЛАТЕЖА И НАЖМИТЕ OK:";

            textBoxPushMoney.Visible = true;
            label6.Visible = true;
            label8.Visible = true;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;

            buttonElectricity.Enabled = false;
            buttonHeating.Enabled = false;
            buttonWaterService.Enabled = false;
            buttonGas.Enabled = false;
            buttonOk.Enabled = true;

            textBoxPushMoney.Focus();
        }


        private void buttonWaterService_Click(object sender, EventArgs e)
        {
            textBoxMenu.Text = "ОПЛАТА ВОДОСНАБЖЕНИЯ! ВВЕДИТЕ СУММУ ПЛАТЕЖА И НАЖМИТЕ OK:";

            textBoxPushMoney.Visible = true;
            label6.Visible = true;
            label8.Visible = true;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;

            buttonElectricity.Enabled = false;
            buttonHeating.Enabled = false;
            buttonWaterService.Enabled = false;
            buttonGas.Enabled = false;
            buttonOk.Enabled = true;

            textBoxPushMoney.Focus();
        }

        private void buttonGas_Click(object sender, EventArgs e)
        {
            textBoxMenu.Text = "ОПЛАТА ЗА ГАЗ! ВВЕДИТЕ СУММУ ПЛАТЕЖА И НАЖМИТЕ OK:";

            textBoxPushMoney.Visible = true;
            label6.Visible = true;
            label8.Visible = true;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;

            buttonElectricity.Enabled = false;
            buttonHeating.Enabled = false;
            buttonWaterService.Enabled = false;
            buttonGas.Enabled = false;
            buttonOk.Enabled = true;

            textBoxPushMoney.Focus();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            textBoxMenu.Text = "ОПЛАТА ПРОШЛА УСПЕШНО. ЧТОБЫ ПРОДОЛЖИТЬ НАЖМИТЕ ДАЛЕЕ:";
            buttonOkGetMoney_Click(sender, e);

            buttonOk.Enabled = false;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            buttonNext_Click(sender, e);

            pictureBoxReceipt.Visible = false;
            pictureBoxCardExit.Visible = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            textBoxMenu.Text = "РАСПЕЧАТАТЬ ЧЕК?";

            buttonExit.Visible = false;
            buttonOk.Visible = true;
            buttonNo.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label13.Visible = false;
            label14.Visible = true;
            label15.Visible = true;

            buttonPutMoney.Enabled = false;
            buttonGetMoney.Enabled = false;
            buttonGetBalance.Enabled = false;
            buttonPutPhone.Enabled = false;
            buttonPayUtilities.Enabled = false;
            buttonYes.Enabled = true;
            buttonNo.Enabled = true;
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            textBoxMenu.Text = space + "ВОЗЬМИТЕ ВАШ ЧЕК";

            label14.Visible = false;
            label15.Visible = false;
            pictureBoxReceipt.Visible = true;

            buttonYes.Enabled = false;
            buttonNo.Enabled = false;
            buttonCancel.Enabled = false;
            buttonNext.Enabled = false;
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            pictureBoxReceipt_Click(sender, e);

            label14.Visible = false;
            label15.Visible = false;

            buttonYes.Enabled = false;
            buttonNo.Enabled = false;
            buttonCancel.Enabled = false;
            buttonNext.Enabled = false;
        }

        private void pictureBoxReceipt_Click(object sender, EventArgs e)
        {
            textBoxMenu.Text = space + "ВОЗЬМИТЕ ВАШУ КАРТУ";

            pictureBoxReceipt.Visible = false;
            pictureBoxCardExit.Visible = true;
        }

        private void pictureBoxCardExit_Click(object sender, EventArgs e)
        {
            pictureBoxCardExit.Visible = false;
            if (flag == true)
            {
                textBoxMenu.Text = space + "ВОЗЬМИТЕ ВАШИ ДЕНЬГИ";
                
                pictureBoxMoney.Visible = true;
            }
            else
            {
                pictureBoxMoney_Click(sender, e);
            }
        }

        private void pictureBoxMoney_Click(object sender, EventArgs e)
        {
            textBoxMenu.Text = space + "СПАСИБО ЧТО ОБРАТИЛИСЬ В НАШ БАНК";

            textBoxInfo.Text = null;
            textBoxPinCode.Text = null;

            pictureBoxMoney.Visible = false;
            buttonPutMoney.Visible = false;
            buttonGetMoney.Visible = false;
            buttonGetBalance.Visible = false;
            buttonPutPhone.Visible = false;
            buttonElectricity.Visible = false;
            buttonHeating.Visible = false;
            buttonWaterService.Visible = false;
            buttonGas.Visible = false;
            buttonPayUtilities.Visible = false;
            buttonYes.Visible = false;
            buttonNo.Visible = false;
            buttonExit.Visible = false;
            buttonOk.Visible = false;
            buttonOkPutMoney.Visible = false;
            buttonOkGetMoney.Visible = false;
            buttonOkPutPhone.Visible = false;
            buttonEnter.Visible = false;
            buttonNext.Visible = false;
            buttonCancel.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button0.Visible = false;
            buttonPlus.Visible = false;
            buttonMinus.Visible = false;
            buttonRepeat.Visible = true;
        }

        public void pinCode(string num)
        {
            textBoxPinCode.Text += num;
        }

        public void mobPhone(string num)
        {
            textBoxNumberOfPhone.Text += num;
        }

        public void summa(string num)
        {
            textBoxPushMoney.Text += num;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxPinCode.Visible == true)
                pinCode(client.num1());
            if (textBoxNumberOfPhone.Visible == true)
                mobPhone(client.num1());
            if (textBoxPushMoney.Visible == true)
                summa(client.num1());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxPinCode.Visible == true)
                pinCode(client.num2());
            if (textBoxNumberOfPhone.Visible == true)
                mobPhone(client.num2());
            if (textBoxPushMoney.Visible == true)
                summa(client.num2());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxPinCode.Visible == true)
                pinCode(client.num3());
            if (textBoxNumberOfPhone.Visible == true)
                mobPhone(client.num3());
            if (textBoxPushMoney.Visible == true)
                summa(client.num3());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBoxPinCode.Visible == true)
                pinCode(client.num4());
            if (textBoxNumberOfPhone.Visible == true)
                mobPhone(client.num4());
            if (textBoxPushMoney.Visible == true)
                summa(client.num4());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBoxPinCode.Visible == true)
                pinCode(client.num5());
            if (textBoxNumberOfPhone.Visible == true)
                mobPhone(client.num5());
            if (textBoxPushMoney.Visible == true)
                summa(client.num5());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBoxPinCode.Visible == true)
                pinCode(client.num6());
            if (textBoxNumberOfPhone.Visible == true)
                mobPhone(client.num6());
            if (textBoxPushMoney.Visible == true)
                summa(client.num6());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBoxPinCode.Visible == true)
                pinCode(client.num7());
            if (textBoxNumberOfPhone.Visible == true)
                mobPhone(client.num7());
            if (textBoxPushMoney.Visible == true)
                summa(client.num7());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBoxPinCode.Visible == true)
                pinCode(client.num8());
            if (textBoxNumberOfPhone.Visible == true)
                mobPhone(client.num8());
            if (textBoxPushMoney.Visible == true)
                summa(client.num8());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBoxPinCode.Visible == true)
                pinCode(client.num9());
            if (textBoxNumberOfPhone.Visible == true)
                mobPhone(client.num9());
            if (textBoxPushMoney.Visible == true)
                summa(client.num9());
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBoxPinCode.Visible == true)
                pinCode(client.num0());
            if (textBoxNumberOfPhone.Visible == true)
                mobPhone(client.num0());
            if (textBoxPushMoney.Visible == true)
                summa(client.num0());
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            mobPhone(client.numPlus());
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            mobPhone(client.numMinus());
        }

        private void buttonRepeat_Click(object sender, EventArgs e)
        {
            flag = false;

            textBoxMenu.Text = space + "ВСТАВЬТЕ КАРТУ";           

            pictureBoxCard.Visible = true;
            buttonRepeat.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter))
            {
                buttonEnter.PerformClick();
                buttonOkPutMoney.PerformClick();
                buttonOkGetMoney.PerformClick();
                buttonOkPutPhone.PerformClick();
                buttonOk.PerformClick();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}