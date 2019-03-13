using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.IO.Compression;
using System.Text.RegularExpressions;

namespace Graduate
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        class LoginWeb
        {

            /************************************************************************/
            /* Http Get请求
             * url为请求的网址
             * data为GET请求参数（格式为：key1=value1&key2=value2）
             */
            /************************************************************************/
            public static string HttpGet(string url, string data)
            {
                url = url + data;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.ContentType = "text/hmtl;charset=UTF-8";
                request.Headers.Add("Authorization", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJhdWQiOiJsb3JhLWFwcC1zZXJ2ZXIiLCJleHAiOjE1NDAyOTQxODgsImlzcyI6ImxvcmEtYXBwLXNlcnZlciIsIm5iZiI6MTU0MDIwNzc4OCwic3ViIjoidXNlciIsInVzZXJuYW1lIjoiYWRtaW4ifQ.LCGyomxLcJ_ZsVZ8Eb37qspYX6byNUZk_4X4y3XutFI");
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream responseStream = response.GetResponseStream();

                StreamReader streamReader = new StreamReader(responseStream);
                string result = streamReader.ReadToEnd();
                streamReader.Close();
                responseStream.Close();
                return result;
            }

            /************************************************************************/
            /* Http Post 请求
             * url为请求的网址
             * data为POST请求参数（格式为：key1=value1&key2=value2）
             * cookie为存储Cookie的容器CookieContainer
             */
            /************************************************************************/
            public static string HttpPost(string url, string data, CookieContainer cookies)
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                //FORM元素的enctype属性指定了表单数据向服务器提交时所采用的编码类型，默认的缺省值是“application/x-www-form-urlencoded”
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = Encoding.UTF8.GetByteCount(data);
                request.CookieContainer = cookies;
                Stream requetStream = request.GetRequestStream();
                StreamWriter streamWriter = new StreamWriter(requetStream);
                streamWriter.Write(data);
                streamWriter.Close();
                request.CookieContainer = cookies;


                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                response.Cookies = cookies.GetCookies(response.ResponseUri);
                cookies.Add(response.Cookies);
                Stream responseStream = response.GetResponseStream();
                StreamReader streamReader = new StreamReader(responseStream, Encoding.GetEncoding("GB2312"));
                string result = streamReader.ReadToEnd();
                streamReader.Close();
                responseStream.Close();
                return result;
            }
        }

        private void Button_Login_Click(object sender, RoutedEventArgs e)
        {
            string password = "admin";
            string username = "admin";
            string loginUrl = "http://66.42.58.90:8000/api/v1/user/login";
            //string loginData = "{\"password\":\"admin\",\"username\":\"admin\"}";
            string loginData = "{\"password\":"+ "\""+password+"\""+ ",\"username\":"+"\""+username+ "\"" + "}";
            CookieContainer cookies = new CookieContainer();
            string origin_token = LoginWeb.HttpPost(loginUrl, loginData, cookies);           
            Regex reg = new Regex("\"jwt\":\"(.+)\"}");
            Match match = reg.Match(origin_token);
            string token = match.Groups[1].Value;
            MessageBox.Show(token);
        }
    }
}
