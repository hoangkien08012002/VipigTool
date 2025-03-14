﻿using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.DevTools.V131.FileSystem;
using File = System.IO.File;
using System.Text.RegularExpressions;
using OpenQA.Selenium.Support.UI;

namespace ToolVipig
{
    public partial class Form1 : Form
    {
        bool run = true;
        string file_account_path = "account.txt";
        ChromeDriver driverInstagram;
        ChromeDriver driverVipig;
        public Form1()
        {
            InitializeComponent();
            dgv.AllowUserToResizeColumns = false;
            AutoFillInputFromFIle();

        }


        // tự động điền các trường input trong form tool 
        void AutoFillInputFromFIle()
        {

            if (File.Exists(file_account_path))
            {
                // lấy dữ liệu từ file
                string data_acc = File.ReadAllText(file_account_path);

                //kiểm tra file có dữ liệu không
                if (!string.IsNullOrEmpty(data_acc))
                {
                    txtUserName_Vipig.Text = Regex.Match(data_acc, "user_vipig=(.*?);").Groups[1].Value;
                    txtPassword_Vipig.Text = Regex.Match(data_acc, "pass_vipig=(.*?);").Groups[1].Value;
                    txtUsername_Instagram.Text = Regex.Match(data_acc, "user_insta=(.*?);").Groups[1].Value;
                    txtPassword_insta.Text = Regex.Match(data_acc, "pass_insta=(.*?);").Groups[1].Value;
                }
            }
            else
            {
                File.Create(file_account_path);
            }
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
                    ChromeDriver driver_vipig = OpenChrome("https://vipig.net/index.php");
                    if (driver_vipig != null)
                    {
                        delay(2);
                        // click button ddongs
                        driver_vipig.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div/div[3]/div/button")).Click();

                        delay(1);
                        //Username
                        // xóa hết dữ liệu trong ô
                        driver_vipig.FindElement(By.Name("username")).Clear();
                        // tiến hành nhập dữ liệu mới
                        //driver_vipig.FindElement(By.Name("username")).SendKeys(usernameVipig);
                        char[] arrayuser = usernameVipig.ToCharArray();
                        foreach (char c in arrayuser)
                        {
                            driver_vipig.FindElement(By.Name("username")).SendKeys(c.ToString());
                            Thread.Sleep(50); //  500ms điền 1 ký ký tự
                        }

                        //Password
                        // xóa hết dữ liệu trong ô
                        driver_vipig.FindElement(By.Name("password")).Clear();
                        // tiến hành nhập dữ liệu mới
                        driver_vipig.FindElement(By.Name("password")).SendKeys(passwordVipig);

                        //click button login
                        driver_vipig.FindElement(By.Name("submit")).Click();
                        delay(2);
                        bool isLogin = false;
                        try
                        {
                            var alert = driver_vipig.SwitchTo().Alert();
                            //xuất ra chữ trong thông báo
                            string texter = alert.Text;
                            //nhấp vào nút ok trong alert
                            alert.Accept();
                            //tắt trình duyệt
                            driver_vipig.Quit();
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
                                my_username.Text = driver_vipig.FindElement(By.XPath("/html/body/div/div/div[1]/h2/i")).Text;
                                //set balance
                                my_coin.Text = driver_vipig.FindElement(By.Id("soduchinh")).Text + " VNĐ";

                            }));

                            // Instagram Login
                            //ChromeDriver driver_ins = OpenChrome("https://www.instagram.com/");
                            //delay(2);
                            ////gửi username cho insta
                            //driver_ins.FindElement(By.Name("username")).SendKeys(usernameInsta);
                            ////gửi pass cho insta
                            //driver_ins.FindElement(By.Name("password")).SendKeys(passwprdInsta);
                            //delay(2);
                            //driver_ins.FindElement(By
                            //    .XPath("/html/body/div[1]/div/div/div[2]/div/div/div[1]/div[1]/div/section/main/article/div[2]/div[1]/div[2]/div/form/div[1]/div[3]/button")).Click();

                            //delay(5);

                            //if (check(driver_ins, By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div[1]/div[1]/div[1]/section/main/div/div/div")))
                            //{
                            //    // click nút "lúc khác"(not now)
                            //    driver_ins.FindElement(By
                            //    .XPath("/html/body/div[1]/div/div/div[2]/div/div/div[1]/div[1]/div[1]/section/main/div/div/div")).Click();
                            //}
                            //else
                            //{
                            //    if (check(driver_ins, By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div[1]/div[1]/div/section/main/article/div[2]/div[1]/div[2]/div/form/span/div")))
                            //    {
                            //        showError(driver_ins.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div[1]/div[1]/div/section/main/article/div[2]/div[1]/div[2]/div/form/span/div")).Text);
                            //        driver_ins.Quit();
                            //        driver_vipig.Quit();
                            //        return;
                            //    }

