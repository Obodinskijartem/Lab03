using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Створюємо екземпляр класу Subscriber
            Subscriber subscriber = new Subscriber();

            // Відкриваємо вікно для введення даних про нового абонента
            fSubscriber fs = new fSubscriber(subscriber);

            // Якщо у вікні натиснули "Ok", додаємо абонента до списку
            if (fs.ShowDialog() == DialogResult.OK)
            {
                // Формуємо рядок для відображення інформації про абонента
                tbSubscribersInfo.Text += string.Format("Ім'я: {0}, Телефон: {1}, Адреса: {2}, "
                    + "Хвилини розмов: {3}, SMS: {4}, Місячний платіж: {5:0.00} грн\n"
                    + "Дані абонента: {6} | {7}\n",
                    subscriber.Name,
                    subscriber.PhoneNumber,
                    subscriber.Address,
                    subscriber.CallMinutesPerMonth,
                    subscriber.SMSPerMonth,
                    subscriber.MonthlyFee,
                    subscriber.HasDataPlan ? "Абонент має тариф з інтернетом" : "Абонент немає тариф з інтернетом",
                    subscriber.HasRoaming ? "Абонент має роумінг" : "Абонент немає роумінгу");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Показуємо вікно з підтвердженням виходу з програми
            if (MessageBox.Show("Припинити роботу застосунку?",
                                "Припинити роботу",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Question) == DialogResult.OK)
            {
                // Якщо користувач натиснув "OK", виходимо з програми
                Application.Exit();
            }
        }
    }
}