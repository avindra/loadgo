using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
public class Block : SplitContainer
{
    public Block(int label)
    {
        this.SplitterDistance = 10;
        this.BorderStyle = BorderStyle.Fixed3D;
        this.Dock  = DockStyle.Fill;
        Label no = new Label();
        no.Text = label < 10 ? "0" + label.ToString() : label.ToString();
        this.Panel1.Controls.Add(no);
        TextBox box = new TextBox();
        box.Dock = DockStyle.Fill;
        this.Panel2.Controls.Add(box);
    }
}