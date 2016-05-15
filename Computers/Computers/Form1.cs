﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Npgsql;
using Microsoft.Office.Interop.Excel;
using System.Text.RegularExpressions;
using System.Reflection;
using OfficeOpenXml;
using System.IO;
using System.Threading;

namespace Computers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadManufacturer()
        {
            dataGridView10.Rows.Clear();
            dataGridView10.Columns.Clear();
            var myBinding = new BasicHttpBinding();
            var myEndpoint = new EndpointAddress("http://localhost:8733/Design_Time_Addresses/WcfServiceLibrary1/Manufacturer/");
            var myChannelFactory = new ChannelFactory<Manufacturer.SManufacturer>(myBinding, myEndpoint);

            Manufacturer.SManufacturer client = null;
            string s = "";
            try
            {
                client = myChannelFactory.CreateChannel();
                s = client.get();
                ((ICommunicationObject)client).Close();
            }
            catch
            {
                if (client != null)
                {
                    ((ICommunicationObject)client).Abort();
                }
            }

            string[,] array = JsonConvert.DeserializeObject<string[,]>(s);            

            for (int l = 0; l < array.GetLength(0); l++)
                if (array[l, 0] != null)
                    dataGridView10.Columns.Add(array[l, 0], array[l, 0]);          
            int row = 0;
            for (int i = 1; i < array.GetLength(1); i++)
            {
                if (array[0, i] != null)
                {
                    dataGridView10.Rows.Add();
                    for (int cell = 0; cell < array.GetLength(0); cell++)
                        if (array[cell, i] != null)
                            dataGridView10.Rows[row].Cells[cell].Value = (array[cell, i]);
                    row++;
                }
            }
        }

        private void loadProcessor()
        {
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            var myBinding = new BasicHttpBinding();
            var myEndpoint = new EndpointAddress("http://localhost:8733/Design_Time_Addresses/WcfServiceLibrary1/Processor/");
            var myChannelFactory = new ChannelFactory<Processor.SProcessor>(myBinding, myEndpoint);

            Processor.SProcessor client = null;
            string s = "";
            try
            {
                client = myChannelFactory.CreateChannel();
                s = client.get();
                ((ICommunicationObject)client).Close();
            }
            catch
            {
                if (client != null)
                {
                    ((ICommunicationObject)client).Abort();
                }
            }

            string[,] array = JsonConvert.DeserializeObject<string[,]>(s);

            for (int l = 0; l < array.GetLength(0); l++)
                if (array[l, 0] != null)
                    dataGridView2.Columns.Add(array[l, 0], array[l, 0]);
            int row = 0;
            for (int i = 1; i < array.GetLength(1); i++)
            {
                if (array[0, i] != null)
                {
                    dataGridView2.Rows.Add();
                    for (int cell = 0; cell < array.GetLength(0); cell++)
                        if (array[cell, i] != null)
                            dataGridView2.Rows[row].Cells[cell].Value = (array[cell, i]);
                    row++;
                }
            }
        }

        private void loadMotherboard()
        {
            dataGridView3.Rows.Clear();
            dataGridView3.Columns.Clear();
            var myBinding = new BasicHttpBinding();
            var myEndpoint = new EndpointAddress("http://localhost:8733/Design_Time_Addresses/WcfServiceLibrary1/Motherboard/");
            var myChannelFactory = new ChannelFactory<Motherboard.SMotherboard>(myBinding, myEndpoint);

            Motherboard.SMotherboard client = null;
            string s = "";
            try
            {
                client = myChannelFactory.CreateChannel();
                s = client.get();
                ((ICommunicationObject)client).Close();
            }
            catch
            {
                if (client != null)
                {
                    ((ICommunicationObject)client).Abort();
                }
            }

            string[,] array = JsonConvert.DeserializeObject<string[,]>(s);

            for (int l = 0; l < array.GetLength(0); l++)
                if (array[l, 0] != null)
                    dataGridView3.Columns.Add(array[l, 0], array[l, 0]);
            int row = 0;
            for (int i = 1; i < array.GetLength(1); i++)
            {
                if (array[0, i] != null)
                {
                    dataGridView3.Rows.Add();
                    for (int cell = 0; cell < array.GetLength(0); cell++)
                        if (array[cell, i] != null)
                            dataGridView3.Rows[row].Cells[cell].Value = (array[cell, i]);
                    row++;
                }
            }
        }

        private void loadPowerSupply()
        {
            dataGridView4.Rows.Clear();
            dataGridView4.Columns.Clear();
            var myBinding = new BasicHttpBinding();
            var myEndpoint = new EndpointAddress("http://localhost:8733/Design_Time_Addresses/WcfServiceLibrary1/PowerSupply/");
            var myChannelFactory = new ChannelFactory<PowerSupply.SPowerSupply>(myBinding, myEndpoint);

            PowerSupply.SPowerSupply client = null;
            string s = "";
            try
            {
                client = myChannelFactory.CreateChannel();
                s = client.get();
                ((ICommunicationObject)client).Close();
            }
            catch
            {
                if (client != null)
                {
                    ((ICommunicationObject)client).Abort();
                }
            }

            string[,] array = JsonConvert.DeserializeObject<string[,]>(s);

            for (int l = 0; l < array.GetLength(0); l++)
                if (array[l, 0] != null)
                    dataGridView4.Columns.Add(array[l, 0], array[l, 0]);
            int row = 0;
            for (int i = 1; i < array.GetLength(1); i++)
            {
                if (array[0, i] != null)
                {
                    dataGridView4.Rows.Add();
                    for (int cell = 0; cell < array.GetLength(0); cell++)
                        if (array[cell, i] != null)
                            dataGridView4.Rows[row].Cells[cell].Value = (array[cell, i]);
                    row++;
                }
            }
        }

        private void loadRam()
        {
            dataGridView5.Rows.Clear();
            dataGridView5.Columns.Clear();
            var myBinding = new BasicHttpBinding();
            var myEndpoint = new EndpointAddress("http://localhost:8733/Design_Time_Addresses/WcfServiceLibrary1/Ram/");
            var myChannelFactory = new ChannelFactory<Ram.SRam>(myBinding, myEndpoint);

            Ram.SRam client = null;
            string s = "";
            try
            {
                client = myChannelFactory.CreateChannel();
                s = client.get();
                ((ICommunicationObject)client).Close();
            }
            catch
            {
                if (client != null)
                {
                    ((ICommunicationObject)client).Abort();
                }
            }

            string[,] array = JsonConvert.DeserializeObject<string[,]>(s);

            for (int l = 0; l < array.GetLength(0); l++)
                if (array[l, 0] != null)
                    dataGridView5.Columns.Add(array[l, 0], array[l, 0]);
            int row = 0;
            for (int i = 1; i < array.GetLength(1); i++)
            {
                if (array[0, i] != null)
                {
                    dataGridView5.Rows.Add();
                    for (int cell = 0; cell < array.GetLength(0); cell++)
                        if (array[cell, i] != null)
                            dataGridView5.Rows[row].Cells[cell].Value = (array[cell, i]);
                    row++;
                }
            }
        }

        private void loadVideocard()
        {
            dataGridView6.Rows.Clear();
            dataGridView6.Columns.Clear();
            var myBinding = new BasicHttpBinding();
            var myEndpoint = new EndpointAddress("http://localhost:8733/Design_Time_Addresses/WcfServiceLibrary1/Videocard/");
            var myChannelFactory = new ChannelFactory<Videocard.SVideocard>(myBinding, myEndpoint);

            Videocard.SVideocard client = null;
            string s = "";
            try
            {
                client = myChannelFactory.CreateChannel();
                s = client.get();
                ((ICommunicationObject)client).Close();
            }
            catch
            {
                if (client != null)
                {
                    ((ICommunicationObject)client).Abort();
                }
            }

            string[,] array = JsonConvert.DeserializeObject<string[,]>(s);

            for (int l = 0; l < array.GetLength(0); l++)
                if (array[l, 0] != null)
                    dataGridView6.Columns.Add(array[l, 0], array[l, 0]);
            int row = 0;
            for (int i = 1; i < array.GetLength(1); i++)
            {
                if (array[0, i] != null)
                {
                    dataGridView6.Rows.Add();
                    for (int cell = 0; cell < array.GetLength(0); cell++)
                        if (array[cell, i] != null)
                            dataGridView6.Rows[row].Cells[cell].Value = (array[cell, i]);
                    row++;
                }
            }
        }

        private void loadHarddrive()
        {
            dataGridView7.Rows.Clear();
            dataGridView7.Columns.Clear();
            var myBinding = new BasicHttpBinding();
            var myEndpoint = new EndpointAddress("http://localhost:8733/Design_Time_Addresses/WcfServiceLibrary1/Harddrive/");
            var myChannelFactory = new ChannelFactory<Harddrive.SHarddrive>(myBinding, myEndpoint);

            Harddrive.SHarddrive client = null;
            string s = "";
            try
            {
                client = myChannelFactory.CreateChannel();
                s = client.get();
                ((ICommunicationObject)client).Close();
            }
            catch
            {
                if (client != null)
                {
                    ((ICommunicationObject)client).Abort();
                }
            }

            string[,] array = JsonConvert.DeserializeObject<string[,]>(s);

            for (int l = 0; l < array.GetLength(0); l++)
                if (array[l, 0] != null)
                    dataGridView7.Columns.Add(array[l, 0], array[l, 0]);
            int row = 0;
            for (int i = 1; i < array.GetLength(1); i++)
            {
                if (array[0, i] != null)
                {
                    dataGridView7.Rows.Add();
                    for (int cell = 0; cell < array.GetLength(0); cell++)
                        if (array[cell, i] != null)
                            dataGridView7.Rows[row].Cells[cell].Value = (array[cell, i]);
                    row++;
                }
            }
        }

        private void loadDiskstorage()
        {
            dataGridView8.Rows.Clear();
            dataGridView8.Columns.Clear();
            var myBinding = new BasicHttpBinding();
            var myEndpoint = new EndpointAddress("http://localhost:8733/Design_Time_Addresses/WcfServiceLibrary1/Diskstorage/");
            var myChannelFactory = new ChannelFactory<Diskstorage.SDiskstorage>(myBinding, myEndpoint);

            Diskstorage.SDiskstorage client = null;
            string s = "";
            try
            {
                client = myChannelFactory.CreateChannel();
                s = client.get();
                ((ICommunicationObject)client).Close();
            }
            catch
            {
                if (client != null)
                {
                    ((ICommunicationObject)client).Abort();
                }
            }

            string[,] array = JsonConvert.DeserializeObject<string[,]>(s);

            for (int l = 0; l < array.GetLength(0); l++)
                if (array[l, 0] != null)
                    dataGridView8.Columns.Add(array[l, 0], array[l, 0]);
            int row = 0;
            for (int i = 1; i < array.GetLength(1); i++)
            {
                if (array[0, i] != null)
                {
                    dataGridView8.Rows.Add();
                    for (int cell = 0; cell < array.GetLength(0); cell++)
                        if (array[cell, i] != null)
                            dataGridView8.Rows[row].Cells[cell].Value = (array[cell, i]);
                    row++;
                }
            }
        }

        private void loadHousing()
        {
            dataGridView9.Rows.Clear();
            dataGridView9.Columns.Clear();
            var myBinding = new BasicHttpBinding();
            var myEndpoint = new EndpointAddress("http://localhost:8733/Design_Time_Addresses/WcfServiceLibrary1/Housing/");
            var myChannelFactory = new ChannelFactory<Housing.SHousing>(myBinding, myEndpoint);

            Housing.SHousing client = null;
            string s = "";
            try
            {
                client = myChannelFactory.CreateChannel();
                s = client.get();
                ((ICommunicationObject)client).Close();
            }
            catch
            {
                if (client != null)
                {
                    ((ICommunicationObject)client).Abort();
                }
            }

            string[,] array = JsonConvert.DeserializeObject<string[,]>(s);

            for (int l = 0; l < array.GetLength(0); l++)
                if (array[l, 0] != null)
                    dataGridView9.Columns.Add(array[l, 0], array[l, 0]);
            int row = 0;
            for (int i = 1; i < array.GetLength(1); i++)
            {
                if (array[0, i] != null)
                {
                    dataGridView9.Rows.Add();
                    for (int cell = 0; cell < array.GetLength(0); cell++)
                        if (array[cell, i] != null)
                            dataGridView9.Rows[row].Cells[cell].Value = (array[cell, i]);
                    row++;
                }
            }
        }

        public void loadComputer()
        {
            BeginInvoke(new ThreadStart(delegate
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
            }));
            var myBinding = new BasicHttpBinding();
            myBinding.MaxReceivedMessageSize = 70000000;
            var myEndpoint = new EndpointAddress("http://localhost:8733/Design_Time_Addresses/WcfServiceLibrary1/Computer/");
            var myChannelFactory = new ChannelFactory<Computer.SComputer>(myBinding, myEndpoint);

            Computer.SComputer client = null;
            string s = "";
            try
            {
                client = myChannelFactory.CreateChannel();
                s = client.get();
                ((ICommunicationObject)client).Close();
            }
            catch (Exception y)
            {
                MessageBox.Show(y.Message);
                if (client != null)
                {
                    ((ICommunicationObject)client).Abort();
                }
            }

            string[,] array = JsonConvert.DeserializeObject<string[,]>(s);
            int row = 0;
            BeginInvoke(new ThreadStart(delegate
            {
                for (int l = 0; l < array.GetLength(0); l++)
                    if (array[l, 0] != null)
                        dataGridView1.Columns.Add(array[l, 0], array[l, 0]);
                for (int i = 1; i < array.GetLength(1); i++)
                {
                    if (array[0, i] != null)
                    {
                        dataGridView1.Rows.Add();
                        for (int cell = 0; cell < array.GetLength(0); cell++)
                            if (array[cell, i] != null)
                                dataGridView1.Rows[row].Cells[cell].Value = (array[cell, i]);
                        row++;
                    }
                }
                progressBar1.Value = progressBar1.MarqueeAnimationSpeed = 0;
            }));           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                loadManufacturer();
                loadProcessor();
                loadMotherboard();
                loadPowerSupply();
                loadRam();
                loadVideocard();
                loadHarddrive();
                loadDiskstorage();
                loadHousing();
                //loadComputer();
                progressBar1.Style = ProgressBarStyle.Marquee;
                progressBar1.MarqueeAnimationSpeed = 100;
                Thread th = new Thread(delegate () { loadComputer(); });
                th.Start();
            }
            catch
            {
                MessageBox.Show("Нет отвера от сервера!");
                return;
            }           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddComputer MyForm = new AddComputer(this);
            MyForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int row = 0;
            string t = "";
            try
            {
                row = dataGridView1.CurrentCell.RowIndex;
                t = dataGridView1[0, row].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Таблица имеет неверный формат!");
                return;
            }
            DialogResult result = new DialogResult();
            result = MessageBox.Show(dataGridView1[0, row].Value.ToString() + "\nУдалить запись?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var myBinding = new BasicHttpBinding();
                var myEndpoint = new EndpointAddress("http://localhost:8733/Design_Time_Addresses/WcfServiceLibrary1/Computer/");
                var myChannelFactory = new ChannelFactory<Computer.SComputer>(myBinding, myEndpoint);

                Computer.SComputer client = null;
                //string s = "";
                try
                {
                    client = myChannelFactory.CreateChannel();
                    client.delete(t);
                    //s = client.toString();                    
                    ((ICommunicationObject)client).Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    if (client != null)
                    {
                        ((ICommunicationObject)client).Abort();
                    }
                    MessageBox.Show("Нет отвера от сервера!");
                    return;
                }
                loadComputer();
                MessageBox.Show("Запись успешно удалена!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int row = dataGridView1.CurrentCell.RowIndex;
                string t = dataGridView1[0, row].Value.ToString();
                UpdateComputer MyForm = new UpdateComputer(t, this);
                MyForm.Show();
            }
            catch
            {
                MessageBox.Show("Таблица имеет неверный формат!");
                return;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Style = ProgressBarStyle.Marquee;
                progressBar1.MarqueeAnimationSpeed = 100;
                Thread th = new Thread(delegate () { loadComputer(); });
                th.Start();
            }
            catch
            {
                MessageBox.Show("Нет отвера от сервера!");
                return;
            }
        }
               

        private void button6_Click(object sender, EventArgs e)
        {
            string path = "";
            saveFileDialog1.Filter = String.Format("xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*");
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
                progressBar1.Style = ProgressBarStyle.Marquee;
                progressBar1.MarqueeAnimationSpeed = 100;
                Thread th = new Thread(delegate () { toExcel1(path); });
                th.Start();
            }
            
        }

        private void toExcel1(string path)
        {
            try
            {
                var myBinding = new BasicHttpBinding();
                myBinding.MaxReceivedMessageSize = 70000000;
                myBinding.AllowCookies = false;
                var myEndpoint = new EndpointAddress("http://localhost:8733/Design_Time_Addresses/WcfServiceLibrary1/Computer/");
                var myChannelFactory = new ChannelFactory<Computer.SComputer>(myBinding, myEndpoint);

                Computer.SComputer client = null;
                string s = "";
                try
                {
                    client = myChannelFactory.CreateChannel();
                    s = client.get();
                    ((ICommunicationObject)client).Close();
                }
                catch (Exception t)
                {
                    if (client != null)
                    {
                        ((ICommunicationObject)client).Abort();
                    }
                    MessageBox.Show(t.Message);
                    return;
                }

                string[,] array = JsonConvert.DeserializeObject<string[,]>(s);
                FileInfo newFile = new FileInfo(path);
                using (ExcelPackage xlPackage = new ExcelPackage(newFile))
                {

                    ExcelWorksheet ws = xlPackage.Workbook.Worksheets.Add("testsheet");

                    int x = 1;
                    for (int i = 0; i < array.GetLength(1); i++)
                    {
                        char pos = 'A';
                        if (array[0, i] != null)
                        {
                            for (int cell = 0; cell < array.GetLength(0); cell++)
                            {
                                string str = pos + x.ToString();
                                if (array[cell, i] != null)
                                    ws.Cells[str].Value = (array[cell, i]);
                                pos++;
                            }
                        }
                        x++;
                    }
                    xlPackage.Save();
                }
                MessageBox.Show("Готово!");
            }
            catch
            {
                MessageBox.Show("Недопустимое имя файла!");
            }
            BeginInvoke(new ThreadStart(delegate
            {
                progressBar1.Value = progressBar1.MarqueeAnimationSpeed = 0;
            }));
               
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string path = "";
            saveFileDialog1.Filter = String.Format("xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*");
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
                progressBar1.Style = ProgressBarStyle.Marquee;
                progressBar1.MarqueeAnimationSpeed = 100;
                Thread th = new Thread(delegate () { toExcel2(path); });
                th.Start();
            }           
        }

        private void toExcel2(string path)
        {
            //try
            //{
                FileInfo newFile = new FileInfo(path);
                using (ExcelPackage xlPackage = new ExcelPackage(newFile))
                {

                    ExcelWorksheet ws = xlPackage.Workbook.Worksheets.Add("testsheet");
                    char pos1 = 'A';
                    for (int l = 0; l < dataGridView1.ColumnCount; l++)
                    {
                        string str = pos1 + "1";
                        ws.Cells[str].Value = dataGridView1.Columns[l].Name;
                        pos1++;
                    }
                    int x = 2;
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        char pos = 'A';
                        for (int cell = 0; cell < dataGridView1.ColumnCount; cell++)
                        {
                            string str = pos + x.ToString();
                            ws.Cells[str].Value = dataGridView1.Rows[i].Cells[cell].Value;
                            pos++;
                        }
                        x++;
                    }
                    xlPackage.Save();
                }
                MessageBox.Show("Готово!");
           // }
            //catch
            //{
            //    MessageBox.Show("Недопустимое имя файла!");
            //}
            BeginInvoke(new ThreadStart(delegate
            {
                progressBar1.Value = progressBar1.MarqueeAnimationSpeed = 0;
            }));               
            
        }
    }
}
