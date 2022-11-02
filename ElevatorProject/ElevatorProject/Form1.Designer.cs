namespace ElevatorProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxBodyUp = new System.Windows.Forms.PictureBox();
            this.pictureBoxBodyDown = new System.Windows.Forms.PictureBox();
            this.pictureBoxDoorLeftDown = new System.Windows.Forms.PictureBox();
            this.pictureBoxDoorRightDown = new System.Windows.Forms.PictureBox();
            this.pictureBoxElevator = new System.Windows.Forms.PictureBox();
            this.pictureBoxDoorLeftUp = new System.Windows.Forms.PictureBox();
            this.pictureBoxDoorRightUp = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.timerOpen = new System.Windows.Forms.Timer(this.components);
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.timerUp = new System.Windows.Forms.Timer(this.components);
            this.timerClose = new System.Windows.Forms.Timer(this.components);
            this.timerDown = new System.Windows.Forms.Timer(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBodyUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBodyDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoorLeftDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoorRightDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxElevator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoorLeftUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoorRightUp)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBodyUp
            // 
            this.pictureBoxBodyUp.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBodyUp.Image")));
            this.pictureBoxBodyUp.Location = new System.Drawing.Point(85, 65);
            this.pictureBoxBodyUp.Name = "pictureBoxBodyUp";
            this.pictureBoxBodyUp.Size = new System.Drawing.Size(310, 250);
            this.pictureBoxBodyUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBodyUp.TabIndex = 0;
            this.pictureBoxBodyUp.TabStop = false;
            // 
            // pictureBoxBodyDown
            // 
            this.pictureBoxBodyDown.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBodyDown.Image")));
            this.pictureBoxBodyDown.Location = new System.Drawing.Point(85, 355);
            this.pictureBoxBodyDown.Name = "pictureBoxBodyDown";
            this.pictureBoxBodyDown.Size = new System.Drawing.Size(310, 250);
            this.pictureBoxBodyDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBodyDown.TabIndex = 1;
            this.pictureBoxBodyDown.TabStop = false;
            // 
            // pictureBoxDoorLeftDown
            // 
            this.pictureBoxDoorLeftDown.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDoorLeftDown.Image")));
            this.pictureBoxDoorLeftDown.Location = new System.Drawing.Point(190, 382);
            this.pictureBoxDoorLeftDown.Name = "pictureBoxDoorLeftDown";
            this.pictureBoxDoorLeftDown.Size = new System.Drawing.Size(54, 187);
            this.pictureBoxDoorLeftDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDoorLeftDown.TabIndex = 2;
            this.pictureBoxDoorLeftDown.TabStop = false;
            // 
            // pictureBoxDoorRightDown
            // 
            this.pictureBoxDoorRightDown.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDoorRightDown.Image")));
            this.pictureBoxDoorRightDown.Location = new System.Drawing.Point(243, 382);
            this.pictureBoxDoorRightDown.Name = "pictureBoxDoorRightDown";
            this.pictureBoxDoorRightDown.Size = new System.Drawing.Size(54, 187);
            this.pictureBoxDoorRightDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDoorRightDown.TabIndex = 3;
            this.pictureBoxDoorRightDown.TabStop = false;
            // 
            // pictureBoxElevator
            // 
            this.pictureBoxElevator.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxElevator.Image")));
            this.pictureBoxElevator.Location = new System.Drawing.Point(190, 382);
            this.pictureBoxElevator.Name = "pictureBoxElevator";
            this.pictureBoxElevator.Size = new System.Drawing.Size(107, 187);
            this.pictureBoxElevator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxElevator.TabIndex = 4;
            this.pictureBoxElevator.TabStop = false;
            // 
            // pictureBoxDoorLeftUp
            // 
            this.pictureBoxDoorLeftUp.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDoorLeftUp.Image")));
            this.pictureBoxDoorLeftUp.Location = new System.Drawing.Point(190, 92);
            this.pictureBoxDoorLeftUp.Name = "pictureBoxDoorLeftUp";
            this.pictureBoxDoorLeftUp.Size = new System.Drawing.Size(54, 187);
            this.pictureBoxDoorLeftUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDoorLeftUp.TabIndex = 5;
            this.pictureBoxDoorLeftUp.TabStop = false;
            // 
            // pictureBoxDoorRightUp
            // 
            this.pictureBoxDoorRightUp.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDoorRightUp.Image")));
            this.pictureBoxDoorRightUp.Location = new System.Drawing.Point(243, 92);
            this.pictureBoxDoorRightUp.Name = "pictureBoxDoorRightUp";
            this.pictureBoxDoorRightUp.Size = new System.Drawing.Size(54, 187);
            this.pictureBoxDoorRightUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDoorRightUp.TabIndex = 6;
            this.pictureBoxDoorRightUp.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(590, 239);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 7;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // timerOpen
            // 
            this.timerOpen.Interval = 1;
            this.timerOpen.Tick += new System.EventHandler(this.timerOpen_Tick);
            // 
            // btnDown
            // 
            this.btnDown.Image = ((System.Drawing.Image)(resources.GetObject("btnDown.Image")));
            this.btnDown.Location = new System.Drawing.Point(313, 153);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(45, 45);
            this.btnDown.TabIndex = 8;
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // btnUp
            // 
            this.btnUp.Image = ((System.Drawing.Image)(resources.GetObject("btnUp.Image")));
            this.btnUp.Location = new System.Drawing.Point(313, 443);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(45, 45);
            this.btnUp.TabIndex = 9;
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // timerClose
            // 
            this.timerClose.Interval = 1;
            this.timerClose.Tick += new System.EventHandler(this.timerClose_Tick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(590, 278);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 634);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.pictureBoxDoorRightUp);
            this.Controls.Add(this.pictureBoxDoorLeftUp);
            this.Controls.Add(this.pictureBoxDoorRightDown);
            this.Controls.Add(this.pictureBoxDoorLeftDown);
            this.Controls.Add(this.pictureBoxBodyUp);
            this.Controls.Add(this.pictureBoxElevator);
            this.Controls.Add(this.pictureBoxBodyDown);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBodyUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBodyDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoorLeftDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoorRightDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxElevator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoorLeftUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoorRightUp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBoxBodyUp;
        private PictureBox pictureBoxBodyDown;
        private PictureBox pictureBoxDoorLeftDown;
        private PictureBox pictureBoxDoorRightDown;
        private PictureBox pictureBoxElevator;
        private PictureBox pictureBoxDoorLeftUp;
        private PictureBox pictureBoxDoorRightUp;
        private Button btnOpen;
        private System.Windows.Forms.Timer timerOpen;
        private Button btnDown;
        private Button btnUp;
        private System.Windows.Forms.Timer timerUp;
        private System.Windows.Forms.Timer timerClose;
        private System.Windows.Forms.Timer timerDown;
        private Button btnClose;
    }
}