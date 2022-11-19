namespace CourseWork.UI
{
    partial class MainForm
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
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonReadMatrix = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.textBoxTriesCount = new System.Windows.Forms.TextBox();
            this.labelTriesCount = new System.Windows.Forms.Label();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(12, 9);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(298, 27);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "текст про задачу (поменять)";
            // 
            // buttonReadMatrix
            // 
            this.buttonReadMatrix.Location = new System.Drawing.Point(12, 293);
            this.buttonReadMatrix.Name = "buttonReadMatrix";
            this.buttonReadMatrix.Size = new System.Drawing.Size(740, 57);
            this.buttonReadMatrix.TabIndex = 1;
            this.buttonReadMatrix.Text = "Решить задачу (переименовать)";
            this.buttonReadMatrix.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // textBoxTriesCount
            // 
            this.textBoxTriesCount.Location = new System.Drawing.Point(611, 60);
            this.textBoxTriesCount.Name = "textBoxTriesCount";
            this.textBoxTriesCount.Size = new System.Drawing.Size(66, 34);
            this.textBoxTriesCount.TabIndex = 3;
            // 
            // labelTriesCount
            // 
            this.labelTriesCount.AutoSize = true;
            this.labelTriesCount.Location = new System.Drawing.Point(12, 63);
            this.labelTriesCount.Name = "labelTriesCount";
            this.labelTriesCount.Size = new System.Drawing.Size(593, 27);
            this.labelTriesCount.TabIndex = 4;
            this.labelTriesCount.Text = "Введите количество попыток нахождения лучшего пути:";
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Enabled = false;
            this.richTextBoxResult.Location = new System.Drawing.Point(12, 100);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(750, 187);
            this.richTextBoxResult.TabIndex = 5;
            this.richTextBoxResult.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 377);
            this.Controls.Add(this.richTextBoxResult);
            this.Controls.Add(this.labelTriesCount);
            this.Controls.Add(this.textBoxTriesCount);
            this.Controls.Add(this.buttonReadMatrix);
            this.Controls.Add(this.labelInfo);
            this.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Калькулятор для решения задачи Коммивояжера методов Монте Карло";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelInfo;
        private Button buttonReadMatrix;
        private OpenFileDialog openFileDialog;
        private TextBox textBoxTriesCount;
        private Label labelTriesCount;
        private RichTextBox richTextBoxResult;
    }
}