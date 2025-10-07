namespace CS332_Lab4
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCreatePolygon = new System.Windows.Forms.Button();
            this.button_ClearPoligons = new System.Windows.Forms.Button();
            this.button_Translation = new System.Windows.Forms.Button();
            this.button_Rotate = new System.Windows.Forms.Button();
            this.button_SelectPolygon = new System.Windows.Forms.Button();
            this.button_Dilation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar_Rotation = new System.Windows.Forms.TrackBar();
            this.trackBar_DilatationX = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_Rotation = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Dx = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Dy = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_DilatationX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_DilatationY = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBar_DilatationY = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Rotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_DilatationX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Rotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Dx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Dy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DilatationX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DilatationY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_DilatationY)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 426);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_Click);
            // 
            // buttonCreatePolygon
            // 
            this.buttonCreatePolygon.Location = new System.Drawing.Point(566, 12);
            this.buttonCreatePolygon.Name = "buttonCreatePolygon";
            this.buttonCreatePolygon.Size = new System.Drawing.Size(222, 23);
            this.buttonCreatePolygon.TabIndex = 1;
            this.buttonCreatePolygon.Text = "Создать полигон";
            this.buttonCreatePolygon.UseVisualStyleBackColor = true;
            this.buttonCreatePolygon.Click += new System.EventHandler(this.buttonCreatePolygon_Click);
            // 
            // button_ClearPoligons
            // 
            this.button_ClearPoligons.Location = new System.Drawing.Point(566, 41);
            this.button_ClearPoligons.Name = "button_ClearPoligons";
            this.button_ClearPoligons.Size = new System.Drawing.Size(222, 23);
            this.button_ClearPoligons.TabIndex = 2;
            this.button_ClearPoligons.Text = "Очистить полигоны";
            this.button_ClearPoligons.UseVisualStyleBackColor = true;
            this.button_ClearPoligons.Click += new System.EventHandler(this.button_ClearPoligons_Click);
            // 
            // button_Translation
            // 
            this.button_Translation.Location = new System.Drawing.Point(566, 106);
            this.button_Translation.Name = "button_Translation";
            this.button_Translation.Size = new System.Drawing.Size(70, 23);
            this.button_Translation.TabIndex = 3;
            this.button_Translation.Text = "Сместить";
            this.button_Translation.UseVisualStyleBackColor = true;
            this.button_Translation.Click += new System.EventHandler(this.button_Translation_Click);
            // 
            // button_Rotate
            // 
            this.button_Rotate.Location = new System.Drawing.Point(566, 158);
            this.button_Rotate.Name = "button_Rotate";
            this.button_Rotate.Size = new System.Drawing.Size(121, 23);
            this.button_Rotate.TabIndex = 4;
            this.button_Rotate.Text = "Повернуть";
            this.button_Rotate.UseVisualStyleBackColor = true;
            this.button_Rotate.Click += new System.EventHandler(this.button_Rotate_Click);
            // 
            // button_SelectPolygon
            // 
            this.button_SelectPolygon.Location = new System.Drawing.Point(566, 70);
            this.button_SelectPolygon.Name = "button_SelectPolygon";
            this.button_SelectPolygon.Size = new System.Drawing.Size(222, 23);
            this.button_SelectPolygon.TabIndex = 5;
            this.button_SelectPolygon.Text = "Выбрать полигон";
            this.button_SelectPolygon.UseVisualStyleBackColor = true;
            // 
            // button_Dilation
            // 
            this.button_Dilation.Location = new System.Drawing.Point(566, 245);
            this.button_Dilation.Name = "button_Dilation";
            this.button_Dilation.Size = new System.Drawing.Size(121, 23);
            this.button_Dilation.TabIndex = 6;
            this.button_Dilation.Text = "Изменить масштаб";
            this.button_Dilation.UseVisualStyleBackColor = true;
            this.button_Dilation.Click += new System.EventHandler(this.button_Dilation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(641, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "dx";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(706, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "dy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(693, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "градусы";
            // 
            // trackBar_Rotation
            // 
            this.trackBar_Rotation.Location = new System.Drawing.Point(566, 187);
            this.trackBar_Rotation.Maximum = 360;
            this.trackBar_Rotation.Minimum = -360;
            this.trackBar_Rotation.Name = "trackBar_Rotation";
            this.trackBar_Rotation.Size = new System.Drawing.Size(222, 45);
            this.trackBar_Rotation.TabIndex = 13;
            this.trackBar_Rotation.Scroll += new System.EventHandler(this.trackBar_Rotation_Scroll);
            // 
            // trackBar_DilatationX
            // 
            this.trackBar_DilatationX.Location = new System.Drawing.Point(563, 291);
            this.trackBar_DilatationX.Maximum = 200;
            this.trackBar_DilatationX.Name = "trackBar_DilatationX";
            this.trackBar_DilatationX.Size = new System.Drawing.Size(222, 45);
            this.trackBar_DilatationX.TabIndex = 14;
            this.trackBar_DilatationX.Value = 100;
            this.trackBar_DilatationX.Scroll += new System.EventHandler(this.trackBar_DilationX_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(563, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ось X";
            // 
            // numericUpDown_Rotation
            // 
            this.numericUpDown_Rotation.Location = new System.Drawing.Point(748, 161);
            this.numericUpDown_Rotation.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDown_Rotation.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.numericUpDown_Rotation.Name = "numericUpDown_Rotation";
            this.numericUpDown_Rotation.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown_Rotation.TabIndex = 17;
            this.numericUpDown_Rotation.ValueChanged += new System.EventHandler(this.numericUpDown_Rotation_ValueChanged);
            // 
            // numericUpDown_Dx
            // 
            this.numericUpDown_Dx.Location = new System.Drawing.Point(660, 109);
            this.numericUpDown_Dx.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_Dx.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDown_Dx.Name = "numericUpDown_Dx";
            this.numericUpDown_Dx.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown_Dx.TabIndex = 18;
            // 
            // numericUpDown_Dy
            // 
            this.numericUpDown_Dy.Location = new System.Drawing.Point(730, 109);
            this.numericUpDown_Dy.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_Dy.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDown_Dy.Name = "numericUpDown_Dy";
            this.numericUpDown_Dy.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown_Dy.TabIndex = 19;
            // 
            // numericUpDown_DilatationX
            // 
            this.numericUpDown_DilatationX.Location = new System.Drawing.Point(623, 273);
            this.numericUpDown_DilatationX.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown_DilatationX.Name = "numericUpDown_DilatationX";
            this.numericUpDown_DilatationX.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown_DilatationX.TabIndex = 20;
            this.numericUpDown_DilatationX.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_DilatationX.ValueChanged += new System.EventHandler(this.numericUpDown_DilationX_ValueChanged);
            // 
            // numericUpDown_DilatationY
            // 
            this.numericUpDown_DilatationY.Location = new System.Drawing.Point(626, 324);
            this.numericUpDown_DilatationY.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown_DilatationY.Name = "numericUpDown_DilatationY";
            this.numericUpDown_DilatationY.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown_DilatationY.TabIndex = 23;
            this.numericUpDown_DilatationY.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_DilatationY.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(566, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Ось Y";
            // 
            // trackBar_DilatationY
            // 
            this.trackBar_DilatationY.Location = new System.Drawing.Point(563, 342);
            this.trackBar_DilatationY.Maximum = 200;
            this.trackBar_DilatationY.Name = "trackBar_DilatationY";
            this.trackBar_DilatationY.Size = new System.Drawing.Size(222, 45);
            this.trackBar_DilatationY.TabIndex = 21;
            this.trackBar_DilatationY.Value = 100;
            this.trackBar_DilatationY.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown_DilatationY);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBar_DilatationY);
            this.Controls.Add(this.numericUpDown_DilatationX);
            this.Controls.Add(this.numericUpDown_Dy);
            this.Controls.Add(this.numericUpDown_Dx);
            this.Controls.Add(this.numericUpDown_Rotation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBar_DilatationX);
            this.Controls.Add(this.trackBar_Rotation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Dilation);
            this.Controls.Add(this.button_SelectPolygon);
            this.Controls.Add(this.button_Rotate);
            this.Controls.Add(this.button_Translation);
            this.Controls.Add(this.button_ClearPoligons);
            this.Controls.Add(this.buttonCreatePolygon);
            this.Controls.Add(this.panel1);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Rotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_DilatationX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Rotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Dx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Dy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DilatationX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DilatationY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_DilatationY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCreatePolygon;
        private System.Windows.Forms.Button button_ClearPoligons;
        private System.Windows.Forms.Button button_Translation;
        private System.Windows.Forms.Button button_Rotate;
        private System.Windows.Forms.Button button_SelectPolygon;
        private System.Windows.Forms.Button button_Dilation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar_Rotation;
        private System.Windows.Forms.TrackBar trackBar_DilatationX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_Rotation;
        private System.Windows.Forms.NumericUpDown numericUpDown_Dx;
        private System.Windows.Forms.NumericUpDown numericUpDown_Dy;
        private System.Windows.Forms.NumericUpDown numericUpDown_DilatationX;
        private System.Windows.Forms.NumericUpDown numericUpDown_DilatationY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBar_DilatationY;
    }
}