                            //}
                            // kiểm tra nếu bấm nút stop sẽ dừng 
                            if (!run)
                            {
                                driver_vipig.Quit();
                                //driver_ins.Quit();
                                return;
                            }
                            //driverInstagram = driver_ins;
                            driverVipig = driver_vipig;
                            while (run)
                            {
                                if (!run)
                                {
                                    driver_vipig.Quit();
                                    //driver_ins.Quit();
                                    return;
                                }

                                var random = new Random();
                                // int rand = random.Next(1, 3);
                                int rand = 1;
                                if (rand == 1)
                                {
                                    start_like(usernameInsta, passwprdInsta);
                                    //like
                                }
                                else if (rand == 2)
                                {
                                    //follow
                                }
                                else if (rand == 3)
                                {
                                    //comment
                                }
                            }
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

        //check element tồn tại
        bool check(ChromeDriver driver, By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch
            {
                return false;

            }
        }

        // Like
        public void start_like(string usernameInsta, string passwprdInsta)
        {
            driverVipig.Url = "https://vipig.net/kiemtien/";
            driverVipig.Navigate();
            delay(1);

            /////////////////
            // Mở tab mới cho Instagram
            ((IJavaScriptExecutor)driverVipig).ExecuteScript("window.open('https://www.instagram.com/', '_blank');");
            delay(4);

            // chuyển sang tab vừa mở
            driverVipig.SwitchTo().Window(driverVipig.WindowHandles.Last());

            //gửi username cho insta
            driverVipig.FindElement(By.Name("username")).SendKeys(usernameInsta);
 
            //gửi pass cho insta
            driverVipig.FindElement(By.Name("password")).SendKeys(passwprdInsta);
            
            driverVipig.FindElement(By
                .XPath("/html/body/div[1]/div/div/div[2]/div/div/div[1]/div[1]/div/section/main/article/div[2]/div[1]/div[2]/div/form/div[1]/div[3]/button")).Click();
            delay(7);


            driverVipig.Close();
            delay(1);
            // quay lại cửa sổ đầu tiên
            driverVipig.SwitchTo().Window(driverVipig.WindowHandles.First());
            ////////////////////////
            delay(4);

            var all_job = driverVipig.FindElement(By.Id("dspost")).FindElements(By.TagName("button"));
            int tab = 0;
            foreach (var job in all_job)
            {
                dgv.Invoke(new Action( () =>
                {

                }));
               if (!run)
                {
                    driverVipig.Quit();
                    driverInstagram.Quit();
                    return;
                }
                // lấy ra url
                string url = job.GetAttribute("title").Replace("'","");// bỏ dấu ' đi nếu có
                job.Click();

                //driverInstagram.Url = url;
                //driverInstagram.Navigate();
                //delay(2);
                delay(7);
                try
                {
                    driverVipig.SwitchTo().Window(driverVipig.WindowHandles.Last());
                    // var elements = driverVipig.FindElements(By.CssSelector(".x1i10hfl.x972fbf.xcfux6l.x1qhh985.xm0m39n.x9f619.xe8uvvx.xdj266r.x11i5rnm.xat24cr.x1mh8g0r.x16tdsg8.x1hl2dhg.xggy1nq.x1a2a7pz.x6s0dn4.xjbqb8w.x1ejq31n.xd10rxx.x1sy0etr.x17r0tee.x1ypdohk.x78zum5.xl56j7k.x1y1aw1k.x1sxyh0.xwib8y2.xurb0ha.xcdnw81"));
                    //var elements = driverVipig.FindElements(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div[1]/div[1]/div[1]/section/main/div/div[1]/div/div[2]/div/div[3]/section[1]/div[1]/span[1]/div/div/div"));

                    IJavaScriptExecutor js = (IJavaScriptExecutor)driverVipig;
                    js.ExecuteScript("document.querySelector('.x1i10hfl.x972fbf.xcfux6l.x1qhh985.xm0m39n.x9f619.xe8uvvx.xdj266r.x11i5rnm.xat24cr.x1mh8g0r.x16tdsg8.x1hl2dhg.xggy1nq.x1a2a7pz.x6s0dn4.xjbqb8w.x1ejq31n.xd10rxx.x1sy0etr.x17r0tee.x1ypdohk.x78zum5.xl56j7k.x1y1aw1k.x1sxyh0.xwib8y2.xurb0ha.xcdnw81')?.click();");
                    //if (elements.Count > 0)
                    //{
                    //    elements[0].Click();
                    //}
                    //else
                    //{
                    //    showError("Không tìm thấy phần tử có class 'x1ahuga'.");
                    //}

                    //driverVipig.FindElements(By.ClassName("x1ahuga"))[1].Click();
                }
                catch
                {
                }
                // next sang tab vừa mở và close
                driverVipig.SwitchTo().Window(driverVipig.WindowHandles.Last());
                driverVipig.Close();
                delay(1);
                // quay lại cửa sổ đầu tiên
                driverVipig.SwitchTo().Window(driverVipig.WindowHandles.First());
                delay(3);
                string id = url.Substring(28).Trim();

                IJavaScriptExecutor java = driverVipig;
                java.ExecuteScript("document.getElementsByClassName('btn-success')[0].click()");

                if (!run)
                {
                    driverVipig.Quit();
                    driverInstagram.Quit();
                    return;
                }
                this.Invoke(new Action(() =>
                {
                    //set username
                  
                    //set balance
                    my_coin.Text = driverVipig.FindElement(By.Id("soduchinh")).Text + " VNĐ";

                }));
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
