namespace Draw
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DoSmallerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DoBiggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DoShapeTransparentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorBlueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.currentStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.speedMenu = new System.Windows.Forms.ToolStrip();
            this.GroupShapesButton = new System.Windows.Forms.Button();
            this.UnGroupShapeButton = new System.Windows.Forms.Button();
            this.doSmallerButton = new System.Windows.Forms.Button();
            this.doBiggerButton = new System.Windows.Forms.Button();
            this.DrawTriangleButton = new System.Windows.Forms.Button();
            this.DeleteShapeButton = new System.Windows.Forms.Button();
            this.DrawSquareButton = new System.Windows.Forms.Button();
            this.DrawCircleButton = new System.Windows.Forms.Button();
            this.DrawEllipseButton = new System.Windows.Forms.Button();
            this.pickUpSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.drawRectangleSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.viewPort = new Draw.DoubleBufferedPanel();
            this.mainMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.speedMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(1128, 28);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DoSmallerToolStripMenuItem,
            this.DoBiggerToolStripMenuItem,
            this.DoShapeTransparentToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.editToolStripMenuItem.Text = "Редактиране";
            // 
            // DoSmallerToolStripMenuItem
            // 
            this.DoSmallerToolStripMenuItem.Name = "DoSmallerToolStripMenuItem";
            this.DoSmallerToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.DoSmallerToolStripMenuItem.Text = "Намали";
            this.DoSmallerToolStripMenuItem.Click += new System.EventHandler(this.DoSmallerToolStripMenuItem_Click);
            // 
            // DoBiggerToolStripMenuItem
            // 
            this.DoBiggerToolStripMenuItem.Name = "DoBiggerToolStripMenuItem";
            this.DoBiggerToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.DoBiggerToolStripMenuItem.Text = "Уголеми ";
            this.DoBiggerToolStripMenuItem.Click += new System.EventHandler(this.DoBiggerToolStripMenuItem_Click);
            // 
            // DoShapeTransparentToolStripMenuItem
            // 
            this.DoShapeTransparentToolStripMenuItem.Name = "DoShapeTransparentToolStripMenuItem";
            this.DoShapeTransparentToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.DoShapeTransparentToolStripMenuItem.Text = "Прозрачност";
            this.DoShapeTransparentToolStripMenuItem.Click += new System.EventHandler(this.DoShapeTransparentToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ColorBlueToolStripMenuItem,
            this.redToolStripMenuItem,
            this.pinkToolStripMenuItem,
            this.randomToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.colorToolStripMenuItem.Text = "Цвят";
            // 
            // ColorBlueToolStripMenuItem
            // 
            this.ColorBlueToolStripMenuItem.Name = "ColorBlueToolStripMenuItem";
            this.ColorBlueToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.ColorBlueToolStripMenuItem.Text = "Blue";
            this.ColorBlueToolStripMenuItem.Click += new System.EventHandler(this.ColorBlueToolStripMenuItem_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // pinkToolStripMenuItem
            // 
            this.pinkToolStripMenuItem.Name = "pinkToolStripMenuItem";
            this.pinkToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.pinkToolStripMenuItem.Text = "Pink";
            this.pinkToolStripMenuItem.Click += new System.EventHandler(this.pinkToolStripMenuItem_Click);
            // 
            // randomToolStripMenuItem
            // 
            this.randomToolStripMenuItem.Name = "randomToolStripMenuItem";
            this.randomToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.randomToolStripMenuItem.Text = "Случаен";
            this.randomToolStripMenuItem.Click += new System.EventHandler(this.randomToolStripMenuItem_Click);
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentStatusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 499);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusBar.Size = new System.Drawing.Size(1128, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // currentStatusLabel
            // 
            this.currentStatusLabel.Name = "currentStatusLabel";
            this.currentStatusLabel.Size = new System.Drawing.Size(0, 16);
            // 
            // speedMenu
            // 
            this.speedMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.speedMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pickUpSpeedButton,
            this.drawRectangleSpeedButton});
            this.speedMenu.Location = new System.Drawing.Point(0, 28);
            this.speedMenu.Name = "speedMenu";
            this.speedMenu.Size = new System.Drawing.Size(1128, 27);
            this.speedMenu.TabIndex = 3;
            this.speedMenu.Text = "toolStrip1";
            this.speedMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.speedMenu_ItemClicked);
            // 
            // GroupShapesButton
            // 
            this.GroupShapesButton.Location = new System.Drawing.Point(788, 24);
            this.GroupShapesButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupShapesButton.Name = "GroupShapesButton";
            this.GroupShapesButton.Size = new System.Drawing.Size(95, 48);
            this.GroupShapesButton.TabIndex = 10;
            this.GroupShapesButton.Text = "Групиране";
            this.GroupShapesButton.UseVisualStyleBackColor = true;
            this.GroupShapesButton.Click += new System.EventHandler(this.GroupShapesButton_Click);
            // 
            // UnGroupShapeButton
            // 
            this.UnGroupShapeButton.Location = new System.Drawing.Point(891, 24);
            this.UnGroupShapeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UnGroupShapeButton.Name = "UnGroupShapeButton";
            this.UnGroupShapeButton.Size = new System.Drawing.Size(127, 48);
            this.UnGroupShapeButton.TabIndex = 11;
            this.UnGroupShapeButton.Text = "Разгрупиране";
            this.UnGroupShapeButton.UseVisualStyleBackColor = true;
            this.UnGroupShapeButton.Click += new System.EventHandler(this.UnGroupShapeButton_Click);
            // 
            // doSmallerButton
            // 
            this.doSmallerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.doSmallerButton.Image = global::Draw.Properties.Resources.zoom_out;
            this.doSmallerButton.Location = new System.Drawing.Point(622, 24);
            this.doSmallerButton.Margin = new System.Windows.Forms.Padding(4);
            this.doSmallerButton.Name = "doSmallerButton";
            this.doSmallerButton.Size = new System.Drawing.Size(48, 48);
            this.doSmallerButton.TabIndex = 13;
            this.doSmallerButton.UseVisualStyleBackColor = true;
            this.doSmallerButton.Click += new System.EventHandler(this.doSmallerButton_Click);
            // 
            // doBiggerButton
            // 
            this.doBiggerButton.Image = global::Draw.Properties.Resources.zoom_in;
            this.doBiggerButton.Location = new System.Drawing.Point(678, 24);
            this.doBiggerButton.Margin = new System.Windows.Forms.Padding(4);
            this.doBiggerButton.Name = "doBiggerButton";
            this.doBiggerButton.Size = new System.Drawing.Size(48, 48);
            this.doBiggerButton.TabIndex = 12;
            this.doBiggerButton.UseVisualStyleBackColor = true;
            this.doBiggerButton.Click += new System.EventHandler(this.doBiggerButton_Click);
            // 
            // DrawTriangleButton
            // 
            this.DrawTriangleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DrawTriangleButton.Image = global::Draw.Properties.Resources.triangle;
            this.DrawTriangleButton.Location = new System.Drawing.Point(256, 30);
            this.DrawTriangleButton.Margin = new System.Windows.Forms.Padding(4);
            this.DrawTriangleButton.Name = "DrawTriangleButton";
            this.DrawTriangleButton.Size = new System.Drawing.Size(48, 48);
            this.DrawTriangleButton.TabIndex = 9;
            this.DrawTriangleButton.UseVisualStyleBackColor = true;
            this.DrawTriangleButton.Click += new System.EventHandler(this.DrawTriangleButton_Click);
            // 
            // DeleteShapeButton
            // 
            this.DeleteShapeButton.Image = global::Draw.Properties.Resources.bin;
            this.DeleteShapeButton.Location = new System.Drawing.Point(733, 24);
            this.DeleteShapeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteShapeButton.Name = "DeleteShapeButton";
            this.DeleteShapeButton.Size = new System.Drawing.Size(48, 48);
            this.DeleteShapeButton.TabIndex = 8;
            this.DeleteShapeButton.UseVisualStyleBackColor = true;
            this.DeleteShapeButton.Click += new System.EventHandler(this.DeleteShapeButton_Click);
            // 
            // DrawSquareButton
            // 
            this.DrawSquareButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DrawSquareButton.Image = global::Draw.Properties.Resources.square;
            this.DrawSquareButton.Location = new System.Drawing.Point(201, 30);
            this.DrawSquareButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DrawSquareButton.Name = "DrawSquareButton";
            this.DrawSquareButton.Size = new System.Drawing.Size(48, 48);
            this.DrawSquareButton.TabIndex = 7;
            this.DrawSquareButton.UseVisualStyleBackColor = true;
            this.DrawSquareButton.Click += new System.EventHandler(this.DrawSquareButton_Click);
            // 
            // DrawCircleButton
            // 
            this.DrawCircleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DrawCircleButton.Image = global::Draw.Properties.Resources.ellipse;
            this.DrawCircleButton.Location = new System.Drawing.Point(147, 30);
            this.DrawCircleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DrawCircleButton.Name = "DrawCircleButton";
            this.DrawCircleButton.Size = new System.Drawing.Size(48, 48);
            this.DrawCircleButton.TabIndex = 6;
            this.DrawCircleButton.UseVisualStyleBackColor = true;
            this.DrawCircleButton.Click += new System.EventHandler(this.DrawCircleButton_Click);
            // 
            // DrawEllipseButton
            // 
            this.DrawEllipseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DrawEllipseButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.DrawEllipseButton.Image = global::Draw.Properties.Resources.ellipse_shape;
            this.DrawEllipseButton.Location = new System.Drawing.Point(93, 30);
            this.DrawEllipseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DrawEllipseButton.Name = "DrawEllipseButton";
            this.DrawEllipseButton.Size = new System.Drawing.Size(48, 48);
            this.DrawEllipseButton.TabIndex = 5;
            this.DrawEllipseButton.UseVisualStyleBackColor = true;
            this.DrawEllipseButton.Click += new System.EventHandler(this.DrawEllipseButton_Click);
            // 
            // pickUpSpeedButton
            // 
            this.pickUpSpeedButton.CheckOnClick = true;
            this.pickUpSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pickUpSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("pickUpSpeedButton.Image")));
            this.pickUpSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pickUpSpeedButton.Name = "pickUpSpeedButton";
            this.pickUpSpeedButton.Size = new System.Drawing.Size(29, 24);
            this.pickUpSpeedButton.Text = "toolStripButton1";
            // 
            // drawRectangleSpeedButton
            // 
            this.drawRectangleSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawRectangleSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawRectangleSpeedButton.Image")));
            this.drawRectangleSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawRectangleSpeedButton.Name = "drawRectangleSpeedButton";
            this.drawRectangleSpeedButton.Size = new System.Drawing.Size(29, 24);
            this.drawRectangleSpeedButton.Text = "DrawRectangleButton";
            this.drawRectangleSpeedButton.Click += new System.EventHandler(this.DrawRectangleSpeedButtonClick);
            // 
            // viewPort
            // 
            this.viewPort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.viewPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPort.Location = new System.Drawing.Point(0, 55);
            this.viewPort.Margin = new System.Windows.Forms.Padding(5);
            this.viewPort.Name = "viewPort";
            this.viewPort.Size = new System.Drawing.Size(1128, 444);
            this.viewPort.TabIndex = 4;
            this.viewPort.Load += new System.EventHandler(this.viewPort_Load);
            this.viewPort.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPortPaint);
            this.viewPort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseDown);
            this.viewPort.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseMove);
            this.viewPort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 521);
            this.Controls.Add(this.doSmallerButton);
            this.Controls.Add(this.doBiggerButton);
            this.Controls.Add(this.UnGroupShapeButton);
            this.Controls.Add(this.GroupShapesButton);
            this.Controls.Add(this.DrawTriangleButton);
            this.Controls.Add(this.DeleteShapeButton);
            this.Controls.Add(this.DrawSquareButton);
            this.Controls.Add(this.DrawCircleButton);
            this.Controls.Add(this.DrawEllipseButton);
            this.Controls.Add(this.viewPort);
            this.Controls.Add(this.speedMenu);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Draw";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.speedMenu.ResumeLayout(false);
            this.speedMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		private System.Windows.Forms.ToolStripStatusLabel currentStatusLabel;
		private Draw.DoubleBufferedPanel viewPort;
		private System.Windows.Forms.ToolStripButton pickUpSpeedButton;
		private System.Windows.Forms.ToolStripButton drawRectangleSpeedButton;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStrip speedMenu;
		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.Button DrawEllipseButton;
        private System.Windows.Forms.Button DrawCircleButton;
        private System.Windows.Forms.Button DrawSquareButton;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ColorBlueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DoSmallerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DoBiggerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DoShapeTransparentToolStripMenuItem;
        private System.Windows.Forms.Button DeleteShapeButton;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button DrawTriangleButton;
        private System.Windows.Forms.Button GroupShapesButton;
        private System.Windows.Forms.Button UnGroupShapeButton;
        private System.Windows.Forms.Button doBiggerButton;
        private System.Windows.Forms.Button doSmallerButton;
    }
}
