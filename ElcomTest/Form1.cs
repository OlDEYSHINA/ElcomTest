using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace ElcomTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Событие нажатия на кнопку загрузки файла.
        /// </summary>
        private void buttonLoadXml_Click(object sender, EventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            try                 // Проверка вводимых данных
            {
                xDoc.Load(textBoxXmlUrl.Text);
                labelLoadInfo.Text = "Файл успешно загружен";
                labelLoadInfo.ForeColor = Color.Green;
            }
            catch (XmlException)
            {
                labelLoadInfo.Text = "Некорректный файл";
                labelLoadInfo.ForeColor = Color.Red;
                return;
            }
            catch (DirectoryNotFoundException)
            {
                labelLoadInfo.Text = "По данному локальному пути ничего не найдено";
                labelLoadInfo.ForeColor = Color.Red;
                return;
            }
            catch (ArgumentException)
            {
                labelLoadInfo.Text = "Заполните поле ввода";
                labelLoadInfo.ForeColor = Color.Red;
                return;
            }
            catch (WebException)
            {
                labelLoadInfo.Text = "Ссылка не указывает на объект";
                labelLoadInfo.ForeColor = Color.Red;
                return;
            }
            catch (Exception)
            {
                labelLoadInfo.Text = "Неизвестная ошибка";
                labelLoadInfo.ForeColor = Color.Red;
                return;
            }

            richTextBoxNonChangedXml.Text = xDoc.InnerXml;
            var xmlNode = xDoc.ChildNodes[1];
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add(new TreeNode(xDoc.DocumentElement.Name));
            var tNode = treeView1.Nodes[0];
            AddNode(xmlNode, tNode);
            richTextBoxTextFormattedXML.Text = FormatToFrendlyXml(xDoc);
        }

        /// <summary>
        /// Рекурсивный метод добавления ветвей и их содержимого
        /// </summary>
        /// <param name="inXmlNode"></param>
        /// <param name="inTreeNode"></param>
        private void AddNode(XmlNode inXmlNode, TreeNode inTreeNode)
        {
            XmlNode xNode;
            TreeNode tNode;
            XmlNodeList nodeList;

            if (inXmlNode.HasChildNodes)
            {
                nodeList = inXmlNode.ChildNodes;
                for (var i = 0; i <= nodeList.Count - 1; i++)
                {
                    xNode = inXmlNode.ChildNodes[i];
                    inTreeNode.Nodes.Add(new TreeNode(xNode.Name));
                    tNode = inTreeNode.Nodes[i];
                    AddNode(xNode, tNode);
                }
            }
            else
            {
                inTreeNode.Text = inXmlNode.OuterXml;
            }
        }

        /// <summary>
        /// Метод форматирования XML файла для лучшей читабельности.
        /// </summary>
        /// <param name="xmlDocument">Форматируемый документ</param>
        /// <returns>Отформатированный документ</returns>
        private string FormatToFrendlyXml(XmlDocument xmlDocument)
        {
            return XElement.Parse(xmlDocument.InnerXml).ToString();
        }

        /// <summary>
        /// Действие кнопки отображения дерева XML
        /// </summary>
        private void buttonViewtreeXml_Click(object sender, EventArgs e)
        {
            richTextBoxTextFormattedXML.Visible = false;
            treeView1.Visible = true;
        }

        /// <summary>
        /// Действие кнопки отображения отформатированного XML
        /// </summary>
        private void buttonViewTextFormattedXml_Click(object sender, EventArgs e)
        {
            richTextBoxTextFormattedXML.Visible = true;
            treeView1.Visible = false;
        }
    }
}
