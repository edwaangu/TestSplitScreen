
namespace TestSplitScreen
{
    partial class GameScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.updateTick = new System.Windows.Forms.Timer(this.components);
            this.timerText = new System.Windows.Forms.Label();
            this.pressingUp = new System.Windows.Forms.Label();
            this.mouseLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // updateTick
            // 
            this.updateTick.Enabled = true;
            this.updateTick.Interval = 1;
            this.updateTick.Tick += new System.EventHandler(this.updateTick_Tick);
            // 
            // timerText
            // 
            this.timerText.AutoSize = true;
            this.timerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.timerText.Location = new System.Drawing.Point(42, 104);
            this.timerText.Name = "timerText";
            this.timerText.Size = new System.Drawing.Size(81, 29);
            this.timerText.TabIndex = 0;
            this.timerText.Text = "label1";
            // 
            // pressingUp
            // 
            this.pressingUp.AutoSize = true;
            this.pressingUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.pressingUp.Location = new System.Drawing.Point(117, 215);
            this.pressingUp.Name = "pressingUp";
            this.pressingUp.Size = new System.Drawing.Size(81, 29);
            this.pressingUp.TabIndex = 1;
            this.pressingUp.Text = "label1";
            // 
            // mouseLabel
            // 
            this.mouseLabel.AutoSize = true;
            this.mouseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.mouseLabel.Location = new System.Drawing.Point(160, 305);
            this.mouseLabel.Name = "mouseLabel";
            this.mouseLabel.Size = new System.Drawing.Size(81, 29);
            this.mouseLabel.TabIndex = 2;
            this.mouseLabel.Text = "label1";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mouseLabel);
            this.Controls.Add(this.pressingUp);
            this.Controls.Add(this.timerText);
            this.DoubleBuffered = true;
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(400, 450);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer updateTick;
        private System.Windows.Forms.Label timerText;
        private System.Windows.Forms.Label pressingUp;
        private System.Windows.Forms.Label mouseLabel;
    }
}
