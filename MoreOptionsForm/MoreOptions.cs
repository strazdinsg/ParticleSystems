﻿using System.Collections.Generic;
using System.Windows.Forms;

namespace ParticleSystems.MoreOptionsForm {
    class MoreOptionsWindow : Form {
        GroupBox placeObjectListBox;
        GroupBox placeObjectBox;
        Button placeButton;
        Label wLabel;
        Label hLabel;
        TextBox sizeW;
        TextBox sizeH;
        Label sizeLabel;
        Label yLabel;
        TextBox posY;
        Label xLabel;
        TextBox posX;
        Label positionLabel;
        ComboBox objectSelect;
        Label objectLabel;
        ListBox placedObjectList;

        MainFrame mainFrame;
        Context context;


        public MoreOptionsWindow(MainFrame mainFrame, Context context) {
            this.mainFrame = mainFrame;
            this.context = context;
            InitializeComponent();
        }

        private void InitializeComponent() {
            this.placeObjectListBox = new System.Windows.Forms.GroupBox();
            this.placedObjectList = new System.Windows.Forms.ListBox();
            this.placeObjectBox = new System.Windows.Forms.GroupBox();
            this.placeButton = new System.Windows.Forms.Button();
            this.wLabel = new System.Windows.Forms.Label();
            this.hLabel = new System.Windows.Forms.Label();
            this.sizeW = new System.Windows.Forms.TextBox();
            this.sizeH = new System.Windows.Forms.TextBox();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.posY = new System.Windows.Forms.TextBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.posX = new System.Windows.Forms.TextBox();
            this.positionLabel = new System.Windows.Forms.Label();
            this.objectSelect = new System.Windows.Forms.ComboBox();
            this.objectLabel = new System.Windows.Forms.Label();
            this.placeObjectListBox.SuspendLayout();
            this.placeObjectBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // placeObjectListBox
            // 
            this.placeObjectListBox.Controls.Add(this.placedObjectList);
            this.placeObjectListBox.Location = new System.Drawing.Point(185, 6);
            this.placeObjectListBox.Name = "placeObjectListBox";
            this.placeObjectListBox.Size = new System.Drawing.Size(290, 175);
            this.placeObjectListBox.TabIndex = 7;
            this.placeObjectListBox.TabStop = false;
            this.placeObjectListBox.Text = "Placed Object List";
            // 
            // placedObjectList
            // 
            this.placedObjectList.FormattingEnabled = true;
            this.placedObjectList.Location = new System.Drawing.Point(6, 17);
            this.placedObjectList.Name = "placedObjectList";
            this.placedObjectList.Size = new System.Drawing.Size(278, 147);
            this.placedObjectList.TabIndex = 0;
            // 
            // placeObjectBox
            // 
            this.placeObjectBox.Controls.Add(this.placeButton);
            this.placeObjectBox.Controls.Add(this.wLabel);
            this.placeObjectBox.Controls.Add(this.hLabel);
            this.placeObjectBox.Controls.Add(this.sizeW);
            this.placeObjectBox.Controls.Add(this.sizeH);
            this.placeObjectBox.Controls.Add(this.sizeLabel);
            this.placeObjectBox.Controls.Add(this.yLabel);
            this.placeObjectBox.Controls.Add(this.posY);
            this.placeObjectBox.Controls.Add(this.xLabel);
            this.placeObjectBox.Controls.Add(this.posX);
            this.placeObjectBox.Controls.Add(this.positionLabel);
            this.placeObjectBox.Controls.Add(this.objectSelect);
            this.placeObjectBox.Controls.Add(this.objectLabel);
            this.placeObjectBox.Location = new System.Drawing.Point(6, 6);
            this.placeObjectBox.Name = "placeObjectBox";
            this.placeObjectBox.Size = new System.Drawing.Size(175, 175);
            this.placeObjectBox.TabIndex = 8;
            this.placeObjectBox.TabStop = false;
            this.placeObjectBox.Text = "Place Object";
            // 
            // placeButton
            // 
            this.placeButton.Location = new System.Drawing.Point(81, 142);
            this.placeButton.Name = "placeButton";
            this.placeButton.Size = new System.Drawing.Size(80, 23);
            this.placeButton.TabIndex = 20;
            this.placeButton.Text = "Place Object";
            this.placeButton.UseVisualStyleBackColor = true;
            this.placeButton.Click += new System.EventHandler(this.placeButton_Click);
            // 
            // wLabel
            // 
            this.wLabel.AutoSize = true;
            this.wLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.wLabel.Location = new System.Drawing.Point(58, 113);
            this.wLabel.Name = "wLabel";
            this.wLabel.Size = new System.Drawing.Size(21, 13);
            this.wLabel.TabIndex = 19;
            this.wLabel.Text = "W:";
            // 
            // hLabel
            // 
            this.hLabel.AutoSize = true;
            this.hLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.hLabel.Location = new System.Drawing.Point(61, 94);
            this.hLabel.Name = "hLabel";
            this.hLabel.Size = new System.Drawing.Size(18, 13);
            this.hLabel.TabIndex = 18;
            this.hLabel.Text = "H:";
            // 
            // sizeW
            // 
            this.sizeW.Enabled = false;
            this.sizeW.Location = new System.Drawing.Point(81, 110);
            this.sizeW.Name = "sizeW";
            this.sizeW.Size = new System.Drawing.Size(80, 20);
            this.sizeW.TabIndex = 17;
            this.sizeW.Text = "100";
            this.sizeW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sizeH
            // 
            this.sizeH.Location = new System.Drawing.Point(81, 91);
            this.sizeH.Name = "sizeH";
            this.sizeH.Size = new System.Drawing.Size(80, 20);
            this.sizeH.TabIndex = 16;
            this.sizeH.Text = "100";
            this.sizeH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(12, 95);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(30, 13);
            this.sizeLabel.TabIndex = 15;
            this.sizeLabel.Text = "Size:";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(62, 68);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(17, 13);
            this.yLabel.TabIndex = 14;
            this.yLabel.Text = "Y:";
            // 
            // posY
            // 
            this.posY.Location = new System.Drawing.Point(81, 65);
            this.posY.Name = "posY";
            this.posY.Size = new System.Drawing.Size(80, 20);
            this.posY.TabIndex = 13;
            this.posY.Text = "300";
            this.posY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(62, 49);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(17, 13);
            this.xLabel.TabIndex = 12;
            this.xLabel.Text = "X:";
            // 
            // posX
            // 
            this.posX.Location = new System.Drawing.Point(81, 46);
            this.posX.Name = "posX";
            this.posX.Size = new System.Drawing.Size(80, 20);
            this.posX.TabIndex = 11;
            this.posX.Text = "300";
            this.posX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Location = new System.Drawing.Point(12, 50);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(47, 13);
            this.positionLabel.TabIndex = 10;
            this.positionLabel.Text = "Position:";
            // 
            // objectSelect
            // 
            this.objectSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.objectSelect.FormattingEnabled = true;
            this.objectSelect.Items.AddRange(new object[] {
            "Square",
            "Rectangle"});
            this.objectSelect.Location = new System.Drawing.Point(81, 17);
            this.objectSelect.Name = "objectSelect";
            this.objectSelect.Size = new System.Drawing.Size(80, 21);
            this.objectSelect.TabIndex = 9;
            this.objectSelect.SelectedIndexChanged += new System.EventHandler(this.objectSelect_SelectedIndexChanged);
            // 
            // objectLabel
            // 
            this.objectLabel.AutoSize = true;
            this.objectLabel.Location = new System.Drawing.Point(12, 21);
            this.objectLabel.Name = "objectLabel";
            this.objectLabel.Size = new System.Drawing.Size(41, 13);
            this.objectLabel.TabIndex = 8;
            this.objectLabel.Text = "Object:";
            // 
            // MoreOptionsWindow
            // 
            this.ClientSize = new System.Drawing.Size(484, 191);
            this.Controls.Add(this.placeObjectBox);
            this.Controls.Add(this.placeObjectListBox);
            this.Name = "MoreOptionsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "More Options";
            this.placeObjectListBox.ResumeLayout(false);
            this.placeObjectBox.ResumeLayout(false);
            this.placeObjectBox.PerformLayout();
            this.ResumeLayout(false);

        }

