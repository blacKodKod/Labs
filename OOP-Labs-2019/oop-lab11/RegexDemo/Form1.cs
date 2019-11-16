using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Regex phone = new Regex(@"^(\+?380?[( \-]?)?\d{2,3}[) \-]?[ \-]?\d{2,3}[ \-.]?\d{2}[ \-.]?\d{2,3}$");
        Regex passport = new Regex(@"^\d{9}$");
        Regex number = new Regex(@"^(?:(1((0((3((1[1-9])|([2-9]\d)))|([4-9]\d{2})))|([1-9]\d{3})))|([2-7]\d{4})|(8(([0-8]\d{3})|(9(([0-5]\d{2})|(6(([0-3]\d)|(4[0-5]))))))))$");
        Regex ukrName = new Regex(@"^(?:([А-ЯІЇЄҐ][а-яіїєґ]+)&([^ЪЭЫъэы])*)$");
        Regex time = new Regex(@"^(?:[01]\d|2[0-4]):(?:[0-5]\d)$");
        Regex email = new Regex("^(?:[\\w!#$%&'*+\\-/=?^{|}~]+)(?:\"[\\w(),:;<>@[\\]]*(.{2})?[\\w(),:;<>@[\\]]*\")*(?:[\\w!#$%&'*+\\-/=?^{|}~]+)(?:\\.[\\w!#$%&'*+\\-/=?^_{|}~]+)*@[\\w-]+(?:\\.\\w+)*(?:\\.[A-Za-z]{2,})$");
       
        private void labelStatusPhone_TextChanged(object sender, EventArgs e)
        {
            if (phone.IsMatch(textBoxPhone.Text))
                OK(labelStatusPhone);
            else
                Error(labelStatusPhone);
        }

        private void labelStatusPassport_TextChanged(object sender, EventArgs e)
        {
            if (passport.IsMatch(textBoxPassport.Text))
                OK(labelStatusPassport);
            else
                Error(labelStatusPassport);
        }

        private void labelStatusNumber_TextChanged(object sender, EventArgs e)
        {
            if (number.IsMatch(textBoxNumber.Text))
                OK(labelStatusNumber);
            else
                Error(labelStatusNumber);
        }

        private void labelStatusUkrName_TextChanged(object sender, EventArgs e)
        {
            if (ukrName.IsMatch(textBoxUkrName.Text))
                OK(labelStatusUkrName);
            else
                Error(labelStatusUkrName);
        }

        private void labelStatusTime_TextChanged(object sender, EventArgs e)
        {
            if (time.IsMatch(textBoxTime.Text))
                OK(labelStatusTime);
            else
                Error(labelStatusTime);
        }

        private void labelStatusEmail_TextChanged(object sender, EventArgs e)
        {
            if (email.IsMatch(textBoxEmail.Text))
                OK(labelStatusEmail);
            else
                Error(labelStatusEmail);
        }

        void OK(Label label)
        {
            label.ForeColor = Color.Green;
            label.Text = "OK";
        }

        void Error(Label label)
        {
            label.ForeColor = Color.Red;
            label.Text = "Помилка";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelStatusPhone_TextChanged(sender, e);
            labelStatusPassport_TextChanged(sender, e);
            labelStatusNumber_TextChanged(sender, e);
            labelStatusUkrName_TextChanged(sender, e);
            labelStatusTime_TextChanged(sender, e);
            labelStatusEmail_TextChanged(sender, e);
        }
    }
}
