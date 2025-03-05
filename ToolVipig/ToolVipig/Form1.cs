using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolVipig
{
    public partial class Form1 : Form
    {
        bool run = true;
        public Form1()
        {
            InitializeComponent();
            dgv.AllowUserToResizeColumns = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            run = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            run = true;

            string usernameVipig = txtUserName_Vipig.Text.Trim();
            string usernameInsta = txtUsername_Instagram.Text.Trim();
            string passwordVipig = txtPassword_Vipig.Text.Trim();
            string passwprdInsta = txtPassword_insta.Text.Trim();

            if (!string.IsNullOrEmpty(usernameInsta)
                && !string.IsNullOrEmpty(passwordVipig)
                && !string.IsNullOrEmpty(usernameVipig)
                && !string.IsNullOrEmpty(passwprdInsta))
            {
                Thread t = new Thread(() =>
                {
                    ChromeDriver driverVipig = OpenChrome("https://vipig.net/index.php");
                    if (driverVipig != null)
                    {
                        delay(2);
                        // click button ddongs
                        driverVipig.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div/div[3]/div/button")).Click();


                        delay(1);
                        //Username
                        // xóa hết dữ liệu trong ô
                        driverVipig.FindElement(By.Name("username")).Clear();
                        // tiến hành nhập dữ liệu mới
                        //driverVipig.FindElement(By.Name("username")).SendKeys(usernameVipig);
                        char[] arrayuser = usernameVipig.ToCharArray();
                        foreach (char c in arrayuser)
                        {
                            driverVipig.FindElement(By.Name("username")).SendKeys(c.ToString());
                            Thread.Sleep(100); //  500ms điền 1 ký ký tự
                        }

                        //Password
                        // xóa hết dữ liệu trong ô
                        driverVipig.FindElement(By.Name("password")).Clear();
                        // tiến hành nhập dữ liệu mới
                        driverVipig.FindElement(By.Name("password")).SendKeys(passwordVipig);

                        //click button login
                        driverVipig.FindElement(By.Name("submit")).Click();
                        delay(2);
                        bool isLogin = false;
                        try
                        {
                            var alert = driverVipig.SwitchTo().Alert();
                            //xuất ra chữ trong thông   báo
                            string texter = alert.Text;
                            //nhấp vào nút ok trong alert
                            alert.Accept();
                            //tắt trình duyệt
                            driverVipig.Quit();
                            //show messege ra mà hình
                            showError(texter);
                        }
                        catch
                        {
                            isLogin = true;
                        }
                        if (isLogin)
                        {
                            //set info
                            this.Invoke(new Action(() =>
                            {
                               
                                //set username
                                my_username.Text = driverVipig.FindElement(By.XPath("/html/body/div/div/div[1]/h2/i")).Text;
                                //set balance
                                my_coin.Text = driverVipig.FindElement(By.Id("soduchinh")).Text + " VNĐ";

                            }));
                        }

                    }
                    else
                    {
                        showError("vui lòng thay chromedrive bằng phiên bản của bạn");
                    }
                });
                t.IsBackground = true;
                t.Start();
            }
            else
            {
                showError("Vui lòng nhập đầy đủ dữ liệu");
            }

        }

        //Show thông báo lỗi
        void showError(string message)
        {
            MessageBox.Show(message, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Hàm mở chorme
        ChromeDriver OpenChrome(string url, bool show = true)
        {
            ChromeOptions option = new ChromeOptions();

            //kiểm tra nếu show = flase thì ẩn chrome đi(chạy ngầm)
            if (!show)
            {
                option.AddArgument("headless");
            }
            ChromeDriverService service;
            try
            {
                service = ChromeDriverService.CreateDefaultService();

                //service.HideCommandPromptWindow = true;
            }
            catch
            {
                return null;
            }
            ChromeDriver drive = new ChromeDriver(service, option);
            try
            {
                // vào url đã truyền vào và trả lại drive
                drive.Url = url;
                drive.Navigate();
            }
            catch
            {
                return null;
            }


            return drive;


        }
        //hàm sleep
        void delay(int s)
        {
            Thread.Sleep(TimeSpan.FromSeconds(s));
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