        private void placeButton_Click(object sender, System.EventArgs e) {
            string objectShape = objectSelect.SelectedItem.ToString();
            int positionX = int.Parse(posX.Text);
            int positionY = int.Parse(posY.Text);
            int sizeHeight = int.Parse(sizeH.Text);
            int sizeWidth = sizeHeight;
            if (objectShape == "rectangle")
                sizeWidth = int.Parse(sizeW.Text);

            mainFrame.createObject(objectShape, positionX, positionY, sizeHeight, sizeWidth);
            putVisibleObjectToGlControl(objectShape, positionX, positionY, sizeHeight, sizeWidth);
        }

        private void objectSelect_SelectedIndexChanged(object sender, System.EventArgs e) {
            string objectShape = objectSelect.SelectedItem.ToString();
            if (objectShape == "Rectangle")
                sizeW.Enabled = true;
            else
                sizeW.Enabled = false;
        }

        private void fillPlacedObjectListFromContext() {
            List<PlaceableObject> placableObjectList = context.getPlacableObjectList();
            if (placableObjectList.Count != 0) {
                this.placedObjectList.Items.Clear();
                foreach (PlaceableObject po in placableObjectList)
                    this.placedObjectList.Items.Add("> Object: " + po.getObjectShape() + " - Position: " + po.getPosition().X + ", " + po.getPosition().Y + " - Size: " + po.getSize().X + ", " + po.getSize().Y);

            }
        }

        private void putVisibleObjectToGlControl(string objectShape, int positionX, int positionY, int sizeHeight, int sizeWidth) {
            this.placedObjectList.Items.Add("> Object: "+objectShape+" - Position: "+positionX+", "+positionY+" - Size: "+sizeHeight+", "+sizeWidth);
        }
    }
}
