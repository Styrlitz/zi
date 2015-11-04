namespace WindowsFormsApplication1
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbChannels = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDigits = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbBites = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbRate = new System.Windows.Forms.TextBox();
            this.waveViewer1 = new NAudio.Gui.WaveViewer();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbName
            // 
            resources.ApplyResources(this.tbName, "tbName");
            this.tbName.Name = "tbName";
            this.tbName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbSize
            // 
            resources.ApplyResources(this.tbSize, "tbSize");
            this.tbSize.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbSize.Name = "tbSize";
            this.tbSize.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // tbChannels
            // 
            resources.ApplyResources(this.tbChannels, "tbChannels");
            this.tbChannels.Name = "tbChannels";
            this.tbChannels.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // tbDigits
            // 
            resources.ApplyResources(this.tbDigits, "tbDigits");
            this.tbDigits.Name = "tbDigits";
            this.tbDigits.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // tbTime
            // 
            resources.ApplyResources(this.tbTime, "tbTime");
            this.tbTime.Name = "tbTime";
            this.tbTime.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // tbBites
            // 
            resources.ApplyResources(this.tbBites, "tbBites");
            this.tbBites.Name = "tbBites";
            this.tbBites.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // tbRate
            // 
            resources.ApplyResources(this.tbRate, "tbRate");
            this.tbRate.Name = "tbRate";
            this.tbRate.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // waveViewer1
            // 
            resources.ApplyResources(this.waveViewer1, "waveViewer1");
            this.waveViewer1.Name = "waveViewer1";
            this.waveViewer1.SamplesPerPixel = 128;
            this.waveViewer1.StartPosition = ((long)(0));
            this.waveViewer1.WaveStream = null;
            // 
            // chart1
            // 
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.AxisX.IsMarksNextToAxis = false;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.IsMarksNextToAxis = false;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.CursorX.LineColor = System.Drawing.Color.Black;
            chartArea1.CursorY.LineColor = System.Drawing.Color.Black;
            chartArea1.IsSameFontSizeForAllAxes = true;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 94F;
            chartArea1.Position.Width = 94F;
            chartArea1.Position.X = 3F;
            chartArea1.Position.Y = 3F;
            this.chart1.ChartAreas.Add(chartArea1);
            resources.ApplyResources(this.chart1, "chart1");
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black};
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.waveViewer1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbBites);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDigits);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbChannels);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbChannels;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDigits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbBites;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbRate;
        private NAudio.Gui.WaveViewer waveViewer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

