using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bitzhuwei.SortingExtension.Winform
{
    public partial class FormMain : Form
    {
        private EventHandler item_ClickEvent;
        private object first;
        private object currentLabel;
        private EventHandler mouseEnterEvent;
        private EventHandler assignColor_ClickEvent;
        //private object second;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                this.MoveItems(new Tuple<int, int>(0, -1));
            }
            else if (e.KeyCode == Keys.S)
            {
                this.MoveItems(new Tuple<int, int>(0, 1));
            }
            else if (e.KeyCode == Keys.A)
            {
                this.MoveItems(new Tuple<int, int>(-1, 0));
            }
            else if (e.KeyCode == Keys.D)
            {
                this.MoveItems(new Tuple<int, int>(1, 0));
            }
        }

        private void MoveItems(Tuple<int, int> tuple)
        {
            foreach (var item in this.panel1.Controls)
            {
                var label = item as Label;
                if (label != null)
                {
                    label.Location = new Point(
                        label.Location.X + tuple.Item1,
                        label.Location.Y + tuple.Item2);
                }
            }
        }

        private void 新建NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.GenerateRandomList(this.panel1);
        }

        private void GenerateRandomList(Panel panel)
        {
            var count = 20;
            panel.Controls.Clear();
            int x = 10, y = 10;
            List<int> list = GetRandomList(1, count + 1);
            for (int i = 0; i < count; i++)
            {
                var item = new Label();
                item.BackColor = Color.SkyBlue;
                item.AutoEllipsis = true;
                item.BorderStyle = BorderStyle.FixedSingle;
                item.Tag = list[i];
                item.Text = item.Tag.ToString();
                item.TextAlign = ContentAlignment.BottomCenter;
                item.Location = new Point(x + i * (20 + 6), y);
                item.Height = 20 + 15* (int)item.Tag;
                item.Width = 20;
                item.Click += this.item_ClickEvent;
                item.MouseEnter += this.mouseEnterEvent;
                item.ContextMenuStrip = this.itemContextMenuStrip;
                panel.Controls.Add(item);
            }
        }


        private List<int> GetRandomList(int min, int max)
        {
            var result = new List<int>();
            for (int i = min; i < max; i++)
            {
                result.Add(i);
            }

            var r = new Random();
            for (int i = 0; i < 100; i++)
            {
                var x = r.Next(0, max - min);
                var y = r.Next(0, max - min);
                if(x!= y)
                {
                    var tmp = result[x];
                    result[x] = result[y];
                    result[y] = tmp;
                }
            }

            return result;
        }

        private void item_Click(object sender, EventArgs e)
        {
            if (this.first == null)
            {
                this.first = sender;
                var label = sender as Label;
                label.BackColor = Color.BurlyWood;
            }
            else
            {
                var label = this.first as Label;
                var label2 = sender as Label;
                var tmp = label.Location;
                label.Location = label2.Location;
                label2.Location = tmp;
                label.BackColor = Color.SkyBlue;
                label2.BackColor = Color.SkyBlue;
                this.first = null;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.item_ClickEvent = new EventHandler(this.item_Click);
            this.mouseEnterEvent = new EventHandler(this.item_MouseEnter);
            this.assignColor_ClickEvent = new EventHandler(this.assignColor_Click);
            this.GenerateRandomList(this.panel1);
        }

        private void 随机打乱ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.GenerateRandomList(this.panel1);
        }

        private void 标记颜色ToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;
            if (menuItem == null) { return; }
            if (menuItem.HasDropDownItems) { return; }

            var props = typeof(Color).GetProperties();
            var width = 10;
            var height = 10;
            foreach (var item in props)
            {
                var color = Color.FromName(item.Name);
                //var brush = new SolidBrush(color);
                var img = new Bitmap(width, height);
                var graphics = Graphics.FromImage(img);
                graphics.Clear(color);
                graphics.Dispose();
                menuItem.DropDownItems.Add(item.Name, img, this.assignColor_ClickEvent);
            }
        }

        private void assignColor_Click(object sender, EventArgs e)
        {
            if (currentLabel == null) { return; }
            var label = currentLabel as Label;
            if (label == null) { return; }
            var item = sender as ToolStripDropDownItem;
            if (item == null) { return; }
            var color = Color.FromName(item.Text);
            label.BackColor = color;
        }

        private void item_MouseEnter(object sender, EventArgs e)
        {
            this.currentLabel = sender;
        }


    }
}
