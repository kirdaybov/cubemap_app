namespace cubemap_app
{
    partial class Main_Form
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
            this.components = new System.ComponentModel.Container();
            this.status_strip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progress_bar = new System.Windows.Forms.ToolStripProgressBar();
            this.open_file_button = new System.Windows.Forms.Button();
            this.open_file_dialog = new System.Windows.Forms.OpenFileDialog();
            this.panorama_picture_box = new System.Windows.Forms.PictureBox();
            this.tabs_image = new System.Windows.Forms.TabControl();
            this.tab_panorama = new System.Windows.Forms.TabPage();
            this.tab_cubemap = new System.Windows.Forms.TabPage();
            this.cubemap_picture_box = new System.Windows.Forms.PictureBox();
            this.tabs_options = new System.Windows.Forms.TabControl();
            this.tab_genaral_properties = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.output_folder_button = new System.Windows.Forms.Button();
            this.input_folder_button = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.output_folder_text_box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.input_folder_text_box = new System.Windows.Forms.TextBox();
            this.process_batch_button = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.save_to_input_check_box = new System.Windows.Forms.CheckBox();
            this.save_cubemap_button = new System.Windows.Forms.Button();
            this.generate_cubemap_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resolution_combo_box = new System.Windows.Forms.ComboBox();
            this.edge_size_text_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.input_file_text_box = new System.Windows.Forms.TextBox();
            this.tab_cubemap_properties = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.blur_track_bar = new System.Windows.Forms.TrackBar();
            this.rotate_z_track_bar = new System.Windows.Forms.TrackBar();
            this.save_file_dialog = new System.Windows.Forms.SaveFileDialog();
            this.input_folder_browser_dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.output_folder_browser_dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.status_strip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panorama_picture_box)).BeginInit();
            this.tabs_image.SuspendLayout();
            this.tab_panorama.SuspendLayout();
            this.tab_cubemap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cubemap_picture_box)).BeginInit();
            this.tabs_options.SuspendLayout();
            this.tab_genaral_properties.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tab_cubemap_properties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blur_track_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotate_z_track_bar)).BeginInit();
            this.SuspendLayout();
            // 
            // status_strip
            // 
            this.status_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.progress_bar});
            this.status_strip.Location = new System.Drawing.Point(0, 514);
            this.status_strip.Name = "status_strip";
            this.status_strip.Size = new System.Drawing.Size(847, 22);
            this.status_strip.TabIndex = 0;
            this.status_strip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // progress_bar
            // 
            this.progress_bar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.progress_bar.Name = "progress_bar";
            this.progress_bar.Size = new System.Drawing.Size(100, 16);
            // 
            // open_file_button
            // 
            this.open_file_button.Location = new System.Drawing.Point(3, 11);
            this.open_file_button.Name = "open_file_button";
            this.open_file_button.Size = new System.Drawing.Size(188, 23);
            this.open_file_button.TabIndex = 1;
            this.open_file_button.Text = "Load Panorama/Cubemap";
            this.open_file_button.UseVisualStyleBackColor = true;
            this.open_file_button.Click += new System.EventHandler(this.open_file_button_Click);
            // 
            // panorama_picture_box
            // 
            this.panorama_picture_box.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panorama_picture_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panorama_picture_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panorama_picture_box.Location = new System.Drawing.Point(3, 3);
            this.panorama_picture_box.Name = "panorama_picture_box";
            this.panorama_picture_box.Size = new System.Drawing.Size(587, 478);
            this.panorama_picture_box.TabIndex = 2;
            this.panorama_picture_box.TabStop = false;
            // 
            // tabs_image
            // 
            this.tabs_image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs_image.Controls.Add(this.tab_panorama);
            this.tabs_image.Controls.Add(this.tab_cubemap);
            this.tabs_image.Location = new System.Drawing.Point(12, 1);
            this.tabs_image.Name = "tabs_image";
            this.tabs_image.SelectedIndex = 0;
            this.tabs_image.Size = new System.Drawing.Size(601, 510);
            this.tabs_image.TabIndex = 3;
            // 
            // tab_panorama
            // 
            this.tab_panorama.Controls.Add(this.panorama_picture_box);
            this.tab_panorama.Location = new System.Drawing.Point(4, 22);
            this.tab_panorama.Name = "tab_panorama";
            this.tab_panorama.Padding = new System.Windows.Forms.Padding(3);
            this.tab_panorama.Size = new System.Drawing.Size(593, 484);
            this.tab_panorama.TabIndex = 0;
            this.tab_panorama.Text = "Panorama";
            this.tab_panorama.UseVisualStyleBackColor = true;
            // 
            // tab_cubemap
            // 
            this.tab_cubemap.Controls.Add(this.cubemap_picture_box);
            this.tab_cubemap.Location = new System.Drawing.Point(4, 22);
            this.tab_cubemap.Name = "tab_cubemap";
            this.tab_cubemap.Padding = new System.Windows.Forms.Padding(3);
            this.tab_cubemap.Size = new System.Drawing.Size(593, 484);
            this.tab_cubemap.TabIndex = 1;
            this.tab_cubemap.Text = "Cubemap";
            this.tab_cubemap.UseVisualStyleBackColor = true;
            // 
            // cubemap_picture_box
            // 
            this.cubemap_picture_box.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cubemap_picture_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cubemap_picture_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cubemap_picture_box.Location = new System.Drawing.Point(3, 3);
            this.cubemap_picture_box.Name = "cubemap_picture_box";
            this.cubemap_picture_box.Size = new System.Drawing.Size(587, 478);
            this.cubemap_picture_box.TabIndex = 3;
            this.cubemap_picture_box.TabStop = false;
            // 
            // tabs_options
            // 
            this.tabs_options.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs_options.Controls.Add(this.tab_genaral_properties);
            this.tabs_options.Controls.Add(this.tab_cubemap_properties);
            this.tabs_options.Location = new System.Drawing.Point(619, 1);
            this.tabs_options.Name = "tabs_options";
            this.tabs_options.SelectedIndex = 0;
            this.tabs_options.Size = new System.Drawing.Size(216, 510);
            this.tabs_options.TabIndex = 4;
            // 
            // tab_genaral_properties
            // 
            this.tab_genaral_properties.Controls.Add(this.label6);
            this.tab_genaral_properties.Controls.Add(this.label5);
            this.tab_genaral_properties.Controls.Add(this.panel4);
            this.tab_genaral_properties.Controls.Add(this.panel3);
            this.tab_genaral_properties.Controls.Add(this.label2);
            this.tab_genaral_properties.Controls.Add(this.panel2);
            this.tab_genaral_properties.Controls.Add(this.label1);
            this.tab_genaral_properties.Controls.Add(this.panel1);
            this.tab_genaral_properties.Location = new System.Drawing.Point(4, 22);
            this.tab_genaral_properties.Name = "tab_genaral_properties";
            this.tab_genaral_properties.Padding = new System.Windows.Forms.Padding(3);
            this.tab_genaral_properties.Size = new System.Drawing.Size(208, 484);
            this.tab_genaral_properties.TabIndex = 0;
            this.tab_genaral_properties.Text = "General Properties";
            this.tab_genaral_properties.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Batch";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Generate and Save";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.output_folder_button);
            this.panel4.Controls.Add(this.input_folder_button);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.output_folder_text_box);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.input_folder_text_box);
            this.panel4.Controls.Add(this.process_batch_button);
            this.panel4.Location = new System.Drawing.Point(6, 357);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(196, 121);
            this.panel4.TabIndex = 9;
            // 
            // output_folder_button
            // 
            this.output_folder_button.Location = new System.Drawing.Point(161, 65);
            this.output_folder_button.Name = "output_folder_button";
            this.output_folder_button.Size = new System.Drawing.Size(28, 23);
            this.output_folder_button.TabIndex = 7;
            this.output_folder_button.Text = "...";
            this.output_folder_button.UseVisualStyleBackColor = true;
            this.output_folder_button.Click += new System.EventHandler(this.output_folder_button_Click);
            // 
            // input_folder_button
            // 
            this.input_folder_button.Location = new System.Drawing.Point(161, 22);
            this.input_folder_button.Name = "input_folder_button";
            this.input_folder_button.Size = new System.Drawing.Size(28, 23);
            this.input_folder_button.TabIndex = 6;
            this.input_folder_button.Text = "...";
            this.input_folder_button.UseVisualStyleBackColor = true;
            this.input_folder_button.Click += new System.EventHandler(this.input_folder_button_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Output folder";
            // 
            // output_folder_text_box
            // 
            this.output_folder_text_box.Location = new System.Drawing.Point(5, 67);
            this.output_folder_text_box.Name = "output_folder_text_box";
            this.output_folder_text_box.Size = new System.Drawing.Size(152, 20);
            this.output_folder_text_box.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Input folder (file)";
            // 
            // input_folder_text_box
            // 
            this.input_folder_text_box.Location = new System.Drawing.Point(5, 24);
            this.input_folder_text_box.Name = "input_folder_text_box";
            this.input_folder_text_box.Size = new System.Drawing.Size(152, 20);
            this.input_folder_text_box.TabIndex = 1;
            // 
            // process_batch_button
            // 
            this.process_batch_button.Location = new System.Drawing.Point(5, 95);
            this.process_batch_button.Name = "process_batch_button";
            this.process_batch_button.Size = new System.Drawing.Size(187, 23);
            this.process_batch_button.TabIndex = 0;
            this.process_batch_button.Text = "Process!";
            this.process_batch_button.UseVisualStyleBackColor = true;
            this.process_batch_button.Click += new System.EventHandler(this.process_batch_button_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.save_to_input_check_box);
            this.panel3.Controls.Add(this.save_cubemap_button);
            this.panel3.Controls.Add(this.generate_cubemap_button);
            this.panel3.Location = new System.Drawing.Point(6, 224);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(196, 100);
            this.panel3.TabIndex = 7;
            // 
            // save_to_input_check_box
            // 
            this.save_to_input_check_box.AutoSize = true;
            this.save_to_input_check_box.Location = new System.Drawing.Point(5, 72);
            this.save_to_input_check_box.Name = "save_to_input_check_box";
            this.save_to_input_check_box.Size = new System.Drawing.Size(151, 17);
            this.save_to_input_check_box.TabIndex = 4;
            this.save_to_input_check_box.Text = "Save *.DDS to input folder";
            this.save_to_input_check_box.UseVisualStyleBackColor = true;
            // 
            // save_cubemap_button
            // 
            this.save_cubemap_button.Enabled = false;
            this.save_cubemap_button.Location = new System.Drawing.Point(4, 42);
            this.save_cubemap_button.Name = "save_cubemap_button";
            this.save_cubemap_button.Size = new System.Drawing.Size(188, 23);
            this.save_cubemap_button.TabIndex = 3;
            this.save_cubemap_button.Text = "Save CubeMap";
            this.save_cubemap_button.UseVisualStyleBackColor = true;
            this.save_cubemap_button.Click += new System.EventHandler(this.save_cubemap_button_Click);
            // 
            // generate_cubemap_button
            // 
            this.generate_cubemap_button.Enabled = false;
            this.generate_cubemap_button.Location = new System.Drawing.Point(4, 13);
            this.generate_cubemap_button.Name = "generate_cubemap_button";
            this.generate_cubemap_button.Size = new System.Drawing.Size(188, 23);
            this.generate_cubemap_button.TabIndex = 2;
            this.generate_cubemap_button.Text = "Generate CubeMap";
            this.generate_cubemap_button.UseVisualStyleBackColor = true;
            this.generate_cubemap_button.Click += new System.EventHandler(this.generate_cubemap_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cube Edge (px)";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.resolution_combo_box);
            this.panel2.Controls.Add(this.edge_size_text_box);
            this.panel2.Location = new System.Drawing.Point(6, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 84);
            this.panel2.TabIndex = 4;
            // 
            // resolution_combo_box
            // 
            this.resolution_combo_box.FormattingEnabled = true;
            this.resolution_combo_box.Location = new System.Drawing.Point(2, 58);
            this.resolution_combo_box.Name = "resolution_combo_box";
            this.resolution_combo_box.Size = new System.Drawing.Size(187, 21);
            this.resolution_combo_box.TabIndex = 4;
            // 
            // edge_size_text_box
            // 
            this.edge_size_text_box.Location = new System.Drawing.Point(3, 15);
            this.edge_size_text_box.Name = "edge_size_text_box";
            this.edge_size_text_box.Size = new System.Drawing.Size(72, 20);
            this.edge_size_text_box.TabIndex = 0;
            this.edge_size_text_box.Text = "256";
            this.edge_size_text_box.TextChanged += new System.EventHandler(this.edge_size_text_box_TextChanged);
            this.edge_size_text_box.Leave += new System.EventHandler(this.edge_size_text_box_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Load";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.input_file_text_box);
            this.panel1.Controls.Add(this.open_file_button);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 69);
            this.panel1.TabIndex = 3;
            // 
            // input_file_text_box
            // 
            this.input_file_text_box.Enabled = false;
            this.input_file_text_box.Location = new System.Drawing.Point(5, 41);
            this.input_file_text_box.Name = "input_file_text_box";
            this.input_file_text_box.Size = new System.Drawing.Size(186, 20);
            this.input_file_text_box.TabIndex = 2;
            // 
            // tab_cubemap_properties
            // 
            this.tab_cubemap_properties.Controls.Add(this.label10);
            this.tab_cubemap_properties.Controls.Add(this.label9);
            this.tab_cubemap_properties.Controls.Add(this.blur_track_bar);
            this.tab_cubemap_properties.Controls.Add(this.rotate_z_track_bar);
            this.tab_cubemap_properties.Location = new System.Drawing.Point(4, 22);
            this.tab_cubemap_properties.Name = "tab_cubemap_properties";
            this.tab_cubemap_properties.Padding = new System.Windows.Forms.Padding(3);
            this.tab_cubemap_properties.Size = new System.Drawing.Size(208, 484);
            this.tab_cubemap_properties.TabIndex = 1;
            this.tab_cubemap_properties.Text = "Cubemap Properties";
            this.tab_cubemap_properties.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Blur CubeMap";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Rotate CubeMap around Z axis";
            // 
            // blur_track_bar
            // 
            this.blur_track_bar.Enabled = false;
            this.blur_track_bar.LargeChange = 10;
            this.blur_track_bar.Location = new System.Drawing.Point(6, 100);
            this.blur_track_bar.Maximum = 30;
            this.blur_track_bar.Name = "blur_track_bar";
            this.blur_track_bar.Size = new System.Drawing.Size(196, 45);
            this.blur_track_bar.SmallChange = 10;
            this.blur_track_bar.TabIndex = 10;
            this.blur_track_bar.TickFrequency = 3;
            this.blur_track_bar.MouseCaptureChanged += new System.EventHandler(this.blur_track_bar_MouseCaptureChanged);
            // 
            // rotate_z_track_bar
            // 
            this.rotate_z_track_bar.Enabled = false;
            this.rotate_z_track_bar.Location = new System.Drawing.Point(6, 23);
            this.rotate_z_track_bar.Maximum = 36;
            this.rotate_z_track_bar.Name = "rotate_z_track_bar";
            this.rotate_z_track_bar.Size = new System.Drawing.Size(196, 45);
            this.rotate_z_track_bar.TabIndex = 0;
            this.rotate_z_track_bar.ValueChanged += new System.EventHandler(this.rotate_z_track_bar_ValueChanged);
            this.rotate_z_track_bar.MouseCaptureChanged += new System.EventHandler(this.rotate_z_track_bar_MouseCaptureChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 536);
            this.Controls.Add(this.tabs_options);
            this.Controls.Add(this.tabs_image);
            this.Controls.Add(this.status_strip);
            this.Name = "Main_Form";
            this.Text = "Cubemap Editor";
            this.status_strip.ResumeLayout(false);
            this.status_strip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panorama_picture_box)).EndInit();
            this.tabs_image.ResumeLayout(false);
            this.tab_panorama.ResumeLayout(false);
            this.tab_cubemap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cubemap_picture_box)).EndInit();
            this.tabs_options.ResumeLayout(false);
            this.tab_genaral_properties.ResumeLayout(false);
            this.tab_genaral_properties.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tab_cubemap_properties.ResumeLayout(false);
            this.tab_cubemap_properties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blur_track_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotate_z_track_bar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip status_strip;
        private System.Windows.Forms.Button open_file_button;
        private System.Windows.Forms.OpenFileDialog open_file_dialog;
        private System.Windows.Forms.PictureBox panorama_picture_box;
        private System.Windows.Forms.ToolStripProgressBar progress_bar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl tabs_image;
        private System.Windows.Forms.TabPage tab_panorama;
        private System.Windows.Forms.TabPage tab_cubemap;
        private System.Windows.Forms.TabControl tabs_options;
        private System.Windows.Forms.TabPage tab_genaral_properties;
        private System.Windows.Forms.TabPage tab_cubemap_properties;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox resolution_combo_box;
        private System.Windows.Forms.TextBox edge_size_text_box;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox output_folder_text_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox input_folder_text_box;
        private System.Windows.Forms.Button process_batch_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox save_to_input_check_box;
        private System.Windows.Forms.Button save_cubemap_button;
        private System.Windows.Forms.Button generate_cubemap_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar blur_track_bar;
        private System.Windows.Forms.TrackBar rotate_z_track_bar;
        private System.Windows.Forms.TextBox input_file_text_box;
        private System.Windows.Forms.SaveFileDialog save_file_dialog;
        private System.Windows.Forms.PictureBox cubemap_picture_box;
        private System.Windows.Forms.Button output_folder_button;
        private System.Windows.Forms.Button input_folder_button;
        private System.Windows.Forms.FolderBrowserDialog input_folder_browser_dialog;
        private System.Windows.Forms.FolderBrowserDialog output_folder_browser_dialog;
        private System.Windows.Forms.Timer timer1;
    }
}

