using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace _XML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // XML严格区分大小写
            // XML标签也是成对出现的
            // XML必须有根节点，只能有一个


            // 1. 创建XML文档对象
            XmlDocument doc = new XmlDocument();

            // 2. 创建一个行描述信息， 并且添加到doc文档中
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);

            // 3. 创建根节点
            XmlElement books = doc.CreateElement("Books");

            // 4. 根节点创建子节点
            XmlElement book = doc.CreateElement("Book");
            XmlElement name = doc.CreateElement("Name");
            XmlElement des = doc.CreateElement("Des");

            // 4.1 子节点设置数据
            book.InnerText = "金瓶梅";
            name.InnerText = "10";
            des.InnerText = "好看，不解释";

            // 4.2 给子节点添加属性
            book.SetAttribute("Price", "20");

            // 5. 将子节点添加到根节点中
            books.AppendChild(book);
            books.AppendChild(name);
            books.AppendChild(des);
            // 6.将根节点添加到文档中
            doc.AppendChild(books);
            
            // 7.保存
            doc.Save("Books.xml");

            Console.WriteLine(doc);

        }
    }
}
